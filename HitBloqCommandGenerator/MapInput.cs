using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitBloqCommandGenerator
{
    public partial class MapInput : Form
    {
        List<string> mapKeyList = new List<string>();

        public MapInput()
        {
            InitializeComponent();
        }

        public void onAddMapsButton(object sender, EventArgs e) {
            string mapLinksStringInput = mapLinksInput.Text;
            List<string> mapLinks = new List<string>(mapLinksStringInput.Split("\n"));
            List<string> mapKeys = mapLinks.Select(link => link.Replace("https://beatsaver.com/maps/", "").Trim()).ToList();
            mapKeys.RemoveAll(key => key.Length == 0 || key.Length > 6);

            mapList.BeginUpdate();
            foreach (String mapKey in mapKeys)
            {
                if (!mapKeyList.Contains(mapKey))
                {
                    mapList.Items.Add(mapKey);
                    mapKeyList.Add(mapKey);
                }
            }
            mapList.EndUpdate();
            fetchSongsButton.Enabled = mapKeyList.Count > 0;
        }

        private void onFetchMapsButton(object sender, EventArgs e)
        {
            List<MapData> mapData = new List<MapData>();
            bool hasOneFailed = false;
            foreach (String key in mapKeyList)
            {
                String bsUrl = "https://api.beatsaver.com/maps/id/" + key;
                string jsonResponse = Get(bsUrl);
                if (jsonResponse == null)
                {
                    hasOneFailed = true;
                    mapList.FindItemWithText(key).ForeColor = Color.OrangeRed;
                    mapList.FindItemWithText(key).BackColor = Color.DarkRed;
                    continue;
                }
                MapData data = JsonConvert.DeserializeObject<MapData>(jsonResponse);              
                mapData.Add(data);

                mapList.FindItemWithText(key).ForeColor = Color.GreenYellow;
                mapList.FindItemWithText(key).BackColor = Color.DarkGreen;
            }
            if (!hasOneFailed && mapData.Count > 0)
            {
                mapList.BackColor = Color.DarkGreen;
                var cycleForm = new MapCycle(mapData);
                cycleForm.Show();
            }
        }

        public string Get(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public void onClearAllButton(object sender, EventArgs e)
        {
            mapList.BeginUpdate();
            mapList.Clear();
            mapList.EndUpdate();
            mapKeyList.Clear();
            mapList.BackColor = Color.Empty;
            fetchSongsButton.Enabled = false;
        }
    }
}
