// See https://aka.ms/new-console-template for more information
using System.Linq;
int n = int.Parse(Console.ReadLine());

string[] myStringArr = new string[2];
int[] myArr0 = new int[n];
int[] myArr1 = new int[n];



for (int i = 0; i < n; i++)
{
    string tempString = Console.ReadLine();
    myStringArr = tempString.Split(' ');

    for (int j = 0; j < 2; j++)
    {
        if (j % 2 == 0)
        {
            myArr0[i] = int.Parse(myStringArr[j]);
        }
        else
        {
            myArr1[i] = int.Parse(myStringArr[j]);
        }
        
    }    

}

for (int i = 0; i < n; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(myArr0[i]+" ");
    }
    
    else
    {
        Console.Write(myArr1[i]+" ");
    }    
}

Console.WriteLine();

for (int i = 0; i < n; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(myArr1[i] + " ");
    }

    else
    {
        Console.Write(myArr0[i] + " ");
    }
}
