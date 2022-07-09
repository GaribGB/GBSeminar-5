Console.Clear();

Console.WriteLine ("Введите размер массива");

int size = Convert.ToInt32(Console.ReadLine());


int[] array = new int [size];

Console.WriteLine("Наш массив");
void FillArray(int[] a)
{
    for (int k=0; k<size; k++)
    {
        a[k] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] a)
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

int result = 0;
for(int k=0; k<size; k++)
{
    if(array[k]%2==0)
    {
        result++;
    }

}
Console.WriteLine("Колличество четных чисел "+ result);