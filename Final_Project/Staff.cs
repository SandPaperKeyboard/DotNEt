using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    // 직원 정보
    internal class Staff : Faculty, Option
    {
        // 직급
        public string grade = null;
        public Staff(string grade, string fa_id, string money, string startDay, string tel, string email, string name, string major) : base(tel, email, name, major)
        {
            this.grade = grade;
            base.fa_id = fa_id;
            base.money = money;
            base.start_day = startDay;
        }
    }
}
