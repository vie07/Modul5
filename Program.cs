using System;

public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData (T data)
    {
        storedData.Add(data); 
        inputDates.Add(DateTime.Now);
    }

    public void PrintData()
    {
        //perulangan untuk print data
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data: {storedData[i]}, input Date: {inputDates[i]}");
        }
    }

    
}
public class Program
{
    public static void Main(string[] args)
    {
        SimpleDataBase<int> dataBase = new SimpleDataBase<int>();
        //memanggil method addNewData dan PrintData 
        dataBase.AddNewData(10);
        dataBase.AddNewData(30);
        dataBase.AddNewData(22);
        dataBase.PrintData();
    }
}