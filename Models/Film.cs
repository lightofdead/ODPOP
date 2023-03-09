using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1.Classes
{
    internal class Film : MediaBasic
    {
        protected string producer;
        public Film(string title, string produser) : base(title)
        {
            this.producer = produser;
        }
    }
}
