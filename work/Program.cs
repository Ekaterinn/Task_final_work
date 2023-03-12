// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше, либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения аглоритма.
Console.Clear();

string[] FirstArray(string[] inArray)
{
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= 3)
            count++;
    }
       
    string[] SecondArray = new string[count];
    int j = 0;

    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= 3)
        {            
            SecondArray[j] = inArray[i];  
            j++;          
        }
    }
    return SecondArray;
}

string[] array = new string[] {"cat", "2345", "^-^", "1"};
string[] SecondArray = FirstArray(array);
Console.WriteLine(String.Join(", ", SecondArray));