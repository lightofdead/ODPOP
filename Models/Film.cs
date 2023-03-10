namespace _1._1.Classes
{
    public class Film : MediaBasic
    {
        protected string producer;
        public Film(string title, string produser) : base(title)
        {
            this.producer = produser;
        }
        public Film() {}
        override public void ShowMe()
        {
            base.ShowMe();
            Console.WriteLine($"Продюссер : {producer}");
        }
        public override bool DeleteOnProps(string propName, string prop)
        {
            if (propName == "Режиссер")
            {
                return producer == prop;
            }
            else return base.DeleteOnProps(propName, prop);
        }
    }
}
