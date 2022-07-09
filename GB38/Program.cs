Console.Clear();

Console.WriteLine ("Введите размер массива");

int size = Convert.ToInt32(Console.ReadLine());


double[] array = new double [size];

Console.WriteLine("Наш массив");
void FillArray(double[] a)
{
    for (int k=0; k<size; k++)
    {
        a[k] = new Random().Next(-99, 100);
    }
}

void PrintArray(double[] a)
{
    for (int k=0; k<size; k++)
    {
        Console.Write(a[k]);
        if (k<size-1)
        {
            Console.Write(", ");
        }
        if (k==size-1)
        {
            Console.WriteLine(".");
        }
    }
}

FillArray(array);

PrintArray(array);

double result = 0;

double max = array[0];
double min = array[0];
for(int k=0; k<size; k++)
{
    if (array[k]>max)
    {
        max = array[k];
    }

    if (array[k]<min)
    {
        min = array[k];
    }
}
Console.WriteLine("Максимальное значение " + max);
Console.WriteLine("Минимальное значение " + min);

result = max - min;
Console.WriteLine("Разница чисел "+ result);