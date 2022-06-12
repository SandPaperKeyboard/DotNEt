using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    // 학생 정보
    internal class Student : Person, Option
    {
        // 학번
        public string st_id = "0";
        // 수혜 장학금
        public string[] money = new string[1000];

        public List<SubjectEnd> subjectEnd = new List<SubjectEnd>();

        public void addSubjectEnd(string[] year, string[] season, string[] sub, string[] grade)
        {
            for(int i = 0; i < year.Length; i++)
            {
                if(year[i] != null && season[i] != null && sub[i] != null && grade[i] != null)
                {
                    subjectEnd.Add(new SubjectEnd(year[i], season[i], sub[i], grade[i]));
                }
            }
        }

        public Student(string st_id, string tel, string email, string name, string major, string[] money, string[] year, string[] season, string[] sub, string[] grade) 
            : base (tel, email, name, major)
        {
            this.st_id = st_id;
            this.money = money;
            addSubjectEnd(year, season, sub, grade);
        }


    }
}
