using Xunit;
using WordCounter.Objects;

namespace RepeatCounterTests
{
  public class myTests
  {
    [Theory]
    [InlineData("a", "a", 1)]
    [InlineData("apple", "apple", 1)]
    [InlineData("an apple", "apple", 1)]
    [InlineData("the big red apple was big", "big", 2)]
    [InlineData("the Big rEd BIG apPle was bIg", "big", 3)]

    public void Test1_TestRepeatCounterMethod_True(string testSentence, string testWordToSearch, int expectedCount)
    {
      RepeatCounter testObj = new RepeatCounter(testSentence, testWordToSearch);
      int testResult = testObj.CountRepeats();
      Assert.Equal(testResult, expectedCount);
    }
  }
}
