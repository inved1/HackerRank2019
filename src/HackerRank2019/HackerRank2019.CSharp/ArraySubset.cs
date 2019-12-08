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

class ArraySubset
{

    // Complete the checkMagazine function below.
    static void checkMagazine(string[] magazine, string[] note)
    {

        bool subset = false;
        int iNote = 0;
        if (note.Length > magazine.Length)
        {
            Console.WriteLine("No");
            return;
        }

        Array.Sort(magazine, StringComparer.InvariantCulture);

        Array.Sort(note, StringComparer.InvariantCulture);

        for (int i = 0; i < magazine.Length; i++)
        {
            if (iNote == note.Length) break;
            if(note[iNote] == magazine[i])
            {
                iNote++;
            }
        }
        if (iNote == note.Length) subset = true;
    
        if (subset) Console.WriteLine("Yes");

        if (!subset) Console.WriteLine("No");
    }


    /*
    static void Main(string[] args)
    {
        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        string[] magazine = Console.ReadLine().Split(' ');

        string[] note = Console.ReadLine().Split(' ');

        checkMagazine(magazine, note);
    }
*/
}
