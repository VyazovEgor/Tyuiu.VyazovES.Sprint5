using Tyuiu.VyazovES.Sprint5.Task1.V17.Lib;

DataService ds = new DataService();
string s;
int a = 2;
int b = 3;
s = ds.SaveToFileTextData(a, b);

Console.WriteLine("Файл: " + s);
Console.WriteLine("Создан!");


Console.ReadKey();

