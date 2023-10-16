// Напишите программу которая выводит случайное трехзначное число и
// удаляет среднюю цифру.
int number = new Random().Next(100,1000); //выдает случайное число от 100 до 1000
Console.Writeline($"Случайное число = (number)");
int number1 = number/100;
int number3 = number%10;
int number4 = number1 * 10 + number3;
Console.WriteLine(number4);

