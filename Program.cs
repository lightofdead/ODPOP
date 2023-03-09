class Program
{
    static void Main(string[] args)
    {
        List<Film> films = new List<Film>();
        List<Multfilm> multfilms = new List<Multfilm>();
        List<Series> series = new List<Series>();
        new ReadFile().CalculateLengthFigures("./data.txt", films, multfilms, series);
    }
}
// TODO: Сделать словарь тип - строка
enum Types
{
    handDrawn, //рисованный
    Puppet, //кукольный
    plasticine, //пластилин
}

// TODO: Базовый/абстрактный класс.
class Film
{
    public string title;
    public string producer;
    public Film(string title, string produser)
    {
        this.title = title;
        this.producer = produser;
    }
}

class Multfilm
{
    public string title;
    public Types type;
    public Multfilm(string title, Types type)
    {
        this.title = title;
        this.type = type;
    }
}

class Series
{
    public string title;
    public string producer;
    public int count;
    public Series(string title, string producer, int count)
    {
        this.title = title;
        this.producer = producer;
        this.count = count;
    }
}

// TODO: Разбить монолит по принципу SRP
// TODO: Добавлить LINQ, где оно уместно
class ReadFile
{
    public void CalculateLengthFigures(string path, List<Film> films, List<Multfilm> multfilms, List<Series> series)
    {
        try
        {
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(path);
            string line = sr.ReadLine();
            while (line != null)
            {
                var splitString = line.Split(',');
                if (splitString[0] == "ADD" & splitString.Length == 3)
                {
                    bool check = false;
                    if (splitString.Length == 3)
                    {
                        foreach (Types type in Enum.GetValues(typeof(Types)))
                        {
                            if (splitString[2] == type.ToString())
                            {
                                multfilms.Add(new Multfilm(splitString[1], type));
                                check = true;
                            }
                        }
                        if (!check)
                        { 
                            films.Add(new Film(splitString[1], splitString[2])); 
                        }
                    }

                }
                if (splitString[0] == "PRINT")
                {
                    if (films.Count > 0)
                    {
                        foreach(Film film in films)
                        {
                            Console.WriteLine(film);
                        }
                    }
                    if (multfilms.Count > 0)
                    {
                        foreach (Multfilm multfilm in multfilms)
                        {
                            Console.WriteLine(multfilm);
                        }
                    }
                    if (series.Count > 0)
                    {
                        foreach (Series ser in series)
                        {
                            Console.WriteLine(ser);
                        }
                    }
                }
                if (splitString[0] == "REM" & splitString.Length >= 3)
                {
                    if (splitString[1] == "Фильм")
                    {
                        if (splitString[2] == "Режиссер")
                        {
                            foreach (Film film in films)
                            {
                                if (film.producer == splitString[3])
                                {
                                    films.Remove(film);
                                };
                            }
                        }
                        if (splitString[2] == "Название")
                        {
                            foreach (Film film in films)
                            {
                                if (film.title == splitString[3])
                                {
                                    films.Remove(film);
                                };
                            }
                        }
                    }
                    if(splitString[1] == "Мультфильм")
                    {
                        if (splitString[2] == "Тип")
                        {
                            foreach (Multfilm multfilm in multfilms)
                            {
                                if (multfilm.type.ToString() == splitString[3])
                                {
                                    multfilms.Remove(multfilm);
                                };
                            }
                        }
                        if (splitString[2] == "Название")
                        {
                            foreach (Multfilm multfilm in multfilms)
                            {
                                if (multfilm.title == splitString[3])
                                {
                                    multfilms.Remove(multfilm);
                                };
                            }
                        }
                    }
                    // TODO Series
                }
                line = sr.ReadLine();
            }
            sr.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }
    }
}