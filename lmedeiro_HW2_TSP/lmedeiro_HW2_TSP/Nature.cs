using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lmedeiro_HW2_TSP
{
    class Nature
    {
        static Random randNum = new Random();
        int x;
        public static int city_pop_size = 100;
        public static int map_pop_xy = 1000;
        public Nature()
        { 

        }
        public int randCityCoord()
        {
            return x = randNum.Next(0, map_pop_xy-1);
        }
        /*
         * Calculates a random number so to 
         * use on the mutation events
         */
        public int mutationCoefficient()
        {
            return x = randNum.Next(1, city_pop_size);
        }
        public int crossOverCoefficient()
        {
            return x = randNum.Next(randNum.Next(1,50), randNum.Next(51,city_pop_size));
        }
        public int crossOverCoefficientEnd(int start)
        {
            return x = randNum.Next(start+1, city_pop_size);
        }

    }
}
