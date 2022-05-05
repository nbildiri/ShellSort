using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ShellSort
{
    public partial class ShellSort : Form
    {

        int randNum;
        int[] arry;


        public ShellSort(int randNum)
        {
            InitializeComponent();
            this.randNum = randNum;
            arry = new int[randNum];
            populateGraph(randNum);
        }


        private void populateGraph(int randNum)
        {

            Random rand = new Random();

            //int j = 1;

            for (int i = 0; i < randNum; i++)
            {
                //if (j > 6) { j = 1; }

                int random = rand.Next(100);

                while (arry.Contains(random))
                {
                    random = rand.Next(100);
                }


                chart1.Series[1].Points.AddXY(i, random);
                // j++; 
                arry[i] = random;
            }

        }



        private void chart1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
         {

             for (int gap = randNum / 2; gap > 0; gap /= 2)
             {

                 for (int i = gap; i < randNum; i++)
                 {
                     int temp = arry[i];

                     int j;

                     for (j = i; j >= gap && arry[j - gap] > temp; j -= gap)
                     { 
                         arry[j] = arry[j - gap];

                        chart1.Series[1].Points.ElementAt(i).SetValueY(arry[i]);
                        chart1.Series[1].Points.AddXY(i, arry[i]);
                        chart1.Refresh();
                        chart1.Series[1].Points.ElementAt(j).SetValueY(arry[j]);
                        chart1.Series[1].Points.AddXY(j, arry[j]);
                        chart1.Refresh();
                    }

                     arry[j] = temp;



                    if (arry[i] != temp)
                    {
                        //chart1.Series[1].Points.RemoveAt(i);
                        //chart1.Refresh();
                        //chart1.Series[1].Points.RemoveAt(j);
                        //chart1.Refresh();
                        //chart1.Series[1].Points.AddXY(i, arry[i]);
                        chart1.Series[1].Points.ElementAt(i).SetValueY(arry[i]);
                        //chart1.Series[1].Points.AddXY(i, arry[i]);
                        chart1.Refresh();
                        chart1.Series[1].Points.ElementAt(j).SetValueY(arry[j]);
                        //chart1.Series[1].Points.AddXY(j, arry[j]);
                        chart1.Refresh();
                        //chart1.Series[1].Points.AddXY(j, arry[j]);

                        chart1.Refresh();
                    }
                }
                chart1.Refresh();
            }
            chart1.Refresh();
        }
     }
 }

 