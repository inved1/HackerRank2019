using System;
using System.Collections.Generic;
using System.Text;

class SolutionArrays
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        Array.Reverse(arr);
        Array.ForEach<int>(arr, x => Console.Write(String.Format("{0} ", x)));

    }
}
