// Четное или нечетное
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b = a % 2;
if ( b == 0)
{
    Console.WriteLine("Четное");
}
else 
{
    Console.WriteLine("нечетное");
}