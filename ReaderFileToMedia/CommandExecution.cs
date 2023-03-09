using _1._1.Classes;
using _1._1.Models;
using _1._1.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1.ReaderFileToMedia
{
    internal static class CommandExecution
    {

        private static List<MediaInterface> medias = new List<MediaInterface>();
        public static void ExecuteCommands(List<string> data)
        {
            medias = medias.Where(e => e != null).ToList();
            if (data.Contains("REM") && Validate.CommandExecutionMediasCountValidate(medias))
            {
                data.RemoveAt(0);
                if (Validate.CommandExecutionDataValidate(data))
                    foreach (var media in medias)
                    {
                        if (media.DeleteOnProps(Validate.ValideProps(data[0]), Validate.ValideProps(data[1])))
                        {
                            medias.Remove(media);
                        };
                    }
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
