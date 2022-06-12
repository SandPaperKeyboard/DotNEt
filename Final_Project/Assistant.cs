using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    // 조교 정보
    internal class Assistant : Faculty, Option
    {
        // 조교 배당 과목
        public string subj = null;
        public Assistant(string subj, string fa_id, string money, string startDay, string tel, string email, string name, string major) : base(tel, email, name, major)
        {
            this.subj = subj;
            base.fa_id = fa_id;
            base.money = money;
            base.start_day = startDay;
        }
    }
}
