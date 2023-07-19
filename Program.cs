int GetSumElementsOddPositions(int[] array)
{
    int SumElements = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        SumElements += array[i];
    }
    return SumElements;
}

int[] GetRandomArray(int Length, int min, int max)
{
    int[] array = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

int[] array = GetRandomArray(4, -99, 100);
Console.Write($"[{String.Join(", ",array)}] -> ");
Console.Write(GetSumElementsOddPositions(array));