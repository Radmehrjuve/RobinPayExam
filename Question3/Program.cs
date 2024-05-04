//Question3
//To use it, Set it as Startup Project in Solution Explorer
string[] strings = new string[2];
string Status = string.Empty;
Console.WriteLine("Write 2 strings:");
strings[0] = Console.ReadLine(); 
strings[1] = Console.ReadLine();
Console.WriteLine($"Orijinal Strings: {strings[0]}, {strings[1]}");
bool result = strings[0].SequenceEqual(strings[1]);
Console.WriteLine($"Check the same character pattern: {result}");
    
