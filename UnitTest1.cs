// namespace WonderButton.Tests;
using WonderButton.Classes;
using WonderButton.Interfaces;
namespace WonderButton;


public class PushMessageTest
{
    [Fact]

    public void PushMessageTester()
    {
        //Arrange
        NewMessage<string?>  a = new();
        NewMessage<int?>     b = new();
        NewMessage<string?>  c = new();
        NewMessage<int?>     d = new();
        
        //Add
        a.Message             = null;
        b.Message             = null;
        c.Message             = "Hei på deg";
        d.Message             = 10;

        //Assert

        Assert.Null (a.Message);
        Assert.Null (b.Message);
        Assert.Equal(10, d.Message);
        Assert.Equal("Hei på deg", c.Message);
        
    }

}
public class PushButtontester : IPushButton 
{
    public ConsoleKey returnKey { get; set; } = ConsoleKey.Enter;

        public ConsoleKey PushButton()
    {
        return returnKey;
    }
}

public class TestingPushButton
{
    [Fact]
    public void TestButtonConsoleKey()
    {
        //Arrange
        PushButtontester fakeButton = new();
        fakeButton.returnKey = ConsoleKey.Escape;
    
        //Act
        ConsoleKey result = fakeButton.PushButton();

        //Assert
        Assert.Equal(ConsoleKey.Escape, result);
    }
}