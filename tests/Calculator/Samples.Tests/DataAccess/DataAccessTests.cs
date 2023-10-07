using Samples.DataAccess;

namespace Samples.Tests.DataAccess;

public class DataAccessTests
{
    [Fact]
    public void AddPersonToPeopleList_WithValidInput_ShouldAddPersonInList()
    {
        var newPerson = new Person { FirstName = "Giorgi", LastName = "Kobaidze"};
        var peopleList = new List<Person>();

        Samples.DataAccess.DataAccess.AddPersonToPeopleList(peopleList, newPerson);
        
        Assert.True(peopleList.Count == 1);
        Assert.Contains(newPerson, peopleList);
    }

    [Theory]
    [InlineData("", "Kobaidze", "FirstName")]
    [InlineData("Giorgi", "", "LastName")]
    public void AddPersonToPeopleList_WithInvalidValues_ShouldThrowException(string firstName, string lastName, string wrongParameter)
    {
        var newPerson = new Person { FirstName = firstName, LastName = lastName };
        var peopleList = new List<Person>();

        Assert.Throws<ArgumentException>(wrongParameter,() =>
            Samples.DataAccess.DataAccess.AddPersonToPeopleList(peopleList, newPerson));
    }

    [Fact]
    public void ConvertModelsToCsv_WithEmptyList_ReturnsEmptyCsv()
    {
        var people = new List<Person>();
        
        var result = Samples.DataAccess.DataAccess.ConvertModelsToCsv(people);
        
        Assert.Empty(result);
    }

    [Fact]
    public void ConvertModelsToCsv_WithOnePerson_ReturnsOneCsvLine()
    {
        var people = new List<Person> { new Person { FirstName = "Giorgi", LastName = "Kobaidze" } };

        var result = Samples.DataAccess.DataAccess.ConvertModelsToCsv(people);

        Assert.Single(result);
        Assert.Equal("Giorgi,Kobaidze", result[0]);
        Assert.Matches(@"^\w+,\w+$", result[0]);
    }

    [Fact]
    public void ConvertModelsToCsv_WithMultiple_ReturnsMultipleCsvLines()
    {
        var people = new List<Person>
        {
            new Person { FirstName = "Giorgi", LastName = "Kobaidze" },
            new Person { FirstName = "Fernando", LastName = "Alonso" },
            new Person { FirstName = "Mark", LastName = "Webber" }
        };

        var result = Samples.DataAccess.DataAccess.ConvertModelsToCsv(people);
        
        Assert.Equal(3, result.Count);
        Assert.Contains("Giorgi,Kobaidze", result);
        Assert.Contains("Fernando,Alonso", result);
        Assert.Contains("Mark,Webber", result);
        Assert.All(result, line => Assert.Matches(@"^\w+,\w+$", line));
    }
}