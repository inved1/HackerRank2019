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

class SolutionMinimumSwap
{


    

    // Complete the minimumSwaps function below.
    static int minimumSwaps(int[] arr)
    {
        int swapsum = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            while (arr[i] != i + 1)
            {
                var key = arr[i] - 1;
                var tmp = arr[i];
                arr[i] = arr[key];
                arr[key] = tmp;

                swapsum++;
            }
        }
        

        return swapsum;
    }

    static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int res = minimumSwaps(arr);

        Console.WriteLine(res);

    }
}
