using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  class Program
  {
    static HttpClient client = new HttpClient();
    public class Message
    {
      public string address { get; set; }
      public string senderAddress { get; set; }
      public string outboundSMSTextMessage { get; set; }
      public string clientCorrelator { get; set; }
      public string senderName { get; set; }
    }
    static void Main()
    {
      RunAsync().Wait();
    }

    static async Task RunAsync()
    {
      client.BaseAddress = new Uri("http://192.168.11.189/apicheck/");
      client.DefaultRequestHeaders.Accept.Clear();
      client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

      Console.ReadLine();
    }
  }
}
