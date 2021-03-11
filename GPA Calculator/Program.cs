using System;
using System.Collections.Generic;
using System.Linq;

namespace GPA_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Input the number of classes: ");
            int NumOfClasses = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Grades or Percentages?");
            string InputSelection = Console.ReadLine();

            if (InputSelection == "Grades" || InputSelection == "grades")
            {
                List<double> gradepoints = new List<double>();
                Console.WriteLine("Please input Grades");
                for (int counter = 0; counter < NumOfClasses; counter++)
                {
                    string grade = Console.ReadLine();
                    double gradepoint;

                    if (grade == "A")
                    {
                        gradepoint = 4;
                        gradepoints.Add(gradepoint);
                    }
                    else if (grade == "A-")
                    {
                        gradepoint = 3.7;
                        gradepoints.Add(gradepoint);
                    }
                    else if (grade == "B+")
                    {
                        gradepoint = 3.3;
                        gradepoints.Add(gradepoint);
                    }
                    else if (grade == "B")
                    {
                        gradepoint = 3;
                        gradepoints.Add(gradepoint);
                    }
                    else if (grade == "B-")
                    {
                        gradepoint = 2.7;
                        gradepoints.Add(gradepoint);
                    }
                    else if (grade == "C+")
                    {
                        gradepoint = 2.3;
                        gradepoints.Add(gradepoint);
                    }
                    else if (grade == "C")
                    {
                        gradepoint = 2;
                        gradepoints.Add(gradepoint);
                    }
                    else if (grade == "C-")
                    {
                        gradepoint = 1.7;
                        gradepoints.Add(gradepoint);
                    }
                    else if (grade == "D+")
                    {
                        gradepoint = 1.3;
                        gradepoints.Add(gradepoint);
                    }
                    else if (grade == "D")
                    {
                        gradepoint = 1;
                        gradepoints.Add(gradepoint);
                    }
                    else if (grade == "D-")
                    {
                        gradepoint = 0.7;
                        gradepoints.Add(gradepoint);
                    }
                    else if (grade == "F")
                    {
                        gradepoint = 0;
                        gradepoints.Add(gradepoint);
                    }


                }
                double[] gradepointaverage = gradepoints.ToArray();
                double GPA = gradepointaverage.Sum() / NumOfClasses;
                Console.WriteLine("Your GPA is: " + GPA);
            }
            else if (InputSelection == "Percentages" || InputSelection == "percentages")
            {
                
                List<double> gradepoints = new List<double>();
                Console.WriteLine("Please input Percentages");
                for (int counter = 0; counter < NumOfClasses; counter++)
                {
                    
                    int percentage = Convert.ToInt32(Console.ReadLine());
                    double gradepoint;
                    
                    if (percentage > 92)
                    {
                        gradepoint = 4;
                        gradepoints.Add(gradepoint);
                    }
                    else if(percentage < 93 && percentage > 89)
                    {
                        gradepoint = 3.7;
                        gradepoints.Add(gradepoint);
                    }
                    else if (percentage < 90 && percentage > 86)
                    {
                        gradepoint = 3.3;
                        gradepoints.Add(gradepoint);
                    }
                    else if (percentage < 87 && percentage > 82)
                    {
                        gradepoint = 3;
                        gradepoints.Add(gradepoint);
                    }
                    else if (percentage < 83 && percentage > 79)
                    {
                        gradepoint = 2.7;
                        gradepoints.Add(gradepoint);
                    }
                    else if (percentage < 80 && percentage > 76)
                    {
                        gradepoint = 2.3;
                        gradepoints.Add(gradepoint);
                    }
                    else if (percentage < 77 && percentage > 72)
                    {
                        gradepoint = 2;
                        gradepoints.Add(gradepoint);
                    }
                    else if (percentage < 73 && percentage > 69)
                    {
                        gradepoint = 1.7;
                        gradepoints.Add(gradepoint);
                    }
                    else if (percentage < 70 && percentage > 66)
                    {
                        gradepoint = 1.3;
                        gradepoints.Add(gradepoint);
                    }
                    else if (percentage < 67 && percentage > 62)
                    {
                        gradepoint = 1;
                        gradepoints.Add(gradepoint);
                    }
                    else if (percentage < 63 && percentage > 59)
                    {
                        gradepoint = 0.7;
                        gradepoints.Add(gradepoint);
                    }
                    else if (percentage < 60)
                    {
                        gradepoint = 0;
                        gradepoints.Add(gradepoint);
                    }

                    
                }     
                double[] gradepointaverage = gradepoints.ToArray();
                double GPA = gradepointaverage.Sum() / NumOfClasses;
                Console.WriteLine("Your GPA is: " + GPA);
            }
        }
    }
}
