// See https://aka.ms/new-console-template for more information
using System.Linq;

string firstString = Console.ReadLine();
string secondString = Console.ReadLine();

string[] firstStringArray = firstString.Split(' ');
string[] secondStringArray = secondString.Split(' ');

for (int i = 0; i < secondStringArray.Length; i++)
{
    for (int j = 0; j < firstStringArray.Length; j++)
    {
        if (secondStringArray[i] == firstStringArray[j])
        {
            Console.Write($"{secondStringArray[i]} ");
        }
    }
}
