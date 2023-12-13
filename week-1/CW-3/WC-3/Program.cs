int[] inputNumbers = new int[5];
for (int i = 0; i < inputNumbers.Length; i++)
{
    Console.WriteLine("\nplease enter your number :");
    inputNumbers[i] = int.Parse(Console.ReadLine());
}
int result= Convert.ToInt32(Math.Floor(inputNumbers.Average()));
Console.WriteLine($"result : {result}\n{result%2==0}");