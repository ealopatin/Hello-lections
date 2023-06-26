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

int IndexOf(int[]] collection, int find)
int [] array = new int [10];
{
    int count = collection.Lenght;  
    int index = 0;
    int position = 0;

    while (index < count)
    {
        if(collection[index]==find)
        {
            position = index;
        }
        index++;
    }
    return position;

}

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array,4);
Console.WriteLine(pos);

//с void не исользуем return