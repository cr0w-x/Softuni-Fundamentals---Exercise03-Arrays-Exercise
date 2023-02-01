// See https://aka.ms/new-console-template for more information
int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();
int sumLeft = 0;
int sumRight = 0;
bool flag = false;

for (int i = 0;i < values.Length; i++)
{
    sumLeft = 0;
    sumRight = 0;

    for (int j = i - 1; j >= 0; j--)
    {
        sumLeft += values[j];
    }        

    for (int k = i+1; k < values.Length; k++)
    {
        sumRight += values[k];
    }

    if (sumLeft == sumRight)
    {
        Console.WriteLine(i);
        flag = true;
    }  
}

if (flag == false && values.Length >= 2)
{
    Console.WriteLine("no");
}

else if (flag == false && values.Length < 2)
{
    Console.WriteLine("0");   
}
