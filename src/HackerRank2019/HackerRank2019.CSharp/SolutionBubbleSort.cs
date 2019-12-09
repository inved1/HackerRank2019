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

class SolutionBubbleSort
{

    // Complete the countSwaps function below.
    static void countSwaps(int[] a)
    {
            int cnt = 0;
            for(int i = 0; i <= a.Length -2; i++)
            {
                for(int j = 0; j <= a.Length -2; j++)
                {
                    if(a[j] > a[j + 1])
                    {
                        var t = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = t;
                        cnt++;
                    }
                }

            }
            Console.WriteLine(String.Format("Array is sorted in {0} swaps.", cnt));
            Console.WriteLine(String.Format("First Element: {0}", a[0]));
            Console.WriteLine(String.Format("Last Element: {0}", a[a.Length - 1]));

    }


    /*
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
        countSwaps(a);
    }

    */
}
