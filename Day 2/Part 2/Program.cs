using System.IO;
using System.Text.RegularExpressions;

namespace AOC_d2_p2
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
            
            string first_half = "";
            string second_half = "";
            long final_sum = 0;
            int num_length;

            foreach (string line in lines)
            {
                splits = line.Split(',');
                foreach (string thing in splits)
                {
                    if (thing == "") continue;

                    ranges.Add(thing);
                }
            }

            foreach (string range in ranges)
            {
                start_range = range.Split("-")[0];
                end_range = range.Split("-")[1];

                //Console.WriteLine(start_range.Length);

                for (long i = long.Parse(start_range); i <= long.Parse(end_range); i++)
                {
                    for (int letters = 1; letters < i.ToString().Length; letters++)
                    {
                        if (i.ToString().Length % letters != 0) continue;

                        string pattern = i.ToString().Substring(0, letters);

                        //Console.WriteLine(pattern);

                        int counter = 0;
                        
                        foreach (Match match in Regex.Matches(i.ToString(), $@"({pattern})")) {
                            if (match.Success)
                            {
                                counter++;
                            }
                        }

                        //Console.WriteLine($"{counter}, {i.ToString().Length / letters}");

                        if (counter == (i.ToString().Length/letters))
                        {
                            final_sum += i;
                            Console.WriteLine(i);
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(final_sum);
        }
    }
}
