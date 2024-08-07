using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

                // Declare second integer, double, and String variables.
  
        
        // Read and save an integer, double, and String to your variables.
        int nextI = Convert.ToInt32(Console.ReadLine());
        double nextD = Convert.ToDouble(Console.ReadLine());
        string nextS = Console.ReadLine();
        
        // Print the sum of both integer variables on a new line.
        int sumInt = i + nextI;
        Console.WriteLine(sumInt);
    
        // Print the sum of the double variables on a new line.
        double sumDouble = d + nextD;
        Console.WriteLine((sumDouble).ToString("F1"));
        //This should've worked without this nonsense.
        
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        string sumString = s + nextS;
        Console.WriteLine(sumString);
    }
}

