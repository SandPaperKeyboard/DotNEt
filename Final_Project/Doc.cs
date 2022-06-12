using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class Doc
    {
        // 과목
        public string subject;
        // 교수
        public string professor;
        // 강의실
        public string room;

        public List<Student> student = new List<Student>();
        public void addStudent(Student student)
        {
            this.student.Add(student);
        }

        public Doc(string subject, string professor, string room)
        {
            this.subject = subject;
            this.professor = professor;
            this.room = room;
        }
    }
}
