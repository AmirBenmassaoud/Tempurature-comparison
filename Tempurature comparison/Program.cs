using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tempurature_comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tempIn = new int[5];
            int tempComp = 0;
            int[] trend = new int[4];
            int trendFlag = 0;
            int average = 0;
            int total = 0;

            {
                for (int i = 0; i < 5; i++) 
                {
                    Console.WriteLine("Input a tempurature between -30 and 130");
                   
                    tempIn[i] = Convert.ToInt32(Console.ReadLine());
                   
                    if (tempIn[i] < -30 || tempIn[i] > 130)
                    { 
                     Console.WriteLine("Please enter a valid temperuature");

                        i--;

                        continue;
                                      
                    }
                             
                }

                for (int i = 0; i < 5; i++)
                {
                    if (i == 0)
                    { 
                     tempComp= tempIn[i];
                        continue;
                    }

                    if (tempIn[i] > tempComp)
                    {
                        trend[i - 1] = 1;
                        tempComp= tempIn[i];
                        continue;
                    }

                    if (tempIn[i] < tempComp)
                    {
                        trend[i - 1] = -1;
                        tempComp = tempIn[i];
                        continue;
                    }

                    trend[i - 1] = 0;
                    tempComp = tempIn[i];

                }

                for (int i = 0; i < 4; i++)
                {
                    trendFlag = trendFlag + trend[i];
                }

                switch (trendFlag)
                {
                    case -4:
                        Console.WriteLine("Getting Colder!");
                        break;
                    case 4:
                        Console.WriteLine("Getting Warmer!");
                        break;
                    default:
                        Console.WriteLine("It's a mixed bag!");
                        break;
                }

                Console.Write("5-Day tempurature [");
                for (int i = 0;i < 5;i++) 
                {
                    Console.Write(tempIn[i] + ", ");
                }
                Console.WriteLine("] \n");

                for (int i = 0; i < 5; i++)
                { 
                 total = total + tempIn[i];
                }

                average = total / 5;

                Console.WriteLine("Average tempurature is " + average + " degrees.");



                Console.Read();
                { 
                
                }



            }
           














        }
    }
}
