using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lmedeiro_HW2_TSP
{
    class Population:  Map
    {
          // attributes: 
        static int mapX = 1000;
        static int mapY = 1000;
        double fit = new double();
        public double fitness
        {
            get { return calculateTotalDistance(this.cityPathList); }
            set { fit=value;}
        }
        public Map map;
        // List<City> currentPathList= new List<City>();
        
        public List<City> cityPathList = new List<City>();
        
          
        /*
            Manipulate pathList, which is inherited from map through this class;
            Utilize population to maintain fitness and all other variables;
               
          
        */
          
        // public: 
         
        public Population()
        {
            map = new Map(mapX, mapY);
            for (int i = 0; i < cityList.Length;i++ )
            {
                cityPathList.Add(cityList[i]);
                cityPathList[i].visited = true;
            
            }
            fit = calculateTotalDistance(this.cityPathList);
                
        }
        public Population(City[] cList)
        {
            map = new Map(cList);
            for (int i = 0; i < cityList.Length; i++)
            {
                cityPathList.Add(cityList[i]);
                cityPathList[i].visited = true;

            }
            fit = calculateTotalDistance(this.cityPathList);

        }

        public  double calculateTotalDistance()
        {
            return fitness= calculateTotalDistance(this.cityPathList);
        }
        public List <City> travelMap(Map mapToTravel)
        {
            //List <City> cityPathList=new List<City>();

            return cityPathList;
        }

       
        /* 
         * Functions to implement: 
        runGeneration():void;
        
        tournaments(): void;
        runoneTournament(int start): void;
        
        */
        

        
        
          
        // private: 
          
          
    }
}
