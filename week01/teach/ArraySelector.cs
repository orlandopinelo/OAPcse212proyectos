public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        // 1. Initialize the result array to match the size of the instructions
    int[] result = new int[select.Length];
    
    // 2. Initialize pointers for the two source arrays
    int index1 = 0;
    int index2 = 0;

    // 3. Iterate through the selector array
    for (int k = 0; k < select.Length; k++)
    {
        if (select[k] == 1)
        {
            // Pick from list1 and move list1 pointer forward
            result[k] = list1[index1];
            index1++;
        }
        else if (select[k] == 2)
        {
            // Pick from list2 and move list2 pointer forward
            result[k] = list2[index2];
            index2++;
        }
    }
        return [];
    }
}