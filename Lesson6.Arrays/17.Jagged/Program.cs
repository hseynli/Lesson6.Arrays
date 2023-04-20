int[][] jagged = new int[3][];

jagged[0] = new int[] { 1, 2 };
jagged[1] = new int[] { 1, 2, 3, 4, 5 };
jagged[2] = new int[] { 1, 2, 3 };


// Xarici dövrdə massivin bütün daxili massivləri üzrə dövr edirik.
for (int i = 0; i < jagged.Length; ++i)
{
    // Xarici dövrdə massivin bütün daxili massivləri üzrə dövr edirik.
    for (int j = 0; j < jagged[i].Length; ++j)
    {
        Console.Write("{0} ", jagged[i][j]);
    }
    Console.Write("\n");
}