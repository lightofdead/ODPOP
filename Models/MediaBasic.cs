using _1._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1.Classes
{
    internal class MediaBasic : MediaInterface
    {
        protected string title;
        public MediaBasic(string title)
        {
            this.title = title;
        }
        public virtual void ShowMe()
        {
            Console.WriteLine($"Название : {title}");
        }
    }
}
