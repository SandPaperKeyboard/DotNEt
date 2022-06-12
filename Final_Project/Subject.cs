using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class Subject 
    {
        // 과목 정보

        public string name = null;
        public string professor = null;
        public Subject(string name, string professor)
        {
            this.name = name;
            this.professor = professor;
        }
    }
}
