Console.Clear();

string[] array=InputArrayOfStrings();

Console.WriteLine("Вы ввели следующий массив строк: ");
PrintArrayOfStrings(array);

Console.WriteLine("Массив из строк длиной 3 или менее: ");
PrintArrayOfStrings(FindThreeSymbolsStrings(array));


string[] InputArrayOfStrings() // метод ввода массива строк
{
    string[] arrayOfStrings=new string[0], buf=new string[0];
    string inputString=string.Empty;
    int numberOfStrings=0;

    Console.WriteLine("Введите строки. После ввода каждой строки нажимайте Enter.");
    Console.WriteLine("Для завершения введите пустую строку.");
    do
    {
        inputString=Console.ReadLine();
        if(inputString!=string.Empty)
        {
            numberOfStrings++;
            buf=new string[numberOfStrings];
            for(int i=0;i<arrayOfStrings.Length;i++)
                buf[i]=arrayOfStrings[i];
            buf[numberOfStrings-1]=inputString;
            arrayOfStrings=buf;
        }
    }
    while(inputString!=string.Empty);

    return arrayOfStrings;
}

void PrintArrayOfStrings(string[] array) // метод для вывода введенного пользователем массива
{
    for(int i=0;i<array.Length;i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

string[] FindThreeSymbolsStrings(string[] inputArray) // метод для формирования массива строк, длиной 3 и менее
{
    int numberOfStrings=0;
   
    for(int i=0;i<inputArray.Length;i++)
        if(inputArray[i].Length<=3)
            numberOfStrings++;

    string[] arrayOfThreeSymbolsStrings=new string[numberOfStrings];
    int j=0;

    for(int i=0;i<inputArray.Length;i++)
        if(inputArray[i].Length<=3)
        {
            arrayOfThreeSymbolsStrings[j]=inputArray[i];
            j++;
        }
    return arrayOfThreeSymbolsStrings;
}           