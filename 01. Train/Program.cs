// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());
int totalSum = 0;

int[] myArr = new int[n];

for (int i = 0; i < n; i++)
{
    myArr[i] = int.Parse(Console.ReadLine());
    totalSum += myArr[i];
    
}

for (int i = 0; i < myArr.Length; i++)
    Console.Write($"{myArr[i]} ");

Console.WriteLine();
Console.WriteLine( totalSum );  

