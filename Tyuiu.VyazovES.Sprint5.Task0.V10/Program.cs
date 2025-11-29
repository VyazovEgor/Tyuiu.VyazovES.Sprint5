using Tyuiu.VyazovES.Sprint5.Task0.V10.Lib;

DataService ds = new DataService();
string s;
int a = 2;
s = ds.SaveToFileTextData(a);

Console.WriteLine("Файл: " + s);
Console.WriteLine("Создан!");


Console.ReadKey();

