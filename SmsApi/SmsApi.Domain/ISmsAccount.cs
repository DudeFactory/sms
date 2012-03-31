namespace SmsApi.Domain
{
    public interface ISmsAccount
    {
        IResponceFromServer GetBalance();
        IResponceFromServer GetLimitSms();

    }
}