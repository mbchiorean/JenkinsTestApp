using Xunit;


namespace JenkinsTestsApp
{
    // see example explanation on xUnit.net website:
    // https://xunit.github.io/docs/getting-started-dotnet-core.html
    public class Class1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
            
        }

        [Fact]
        public void FailingTest()
        {
            Assert.NotEqual(5, Add(2, 2));
        }
        
        [Fact]
        public void PassingTest2()
        {
            Assert.Equal("Hello world1fortest+1", Program.CreateMessage());
        }

        int Add(int x, int y)
        {
            return x + y; 
        }
    }
}
