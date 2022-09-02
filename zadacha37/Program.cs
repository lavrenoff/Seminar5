//Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

void RandomMassive(int[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
        massiv[i] = new Random().Next(1, 10); ;
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

string WriteOtvet(int[] massiv)
{
    string result = "";

    for (int i = 0; i < massiv.Length; i++)
    {
        if (i < (massiv.Length - i-1))
        {
            int res = massiv[i] * massiv[massiv.Length - i - 1];
            result = result + Convert.ToString(res) + " ";
        }
        else
        if(i==(massiv.Length - i-1))
        {
            int res = massiv[i];
            result = result + Convert.ToString(res) + " ";
            break;
        }
    }

    return result;
}

Console.Write("Введите число элементов: ");
int massivLength = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[massivLength];

RandomMassive(numbers);

Console.Write($"{WriteMassiv(numbers)}=>{WriteOtvet(numbers)}");



