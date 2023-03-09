using _1._1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace _1._1.Classes
{
    internal class Multfilm : MediaBasic
    {
        private Types type;
        private enum Types
        {
            handDrawn, //рисованный
            Puppet, //кукольный
            plasticine, //пластилин
        }

        Dictionary<string, Types> films = new Dictionary<string, Types>()
        {
            ["Рисованный"] = Types.handDrawn,
            ["Кукольный"] = Types.Puppet,
            ["Пластилиновый"] = Types.plasticine
        };
        public Multfilm(string title, string type) : base(title)
        {

        }
    }
}
