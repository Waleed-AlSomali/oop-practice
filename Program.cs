class Person
{
    private string name; // yes write, yes read
    private int age; // write yes, read yes

    public string Name { get { return name; } set { name = value; } }
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Sorry, Age can not be negative");
            }
            age = value;
        }
    }
}

public class MyClass
{
    public static void Main1(string[] args)
    {
        try
        {
            Person p1 = new Person();
            p1.Name = "Anisul Islam"; // writing 
            p1.Age = -32;
            Console.WriteLine($"{p1.Name}"); // read
            Console.WriteLine($"{p1.Age}"); // read
        }
        catch (System.Exception ex)
        {
            Console.WriteLine($"{ex.Message}");

        }

    }
}
