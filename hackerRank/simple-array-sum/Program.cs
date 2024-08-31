using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(string[] args){
        Console.ReadLine();
        var numArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int sum = 0;
        foreach (var num in numArray){
            sum += num;
        }
        Console.WriteLine(sum);
    }
}