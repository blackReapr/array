#region Task 1

int[] arr = { 1, 7, 15, -5, 1, 9 };
int sum = 0;

foreach (int i in arr)
{
    sum += i;
}

Console.WriteLine(sum);

#endregion

#region Task 2

int[] array = { 1, 7, 15, -5, 1, 9 };
int maxNum = int.MinValue;

foreach (int i in array)
{
    if (i > maxNum)
    {
        maxNum = i;
    }
}

Console.WriteLine(maxNum);

#endregion

#region Task 3

int[] newArr = { 4, 8, 2, 9, -5, 9, 12 };

Console.WriteLine(newArr[0] + newArr[newArr.Length - 1]);

#endregion