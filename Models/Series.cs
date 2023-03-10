using _1._1.Validations;

namespace _1._1.Classes
{
    public class Series : Film
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
