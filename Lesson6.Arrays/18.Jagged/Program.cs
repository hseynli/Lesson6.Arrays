int[][] jagged = new[]
            {
               new int[] { 1, 2 },
               new int[] { 1, 2, 3, 4, 5 },
               new int[] { 1, 2, 3 }
            };

// Xarici dövrdə massivin bütün daxili massivləri üzrə dövr edirik..
for (int i = 0; i < jagged.Length; ++i)
{
    // Xarici dövrdə massivin bütün daxili massivləri üzrə dövr edirik.
    for (int j = 0; j < jagged[i].Length; ++j)
    {
        Console.Write("{0} ", jagged[i][j]);
    }
    Console.Write("\n");
}