using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lmedeiro_HW2_TSP
{
    class Map: Nature
    {
        // Attributes: 

        private City cityToAdd;
        //public List<City> pathList;
        public static City[] cityList = new City[city_pop_size];// zeroth city will be 
        // initial city;
        public double totalD = new double();
        double distance;
        public double totalDistance
        {
            get { return totalD; }
            set { totalD=value;}
        }
        // public: 
        public Map()
        {
            totalD = 0.0;

        }
        public Map(int width, int height)
        {
            //cities = new City[100];
            //pathList = new List<City>();
            totalD = 0; // initiatin it's value ;
            for (int i=0;i<city_pop_size;i++)
            {
                cityToAdd=new City();
                cityToAdd.x=randCityCoord();
                cityToAdd.y=randCityCoord();
                cityToAdd.visited=false;

                cityList[i]=cityToAdd;
            }
            totalD = 0.0;
        }
        public Map( City[] cList)
        {
            cityList = cList;


        }



        // private:

        public  double calculateTotalDistance(List<City> listToCheck)
        {
            double x1, x2, y1, y2, dx, dy;
            int listSize = listToCheck.Count; 
            /*
             * Below is the loop which produces the count of the total
             * distance that the list in question will have. 
             * This means that we will be adding the list from the first 
             * City to the next, and so on, until the last City 
             * to the first.
             */
            distance = new double();
            for (int i = 0; i<listSize ; i++)
            {
                // The first case mentioned is the special case where 
                // the list is in it's last object.
                if (i==listSize-1)
                {
                    x1 = listToCheck[i].x;
                    x2 = listToCheck[0].x;
                    dx = x1 - x2;
                    y1 = listToCheck[i].y;
                    y2 = listToCheck[0].y;
                    dy = y1 - y2;
                    distance += Math.Sqrt(dx * dx + dy * dy);
                    totalD = distance;
                    return totalD;
                }
                x1 = listToCheck[i].x;
                x2 = listToCheck[i + 1].x;
                dx = x1 - x2;
                y1 = listToCheck[i].y;
                y2 = listToCheck[i + 1].y;
                dy = y1 - y2;
                distance += Math.Sqrt(dx * dx + dy * dy);
            }

            totalD = distance;
            return totalD;
        }

        public double calculateDistance(City a, City b, List<City> listToCheck)
        {
            int indexOfA = new int(), indexOfB = new int();
            indexOfA= listToCheck.IndexOf(a);
            indexOfB = listToCheck.IndexOf(b);
            double x1, x2, y1, y2, dx, dy, distance;
            x1 = listToCheck[indexOfA].x;
            x2 = listToCheck[indexOfB].x;
            dx = x1 - x2;
            y1 = listToCheck[indexOfA].y;
            y2 = listToCheck[indexOfB].y;
            dy = y1 - y2;
            distance = Math.Sqrt(dx * dx + dy * dy);
            
           return distance;
        }

        public City[] getCities()
        {
            return cityList;
        }



    }
}
