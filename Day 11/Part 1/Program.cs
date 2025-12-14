using System.IO;

namespace AOC_d11_p1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("../../../../../Inputs/Test.txt");

            List<string> paths = new List<string>();
            List<string> copy = new List<string>();

            bool loop = true;
            int result = 0;
            string start = "";
            string next_word = "gazilion";

            foreach (string line in input)
            {
                if (line.Substring(0,3) == "you") start = line.Substring(4);
                paths.Add(line);
            }
            
            while (loop)
            {
                copy = paths;
                while (true)
                {
                    if (next_word.Substring(4, 3) == "out")
                    {
                        result++;
                        break;
                    }
                    
                }
            }
        }
    }
}
