// Console.Clear();
// double CalculateFormula(int a, int b, int c, int d)
// {
//     double numenator = a * b;
//     int denomenator = c + d;
//     double result = numenator / denomenator;
//     return result;
// }

// double result  = CalculateFormula(1, 2, 3, 4);
// Console.WriteLine(result);


//-----------------------------------------------------------

// Console.Clear();
// void PrintSquares (int limit)
// {
//     int i = 1;
//     while(i <= limit)
//     {
//         Console.Write($"{i*i} ");
//         i++;
//     }
// }

// PrintSquares(5);
// PrintSquares(10);
// PrintSquares(15);

//-----------------------------------------------------------

void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }

    }
}

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}

int[] array = { 1, 2, 3, 4, 5, 23, 6346, 3425, 345, 754, 3245, 235, 57, 5768 };
ZeroEvenElements(array);
PrintArray(array);
