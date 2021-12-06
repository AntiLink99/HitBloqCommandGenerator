using System;
using System.Collections.Generic;
using System.Text;

namespace HitBloqCommandGenerator
{
    public class MapData
    {

        public virtual string id { get; set; }

        public virtual string name { get; set; }

        public virtual List<MapVersion> versions { get; set; }
    }

    public class MapVersion
    {
        public virtual string hash { get; set; }
        public virtual List<MapDiff> diffs { get; set; }

        public List<MapCharacteristic> getDiffsByCharacteristic()
        {
            Dictionary<string, MapCharacteristic> diffsByCharacteristic = new Dictionary<string, MapCharacteristic>();

            foreach (MapDiff diff in diffs)
            {
                if (diffsByCharacteristic.ContainsKey(diff.characteristic))
                {
                    diffsByCharacteristic[diff.characteristic].diffs.Add(diff);
                } else
                {
                    MapCharacteristic newCharacteristic = new MapCharacteristic();
                    newCharacteristic.name = diff.characteristic;
                    newCharacteristic.diffs.Add(diff);
                    diffsByCharacteristic.Add(diff.characteristic, newCharacteristic);
                }
            }

            List<MapCharacteristic> values = new List<MapCharacteristic>(); // No idea how to do it better
            foreach (KeyValuePair<string, MapCharacteristic> entry in diffsByCharacteristic)
            {
                values.Add(entry.Value);
            }
            return values;
        }
    }

    public class MapDiff
    {
        public virtual string characteristic { get; set; }
        public virtual string difficulty { get; set; }
    }

    public class MapCharacteristic
    {
        public virtual string name { get; set; }

        public List<MapDiff> diffs = new List<MapDiff>();

        public bool hasDiff(string diffName)
        {
            List<MapDiff> diffsWithName = diffs.FindAll(diff => diff.difficulty.Equals(diffName));
            return diffsWithName.Count > 0;
        }
    }
}
