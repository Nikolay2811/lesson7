// Задача 2: Напишите программу, которая на вход принимает позиции элемента в 
//двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }

    }

    return array;
}


int[,] array = GenerateArray(3, 3, -10, 10);
int a = Prompt("Ведите строку => ");
int b = Prompt("Ведите колонку => ");
void ChekArray(int[,] matr, int row, int colum)
{
    int a = 0;
    if (row < matr.GetLength(0) && colum - 1 < matr.GetLength(1))
    {
        Console.WriteLine($"В позиции ({row}, {colum}) находится элемент {matr[row, colum]}");
    }
    else
    { Console.WriteLine("Такого элемента нет "); }


}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
PrintArray(array);
ChekArray(array, a, b);