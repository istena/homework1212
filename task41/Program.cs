//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum=0;
for(int i=0;i<n;i++){
    if(Convert.ToInt32(Console.ReadLine())>0) sum++;
}
Console.Write($"Кол-во чисел больше нуля = {sum} ");

