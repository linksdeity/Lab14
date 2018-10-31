using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab14
{
    class Alligator : ICountable
    {

        private int Count { get; set; }
        public string Name { get; set; }



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


    }
}
