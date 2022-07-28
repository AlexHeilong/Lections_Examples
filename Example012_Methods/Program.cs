// Вид 1 - ничего не принимают и ничего не возвращает
void Method1()
{
    Console.WriteLine("Автор Алексей");
}
//Method1(); - для вызова метода, указывается его идентификатор и круглые скобки

// Вид 2 - могут принимать какие-то аргументы, но ничего не возвращают
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

void Method2_1(string msg, int count)
{
    int i = 0; 
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method2_1("Текст", 4);
// Method2_1(msg: "Текст", count: 4); - можно прямо указывать сообщения 
//к аргументам, при этом не порядок можно изменить (count: 4, msg: "Текст")

// Вид 3 - что-то возвращают, но ничего не принимают

int Method3() //в начале обяхательно указываем тип данных, который ожидаем получить
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// Вид 4 - методы, которые то-то принимают и что-то возвращают
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "asdf");
// Console.WriteLine(res);

string Method4_1(int count, string text) // С циклом for
{
    
    string result = String.Empty;
    for(int i = 0; i < count; i++) // инициализация счетчика(int i = 0); 
    //проверка условия (i < count); далее идет инкремент (увеличение счетчика i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4_1(10, "za");
Console.WriteLine(res);

// Цикл в цикле, пример - таблица умножения
for(int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}

// Дан текст. В тексте нужно все проблелы заменить черточками, 
// маленькие к заменить на большие, а большие С на маленькие

string text = "- Я думаю, - сказал князь, улыбаясь, - что, " 
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// Если будет строка string s =   "qwerty"
// мы можем обратиться к индексу   012345
// s[3] - это будет r
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

// Сортировка массива для поиска минимального значения
// с последующей отсортировкой мин значений

int [] arr = {1, 5, 4, 3 , 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array) //Метод для упорядочивания массива
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosission = i;
        
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosission]) minPosission = j; //Данный блок ищет минимальный элемент
        }

        int temporary = array[i];
        array[i] = array[minPosission]; //этот блок производит замену
        array[minPosission] = temporary; // одного элемента на др
    }
}

PrintArray(arr);
SelectionSort(arr); 
PrintArray(arr);