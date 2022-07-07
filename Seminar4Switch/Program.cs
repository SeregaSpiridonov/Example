// See Напишите программу, которая по заданному номеру четверти, показывает 
//диапазон возможных координат точек в этой четверти (x и y).


int num = Convert.ToInt32(Console.ReadLine()); //пример со свитч
string FindCord(int number)
{    
    switch(number) 
    {
        case 1:
        {
            return "x,y от 1 до 9999";
        }
        case 2:
        {
            return "x от -1 до -9999 ,y от 1 до 9999";
        }
        case 3:
        {
            return "x,y от -1 до -9999";
        }
        case 4:
        {
            return "x от 1 до 9999, y от -1 до -9999";
        }
    }
    return "Error";
}
Console.WriteLine(FindCord(num));