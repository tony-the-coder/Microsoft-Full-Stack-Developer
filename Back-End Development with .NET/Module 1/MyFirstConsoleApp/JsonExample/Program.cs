// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Newtonsoft.Json;

public class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }
}


public class Program
{
    public static void Main()
    {
        string json = "{\"Name\": \"John Doe\", \"Age\": 30}";
        Person person = JsonConvert.DeserializeObject<Person>(json);
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
       
        string updatedJson = JsonConvert.SerializeObject(person);
        Console.WriteLine($"Updated JSON: {updatedJson}");

        // Serialize a new person object
        
        Person newPerson = new Person { Name = "Jane Doe", Age = 25 };
        string newJson = JsonConvert.SerializeObject(newPerson);
        Console.WriteLine($"New Person JSON: {newJson}");
    }
}
