using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

class Solution{
    static void Main(string[] args){
        Console.ReadLine();
        var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Array.Reverse(array);
        foreach(var i in array){
            Console.Write(i + " ");
        }
    }
}