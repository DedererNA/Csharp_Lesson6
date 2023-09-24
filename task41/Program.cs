int[] CustomArr (int size)
{
    Console.WriteLine($"Введите {size} чисел.");
    int[] array = new int[size];
    for (int i=0; i<size; i++)
    {
        Console.WriteLine($"Введите {i+1}-е число:");
        array[i]=Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int PosCount (int[] array)
{
    int count=0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]>=0)
        {
            count++;
        }
    }
    return count;
}

int m = 6;
int[] array=CustomArr(m);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Количество положительных чисел: {PosCount(array)}");