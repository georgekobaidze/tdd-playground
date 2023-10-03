namespace Samples.DataAccess;

public static class DataAccess
{
    private static string personTextFile = "Person.txt";

    public static void AddNewPerson(Person person)
    {
        var people = GetAllPeople();
        people.Add(person);
        
        var lines = new List<string>();
        foreach (var user in people)
        {
            lines.Add($"{user.FirstName},{user.LastName}");
        }
        
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
}