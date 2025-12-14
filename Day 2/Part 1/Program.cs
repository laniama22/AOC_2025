using System.IO;

namespace AOC_d2_p1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../../../../Inputs/Input.txt");
            List<string> ranges = new List<string>();
            string[] splits;
            string start_range = "";
            string end_range = "";
            string actual_number = "";
            char[] char_num;
            string first_half = "";
            string second_half = "";
            long final_sum = 0;
            int num_length;

            foreach (string line in lines)
            {
                splits = line.Split(',');
                foreach(string thing in splits)
                {
                    ranges.Add(thing);
                }
            }

            foreach (string range in ranges)
            {
                if (range == "")
                {
                    
                } else
                {
                    splits = range.Split('-');
                    start_range = splits[0];
                    end_range = splits[1];

                    for(long i = long.Parse(start_range); i <= long.Parse(end_range); i++)
                    {
                        actual_number = i.ToString();
                        num_length = actual_number.Length;

                        for (int pat_lenght = 1; pat_lenght <= (num_length/2); pat_lenght++)
                        {

                        }
                        
                    }

                    Console.WriteLine(final_sum);
                    //Console.WriteLine($"{range}, {start_range}, {end_range}");
                }
            }
        }
    }
}
