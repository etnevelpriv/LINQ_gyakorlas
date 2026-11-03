using System.Diagnostics.Tracing;

namespace LINQ_gyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Diak> diakok = [];
            bool isFirstLine = true;
            foreach (string diakLine in File.ReadLines("diakok.csv"))
            {
                if (isFirstLine)
                {
                    isFirstLine = false;
                    break;
                } else
                {
                    string[] diakStringArr = diakLine.Trim().Split(";");
                    Diak diak = new Diak(diakStringArr[0], Convert.ToInt32(diakStringArr[1]), diakStringArr[2], Convert.ToDouble(diakStringArr[3]));
                    diakok.Add(diak);
                }
            }
            
        }
    }
}