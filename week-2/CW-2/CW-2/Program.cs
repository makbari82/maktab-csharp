Console.WriteLine("please enter hour :");
int inputHours = int.Parse(Console.ReadLine());
Console.WriteLine("please enter minutes :");
int inputMinutes = int.Parse(Console.ReadLine());
Console.WriteLine("please enter seconds :");
int inputSeconds = int.Parse(Console.ReadLine());
int minutes = inputMinutes;
int result = inputSeconds;
for (int i = 0; i < inputHours; i++)
{
    minutes += 60;
}
for (int i = 0; i < minutes; i++)
{
    result += 60;
}
Console.WriteLine($"result : {result}");


