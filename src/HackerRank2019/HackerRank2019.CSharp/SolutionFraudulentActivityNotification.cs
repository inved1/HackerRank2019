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

class SolutionFraudulentActivityNotification
{

    // Complete the activityNotifications function below.
    static int activityNotifications(int[] expenditure, int d)
    {
        int notifications = 0;
        //[10,20,30,40,50]
        //d = 3
        if (d + 1 > expenditure.Length) return 0;

        int days = expenditure.Length - d;
        //days = 5-2 = 2
        for (int i = days; i>0; i--)
        {
            int[] tmp = new int[d];
            Array.Copy(expenditure, expenditure.Length - d -i, tmp, 0, d);
            double median = calcMedian(tmp);
            if (median * 2 <= expenditure[expenditure.Length - i]) notifications++;
            
        }

        return notifications;
    }
    

    static double calcMedian(int[] arr)
    {
        Array.Sort(arr);
        if(arr.Length %2 == 1)
        {
            return (double)arr[(int)(arr.Length / 2)];
        }
        else
        {
            return (double)(arr[(arr.Length / 2) - 1] +
                arr[(arr.Length / 2)]) / 2;
        }
    }

    /*
    static void Main(string[] args)
    {
        
        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] expenditure = Array.ConvertAll(Console.ReadLine().Split(' '), expenditureTemp => Convert.ToInt32(expenditureTemp))
        ;
        int result = activityNotifications(expenditure, d);

        Console.WriteLine(result);

        Console.ReadKey();

    }
*/
}
