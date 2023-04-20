Console.Write("Massivin olcusunu daxil edin: ");
int length = Convert.ToInt32(Console.ReadLine());
byte[] array = new byte[length];
int index = 0;

while (index < array.Length)
{
    array[index] = (byte)index;
    Console.Write($"{array[index]}, ");
    index++;
}

Console.Write($"\nYeni elementin deyerini daxil edin: ");
byte newElement = Convert.ToByte(Console.ReadLine());
byte[] tempArray = new byte[array.Length + 1];
array.CopyTo(tempArray, 0);
tempArray[tempArray.Length - 1] = newElement;
array = tempArray;
index = 0;

while (index < array.Length)
{
    Console.Write($"{array[index]}, ");
    index++;
}