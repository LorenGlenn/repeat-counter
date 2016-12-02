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
      _userSentence = inputSentence.ToLower();
      _userWordToSearch = inputWordToSearch.ToLower();
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
      int totalCount = 0;
      for (int i =0; i < _splitSentence.Length; i++)
      {
        if(_splitSentence[i] == _userWordToSearch)
        {
          totalCount += 1;
        }
      }
      return totalCount;
    }
  }
}
