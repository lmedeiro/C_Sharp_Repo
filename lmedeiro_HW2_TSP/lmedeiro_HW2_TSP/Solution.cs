using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lmedeiro_HW2_TSP
{
    class Solution :  Map, IEquatable<Solution>, IComparable<Solution>
    {
         // attributes
        List <City> bestPath= new List <City> ();
        List < City> currentPath= new List <City> ();
        List<City> crossOverGenome = new List<City>();
        
        List<City> citiesNotVisited = new List<City>();
         //public Population pop;
         int crossIndex=new int();
         bool bestHasChanged;
        double crossFit0 = new double();
        double crossFit1 = new double();
        public struct IndexRange
        {
            public int min; public int max;
        }
        IndexRange range = new IndexRange();
         
         
                       
         // public: 
         
         //The functions should include mutation and crossover related funcs.
         
        // Should be able to manipulate the crossoverGenome and index of crossover points here;
         
        public Solution ()
         {
             //pop= new Population();
             

         }

        Population mutate()
        {
            return new Population();
        }
         
        public List<City> buildCrossoverGenome(Population pop)
        {
            // create the crossover function; 
            // should be some variable number that may consider the generation,
            // fitness and randomness.
            // what is a strong trait? what is a weak trait? 
            crossIndex= pop.crossOverCoefficient();
            crossOverGenome = new List<City>(); 
                range.min = crossIndex;
            while (crossIndex < (pop.cityPathList.Count) )
            {
                crossOverGenome.Add(pop.cityPathList[crossIndex-1]);
                pop.cityPathList[crossIndex -1].visited = false;
                //pop.fitness= pop.calculateTotalDistance(pop.cityPathList);
                crossIndex++;
                

            }
            range.max = pop.cityPathList.Count;
            // must randomize genome so to make different path;
            // This will require us to randomize the crossOverGenome list
            // and then insert it in their original indexes on the popuplation;
            Random rand = new Random();
            int test=rand.Next(range.min, range.max);
            //rand.Next()
            int a, b;
            a=rand.Next(0,crossOverGenome.Count-2);
            b = crossOverGenome.Count - 1;
            
            int j = 0;
            // Basically splitting the cities; 
            // and shuffling;
             
            crossOverGenome = shuffle(crossOverGenome);
            /*crossFit0 = calculateTotalDistance(crossOverGenome);
            List<City> crossR = new List<City>();
            crossR = crossOverGenome;
            crossR.Reverse();
            crossFit1 = calculateTotalDistance(crossR);
            if (crossFit0<crossFit1)
            {
                return crossOverGenome;
            }
            else
            {
                return crossR;
            }*/
                //crossOverGenome.Reverse(a,b); // just a simple sort to change things around and use
                // this genome as crossOver;
            //crossOverGenome.Reverse();
            
            return crossOverGenome;
              
        }

         public Population mate( Population popToMate, List<City> crossOverList)
         {
             int i = 0, j = 0;

             while (i < popToMate.cityPathList.Count)
             {
                 if (popToMate.cityPathList[i].visited == false && j<crossOverList.Count)
                 {
                     popToMate.cityPathList[i] = crossOverList[j];
                     popToMate.cityPathList[i].visited = true;
                     j++;
                 }
                
                 i++;
                 
             }
            
             return popToMate;
         }
         
         // private: 



         public bool Equals(Solution other)
         {
             throw new NotImplementedException();
         }

         public int CompareTo(Solution other)
         {
             throw new NotImplementedException();
         }
        
        private List<City> shuffle(List<City> sList)
         {
             List<City> ss = new List<City>();
             ss = sList;
             int j = 0;
             // Basically splitting the cities; 
             // and shuffling;
             int midpoint = sList.Count / 2;
             int mid = midpoint;
             for (int i = 0; i < midpoint; i++)
             {
                 sList[i] = ss[mid];
                 mid++;
             }
             mid = sList.Count / 2;
             for (int i = midpoint; i < sList.Count; i++)
             {
                 sList[i] = ss[j];
                 j++;
             }
             return sList;
         }
    }
}
