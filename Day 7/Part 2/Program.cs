using System.IO;

namespace AOC_d7_p2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("../../../../../Inputs/Input.txt");
            char[,] map = new char[input[0].Length, input.Length];
            HashSet<int> positions = new HashSet<int>();
            long[] position_count = new long[input[0].Length];

            int start = input[0].IndexOf(char.Parse("S"));
            long result = 0;

            positions.Add(start);
            position_count[start] = 1;

            for (int y = 0; y < input.Length; y++)
            {
                for (int x = 0; x < input[y].Length; x++)
                {
                    map[x, y] = input[y][x];
                }
            }


            for (int y = 1; y < input.Length; y++)
            {
                Console.WriteLine($"Line: {y}, Positions: {positions.Count}");
                foreach (int position in positions.ToArray()) 
                {
                    if (map[position, y].ToString() == "^")
                    {
                        position_count[position + 1] += position_count[position];
                        position_count[position - 1] += position_count[position];
                        position_count[position] = 0;

                        map[position + 1, y] = char.Parse("|");
                        map[position - 1, y] = char.Parse("|");

                        positions.Add(position + 1);
                        positions.Add(position - 1);
                        positions.Remove(position);
                    }
                    else if (map[position, y].ToString() == ".")
                    {
                        map[position, y] = char.Parse("|");
                    }
                }
            }

            for (int y = 0; y < input.Length; y++)
            {
                for (int x = 0; x < input[y].Length; x++)
                {
                    Console.Write(map[x,y]);
                }
                Console.WriteLine();
            }

            foreach (long count in position_count)
            {
                result += count;
            }


            Console.WriteLine(result);
        }
    }
}
