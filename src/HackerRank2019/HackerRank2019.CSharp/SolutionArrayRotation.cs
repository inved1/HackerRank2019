
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

class SolutionArrayRotation
{

    // Complete the rotLeft function below.
    static int[] rotLeft(int[] a, int d)
    {
        d = d % a.Length;

        int[] buf = new int[d];
        Array.Copy(a, buf, d);
        Array.Copy(a, d, a, 0, a.Length - d);
        Array.Copy(buf, 0, a, a.Length - d,d);

        return a;
    }

    /*
    static void Main(string[] args)
    {

        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
        int[] result = rotLeft(a, d);

        Console.WriteLine(string.Join(" ", result));

    }
    */
}
