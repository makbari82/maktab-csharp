Console.WriteLine("please enter a string :");
string userInput  = Console.ReadLine();
bool result = int.TryParse(userInput , out int inputNumber);
if (result)
{
    Console.WriteLine($"\nresult :\n{result}\n{inputNumber}");
}
else
{
    Console.WriteLine($"result :\n{result}\n0");
}