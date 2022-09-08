// Задать двумерный массив следующим правилом: Aₘₙ = m+n

void PrintArray(double[,] matr)//вывод массива на экран
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

void FillArray(double[,] matr)//заполнение массива согласно условию
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = i + j;
        }
    }
}
Console.Write("Введите размерность массива m*n ");
int m;
Console.WriteLine("Input m: ");
while (!int.TryParse(Console.ReadLine(), out m))//проверка что вводится число
    Console.Write("Неверный ввод! \nВведите значение снова : ");
int n;
Console.WriteLine("Input n: ");
while (!int.TryParse(Console.ReadLine(), out n))//проверка что вводится число
    Console.Write("Неверный ввод! \nВведите значение снова : ");

double[,] matrix = new double[m, n];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
