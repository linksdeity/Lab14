using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab14
{
    class Sheep : ICountable, ICloneable
    {
        private int Count { get; set; }
        public string Name { get; set; }

        public Sheep(string name)
        {
            Name = name;
        }

        public void IncrementCount()
        {
            Count++;
        }


        public void ResetCount()
        {
            Count = 0;
        }


        public int GetCount()
        {
            return Count;
        }


        public string GetCountString()
        {
            return Count.ToString();
        }


        public Object Clone()
        {
            return this.MemberwiseClone();

        }

    }
}
