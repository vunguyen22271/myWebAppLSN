namespace myWebTest;

public class UnitTest2
{
    // https://xunit.net/docs/getting-started/netcore/cmdline#:~:text=From%20the%20command%20line%2C%20create,Test%20Project%22%20was%20created%20successfully.
    [Fact]
    public void PassingTest()
    {
        Assert.Equal(4, Add(2, 2));
    }

    [Fact]
    public void FailingTest()
    {
        Assert.Equal(5, Add(3, 2));
    }

    int Add(int x, int y)
    {
        return x + y;
    }
}