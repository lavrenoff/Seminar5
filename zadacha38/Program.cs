//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

void RandomMassive(double[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
        massiv[i] = new Random().Next(1, 10); ;
}

string WriteMassiv(double[] massiv)
{
    string str = "";

    for (int i = 0; i < massiv.Length; i++)
        if (massiv.Length - 1 > i) str = str + Convert.ToString(massiv[i]) + ",";
        else
            str = str + Convert.ToString(massiv[i]);

    return "[" + str + "]";
}

double RazMinMax(double[] massiv)
{
    double result=0;

    double min=massiv[0];
    double max=massiv[0];

    for (int i = 0; i < massiv.Length; i++)
    {
        if(min>massiv[i]) min=massiv[i];
        if(max<massiv[i]) max=massiv[i];
    }

    result=max-min;
    return result;
}

double[] dnumbers=new double[5];
RandomMassive(dnumbers);

Console.Write($"{WriteMassiv(dnumbers)}=>{RazMinMax(dnumbers)}");