Console.WriteLine("please enter month :");
int months = int.Parse(Console.ReadLine());
Console.WriteLine("please enter day :");
int days = int.Parse(Console.ReadLine());
int result = days;
for (int i = 0; i < months; i++)
{
    result += 30;
}
Console.WriteLine($"\nresult : {result}");
