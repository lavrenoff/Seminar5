//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] numbers = new int[4];

void RandomMassive(int[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
        massiv[i] = new Random().Next(-100, 100); ;
}

string WriteMassiv(int[] massiv)
{
    string str = "";

    for (int i = 0; i < massiv.Length; i++)
        if (massiv.Length - 1 > i) str = str + Convert.ToString(massiv[i]) + ",";
        else
            str = str + Convert.ToString(massiv[i]);

    return "[" + str + "]";
}

int SumNo2(int[] massiv)
{
    int result = 0;
    for (int i = 0; i < massiv.Length; i++)
        if (i % 2 != 0) result = result + massiv[i];
    return result;
}

RandomMassive(numbers);
Console.Write($"{WriteMassiv(numbers)}=>{SumNo2(numbers)}");


