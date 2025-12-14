using System.IO;
using System.Text.RegularExpressions;

namespace AOC_d6_p1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("../../../../../Inputs/Input.txt");

            string num_pattern = @"\d+";
            string char_patterm = @"[*+]";

            List<long> numbers_1 = new List<long>();
            List<long> numbers_2 = new List<long>();
            List<long> numbers_3 = new List<long>();
            List<long> numbers_4 = new List<long>();

            List<char> operators = new List<char>();

            long result = 0;

            for (int line = 0; line < input.Length; line++)
            {
                if (line < 4)
                {
                    foreach (Match match in  Regex.Matches(input[line], num_pattern))
                    {
                        
                        switch (line)
                        {
                            case 0:
                                numbers_1.Add(int.Parse(match.Value));
                                break;
                            case 1:
                                numbers_2.Add(int.Parse(match.Value));
                                break;
                            case 2:
                                numbers_3.Add(int.Parse(match.Value));
                                break;
                            case 3:
                                numbers_4.Add(int.Parse(match.Value));
                                break;
                            default:
                                break;
                        }
                        
                    }
                } else
                {
                    foreach (Match oper in Regex.Matches(input[line], char_patterm))
                    {
                        
                        operators.Add(char.Parse(oper.Value));
                        
                    }
                }

            }

            for (int i = 0; i < numbers_1.Count; i++)
            {
                if (operators[i].ToString() == "+")
                {
                    result = result + (numbers_1[i] + numbers_2[i] + numbers_3[i] + numbers_4[i]);
                    //Console.WriteLine($"{result}, {numbers_1[i]}, {numbers_2[i]}, {numbers_3[i]}, {numbers_4[i]}");
                } else if (operators[i].ToString() == "*")
                {
                    result = result + (numbers_1[i] * numbers_2[i] * numbers_3[i] * numbers_4[i]);
                    //Console.WriteLine($"{result}, {numbers_1[i]}, {numbers_2[i]}, {numbers_3[i]}, {numbers_4[i]}");
                }
            }

            Console.WriteLine(result);

            //Console.WriteLine(numbers_1.Count);
            //Console.WriteLine(numbers_2.Count);
            //Console.WriteLine(numbers_3.Count);
            //Console.WriteLine(numbers_4.Count);
            //Console.WriteLine(operators.Count);

            //Console.WriteLine(input.Length);
        }
    }
}
