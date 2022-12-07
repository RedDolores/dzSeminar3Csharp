// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());

int extraNum = Num;
int tmp = 0;
int newNum = 0;


while(extraNum > 0)
{
    tmp = extraNum % 10;
    newNum = newNum * 10 + tmp;
    extraNum = extraNum / 10;
}

if(newNum == Num) Console.WriteLine("yes");
else Console.WriteLine("no");
