int ArraySize = 0;
int MinimumSize = 0;
Console.Write("Input number of string to store in the Array: ");
ArraySize = int.Parse(Console.ReadLine());
string[] array = new string[ArraySize];
Console.WriteLine($"Input {ArraySize} strings for the Array:");
for(int i = 0; i < ArraySize; i++)
{
    Console.Write($"Element[{i}] : ");
    array[i] = Console.ReadLine();
}
Console.Write("Input the minimum length of the item you want to find: ");
MinimumSize = int.Parse(Console.ReadLine());
Console.WriteLine($"The items of minimum {MinimumSize} characters are: ");
foreach (string s in array)
{
    if(s.Length >= MinimumSize)
        Console.WriteLine("Item: " + s);
    
}
Console.ReadLine();