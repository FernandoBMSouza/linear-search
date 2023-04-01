int[] a = {3,2,8,9,11,23};
System.Console.Write(LinearSearch(a, 3));


int LinearSearch(int[] array, int k)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == k)
            return i;
    }
    return -1;
}