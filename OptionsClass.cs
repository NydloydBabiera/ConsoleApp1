using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class OptionsClass : StudentInfoClass
    {
        //inherit from StudentInfoClass, pero mahugot ko gihapon ang sa studetClass
        //since naka inheriot sa studentInfoCLass ang student class bale diri na part ang mga function lang gin tawag ko
        //diri na class ang super class ko since diri ko man tanan gin perform ang mga methods ko sa student kag studentinfo classes
        public void opt1()
        {
            addStudents();
        }
        public void opt2()
        {
            inputStudentGrades();
        }
        public void opt3()
        {
            displayStudentGrades();
        }
    }
}
