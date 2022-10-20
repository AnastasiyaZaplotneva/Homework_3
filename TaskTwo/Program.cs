// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

int count = 0;
int num = number;

while(num > 0)
{
    num = num / 10;
    count++;
}

if(count < 3)
{
    Console.WriteLine("У числа нет третьей цифры");
}
else
{
int[] array = new int[count];

int index = array.Length - 1;

while(number > 0)
{
    array[index] = number%10;
    number = number/10;
    index--;
}
Console.WriteLine(array[2]);
}
