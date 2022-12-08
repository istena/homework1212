Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a<(b+c)&&b<(a+c)&&c<(a+b))  Console.Write("есть такое треугольник");
else Console.Write("Нет такого треугольника ");

