using System;

namespace WordCounter.Objects
{
  public class RepeatCounter
  {
    private string _userSentence;
    private string _userWordToSearch;

    public RepeatCounter(string inputSentence, string inputWordToSearch)
    {
      _userSentence = inputSentence;
      _userWordToSearch = inputWordToSearch;
    }

    public string GetUserSentence()
    {
      return _userSentence;
    }

    public string GetUserWordToSearch()
    {
      return _userWordToSearch;
    }

    public void SetUserSentence(string newSentence)
    {
      _userSentence = newSentence;
    }

    public void SetUserWordToSearch(string newWordToSearch)
    {
      _userWordToSearch = newWordToSearch;
    }

    public int CountRepeats()
    {
      return 5;
    }
  }
}
