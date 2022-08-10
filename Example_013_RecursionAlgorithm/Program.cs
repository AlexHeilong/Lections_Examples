//string[,] table = new string[2, 5]; // таблица строк. Тип данных string
// string.Empty - инициализация строки
// 2 - строчки, 5 - столбцов
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4] - индексы столбцов тоже начинаются с 0
// table[1,0] table[1,1] table[1,2] table[1,3] table[1,4] - индекс строки
// table[2,0] table[2,1] table[2,2] table[2,3] table[2,4]
/*
table[1, 2] = "слово";

for(int rows = 0; rows < 2; rows++)
{
    for(int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}

_________


int[,] matrix = new int[3, 4];

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();
}

// Сделаем метод по созданию двухмерной матрицы

void PrintArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    } 
}

int[,] matrix = new int[3, 4];

PrintArray(matrix);
____________________
*/

// Метод для генерации двухмерной матрицы случайными числами
/*
void PrintArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    } 
}

void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    } 
}
int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
____________________________
*/
// Как представить черно-белое изображение?
//int[,] pic = new int[23, 25];
// 0 - закрашенный
// 1 - незакрашенный
// Как закрасить область?
/*
int[,] pic = new int[23, 25];

void PrintImage(int[,] image)
{
    for(int i = 0; i < image.GetLength(0); i++)
    {
        for(int j = 0; j < image.GetLength(1); j++)
        {
            if(image[i, j] == 0) Console.Write(" ");
            else Console.Write("+");
        }
    Console.WriteLine();
    } 
}

void FillImage(int row, int col)
{
    if(pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row-1, col);
        FillImage(row, col-1);
        FillImage(row+1, col);
        FillImage(row, col+1);
    }
}

PrintImage(pic);
FillImage(13, 13);
PrintImage(pic);
*/
/*
// Написать функцию (метод), которая принимает число, фаториал которого нужно вычислить

double Factorial(int n)
{
    if(n == 1) return 1; // 1! = 1 - факториал 1 = 1 !!! 0! = 1
    else return n * Factorial(n-1);
}
for(int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}"); 
}
_________________________________
*/
/*
// Числа Фибоначи
// f(1) = 1;
// f(2) = 1;
// f(n) = f(n-1) + f(n-2)

double Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}
for(int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}

______________________
*/

// Как обойти директорию?
// Зайти в директорию?
// Обойти все директории внутри?

