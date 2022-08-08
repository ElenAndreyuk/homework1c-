// Четные числа от 1 до N
Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;
while ( i <= N )
{
    Console.WriteLine( i );
    i = i + 2;
}