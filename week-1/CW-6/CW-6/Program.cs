Console.WriteLine("please enter a number :");
int inputNumber1 = int.Parse(Console.ReadLine());
Console.WriteLine("\nplease enter a number less from first number :");
int inputNumber2  = int.Parse(Console.ReadLine());
Console.WriteLine($"result : {inputNumber1%inputNumber2==0}");