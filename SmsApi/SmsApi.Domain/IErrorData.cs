namespace SmsApi.Domain
{
    public interface IErrorData
    {
        int Code { get; set; }
        string Error { get; set; }
    }
}