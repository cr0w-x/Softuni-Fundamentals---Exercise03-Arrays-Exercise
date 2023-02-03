// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;

int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int counter = 0;
int biggest = 0;
int index = 0;


for (int i = 0;i < numbers.Length-1; i++)
{    
    if (numbers[i] == numbers[i + 1])
    {
        counter++;        
    }

    else
    {
        counter = 0;
    }

    if (biggest < counter )
    {
        biggest = counter;
        index = i;
    }
}

int output = numbers[index];

for (int i = 0; i <= biggest; i++)
    Console.Write($"{output} ");
