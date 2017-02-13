using System;
using System.Collections.Generic;

namespace PingPong.Objects
{
  public class PingPongGenerator
  {
  public List<string> Generate_PingPong(int number)
  {
    List<string> listPingPong = new List<string>();
    for(int i=1 ;i <= number; i++){
      if(i % 3==0 && i% 5 == 0){
        listPingPong.Add("ping-pong");
      }else if(i % 3 ==0){
        listPingPong.Add("Ping");
      }else if (i % 5 == 0){
        listPingPong.Add("Pong");
      }else{
        listPingPong.Add(i.ToString());
      }
    }
    return listPingPong;

  }
  }
}
