using Tyuiu.VyazovES.Sprint5.Task5.V22.Lib;

DataService ds = new DataService();
string filePath = @"С:\DataSprint5\InPutDataFileTask5V22.txt";
double a;
a = ds.LoadFromDataFile(filePath);

Console.WriteLine(a);


Console.ReadKey();

