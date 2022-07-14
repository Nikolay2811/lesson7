// Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int row = Prompt("Введите кол-во строе в массиве => ");
int colum = Prompt("Введите кол-во столбцов в массиве => ");
int min = Prompt("Введите min значение элемента в массиве => ");
int max = Prompt("Введите max значение элемента в массиве => ");

int[,] mass = GenerateArray(row, colum, min, max);

void CalkulateMass(int[,] array)
{
    for (int count = 0; count < array.GetLength(1); count++)
    {
        double sum = 0;
        for (int count1 = 0; count1 < array.GetLength(0); count1++)
        {

            sum = sum + array[count1, count];
        }

        double srsum = sum / array.GetLength(0);
        Console.WriteLine($" в столбце {count} средняя орефметическая {srsum}");
    }
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

PrintArray(mass);
CalkulateMass(mass);