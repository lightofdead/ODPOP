using _1._1.Models;

namespace _1._1.Classes
{
    internal class MediaBasic : MediaInterface
    {
        protected string title;
        public MediaBasic(string title)
        {
            this.title = title;
        }
        public MediaBasic() { }
        public virtual void ShowMe()
        {
            Console.WriteLine($"Название : {title}");
        }
        public virtual bool DeleteOnProps(string propName, string prop)
        {
            if (propName == "Название")
            {
                return title == prop;
            }
            else return false;
        }
    }
}
