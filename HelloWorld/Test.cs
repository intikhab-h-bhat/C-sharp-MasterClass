public class Employee
{
    public string Name { get; set; }
    public string Address { get; set; }
   

}

public class Teacher:Employee
{
    public void Teaches()
    {
        Console.WriteLine("Teaches");
    }

}