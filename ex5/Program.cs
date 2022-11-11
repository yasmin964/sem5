//[1,2,3,4,5]->1*5,2*4
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int[] DoubleNum(int[] array);
{
    int size = array.Length / 2;
    if (size % 2 != 0)
    { size++; }
    int[] result = new int[size];
    for (int i = 0; i < (array.Length / 2); i++)
    {
        result[i] = array[i] * array[array.Length - i - 1];
    }
    if (size % 2 != 0)
    {
        result[size - 1] = array[array.Length / 2];
    }

    return result;
}
int [] array = GetArray(123, -500, 500);

Console.WriteLine(String.Join(" ", array));
int[] array2 = DoubleNum(array);
Console.WriteLine($"{array2}");
