using System;

namespace SmsApi.Domain
{
    public interface ISms
    {
        IResponceFromServer Send(string[] to, string text);
        IResponceFromServer Send(string[] to, string text, params object[] objects);
        IResponceFromServer Send(string[] to, string text, string from);
        IResponceFromServer Send(string[] to, string text, string from, DateTime dateTime);
        IResponceFromServer Send(string[] to, string text, string from, int time);
        IResponceFromServer Send(string[] to, string text, string from, int time, string login, string token, string sig);
        IResponceFromServer Send(string[] to, string text, string from, int time, params object[] objects);


        IResponceFromServer Send(string[] to, string text, SendType sendType);
    }
}