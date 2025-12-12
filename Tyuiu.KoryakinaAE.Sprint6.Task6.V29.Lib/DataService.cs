using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KoryakinaAE.Sprint6.Task6.V29.Lib
{
    public class DataService : ISprint6Task6V29
    {
        public string CollectTextFromFile(string path)
        {
            string[] lineList;
            string res = "";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lineList = line.Trim().Split(' ');
                    foreach (string i in lineList)
                    {
                        if (i.Contains('i')) res += " " + i;
                    }
                }
            }
            return res.Trim();
        }
    }
}
