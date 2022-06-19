// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// ПОМОГИТЕ ЗАКЛЮЧИТЬ В СКОБКИ МАССИВ ПРИ ВЫВОДЕ

// int[] array = new int[8];
// Random RandomArr = new Random();
 
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 9);
//     Console.Write("{0} ", array[i]);
// }

void fillArray(int[] col)
{
    for (int index = 0 ; index < col.Length; index++)
    {
        col[index] = new Random().Next(0,9);
    }
}

void printArray (int[] collection)
{
    Console.WriteLine("[{0}]", string.Join( ", ", collection)); // метод Join создаёт одну строку из всех элементов
}

int[] array = new int[8];// определили размер массива
fillArray(array);// вызван метод, который заполнил массив
printArray(array);// вызван метод выведения массива на экран