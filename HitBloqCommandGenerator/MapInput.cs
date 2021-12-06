using BeatSaberPlaylistsLib;
using BeatSaberPlaylistsLib.Legacy;
using BeatSaberPlaylistsLib.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Timers;
using System.Windows.Forms;

namespace HitBloqCommandGenerator
{
    public partial class MapInput : Form
    {
        List<string> mapKeyAndHashList = new List<string>();
        Dictionary<string, List<Difficulty>> highlightedDifficultyData = new Dictionary<string, List<Difficulty>>();

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
            foreach (string mapKey in mapKeys)
            {
                if (!mapKeyAndHashList.Contains(mapKey))
                {
                    mapList.Items.Add(mapKey);
                    mapKeyAndHashList.Add(mapKey);
                    mapList.EnsureVisible(mapList.Items.Count - 1);
                }
            }
            mapList.EndUpdate();
            fetchButton.Enabled = mapKeyAndHashList.Count > 0;
        }

        private void onFetchMapsButton(object sender, EventArgs e)
        {
            List<MapData> mapData = new List<MapData>();
            bool hasOneFailed = false;
            foreach (string keyOrHash in mapKeyAndHashList)
            {
                bool isKey = keyOrHash.Length < 20;
                string bsUrl = "https://api.beatsaver.com/maps/" + (isKey ? "id" : "hash" ) + "/" + keyOrHash;
                string jsonResponse = Get(bsUrl);
                if (jsonResponse == null || jsonResponse.Contains("\"error\": \"Not Found\""))
                {
                    hasOneFailed = true;
                    findItemWithText(mapList, keyOrHash).ForeColor = Color.OrangeRed;
                    mapList.FindItemWithText(keyOrHash).BackColor = Color.DarkRed;
                    continue;
                }
                MapData data = JsonConvert.DeserializeObject<MapData>(jsonResponse);
                mapData.Add(data);

                findItemWithText(mapList, keyOrHash).ForeColor = Color.GreenYellow;
                findItemWithText(mapList, keyOrHash).BackColor = Color.DarkGreen;
                mapList.EnsureVisible(mapList.Items.IndexOf(mapList.FindItemWithText(keyOrHash)));
            }
            if (mapData.Count > 0)
            {
                if (!hasOneFailed)
                {
                    mapList.BackColor = Color.DarkGreen;
                }
                var cycleForm = new MapCycle(mapData, highlightedDifficultyData);
                cycleForm.Show();
            }
        }

        public ListViewItem findItemWithText(ListView view, string text)
        {
            return view.Items.Cast<ListViewItem>().FirstOrDefault(x => x.Text == text);
        }

        public string Get(string uri)
        {
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(uri);
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
            catch (Exception)
            {
                return null;
            }
        }

        public void onClearAllButton(object sender, EventArgs e)
        {
            mapList.BeginUpdate();
            mapList.Clear();
            mapList.EndUpdate();
            mapKeyAndHashList.Clear();
            highlightedDifficultyData.Clear();
            mapList.BackColor = Color.FromArgb(70, 70, 70);
            fetchButton.Enabled = false;
            labelPlaylists.Text = "";
        }

        private void importPlaylist_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string absolutePath = openFileDialog1.FileName;

            IPlaylistHandler handler = new LegacyPlaylistHandler();

            byte[] fileBytes = File.ReadAllBytes(absolutePath);
            Stream playlistStream = new MemoryStream(fileBytes);
            IPlaylist selectedPlaylist = handler?.Deserialize(playlistStream);

            if (selectedPlaylist == null)
            {
                showPlaylistMessage("Could not import playlist!");
                return;
            }

            foreach (IPlaylistSong song in selectedPlaylist)
            {
                if (!mapKeyAndHashList.Contains(song.Hash))
                {
                    mapList.Items.Add(song.Hash);
                    mapKeyAndHashList.Add(song.Hash);
                }
                List<Difficulty> highlightedDiffs = song.Difficulties;

                if (!highlightedDifficultyData.ContainsKey(song.Hash))
                {
                    highlightedDifficultyData.Add(song.Hash, highlightedDiffs);
                }

                fetchButton.Enabled = mapKeyAndHashList.Count > 0;
            }
            showPlaylistMessage("Playlist imported!");
        }

        public void showPlaylistMessage(String msg)
        {
            labelPlaylists.Text = msg;

            var t = new System.Windows.Forms.Timer();
            t.Interval = 3000;
            t.Tick += (s, e) =>
            {
                labelPlaylists.Text = "";
                t.Stop();
            };
            t.Start();
        }
    }
}
