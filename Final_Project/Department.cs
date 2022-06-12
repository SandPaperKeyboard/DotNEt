using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class Department  // 학과
    {
        // 학과명
        public string de_name = null;
        // 학과 주소
        public string de_address = null;
        // 학과 전화번호
        public string de_tel = "0";
        // 학과 조교명
        public string de_assist = null;
        // 학과장명
        public string de_cap = null;
        // 학과 이메일
        public string de_email = null;
        // 학과 웹사이트
        public string de_web = null;

        public List <Person> person = new List <Person> ();
        public List <Subject> subject = new List <Subject> ();

        // 
        public void addSubject(string[] sub, string[] pro)
        {
            for (int i = 0; i < sub.Length; i++)
            {
                if(sub[i] != null && pro[i] != null)
                {
                    subject.Add(new Subject(sub[i], pro[i]));
                }
            }
        }

        public void addStudent(Student student)
        {
            person.Add(student);
        }

        public void addProfessor(Professor professor)
        {
            person.Add(professor);
        }

        public Department(string de_name, string de_address, string de_tel, string de_assist, string de_cap, string de_email, string de_web, string[] subject, string[] professor)
        {
            this.de_name = de_name;
            this.de_address = de_address;
            this.de_tel = de_tel;
            this.de_assist = de_assist;
            this.de_cap = de_cap;
            this.de_email = de_email;
            this.de_web = de_web;
            addSubject(subject, professor);
        }
    }
}
