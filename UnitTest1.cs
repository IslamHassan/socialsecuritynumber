namespace socialsecuritynumber;

public class UnitTest1
{
    [Fact]
    public void TestWriteNumber()
    {
        String number = "8112189876";
        var obj = new SocialSecNum(number);
        Console.WriteLine("rrrrrr:", obj.IsValid());

        Assert.True(obj.IsValid());
        //bool c = obj.IsValid();

        //Assert.Equal(4, Add(2, 2));
    }

    [Fact]
    public void TestWrongNumber()
    {
        String number = "8112189875";
        var obj = new SocialSecNum(number);
        Console.WriteLine("rrrrrr:", obj.IsValid());

        Assert.False(obj.IsValid());
        //bool c = obj.IsValid();

        //Assert.Equal(4, Add(2, 2));
    }

    [Fact]
    public void TestBiggerNumber()
    {
        String number = "81121898755";
        var obj = new SocialSecNum(number);
        Console.WriteLine("rrrrrr:", obj.IsValid());

        Assert.False(obj.IsValid());
        //bool c = obj.IsValid();

        //Assert.Equal(4, Add(2, 2));
    }
    [Fact]
    public void TestSmallerNumber()
    {
        String number = "81121898";
        var obj = new SocialSecNum(number);
        Console.WriteLine("rrrrrr:", obj.IsValid());

        Assert.False(obj.IsValid());
        //bool c = obj.IsValid();

        //Assert.Equal(4, Add(2, 2));
    }
}