// Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
Console.Clear();

int[] numbers = new int[10];

void RandomMassive(int[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
        massiv[i] = new Random().Next(100, 999);;
}

int Sum2(int[] massiv)
{
    int result = 0;
    for (int i = 0; i < massiv.Length; i++)
        if (massiv[i] % 2 == 0)
            result++;

    return result;
}

string WriteMassiv(int[] massiv)
{
    string str = "";

    for (int i = 0; i < massiv.Length; i++)
        if (massiv.Length-1 > i) str = str + Convert.ToString(massiv[i]) + ",";
            else
            str = str + Convert.ToString(massiv[i]);

    return "["+str+"]";
}

RandomMassive(numbers);
Console.Write($"{WriteMassiv(numbers)}=>{Sum2(numbers)}");


