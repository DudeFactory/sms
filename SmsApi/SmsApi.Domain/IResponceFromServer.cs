using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmsApi.Domain
{
    public interface IResponceFromServer
    {
        IErrorData ErrorData { get; set; }
        string Data { get; set; }

     

    }
}
