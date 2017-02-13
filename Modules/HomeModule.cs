using System;
using Nancy;
using Xunit;
using PingPong.Objects;
using System.Collections.Generic;
namespace PingPong
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
     Get["/"]=_=>View ["pingpong.cshtml"];
     Post["show_pingpong"]=_=> {                 //when user submit the form after entering the number
       //Read the user input
       int userNumber = int.Parse(Request.Form["input-number"]);
       PingPongGenerator newPingPong = new PingPongGenerator();
       List<string> listResult =newPingPong.Generate_PingPong(userNumber);
       return View ["view_pingpong.cshtml", listResult];
     };











    }
  }

}
