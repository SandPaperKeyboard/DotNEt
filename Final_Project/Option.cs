using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal interface Option
    {
        // 전화번호
        public string tel { get; set; }
        // 이메일
        public string e_mail { get; set; }
        // 이름
        public string name { get; set; }
        // 소속학과
        public string major { get; set; }
    }
}
