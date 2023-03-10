using _1._1.ReaderFileToMedia;


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
