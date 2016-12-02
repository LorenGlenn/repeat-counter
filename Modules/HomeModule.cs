using Nancy;
using WordCounter.Objects;
using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"]=_=> View["index.cshtml"];
      Post["/count"]=_=>
      {
        string inputSentence = Request.Form["sentence"];
        string inputWordToSearch = Request.Form["word"];
        RepeatCounter newCounter = new RepeatCounter(inputSentence, inputWordToSearch);
        int result = newCounter.CountRepeats();
        return View["result.cshtml", result];
      };
    }
  }
}
