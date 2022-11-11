//задайте массив заполненный трехзначными случайными положительными числами и выведите количество четных чисел
int[] GetArray(int size,int minValue,int maxValue)
 {
    int[] res=new int[size];
    for (int i=0;i<size;i++)
    { res[i]=new Random().Next(minValue,maxValue+1);
    }
    return res;
 
 }
 void CountNumbers(int [] array)
 {
    int count=0;
    for (int i = 0; i < array.Length;i++)
    { 
        if(array[i]%2=0)
        {
            count+=1;
        }
    } Console.WriteLine($"количество четных чисел{count}");
 }
int[] array=GetArray(10,100,1000);
 Console.WriteLine(String.Join(" ",array));
 СountNumbers(array);