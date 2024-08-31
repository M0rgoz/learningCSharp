using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static void Main(String[] args){
        Console.ReadLine();
        var candleHeights = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var maxHeight = candleHeights.Max();
        var maxCount = candleHeights.Count(x => x == maxHeight);
        Console.WriteLine(maxCount);
    }
}

