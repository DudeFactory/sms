using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmsApi.Domain;

namespace SmsRu
{
    public class Sms : ISms
    {
        private string m_smsUrl = "http://sms.ru/sms/send";
        private SmsBase m_baseSms;

        public Sms(SmsBase baseSms)
        {
            // TODO: Complete member initialization
            this.m_baseSms = baseSms;
        }

        #region Implementation of ISms

        public IResponceFromServer Send(string[] to, string text)
        {
            if(to==null || to.Length>100)
            {
                throw new ArgumentException("Телефоны или пустые или больше 100");
            }

            var builder = new StringBuilder();

            builder.Append(String.Format("{0}={1}&", "to", String.Join(",", to)));
            builder.Append(String.Format("{0}={1}&", "text", text));

            var data = m_baseSms.SendRequest(m_smsUrl, builder);
            var responceFromServer = new ResponceFromServer(data);
            
            return responceFromServer;
        }

        public IResponceFromServer Send(string[] to, string text, params object[] objects)
        {
            throw new NotImplementedException();
        }

        public IResponceFromServer Send(string[] to, string text, string from)
        {
            throw new NotImplementedException();
        }

        public IResponceFromServer Send(string[] to, string text, string from, DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public IResponceFromServer Send(string[] to, string text, string from, int time)
        {
            throw new NotImplementedException();
        }

        public IResponceFromServer Send(string[] to, string text, string from, int time, string login, string token, string sig)
        {
            throw new NotImplementedException();
        }

        public IResponceFromServer Send(string[] to, string text, string from, int time, params object[] objects)
        {
            throw new NotImplementedException();
        }

        public IResponceFromServer Send(string[] to, string text, SendType sendType)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
