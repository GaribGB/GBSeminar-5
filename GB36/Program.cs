Console.Clear();

Console.WriteLine ("Введите размер массива");

int size = Convert.ToInt32(Console.ReadLine());


int[] array = new int [size];

Console.WriteLine("Наш массив");
void FillArray(int[] a)
{
    for (int k=0; k<size; k++)
    {
        a[k] = new Random().Next(-99, 100);
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
    if(k%2==1)
    {
        result = result + array[k];
        
    }

}
Console.WriteLine("Cумма чисел "+ result);