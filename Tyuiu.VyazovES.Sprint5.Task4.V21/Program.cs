using Tyuiu.VyazovES.Sprint5.Task4.V21.Lib;

DataService ds = new DataService();
string filePath = @"C:\DataSprintS\InPutDataFileTask4V0.txt";
double a;
a = ds.LoadFromDataFile(filePath);

Console.WriteLine(a);


Console.ReadKey();

