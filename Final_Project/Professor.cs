using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    // 교수 정보
    internal class Professor : Faculty, Option
    {
        public List<Subject> subject = new List<Subject>();
        // 강의 과목
        public void add_Subject(string[] sub, string name)
        {
            for (int i = 0; i < sub.Length; i++)
            {
                if (sub[i] != null)
                {
                    subject.Add(new Subject(sub[i], name));
                }
            }
        }
        // 직급
        public string grade = null;
        public Professor(string fa_id, string tel, string email, string name, string major, string money, string[] sub_pro, string grade, string startDay) : base(tel, email, name, major)
        {
            this.grade = grade;
            base.fa_id = fa_id;
            base.money = money;
            base.start_day = startDay;
            add_Subject(sub_pro, name);
        }
    }
}
