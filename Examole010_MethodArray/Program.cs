// надо погуглить как переименовать папки в гите

int [] array = {1,12,32,4,18,15,16,71,18};

int n = array.Length; // длинна массива, или колличество элементов массива
int find = 18;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;  // завершение условия
    }
    index++;
}