Console.WriteLine("please enter radius of circle :");
float radius = float.Parse(Console.ReadLine());
const float p = 3.14F;
float area = p*(radius*radius) ;
float environment = p * 2 * radius;
Console.WriteLine($"\nArea : {area}\nEnvironment : {environment}");