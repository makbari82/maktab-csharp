Console.WriteLine("please enter a number :");
string inputNumber = Console.ReadLine();
int number = int.Parse(inputNumber);
int charFirstOfNumber = int.Parse(inputNumber[0].ToString());
int charSecondOfNumber = int.Parse(inputNumber[1].ToString());
try
{
    Console.WriteLine($"result : {number % charFirstOfNumber == 0 && number % charSecondOfNumber == 0}");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message );
}
