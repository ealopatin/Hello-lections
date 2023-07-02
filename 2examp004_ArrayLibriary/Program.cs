void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] collection2)
{
    int count = collection2.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(collection2[position]);
        position++;
    }

}

// int IndexOf(int[] collection, int find)
// {
//     int count = collection.Length;
//     int index = 0;
//     int position = -1;

//     while (index < count)
//     {
//         if (collection[index] == find)
//         {
//             position = index;
//             break;
//         }
//         index++;
//     }
//     return position;
// }

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();

// int pos = IndexOf(array, 4);
// Console.Write(pos);

//с void не исользуем return

