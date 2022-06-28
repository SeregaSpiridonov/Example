void FillArray(int[] collection) //Заполняет массив случайными числами от 1 до 10
{
    int length=collection.Length;
    int index = 0;
    while(index<length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)  //Сдесь задаётся вывод массива на экран
{
    int count = col.Length;
    int position = 0;
    while(position<count)
    {
        Console.Write(col[position]+", ");
        position++;
    }
}
Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];  //new int заменяет то что в функциях новым int?

FillArray(array);
PrintArray(array);