using Samples.DataAccess;

namespace Samples.Tests.DataAccess;

public class DataAccessTests
{
    [Fact]
    public void AddPersonToPeopleList_ShouldWork()
    {
        var newPerson = new Person { FirstName = "Giorgi", LastName = "Kobaidze"};
        var peopleList = new List<Person>();

        Samples.DataAccess.DataAccess.AddPersonToPeopleList(peopleList, newPerson);
        
        Assert.True(peopleList.Count == 1);
        Assert.Contains(newPerson, peopleList);
    }
}