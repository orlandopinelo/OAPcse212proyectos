public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
// PLAN:
    // 1. Initialize a new array of doubles with the size provided by 'length'.
    // 2. Use a for loop to iterate from 0 up to 'length - 1'.
    // 3. For each iteration (i), calculate the multiple. 
    //    Since the first multiple is the number itself (number * 1), 
    //    the formula will be: number * (i + 1).
    // 4. Store the result of that calculation into the current index of the array.
    // 5. After the loop completes, return the populated array.

    double[] multiples = new double[length];//Initialize

    for (int i = 0; i < length; i++) //Iterate
    {
        multiples[i] = number * (i + 1);
    }

    return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // PLAN:
    // 1. Identify the "split point." To rotate right by 'amount', we need to 
    //    take the last 'amount' of items and move them to the front.
    // 2. The starting index of the section to move is: data.Count - amount.
    // 3. Use GetRange to capture those last 'amount' items into a temporary list.
    // 4. Use RemoveRange to delete those items from the end of the original 'data' list.
    // 5. Use InsertRange to place that temporary list at index 0 of the 'data' list.
    
    // Step 1 & 2
    int startingIndex = data.Count - amount;

    // Step 3
    List<int> movedPart = data.GetRange(startingIndex, amount);

    // Step 4
    data.RemoveRange(startingIndex, amount);

    // Step 5
    data.InsertRange(0, movedPart);

    }
}
