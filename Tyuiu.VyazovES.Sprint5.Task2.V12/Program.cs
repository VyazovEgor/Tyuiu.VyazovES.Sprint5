using Tyuiu.VyazovES.Sprint5.Task2.V12.Lib;

DataService ds = new DataService();
string s;
int a = 3, b = 3;
int[,] array = new int[a, b];

for (int i = 0; i <= a; i++)
{
    for (int j = 0; j <= b; j++)
    {
        array[i, j] = Convert.ToInt32(Console.ReadLine());
    }

}
s = ds.SaveToFileTextData(array);

for (int i = 0; i <= a; i++)
{
    for (int j = 0; j <= b; j++)
    {
        Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();

}


//Console.WriteLine("Файл: " + s);
//Console.WriteLine("Создан!");


Console.ReadKey();

