// See https://aka.ms/new-console-template for more information
int[] givenNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int magicNumber = int.Parse(Console.ReadLine());

for (int i = 0;i < givenNumbers.Length; i++)
{
    for (int j = i +1; j < givenNumbers.Length; j++)
    {
        if (givenNumbers[i] + givenNumbers[j]==magicNumber)
        {
            Console.Write($"{givenNumbers[i]} {givenNumbers[j]}");
            Console.WriteLine();
        }        
    }   
}
