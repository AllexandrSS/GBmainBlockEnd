int n = 3;
int size = 7;
int lover = 1;
int upper = 8;
string[] arrayOne = new string[size];
FillRandArr(arrayOne);
void FillRandArr(string[] arr)
{
    Random rand = new Random();
    string Symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*";
    for (int i = 0; i < size; i++)
    {
        int randElemSize = rand.Next(lover, upper);
        for (int j = 0; j < randElemSize; j++)
        {
            arr[i] += Symbols[rand.Next(0,Symbols.Length)];
        }        
    }
}
int GetSizeOfSecondArray(string[] arr)
{   
    int secondSize = 0;
    for (int i = 0; i < size; i++)
    {
        if(arr[i].Length <= n)
        {
            secondSize++;
        }
    }
    return secondSize;
}
string[] RotateElemOfArr(string[] arr)
{
    string[] arrayTwo = new string[GetSizeOfSecondArray(arrayOne)];
    for (int i = 0, j = 0; i < size; i++)
    {
        if(arr[i].Length <= n)
        {
            arrayTwo[j] = arr[i];
            j++;
        }
    }
    return arrayTwo;
}
if (GetSizeOfSecondArray(arrayOne) == 0){Console.WriteLine("искомых элементов строкового масива для переноса в новый массив - нет");}
else
{
string[] arrayTwo = RotateElemOfArr(arrayOne);
Console.Clear();
    Console.WriteLine($"Это массив заполненный рандомными занчениями, и новый массив, длиной не более трёх символов:");
    Console.WriteLine();
    Console.WriteLine($"[{String.Join(", ", arrayOne)}] -> [{String.Join(", ", arrayTwo)}]");
    Console.WriteLine();
}