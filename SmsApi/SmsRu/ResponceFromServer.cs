using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using SmsApi.Domain;

namespace SmsRu
{
    public class ResponceFromServer : IResponceFromServer
    {
        public IErrorData ErrorData { get; set; }
        public string Data { get; set; }
       

        public ResponceFromServer(string data)
        {
            var smsError = new SmsError();
            var error = smsError.GetError(data);
            if (error == null)
                throw new ArgumentNullException();
            ErrorData = error;
            Data = data.Substring(data.IndexOf("\n")+1);

        }
        public ResponceFromServer(int code, string error, string data)
        {
            
            Data = data;
        }
    }
}
