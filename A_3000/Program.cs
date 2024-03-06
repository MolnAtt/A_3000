using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace A_3000
{
	internal class Program
	{
		static string Stringbe<T>(List<T> t, string separator = " ", string start = "[ ", string end = " ]")
		{
			if (t.Count == 0)
			{
				return start + end;
			}

			string result = start;
			for (int i = 0; i < t.Count - 1; i++)
			{
				result += $"{t[i]}" + separator;
			}
			result += t[t.Count - 1];
			return result + end;
			// default: "[ 0 10 0 0 0 ]";
		}
		static List<int> Beolvas(string fajlnev)
		{
			string[] sorok = File.ReadAllLines(fajlnev);
			List<int> result = new List<int>();
			foreach (string sor in sorok)
			{
				result.Add(int.Parse(sor));
			}
			return result;
		}

		static bool Van_e_negativ(List<int> lista)
		{
			int i = 0;
			while (i < lista.Count && !( lista[i] < 0 ))
			{
				i++;
			}
			return i < lista.Count;
		}
		static int Hany_paros(List<int> lista)
		{
			int db = 0;
			foreach (int elem in lista)
			{
				if (elem % 2 == 0)
				{
					db++;
				}
			}
			return db=0;
		}

		static int Legnagyobb(List<int> lista)
		{
			int best = lista[0];

			for (int i = 1; i < lista.Count; i++)
			{
				if (best < lista[i])
				{
					best = lista[i];
				}
			}
			return best;
		}

		static List<int> Tizzel_oszthatok(List<int> lista)
		{
			List<int> result = new List<int>();
            foreach (int elem in lista)
            {
				if (elem%10==0)
				{
					result.Add(elem);
				}
            }
			return result;
        }

		static void Main(string[] args)
		{
			List<int> lista = Beolvas("input.txt");

            Console.WriteLine("Hány eleme van a sorozatnak?");
            Console.WriteLine(lista.Count);
			Console.WriteLine("Van-e a sorozatban negatív szám?");
			Console.WriteLine(Van_e_negativ(lista));
			Console.WriteLine("Hány páros szám található a sorozatban?");
            Console.WriteLine(Hany_paros(lista));
            Console.WriteLine("Mennyi a sorozatban található legnagyobb szám?");
            Console.WriteLine(Legnagyobb(lista));
            Console.WriteLine(Stringbe(Tizzel_oszthatok(lista)));
        }
	}
}
