Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
array[0]=0;
array[1]=1;
for (int i = 2; i < array.Length; i++)
        array[i] = array[i-1]+array[i-2];
Console.WriteLine($"[{string.Join(", ", array)}]");

