// Aşağıdakı sətirdə 5 elementdən ibarət olacaq massiv yaradırıq və inisializasiya bloku vasitəsilə onun elementlərinə dəyər veriririk

int[] array = new int[5] { 1, 2, 3, 4, 5 };

// Massivin elementlərinin ekranda əks elətdirilməsi.
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}