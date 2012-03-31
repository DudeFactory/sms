using System.Collections.Generic;

namespace SmsApi.Domain
{
    public interface ISmsError
    {
        IErrorData GetError(string responceStr);
    }
}