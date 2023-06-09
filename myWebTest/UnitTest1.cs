using webapp.Modules;

namespace myWebTest;

public class UnitTest1
{
    [Fact]
    public void DemoTest()
    {
        int i = 1;
        bool result = false;
        if (i == 1) result = true;
        Assert.True(result, "Value should be equal to 1");
    }

    [Fact]
    public void CheckAddFuntion()
    {
        Functions func = new Functions();
        int y = func.Add(3, 2);
        bool result = false;
        if (y == 5) result = true;
        Assert.True(result, "Value should be equal to 5");
    }
}