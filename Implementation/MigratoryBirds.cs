using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string b = Console.ReadLine();

 		string[] b1 = Console.ReadLine().Split(' ');
		int[] numberOfBirds = Array.ConvertAll(b1, Int32.Parse);

		Dictionary<int, int> dictionary = new Dictionary<int, int>();

		for (int x = 0; x < numberOfBirds.Length; x++)
		{
			if (dictionary.ContainsKey(numberOfBirds[x]))
			{
				dictionary[numberOfBirds[x]]++;
			}
			else
			{
				dictionary.Add(numberOfBirds[x], 1);
			}
		}

		int key = 0;
		int value = 0;
		
		foreach(var x in dictionary)
		{
			key = x.Key;
			value = x.Value;
			break;
		}
		
		foreach (var x in dictionary)
		{
			if(x.Value == value)
			{
				if(key > x.Key)
				{
					value = x.Value;
					key = x.Key;
				}
			}
			else if (x.Value > value)
			{
				value = x.Value;
				key = x.Key;
			}
		}
		Console.WriteLine(key);
    }
}

