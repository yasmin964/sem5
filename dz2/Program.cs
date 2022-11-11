//напишите массив,заполненнный случайными числами.найдите сумму чисел стоящих на нечетных позициях
int[] GetArray(int size,int minValue,int maxValue)
 {
    int[] res=new int[size];
    for (int i=0;i<size;i++)
    { res[i]=new Random().Next(minValue,maxValue+1);
    }
    return res;
 
 }
void GetSum(int [] array)
{
    for (int i = 0; i < array.Length;i++)
    {
        if (i%2!=0)
        {
            int res=0;
            int res= res+array[i];


        }

    }
    Console.WriteLine($"сумма нечетных чисел {res}");
    
}
int[] array=GetArray(10,-9,9);
 Console.WriteLine(String.Join(" ",array));
 CountNumbers(array);