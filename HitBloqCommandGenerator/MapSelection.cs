using System;
using System.Collections.Generic;
using System.Text;

namespace HitBloqCommandGenerator
{
    public class MapSelection
    {
        public virtual string hash { get; set; }
        public List<MapSelectionCharacteristic> characteristics = new List<MapSelectionCharacteristic>();
}

    public class MapSelectionCharacteristic
    {
        public virtual string name { get; set; }

        public virtual bool easy { get; set; }
        public virtual bool normal { get; set; }
        public virtual bool hard { get; set; }
        public virtual bool expert { get; set; }
        public virtual bool expertPlus { get; set; }

        public virtual decimal starsEasy { get; set; }
        public virtual decimal starsNormal { get; set; }
        public virtual decimal starsHard { get; set; }
        public virtual decimal starsExpert { get; set; }
        public virtual decimal starsExpertPlus { get; set; }
    }
}
