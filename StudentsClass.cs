using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class StudentsClass
    {
        public int studentCnt = 0;

        public string[] studentNames = { };
        public void addStudents()
        {
            studentNames = new string[studentCnt];
            for (int x = 0; x < studentNames.Length; x++)
            {
                Console.Write("Enter student name: ");
                studentNames[x] = Console.ReadLine();

                Console.Write("Do you want to add more?[Y/N]: ");
                string decide = Console.ReadLine();
                if (decide.ToLower() == "n") break;
                
            }
        }




        
    }
}
