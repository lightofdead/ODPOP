namespace _1._1.ReaderFileToMedia
{
    public static class ReaderFileToListString
    {
        public static List<string> FileToList(string path)
        {
            List<string> _list = new List<string>();
            string line;
            try
            {
                StreamReader sr = new StreamReader(path);
                line = sr.ReadLine();
                while (line != null)
                {
                    _list.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return _list;
        }
    }
}
