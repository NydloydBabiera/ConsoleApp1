using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class OptionsClass : StudentInfoClass
    {
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
