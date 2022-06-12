using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class Faculty : Person, Option
    {
        // 사번
        public string fa_id = "0";

        // 급여
        public string money = "0";

        // 입사일
        public string start_day = "0";

        public Faculty(string tel, string email, string name, string major) 
            : base(tel, email, name, major) { }
    }
}
