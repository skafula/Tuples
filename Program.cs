using System.Diagnostics;

internal class Program
{
    class Person
    {
        public int Id { get; set; } 
        public Tuple<string, int> GetTupleNameAge()
        {
            Tuple<string, int> returnMultipleValues = new Tuple<string, int>("Scott", 20);
            return returnMultipleValues;
        }

        public (int id, string name, int age) GetDetailsAsValueTuple()
        {
            Id = 1;
            //Order is always important to hold the meaning of variable names
            return (Id, "Jill", 20);
        }
    }
    private static void Main(string[] args)
    {
        Person personObject = new Person();

        //Tuple type can be used for return multiple values or add as mutliple valued parameter to a method. It's elements can
        //be called by *.Item1, *.Item2...
        Tuple<string, int> personTuple = personObject.GetTupleNameAge();

        Console.WriteLine(personTuple.Item1);
        Console.WriteLine(personTuple.Item2);

        //Value Tuple is much more better as it uses easier syntax and also it's values can be named and it's not only readonly. 
        //Also the values can be assigned as local variables in a really short syntax.
        (int id, string name, int age) personVTuple = personObject.GetDetailsAsValueTuple();
        
        Console.WriteLine(personVTuple.id);
        Console.WriteLine(personVTuple.name);
        Console.WriteLine(personVTuple.age);
        personVTuple.id = 10;
        Console.WriteLine(personVTuple);

        //Deconstruction is an easy step to leave the reference variable and save the value tuple's values in variables named at declaration.
        //Also Discard is used for skip 1 or more values with '_'
        (int id, _, int age) = personVTuple;
        Console.WriteLine(id);
        Console.WriteLine(age);

    }
}