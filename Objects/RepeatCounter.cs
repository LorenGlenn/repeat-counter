using System;

namespace WordCounter.Objects
{
  public class RepeatCounter
  {
    private string _userSentence;
    private string _userWordToSearch;
    private string[] _splitSentence;

    public RepeatCounter(string inputSentence, string inputWordToSearch)
    {
      _userSentence = inputSentence;
      _userWordToSearch = inputWordToSearch;
      SplitSentence();
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

    public void SplitSentence()
    {
      _splitSentence = _userSentence.Split(' ');
    }

    public int CountRepeats()
    {

    }
  }
}
