// See https://aka.ms/new-console-template for more information
int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();
for (int i = 0; i < values.Length; i++)
{
    bool isTopInteger = true;
    for (int k = i + 1; k < values.Length; k++)
    {
        if (values[i] <= values[k])
        {
            isTopInteger = false;
        }
    }

    if (isTopInteger)
    {
        Console.Write(values[i] + " ");
    }
}
