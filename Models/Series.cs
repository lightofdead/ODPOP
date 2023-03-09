using _1._1.Validations;
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
        override public void ShowMe()
        {
            base.ShowMe();
            Console.WriteLine($"Количество серий : {count}");
        }
        public override bool DeleteOnProps(string propName, string prop)
        {
            if (propName == "Количество")
            {
                if (Validate.CheckValideCountSeries(prop))
                {
                    return this.count == Int32.Parse(prop);
                }
                else return false;
            }
            else return false;
        }
    }
}
