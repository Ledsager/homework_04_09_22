// Написать программу, которая обменивает элементы первой строки и последней строки

void PrintArray(int[,] matr)//вывод массива на экран
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)//заполнение массива случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);//[1; 10)
        }
    }
}

void ChangeLineArray(int[,] matr)//обмен строк
{
    int chenge;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        chenge = matr[0, j];
        matr[0, j] = matr[matr.GetLength(0)-1, j];
        matr[matr.GetLength(0)-1, j] = chenge;
    }
}

int m;
Console.Write("Input m: ");
while (!int.TryParse(Console.ReadLine(), out m))//проверка что вводится число
    Console.Write("Неверный ввод! \nВведите значение снова : ");
int n;
Console.Write("Input n: ");
while (!int.TryParse(Console.ReadLine(), out n))//проверка что вводится число
    Console.Write("Неверный ввод! \nВведите значение снова : ");

int[,] matrix = new int[m, n];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
ChangeLineArray(matrix);
Console.WriteLine();
PrintArray(matrix);
