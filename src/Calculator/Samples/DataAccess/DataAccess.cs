namespace Samples.DataAccess;

public static class DataAccess
{
    private static string personTextFile = "Person.txt";

    public static void AddNewPerson(Person person)
    {
        var people = GetAllPeople();

        AddPersonToPeopleList(people, person);
        var lines = ConvertModelsToCsv(people);
        
        File.WriteAllLines(personTextFile, lines);
    }

    public static List<Person> GetAllPeople()
    {
        var content = File.ReadAllLines(personTextFile);

        var output = new List<Person>();
        foreach (var line in content)
        {
            var data = line.Split(',');
            output.Add(new Person { FirstName = data[0], LastName = data[1]});
        }

        return output;
    }

    public static void AddPersonToPeopleList(List<Person> people, Person person)
    {
        if (string.IsNullOrWhiteSpace(person.FirstName))
            throw new ArgumentException(message: "Invalid parameter", paramName: "FirstName");

        if (string.IsNullOrWhiteSpace(person.LastName))
            throw new ArgumentException(message: "Invalid parameter", paramName: "LastName");
        
        people.Add(person);
    }

    public static List<string> ConvertModelsToCsv(List<Person> people)
    {
        var lines = new List<string>();
        foreach (var user in people)
        {
            lines.Add($"{user.FirstName},{user.LastName}");
        }

        return lines;
    }
}