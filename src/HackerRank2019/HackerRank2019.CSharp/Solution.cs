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

class Solution
{

    // Complete the jumpingOnClouds function below.
    static int jumpingOnClouds(int[] c)
    {
        int steps = 0;

        for(int i= 0; i< c.Length-1; i++)
        {
            int stepsize = 2;
            if ((i + stepsize) >= c.Length) stepsize = 1;
            if (c[i + stepsize] == 1) stepsize = 1;
            if (stepsize == 2) i++;
            steps++;
        }

        return steps;
    }

   /* static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine());

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
        int result = jumpingOnClouds(c);

        Console.WriteLine(result);

    }
    */
}
