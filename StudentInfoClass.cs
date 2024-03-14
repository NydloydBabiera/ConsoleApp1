using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class StudentInfoClass : StudentsClass
    {
        //inherit halin sa student class ang function na add students ang variables from studentClass magamit ko anywhere hangtod options since connected sila
        //kag gin inherit ko sila tanan so connected sila

        private string[] headers = { "Science", "English", "Math", "Average" };
       public string[] studentGrades = { };
        private double sumGrades = 0;
        private double average = 0;

      public void inputStudentGrades()
        {
            studentGrades = new string[studentCnt * 4];
            int subjCounter = 0;
            for(int x  = 0; x < studentNames.Length; x++)
            {
                Console.Write(studentNames[x] + "\n");
                for (int y = 0; y < headers.Length; y++)
                {
                    if (y == headers.Length - 1)
                    {
                        average = sumGrades / headers.Length;
                        studentGrades[subjCounter] = average.ToString();
                    }
                    else { 
                    Console.Write($"Enter grade for {headers[y]}");
                    studentGrades[subjCounter] = Console.ReadLine();
                    sumGrades += Convert.ToDouble(studentGrades[subjCounter]);
                        }
                    subjCounter++;
                       
                }
            }
        }

        public void displayStudentGrades()
        {
            int subjCounter = 0;
            for (int x = 0; x < studentNames.Length; x++)
            {
                Console.Write(studentNames[x]);
                for (int y = 0; y < headers.Length; y++)
                {
                    Console.Write("\t");
                    Console.Write(studentGrades[subjCounter]);
                    subjCounter++;
                }
                Console.Write("\n");
            }
        }
        }

    
}
