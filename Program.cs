using System;

namespace ConsoleApp1
{
    class Program 
    {
        static void Main(string[] args)
        {

            OptionsClass opt = new OptionsClass();
            Console.WriteLine("Enter number of Students:");
            opt.studentCnt = Convert.ToInt32(Console.ReadLine());
            int menu = 0;
            while (menu != 5)
            {
                Console.WriteLine("Welcome to Student Information System");
                Console.WriteLine("[1] Enter students name\n[2] Enter Student Grades" +
                "\n[3] Show student Grades\n[4] Show top student\n[5]Exit application");
                Console.Write("Enter your choice: ");
                menu = Convert.ToInt32(Console.ReadLine());

                if (menu == 1)
                {
                    opt.opt1();
                }
                else if (menu == 2)
                {
                    opt.opt2();
                }
                else if (menu == 3)
                {
                    opt.opt3();
                }
            }

        }
    }
}
