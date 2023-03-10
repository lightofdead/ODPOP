using _1._1.Models;

namespace _1._1.Validations
{
    internal static class Validate
    {


        public static string ValideProps(string prop)
        {
            return prop.Trim().Replace(" ", "").Replace("_", " ");
        }

        public static bool CheckValideCountSeries(string propCount)
        {
            if (int.TryParse(propCount, out int count))
            {
                return count > 0;
            }
            else
            {
                return false;
            }
        }
        public static bool CommandExecutionDataValidate(List<string> strings)
        {
            return strings.Count == 2;
        }
        public static bool CommandExecutionMediasCountValidate(List<MediaInterface> medias)
        {
            return medias.Count > 0;
        }
    }
}
