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

        public bool hasDiff(string diffName)
        {
            List<MapDiff> diffsWithName = diffs.FindAll(diff => diff.difficulty.Equals(diffName));
            return diffsWithName.Count > 0;
        }
    }

    public class MapDiff
    {
        public virtual string difficulty { get; set; }
    }
}
