// Problem URL: https://www.hackerrank.com/challenges/plus-minus/problem
// Wrote it myself, the answer is under the comments.

/*
int positive = 0;
int negative = 0;
int zero = 0;

Console.WriteLine("Enter the number of elements in the array: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
Console.WriteLine("Enter the elements of the array: ");
for (int i = 0; i < n; i++)
{
    Console.Write("Enter the {0}. element: ", i + 1);
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
foreach (var number in arr)
{
    if (number > 0)
    {
     positive++;   
    }
    else if (number < 0)
    {
        negative++;
    }
    else
    {
        zero++;
    }
}

Console.WriteLine("The ratio of positive numbers: " + ((double)positive / n).ToString("F6"));
*/


/* 
        int positive = 0;
        int negative = 0;
        int zero = 0;
        
        foreach(var number in arr)
        {
        if (number > 0){
            positive++;
        }else if(number < 0){
            negative++;
        }else{
            zero++;
        }
        }
        Console.WriteLine((double)positive / n).ToString("F6");
        Console.WriteLine((double)negative / n).ToString("F6");
        Console.WriteLine((double)zero / n).ToString("F6");
*/


// Answer:




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

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int positive = 0;
        int negative = 0;
        int zero = 0;
        
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        
        foreach (int number in arr){
            if(number > 0){
                positive++;
            }else if(number < 0){
                negative++;
            }else{
                zero++;
            }
        }
        Console.WriteLine(((double)positive / n).ToString("F6"));
        Console.WriteLine(((double)negative / n).ToString("F6"));
        Console.WriteLine(((double)zero / n).ToString("F6"));
        Result.plusMinus(arr);
    }
}
