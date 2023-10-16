// Напишите программу которая выводит случайное число из отрезка [10, 99] и показывает
//наибольшую цифру числа.
int number = new Random().Next(10,100); //выдает случайное число от 10 до 100
Console.Writeline($"Случайное число = (number)");
int digit1 = number/10; //В digit1 будет лежать первая цифра
int digit2 = number%10; //В digit2 будет лежать вторая цифра
if (digit1 > digit2)
{
    Console.WriteLine(digit1);
}
else if (digit1 < digit2)
{
   Console.WriteLine(digit1); 
}
else
{
    Console.WriteLine("Цифры равны");
}