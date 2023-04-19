int[,] numbers = { { 1, 2, 3, 7, 7 }, {4, 5, 6, 7, 7 } };

int rows = numbers.GetUpperBound(0) + 1;    // sətirlərin sayı
int columns = numbers.Length / rows;        // sütunların sayı
                                            // və ya
                                            // int columns = numbers.GetUpperBound(1) + 1;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{numbers[i, j]} \t");
    }
    Console.WriteLine();
}