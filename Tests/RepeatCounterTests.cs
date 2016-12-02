using Xunit;
using WordCounter.Objects;

namespace RepeatCounterTests
{
  public class myTests
  {
    [Theory]
    [InlineData("a", "a", 1)]

    public void Test1_TestRepeatCounterMethod_True(string testSentence, string testWordToSearch, int expectedCount)
    {
      RepeatCounter testObj = new RepeatCounter(testSentence, testWordToSearch);
      int testResult = testObj.CountRepeats();
      Assert.Equal(testResult, expectedCount);
    }
  }
}
