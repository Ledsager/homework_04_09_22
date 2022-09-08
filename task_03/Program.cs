// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

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

void FillArray(double[,] matr)//заполнение массива числами
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(2, 10);
        }
    }
}

void ChangeElementArraySquare(double[,] matr)//замена элемента с четными индексами на его квадрат
{
    for (int i = 0; i < matr.GetLength(0); i += 2)
    {
        for (int j = 0; j < matr.GetLength(1); j += 2)
        {
            //Console.Write($" {matr[i,j]} ");
            matr[i, j] = Math.Pow(matr[i, j], 2);
        }
        //Console.WriteLine();
    }
}
Console.Write("Введите размерность массива m*n: ");
int m;
Console.WriteLine("Input m: ");
while (!int.TryParse(Console.ReadLine(), out m))//проверка что вводится число
    Console.Write("Неверный ввод! \nВведите значение снова : ");
int n;
Console.WriteLine("Input n: ");
while (!int.TryParse(Console.ReadLine(), out n))//проверка что вводится число
    Console.Write("Неверный ввод! \nВведите значение снова : ");

double[,] matrix = new double[m, n];
FillArray(matrix);
Console.WriteLine("Матрица с рандом сформированными элементами: ");
PrintArray(matrix);
ChangeElementArraySquare(matrix);
Console.WriteLine("Матрица после выполнения условия задачи: ");
PrintArray(matrix);