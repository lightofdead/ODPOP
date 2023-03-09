using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1.Classes
{
    internal class Series : Film
    {
        private int count;
        public Series(string title, string produser, int count) : base(title, produser)
        {
            this.count = count;
        }
    }
}
