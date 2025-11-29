using Tyuiu.VyazovES.Sprint5.Task6.V23.Lib;

DataService ds = new DataService();
string filePath = @"С:\DataSprint5\InPutDataFileTask6V23.txt";
int a;
a = ds.LoadFromDataFile(filePath);

Console.WriteLine(a);


Console.ReadKey();

