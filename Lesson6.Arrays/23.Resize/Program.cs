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

Array.Resize(ref array, array.Length + 1);
array[array.Length - 1] = newElement;

index = 0;

while (index < array.Length)
{
    Console.Write($"{array[index]}, ");
    index++;
}