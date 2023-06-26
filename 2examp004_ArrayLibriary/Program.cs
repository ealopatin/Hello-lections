void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
            collection[index] = new Random().Next(1, 100);
            index++;
    }
}

void PrintArray(int[] collection2)
{
    int count = collection2.Length;
    int position = 0;
    while (position<count)
    {
        Console.WriteLine(collection2[position]);
        position++;
    }

}   

int [] array = new int [10];

FillArray(array);
PrintArray(array);

//с void не исользуем return