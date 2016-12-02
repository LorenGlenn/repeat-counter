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
      
    }
  }
}
