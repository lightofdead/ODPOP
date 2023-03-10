using _1._1.Models;
using _1._1.Validations;

namespace _1._1.ReaderFileToMedia
{
    public static class CommandExecution
    {

        private static List<MediaInterface> medias = new List<MediaInterface>();
        public static void ExecuteCommands(List<string> data)
        {
            medias = medias.Where(e => e != null).ToList();
            if (data.Contains("REM") && Validate.CommandExecutionMediasCountValidate(medias))
            {
                List<MediaInterface> mediasForDelete = new List<MediaInterface>();
                data.RemoveAt(0);
                if (Validate.CommandExecutionDataValidate(data))
                {
                    foreach (var media in medias)
                    {
                        if (media.DeleteOnProps(Validate.ValideProps(data[0]), Validate.ValideProps(data[1])))
                        {
                            mediasForDelete.Add(media);
                        };
                    }
                    foreach (var media in mediasForDelete)
                    {
                        medias.Remove(media);
                    }
                }
                mediasForDelete.Clear();
            }
            if (data.Contains("PRINT") && Validate.CommandExecutionMediasCountValidate(medias))
            {
                foreach(var media in medias)
                {
                    media.ShowMe();
                    Console.WriteLine("-                                        -");
                }
                Console.WriteLine("--------------------------------------------");
            }
            if (data.Contains("ADD"))
            {
                data.RemoveAt(0);
                medias.Add(DefineClass.GetMediaClass(data));
            }
        }
    }
}
