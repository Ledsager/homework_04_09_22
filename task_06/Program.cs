// Написать программу упорядочивания, по убыванию элементов, каждой строки двумерного массива.

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

void SortArray(int[,] array)//сортировка строк массива по убыванию
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int maxPosition = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, maxPosition])
                {
                    maxPosition = k;
                }
            }
            int temporary = array[i, j];
            array[i, j] = array[i, maxPosition];
            array[i, maxPosition] = temporary;
        }

    }
}


Console.Write("mas[x,y]");
int x;
Console.Write("Input x: ");
while (!int.TryParse(Console.ReadLine(), out x))//проверка что вводится число
    Console.Write("Неверный ввод! \nВведите значение снова : ");
int y;
Console.Write("Input y: ");
while (!int.TryParse(Console.ReadLine(), out y))//проверка что вводится число
    Console.Write("Неверный ввод! \nВведите значение снова : ");

int[,] matrix = new int[x, y];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
SortArray(matrix);
PrintArray(matrix);


