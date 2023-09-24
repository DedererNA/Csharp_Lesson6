double[] GetInc(string mess = "k1 b1 k2 b2")
{
    double[] array=new double[4];
    Console.WriteLine($"Введите числа {mess}.");
    for (int i=0, l=0; i<4 ; i++, l+=3)
    {
        Console.WriteLine($"Введите {mess[l]}{mess[l+1]}:");
        array[i]=Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void Solve(double[]array)
{
    string[] result = new string[2];
    result[0]="-";
    result[1]="-";
    if (array[0]!=array[2])
    {
            double x = (array[3]-array[1])/(array[0]-array[2]);
            double y = x*array[0]+array[1];
            result[0]=$"{x}";
            result[1]=$"{y}";
            Console.WriteLine($"Координаты персечения: ({string.Join(";", result)})");        
    }
    else
    {
        if (array[1]==array[3])
        {
            Console.WriteLine("Прямые совпадают");
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
        }
        
    }
}

double[] array=GetInc();
Console.WriteLine(string.Join(" ", array));
Solve(array);
