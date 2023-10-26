int[] array = { 15, 24, 36, 47, 85, 96, 337, 118, 555, 36 };

int n = array.Length;
int find = 36;

int index = 0;

while(index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++; //index = index + 1;
}