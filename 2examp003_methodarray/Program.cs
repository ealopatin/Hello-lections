int [] array = {11,21,31,4,51,61,999,61,91};

int n = array.Length;
int find = 61;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}