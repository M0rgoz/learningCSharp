using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

class Solution{
    static void Main(string[] args){
        //Console.WriteLine("Enter Bob's array: ");
        var bobArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //Console.WriteLine("Enter Alice's array: ");
        var aliceArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var bobPoints = 0;
        var alicePoints = 0;
        for(int i = 0; i < bobArray.Length; i++){
            if(bobArray[i] > aliceArray[i]){
                bobPoints++;
            }else if(bobArray[i] < aliceArray[i]){
                alicePoints++;
            }else{
                continue;
            }
        }
        Console.WriteLine(bobPoints + " " + alicePoints);
    }
}