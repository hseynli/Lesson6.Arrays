// params açar sözü ilə olan parametr ancaq bir sayda ola bilər və mütləq arqumentlərin sonunda gəlməlidir.
void ShowArray(string name, params int[] array)
{
    Console.Write(name);

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("{0} ", array[i]);
    }
}


ShowArray("Numbers: ", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9);

// Delay.
Console.ReadKey();