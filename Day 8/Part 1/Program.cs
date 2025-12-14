using System.IO;
using System.Runtime.InteropServices.Marshalling;

namespace AOC_d8_p1
{
    internal class Program
    {
        class Position
        {
            public int x { get; set; }
            public int y { get; set; }
            public int z { get; set; }
        }
        class Pair
        {
            public Position junc_1;
            public Position junc_2;

            public double distance;
        }

        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("../../../../../Inputs/Test.txt");

            List<Position> junctions = new List<Position>();
            List<Pair> junc_pairs = new List<Pair>();

            foreach (string line in input)
            {
                int x = int.Parse(line.Split(",")[0]);
                int y = int.Parse(line.Split(",")[1]);
                int z = int.Parse(line.Split(",")[2]);
                Position junction = new Position();
                junction.x = x;
                junction.y = y;
                junction.z = z;
                junctions.Add(junction);
            }

            int n = junctions.Count;

            for (int a = 0; a < n; a++)
            {
                for (int b = 0; b < n; b++)
                {
                    if (a >= b)
                    {
                        continue;
                    }

                    double distance = Math.Sqrt(Math.Pow(junctions[a].x - junctions[b].x, 2) + Math.Pow(junctions[a].y - junctions[b].y, 2) + Math.Pow(junctions[a].z - junctions[b].z, 2));
                    Pair pair = new Pair();
                    pair.junc_1 = junctions[a];
                    pair.junc_2 = junctions[b];
                    pair.distance = distance;
                    junc_pairs.Add(pair);
                }
            }


            junc_pairs = junc_pairs.OrderBy(j => j.distance).ToList();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(junc_pairs[i].distance);
            }
            

        }
    }
}
