// На вход принимает одно число (N) и выводит все целые числа в диапазоне от (-N) до (N)

Console.WriteLine("Please, input number: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int start = -Math.Abs(number);

while (start <= number)
    {
    Console.WriteLine(start);
    start++;
    }

//do
//{
//    Console.WriteLine(start);
  //  start++;
//}
//while (start <= number);

/* if (number >= 0)
{
    while (start <= number)
    {
    Console.WriteLine(start);
    start++;
    }
}
else
{
    while (start >= number)
    {
    Console.WriteLine(start);
    start--;
    }
}
*/

