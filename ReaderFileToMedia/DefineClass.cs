using _1._1.Classes;
using _1._1.Models;
using _1._1.Validations;

namespace _1._1.ReaderFileToMedia
{
    internal static class DefineClass
    {
        public static MediaInterface GetMediaClass(List<string> props)
        {
            if (props.Count == 2)
            {
                Multfilm mult = new Multfilm(Validate.ValideProps(props[0]), Validate.ValideProps(props[1]));
                if (mult.GetStringType() != "NONE")
                {
                    return mult;
                }
                else
                {
                    Film film = new Film(Validate.ValideProps(props[0]), Validate.ValideProps(props[1]));
                    return film;
                }
            }
            if (props.Count == 3 && Validate.CheckValideCountSeries(props[2]))
            {
                Series series = new Series(Validate.ValideProps(props[0]), Validate.ValideProps(props[1]), Int32.Parse(props[2]));
                return series;
            }
            else return null;
        }
    }
}
