// В прямоугольной матрице найти строку с наименьшей суммой элементов.

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

int MinSumColumnIndexArray(int[,] array)//поиск и возврат строки с наименьшей суммой элементов 
{
    int numberline = 0;
    int result = 0;
    for (int j = 0; j < array.GetLength(1); j++)//считаем сумму элементов 0-ой строки в переменную
    {
        result = result + array[0, j];
    }
    Console.WriteLine($"сумма элементов 1-й строки = {result} ");
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sumcolumn = 0;
        for (int j = 0; j < array.GetLength(1); j++)//считаем сумму элементов следующей строки
        {
            sumcolumn = sumcolumn + array[i, j];

        }
        Console.WriteLine("сумма элементов {0}-й строки = {1}", i + 1, sumcolumn);

        if (result > sumcolumn)//сравниваем суммы элементов 0-й и следующей строки, 
        {                  //если сумма 0-й больше то перезаписываем сумму в переменную
            numberline = i;      //запоминаем номер строки
            result = sumcolumn;
            //Console.WriteLine($" {numberline} + {result} ");
        }
    }
    return numberline;
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
Console.WriteLine("Матрица с случайно сгенерированными элементами");
PrintArray(matrix);
Console.WriteLine();

Console.WriteLine("Строка с минимальной суммой {0}-я ", MinSumColumnIndexArray(matrix) + 1);
