// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

string input = Console.ReadLine();
string[] baseArray = input.Split(' ');

int n = int.Parse(Console.ReadLine());


int counter = 0;

if (n > baseArray.Length)
{
    n -= baseArray.Length;
}


string[] tempArray = new string[n];


for (int i = 0; i < n; i++)
{
    tempArray[i] = baseArray[i];
}

int[] digitArray = baseArray.Select(int.Parse).ToArray();
int[] digitTempArray = tempArray.Select(int.Parse).ToArray();

int[] newDigitArray = new int[digitArray.Length];

for (int i = n; i < digitArray.Length; i++)
{
    
    newDigitArray[i-n] = digitArray[i];
    
}

for (int i = digitArray.Length - n; i < digitArray.Length; i++)
{
    
    newDigitArray[i] += digitTempArray[counter];
    counter++;
}

for (int i = 0; i < newDigitArray.Length; i++)
{
    Console.Write(newDigitArray[i] + " ");
}