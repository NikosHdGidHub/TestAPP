using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPP.BL
{
    public class Uset
    {
        public string Name { get; set; }
        public Uset():this("123")
        {

        }
        public Uset(string name)
        {
            Name = name;
        }
    }
}
