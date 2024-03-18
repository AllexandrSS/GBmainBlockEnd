int n = 3;
int size = 6;
int lover = 1;
int upper = 7;
string[] arrayOne = new string[size];
fillRandArr(arrayOne);
void fillRandArr(string[] arr)
{
    var rnd = new Random();
    string Symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*";
    for (int i = 0; i < size; i++)
    {
        int randElemSize = rnd.Next(lover, upper);
        for (int j = 0; j < randElemSize; j++)
        {
            arr[i] += Symbols[rnd.Next(0,Symbols.Length)];
        }        
    }
}
int getSizeOfSecondArray(string[] arr)
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
string[] moveElemOfArr(string[] arr)
{
    string[] arrayTwo = new string[getSizeOfSecondArray(arrayOne)];
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
if (getSizeOfSecondArray(arrayOne) == 0){Console.WriteLine("Искомых элементов масива для переноса в новый массив - нет");}
else
{
string[] arrayTwo = moveElemOfArr(arrayOne);
// Console.Clear();
Console.WriteLine($"Это массив заполненный рандомными значениями, и новый массив, длиной не более {n} символов отобранный из рандомного:");
Console.WriteLine();
Console.WriteLine($"[{String.Join(", ", arrayOne)}] -> [{String.Join(", ", arrayTwo)}]");
Console.WriteLine();
}