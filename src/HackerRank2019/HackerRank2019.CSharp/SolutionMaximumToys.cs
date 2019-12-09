using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class SolutionMaximumToys
{

    // Complete the maximumToys function below.
    static int maximumToys(int[] prices, int k)
    {
        Array.Sort(prices);
        int count = 0;
        //k-prices[count] >= 0 : this is your leftover money
        while (k-prices[count]>= 0 && count < k)
        {
            k -= prices[count];
            count++;
        }
        return count;
    }

    static void Main(string[] args)
    {
      
        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] prices = Array.ConvertAll(Console.ReadLine().Split(' '), pricesTemp => Convert.ToInt32(pricesTemp))
        ;
        int result = maximumToys(prices, k);

        Console.WriteLine(result);

    }
}
