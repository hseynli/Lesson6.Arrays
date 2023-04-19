int[] array = { 1, 2, 3, 4, 5 };

//Aşağıdakı dövr vasitəsilə massivin elementlərini sondan başlayaraq ekranda əks elətdiririk.
for (int i = array.Length - 1; i >= 0; i--)
{
    Console.WriteLine(array[i]);
}