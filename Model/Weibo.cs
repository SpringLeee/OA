using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Weibo
    {
        public int id { get; set; }
        public string text { get; set; }
        public string images { get; set; }
        public Nullable<int> sendman { get; set; }
        public Nullable<System.DateTime> sendtime { get; set; }
        public Nullable<int> transpond { get; set; }
        public Nullable<int> remark { get; set; }
        public Nullable<int> nice { get; set; }
    }
    
}
