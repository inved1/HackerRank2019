using System;
using System.Collections.Generic;
using System.IO;

class SolutionDictionary
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());

        Dictionary<string, int> dict = new Dictionary<string, int>();

        for(int i = 0; i < n; i++)
        {
            char[] sep = { ' ' };
            string name = Console.ReadLine().Split(sep)[0];
            int number = int.Parse(Console.ReadLine().Split(sep)[1]);
            dict.Add(name, number);
        }

        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            int tmp;
            if(dict.TryGetValue(name,out tmp))
            {
                Console.WriteLine(String.Format("{0}={1}", name, tmp));

            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}

