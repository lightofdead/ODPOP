namespace _1._1.Classes
{
    public class Multfilm : MediaBasic
    {
        private Types type;
        public string Type => type.ToString();

        Dictionary<string, Types> stringToTypes = new Dictionary<string, Types>()
        {
            ["Рисованный"] = Types.handDrawn,
            ["Кукольный"] = Types.Puppet,
            ["Пластилиновый"] = Types.plasticine
        };
        Dictionary<Types, string> typesToString = new Dictionary<Types, string>()
        {
            [Types.handDrawn] = "Рисованный",
            [Types.Puppet] = "Кукольный",
            [Types.plasticine] = "Пластилиновый"
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
                typesToString.TryGetValue(type, out string value);
                Console.WriteLine($"Тип мультфильма : {value}");
            }
        }

        public string GetStringType()
        {
            return Type;
        }

        public override bool DeleteOnProps(string propName, string prop)
        {
            if (propName == "Тип")
            {
                stringToTypes.TryGetValue(prop, out Types value);
                return this.type == value;
            }
            else return false;
        }
    }
}
