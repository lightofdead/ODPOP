using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1.ReaderFileToMedia
{
    internal static class ReaderFileToListString
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
