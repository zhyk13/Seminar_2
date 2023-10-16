// Программа принимает на вход два числа и выводит
// является ли второе число кратным первому
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.Readline());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.Readline());
int ostatok = number2%number1;
if (ostatok == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно, остаток: [ostator]");
}