using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
class Solution {
    static void Main(String[] args){
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        int[] birdCount = new int[n];

        foreach(int bird in arr){
            birdCount[bird]++;
        }
        int maxValue = birdCount.Max();
        int maxIndex = birdCount.ToList().IndexOf(maxValue);
        Console.WriteLine(maxIndex);
    }
}