using System.IO;

namespace AOC_d7_p1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("../../../../../Inputs/Input.txt");
            char[,] map = new char[input[0].Length, input.Length];
            HashSet<int> positions = new HashSet<int>();

            int splitters = 0;
            int start = input[0].IndexOf(char.Parse("S"));

            positions.Add(start);
            
            for (int y = 0; y < input.Length; y++)
            {
                for (int x = 0; x < input[y].Length; x++)
                {
                    map[x,y] = input[y][x];
                }
            }


            for (int y = 1; y < input.Length; y++)
            {

                foreach (int position in positions.ToArray())
                {
                    if (map[position, y].ToString() == "^")
                    {
                        if (map[position + 1, y].ToString() != "|")
                        {
                            positions.Add(position + 1);
                        }
                        if (map[position - 1, y].ToString() != "|")
                        {
                            positions.Add(position - 1);
                        }
                        map[position + 1, y] = char.Parse("|");
                        map[position - 1, y] = char.Parse("|");
                        splitters++;
                        //Console.Write($"{position}, ");
                        positions.Remove(position);
                    } else if (map[position, y].ToString() == ".")
                    {
                        map[position, y] = char.Parse("|");
                    }
                }
            }

            for (int y = 0; y < input.Length; y++)
            {
                for (int x = 0; x < input[y].Length; x++)
                {
                    Console.Write(map[x, y]);
                }
                Console.WriteLine();
            }



            Console.WriteLine(splitters);
        }
    }
}
