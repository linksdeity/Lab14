using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab14
{
    class CountUntil
    {

        public static void Count (ICountable c, int maxCount)
        {


            for (int i = 1; i <= maxCount; i++)
            {

                c.IncrementCount();
                Console.WriteLine(c.GetCountString() + " " + c.Name + "\n");

            }

            c.ResetCount();

        }

    }
}
