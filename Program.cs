using _1._1.Models;
using _1._1.ReaderFileToMedia;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        List<string> strings = new List<string>();
        foreach (var item in ReaderFileToListString.FileToList("./data.txt"))
        {
            CommandExecution.ExecuteCommands(new List<string>(item.Split(',')));
        }
    }

}
