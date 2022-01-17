using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2022_Gavrilut_Adriana_Problema_261
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader load = new StreamReader(@"..\..\intervale.in");
            StreamWriter afisare = new StreamWriter(@"..\..\intervale.out");
            string line = load.ReadLine();
            char[] sep = { ' ' };
            int n;
            string[] tokens = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            n = int.Parse(tokens[0]);
            int[,] matrice = new int[n, 2];
            for (int i = 0; i < n; i++)
            {
                line = load.ReadLine();
                tokens = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < 2; j++)
                {
                    matrice[i, j] = int.Parse(tokens[j]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matrice[i,j] + " ");
                }
                Console.WriteLine();
            }
            List<int> intervaleBune = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int intersectii = 0;
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        if (matrice[i, 1] >= matrice[j, 0] && matrice[j, 1] >= matrice[i, 0])
                        {
                            intersectii++;
                            break;
                        }
                    }
                }
                if (intersectii == 0)
                {
                    intervaleBune.Add(i);
                }
            }
            afisare.WriteLine(intervaleBune.Count());
            for (int i = 0; i < intervaleBune.Count; i++)
            {
                afisare.WriteLine(matrice[intervaleBune[i], 0] + " " + matrice[intervaleBune[i], 1]);
            }
            afisare.Close();
        }
    }
}
