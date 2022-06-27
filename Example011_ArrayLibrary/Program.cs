void FillArray(int[] collection) // функция заполнения массива
    {
        int length = collection.Length;
        int index = 0;
        while (index < length)
            {
                collection[index] = new Random().Next(1, 10);  // рендомными значениями от 1 до 9
                index++;
            }
    }

void PrintArray(int[] col)  // void невозвратный метод    // выводит массив 
    {
        int count = col.Length;
        int position = 0;
        while (position < count)
            {
                Console.WriteLine(col[position]);
                position++;
            }
    }

int[] array = new int[10]; // new int[] создает новый массив с "0", 10 - коллличество элементов 

int IndexOf(int[] collection, int find)
    {
        int count = collection.Length;
        int index = 0;
        int position = -1;

        while (index < count)
            {
                if (collection[index] == find)
                    {
                        position = index;
                        break;
                    }
                index++;
            }
        return position;
    }

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);

