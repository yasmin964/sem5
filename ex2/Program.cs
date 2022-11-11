//напишите программу массива:положительные элементы замените на соответствующие отрицательные,и наоборот
int[] GetArray(int size,int minValue,int maxValue)
 {
    int[] res=new int[size];
    for (int i=0;i<size;i++)
    { res[i]=new Random().Next(minValue,maxValue+1);
    }
    return res;
 
 }
 void Function (int[] array)
 { 
    for (int i = 0; i < array.Length;i++)
    { 
        array[i]*=-1;
    }


 };
 int [] array=GetArray(4,-9,9);
Console.WriteLine(String.Join(",",array));//используется для вывода массива
Function(array);
Console.WriteLine(String.Join(",",array));