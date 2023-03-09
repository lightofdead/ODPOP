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
        private Enum type;

        Dictionary<string, Types> stringToTypes = new Dictionary<string, Types>()
        {
            ["Рисованный"] = Types.handDrawn,
            ["Кукольный"] = Types.Puppet,
            ["Пластилиновый"] = Types.plasticine
        };
        private enum Types
        {
            handDrawn, //рисованный
            Puppet, //кукольный
            plasticine, //пластилин
            NONE
        }
        public Multfilm(string title, string type) : base(title)
        {
            if(stringToTypes.TryGetValue(type, out Types value))
            {
                this.type = value;
            }
            else
            {
                this.type = Types.NONE;
            }
        }
        override public void ShowMe()
        {
            if (this.type.ToString() == "NONE") { }
            else
            {
                base.ShowMe();
                Console.WriteLine($"Тип мультфильма : {type.ToString()}");
            }
        }
    }
}
