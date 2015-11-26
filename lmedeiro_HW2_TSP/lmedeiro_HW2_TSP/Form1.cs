using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lmedeiro_HW2_TSP
{
    public partial class mainWindow : Form
    {

        Population currentFit;
        Population bestFit;
        Solution solve;
        double fitnessBest;
        double fitnessCurrent;

        Population currentFit2;
        Population bestFit2;
        Solution solve2;
        double fitnessBest2;
        double fitnessCurrent2;

        double[] sample1, sample2;

        public mainWindow()
        {
            InitializeComponent();
            currentFit = new Population();
            bestFit = currentFit;
            //bestFit = currentFit;
            solve = new Solution();

            
            currentFit2 = new Population(currentFit.getCities());
            bestFit2 = currentFit2;
            //bestFit = currentFit;
            solve2 = new Solution();
            //Map map = new Map(1000, 1000);
            /*
             * 
             * Must now implement the second constructor for the population, 
             * which will consider a set of cities that is passed in. 
             * This is so to continue a second generation from a given set of paths.
             */


            fitnessBest = new double();
            fitnessCurrent = new double();
            fitnessBest = bestFit.calculateTotalDistance();
            
            fitnessBest2 = new double();
            fitnessCurrent2 = new double();
            fitnessBest2 = bestFit2.calculateTotalDistance();
            int numberOfRuns = 50;

            sample1 = new double[numberOfRuns];
            sample2 = new double[numberOfRuns];

            // run first gen;
            for (int i = 0; i < numberOfRuns; i++)
            {
                
                //currentFit = new Population();
                //currentFit.calculateTotalDistance();
                currentFit = solve.mate(bestFit, solve.buildCrossoverGenome(currentFit));

                fitnessCurrent = currentFit.calculateTotalDistance();
                sample1[i] = fitnessCurrent; 
                if (fitnessBest > fitnessCurrent)
                {
                    //bestFit = new Population();
                    bestFit=currentFit;
                    fitnessBest= bestFit.calculateTotalDistance();
                }
                
            }

            // run second gen;
            for (int i = 0; i < numberOfRuns; i++)
            {

                //currentFit = new Population();
                //currentFit.calculateTotalDistance();
                currentFit2 = solve2.mate(bestFit2, solve2.buildCrossoverGenome(currentFit2));

                fitnessCurrent2 = currentFit2.calculateTotalDistance();
                sample2[i] = fitnessCurrent2; 
                if (fitnessBest2 > fitnessCurrent2)
                {
                    //bestFit = new Population();
                    bestFit2 = currentFit2;
                    fitnessBest2 = bestFit2.calculateTotalDistance();
                }

            }

            double mean1=0, mean2 = 0;
            for (int i = 0; i < sample1.Length;i++ )
            {
                mean1 = mean1 + sample1[i];
            }
            mean1 = mean1 / ((float)(sample1.Length));
            for (int i = 0; i < sample2.Length; i++)
            {
                mean2 = mean2 + sample2[i];
            }
            mean2 = mean2 / ((float)(sample2.Length));
            mean1TextBox.Text = mean1.ToString();
            mean2TextBox.Text = mean2.ToString();
            double variance1 = 0.0, variance2 = 0.0;

            foreach (double num1 in sample1)
            {
                variance1 += Math.Pow((num1 - mean1), 2.0);

            }
            variance1=variance1/((double)(sample1.Length-1));
            
            foreach (double num2 in sample2)
            {
                variance2 += Math.Pow((num2 - mean2), 2.0);

            }
            variance2 = variance2 / ((double)(sample2.Length - 1));
            variance1TextBox.Text = variance1.ToString();
            variance2TextBox.Text = variance2.ToString();
            size1TextBox.Text = sample1.Length.ToString();
            size2TextBox.Text = sample2.Length.ToString();
                /*
                 *  Setting up the charts for display;
                 *  Getting Best runs from the respective sets and displaying them.
                 * */
                for (int i = 0; i < Nature.city_pop_size; i++)
                {

                    this.citiesChart.Series["tspCities"].Points.AddXY(bestFit.map.getCities()[i].x, bestFit.map.getCities()[i].y);
                    this.salesmanPathChart.Series["tspPath"].Points.AddXY(bestFit.map.getCities()[i].x, bestFit.map.getCities()[i].y);
                    this.citiesChart2.Series["tspCities2"].Points.AddXY(bestFit2.map.getCities()[i].x, bestFit2.map.getCities()[i].y);
                    this.salesmanPathChart2.Series["tspPath2"].Points.AddXY(bestFit2.map.getCities()[i].x, bestFit2.map.getCities()[i].y);

                    if (i == Nature.city_pop_size - 1)
                    {
                        this.salesmanPathChart.Series["tspPath"].Points.AddXY(bestFit.map.getCities()[0].x, bestFit.map.getCities()[0].y);
                        this.salesmanPathChart2.Series["tspPath2"].Points.AddXY(bestFit2.map.getCities()[0].x, bestFit2.map.getCities()[0].y);

                    }

                    //dataCount++;
                }

            fitness1.Text = bestFit.fitness.ToString();
            fitness2.Text = bestFit2.fitness.ToString();
            //expPathBox.Text = currentFit.calculateDistance(currentFit.cityPathList[2], currentFit.cityPathList[5],currentFit.cityPathList).ToString();
            this.citiesChart.Show();
            this.citiesChart2.Show();
            //Console.WriteLine(dataIn);
            //this.citiesChart.Series["tspCities"].Points.AddXY(8, 713);

            this.salesmanPathChart.Show();
            this.salesmanPathChart2.Show();
            
            //this.loadChartsButton.Hide();

            // Selecting the first radio button by default;
            //this.set1Button.Checked = true;
            //this.set1Button.Checked = false;
            
            //data1.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loadChartsButton_Click(object sender, EventArgs e)
        {
            
        }

        private void expPathBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void citiesChart2_Click(object sender, EventArgs e)
        {

        }
        private void WorkThreadFunction(int numberOfRuns, Population currentFit, Population bestFit)
        {
            try
            {
                for (int i = 0; i < numberOfRuns; i++)
                {

                    //currentFit = new Population();
                    //currentFit.calculateTotalDistance();
                    currentFit = solve.mate(bestFit, solve.buildCrossoverGenome(currentFit));

                    fitnessCurrent = currentFit.calculateTotalDistance();
                    if (fitnessBest > fitnessCurrent)
                    {
                        //bestFit = new Population();
                        bestFit = currentFit;
                        fitnessBest = bestFit.calculateTotalDistance();
                    }

                }


            }
            catch (Exception ex)
            {
                // log errors
            }
        }
        
    }
}
