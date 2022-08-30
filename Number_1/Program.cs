Console.Clear();

Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

int a1 = num / 10;
int a2 = a1 % 10;

Console.Write("Ответ: ");
Console.WriteLine(a2);