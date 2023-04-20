int[] ModifyArray(int[] array, int modifier)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * modifier;
    }

    return array;
}


int[] myArray = { 1, 2, 3, 4, 5 };

myArray = ModifyArray(myArray, 5);


for (int i = 0; i < myArray.Length; i++)
{
    Console.Write("{0},", myArray[i]);
}


Console.ReadKey();