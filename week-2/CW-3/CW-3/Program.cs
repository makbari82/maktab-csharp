Console.WriteLine("please enter your Wages :");
int wages = int.Parse(Console.ReadLine());
float tax = (wages / 100) * 10;
float insurance = (wages / 100) * 6;
float result = wages - (tax + insurance);
Console.WriteLine($"result : {result}");