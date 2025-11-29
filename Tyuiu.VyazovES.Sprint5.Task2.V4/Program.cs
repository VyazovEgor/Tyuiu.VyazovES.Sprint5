using Tyuiu.VyazovES.Sprint5.Task3.V2.Lib;

DataService ds = new DataService();
string s;
int a = 3;
s = ds.SaveToFileTextData(a);

Console.WriteLine("Файл: " + s);
Console.WriteLine("Создан!");


Console.ReadKey();

