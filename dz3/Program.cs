//задайте массив вещественных чисел,найдите разницу между макс и мин элементом масссив
void Differ(double [] array)
{
    double min = Int32.MaxValue;
    double max = Int32.MinValue;
    for(int i=0;i<array.Length;i++)
    {
        if (array[i]> max)
        {
            array[i]==max;
        }
        if (array[i] < min)
        {
            min =array[i];
        }

    }int di=max-min;
    Console.WriteLine($"разница между мин и мах {di}");
    
}
double [] array=Console.WriteLine("Введите ")