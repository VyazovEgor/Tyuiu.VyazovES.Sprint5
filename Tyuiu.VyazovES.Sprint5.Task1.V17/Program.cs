using Tyuiu.VyazovES.Sprint5.Task1.V17.Lib;

DataService ds = new DataService();
string s;
int a = -5;
int b = 5;
s = ds.SaveToFileTextData(a, b);

Console.WriteLine("Файл: " + s);
Console.WriteLine("Создан!");


Console.ReadKey();

