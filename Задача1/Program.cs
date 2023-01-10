// Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 

string[] array1 = new string[3] {"Hi!", "Iam", "Artyom"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int m = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[m] = array1[i];
        m++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
PrintArray(array2);

