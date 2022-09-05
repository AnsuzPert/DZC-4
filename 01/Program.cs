//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("ВВедите первое число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите второе число");
int y = Convert.ToInt32(Console.ReadLine());
string func (int per1, int per2)
{
    int z = per1;
while (per2!=1)
{
    per2 = per2-1;
    z = z*per1;
}
return($"{per1} в заданной степени равна {z}.");
}
Console.WriteLine(func(x,y));