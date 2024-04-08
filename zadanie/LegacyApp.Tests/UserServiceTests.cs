namespace LegacyApp.Tests;

public class UserServiceTests
{
    [Fact]
    public void AddUser_Returns_False_When_First_Name_Is_Empty()
    {
        //Arrange
        var userService = new UserService();
        
        //Act
        var result = userService.AddUser(null,"Kowalski","kowalski@kowal.com", DateTime.Parse("2000-01-01"), 1);

        //Assert
        Assert.False(result);
    }
    
    
    [Fact]
    public void AddUser_Throws_Exception_When_Client_Does_Not_Exist()
    {
        //Arrange
        var userService = new UserService();
        
        //Act
        Action action = () => userService.AddUser("Jan","Kowalski","kowalski@kowal.com", DateTime.Parse("2000-01-01"), 100);
        
        //Assert
        Assert.Throws<ArgumentException>(action);
    }
}