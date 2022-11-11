//задайте массив,которое определяет есть ли это число в массиве
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;

}
void FindNumber(int[] array, int N)
{
    for (int i = 0; i < array; i++)
    {
        if (array[i] == N)
        {
            Console.WriteLine("ДА");
            return;

        }

    }
    Console.WriteLine("НЕТ");
}
int[] array = GetArray(5, -9, 9);
FindNumber(array,N);
int N=int.Parse(Console.Readline()!);
 Console.WriteLine(String.Join(" ",array));