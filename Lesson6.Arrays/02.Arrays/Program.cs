int[] array = new int[5];

// Massivin elementlərinin doldurulması.
for (int i = 0; i < array.Length; i++)
{
    array[i] = i * 2;
}

// Massivin elementlərinin ekranda əks elətdirilməsi
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

// Delay.
Console.ReadKey();