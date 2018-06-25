using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordFrequencyCounter
{
	class Program
	{
		static void Main(string[] args)
		{
			string aaa = File.ReadAllText("file.txt");
			// string aaa = File.ReadAllText("file.docx");
			//string[] aa = aaa.Split(' ',':');
			string[] aa = aaa.Split(' ');

			Dictionary<string, int> words = new Dictionary<string, int>();
			foreach (string a in aa)
			{

				if (words.ContainsKey(a))
				{
					words[a]++;
				}
				else
				{
					words.Add(a, 1);
				}
			}
			//words = words.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
			//foreach (string item in words.Keys)
			//{
			//	Console.WriteLine(item + " " + words[item] );
			//}

			var list = words.Keys.ToList();
			list.Sort();

			// Loop through keys.
			foreach (var key in list)
			{
				Console.WriteLine("{0}: {1}", key, words[key]);
			}


			Console.ReadKey();
		}
	}
}
