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

class SolutionTwoStrings
{
    static int SIZEALPHABET = 26;
    // Complete the twoStrings function below.
    static string twoStrings(string s1, string s2)
    {

        string ret = "NO";
        bool[] vec = new bool[SIZEALPHABET]; //for all chars in the alphabet

        for(int i = 0; i< SIZEALPHABET; i++)
            vec[i] = false;

        for(int i= 0; i< s1.Length; i++)
        {
            vec[s1[i] - 'a'] = true; //set true for each char which appears in the string
        }

        //now we check the second string
        for(int i= 0; i< s2.Length; i++)
        {
            if (vec[s2[i] - 'a']) //this means we found a char in s2 which was marked as true in the loop above
            {
                ret = "YES";
                break;
            }
        }


        return ret;
    }
    /*
    static void Main(string[] args)
    {

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s1 = Console.ReadLine();

            string s2 = Console.ReadLine();

            string result = twoStrings(s1, s2);

            Console.WriteLine(result);
        }


    }
*/
}
