string[] array = {"Hello", "world", "!!!", ":-)", "<3"};

string[] LessArray(string[] array) 
{
    string[] resultingArray = new string[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            resultingArray[i] = array[i];
        }
    }

    resultingArray = resultingArray.Where(i => !string.IsNullOrWhiteSpace(i)).ToArray();

    return resultingArray;
}

string[] arrayLessThanFour = LessArray(array);

Console.Write('[' + string.Join(" ", array) + ']' + " ==> " + '[' + string.Join(" ", arrayLessThanFour) + ']');