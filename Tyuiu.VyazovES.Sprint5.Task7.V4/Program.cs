using Tyuiu.VyazovES.Sprint5.Task7.V4.Lib;

DataService ds = new DataService();
string filePath = @"С:\DataSprint5\InPutDataFileTask7V4.txt";
string a;
a = ds.LoadDataAndSave(filePath);

Console.WriteLine(a);


Console.ReadKey();

