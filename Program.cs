Console.Write("Введите элементы (через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int element = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        element++;
    }
}

Console.WriteLine("Кол-во элементов > 0:" + element);


