using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KoryakinaAE.Sprint6.Task6.V29.Lib
{
    public class DataService : ISprint6Task6V29
    {
        public string CollectTextFromFile(string path)
        {
            string result = "";

            using (StreamReader sr = new StreamReader(path))
            {
                string? line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        if (word.Contains('i'))
                            result += word + " ";
                    }
                }
            }

            return result.TrimEnd();
        }
    }
}