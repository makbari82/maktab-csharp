Console.WriteLine("please enter a number :");
string inputNumber = Console.ReadLine();
int number1 = int.Parse(inputNumber[0].ToString());
int number2 = int.Parse(inputNumber[1].ToString());
int number3 = int.Parse(inputNumber[2].ToString());
Console.WriteLine($"result : {number1 + number3 == number2}");
