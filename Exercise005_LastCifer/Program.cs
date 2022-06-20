// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter a three-digit number: ");

int a = Convert.ToInt32(Console.ReadLine());
int result;

result = (a % 10);

if (a > 99 && a < 1000)
{
Console.WriteLine(result);
}
else
{
    Console.WriteLine("Wrong number, motherfucker!");
}

