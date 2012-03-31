using SmsApi.Domain;

namespace SmsRu
{
    public class ErrorData : IErrorData
    {
        public int Code { get; set; }
        public string Error { get; set; }

        public ErrorData(int code, string error)
        {
            Code = code;
            Error = error;
        }
    }
}