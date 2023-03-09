// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

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
