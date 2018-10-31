using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab14
{
    class CountTestApp
    {

        //test prints alligator 3 times

        public static void Count()
        {

            Alligator alligator = new Alligator();
            alligator.Name = "Alligator";

            Console.WriteLine("Counting " + alligator.GetType().Name + "s \n===============");


            CountUntil.Count(alligator, 3);


            //same for sheep

            Sheep sheep = new Sheep("Blackie");
            Console.WriteLine("Counting " + sheep.GetType().Name + "s \n===============");


            CountUntil.Count(sheep, 2);


            Sheep sheep2 = (Sheep)sheep.Clone();
            sheep2.Name = "Dolly";



            CountUntil.Count(sheep2, 3);

            CountUntil.Count(sheep, 1);
            


        }

    }

}
