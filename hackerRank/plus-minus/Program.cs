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

// Answer:

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