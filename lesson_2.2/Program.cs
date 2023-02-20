int[] array = { 1, 34, 35, 12, 454, 76, 23, 443, 6767, 23, 12 };

int n = array.Length;
int find = 23;
int index = 0;

while (index < n)
{

    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
