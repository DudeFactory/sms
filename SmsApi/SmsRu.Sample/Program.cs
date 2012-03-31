using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmsRu.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            string apiID = "";
            var baseSms = new SmsBase(apiID, true);
            //baseSms.Sms.Send(new string[] { "9686262480" }, "test");
            var a = baseSms.SmsAccount.GetBalance();
            a.ToString();
        }
    }
}
