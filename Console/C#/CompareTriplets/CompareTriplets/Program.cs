﻿using System.CodeDom.Compiler;
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

    // Complete the compareTriplets function below.
    static List<int> compareTriplets(List<int> a, List<int> b)
    {
        List<int> res = new List<int>();
        int alice = 0;
        int bob = 0;

        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] > b[i])
            {
                alice++;
            }
            else if (a[i] < b[i])
            {
                bob++;
            }
        }
        res.Add(alice);
        res.Add(bob);

        return res;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@"C:\Users\reneb\compareTriplets.txt");

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}