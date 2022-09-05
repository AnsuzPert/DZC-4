//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите целое число");
int x = Convert.ToInt32(Console.ReadLine());
int func (int per1)
{
int sum=0;
while (x>=1)
{
    sum = sum + (x%10);
    x = x/10;
}
return(sum);
}
Console.WriteLine(func(x));