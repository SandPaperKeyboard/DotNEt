using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class Person : Option
    {
        //전화번호
        public string tel { get; set; }
        //이메일
        public string email { get; set; }
        //이름
        public string name { get; set; }
        // 소속학과
        public string major { get; set; }
        public string e_mail { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Person(string tel, string email, string name, string major) // Person 생성자
        {
            this.tel = tel;
            this.email = email;
            this.name = name;
            this.major = major;
        }
    }
}
