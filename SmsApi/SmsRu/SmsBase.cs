using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using SmsApi.Domain;

namespace SmsRu
{
    public class SmsBase : ISmsBase
    {
        private readonly string m_apiId;
        private readonly bool m_isTest;
        public readonly ISms Sms;
        public readonly ISmsError SmsError;
        public readonly ISmsAccount SmsAccount;
        public SmsBase(string apiId, bool isTest)
        {
            m_apiId = apiId;
            SmsError = new SmsError();
            Sms = new Sms(this);
            SmsAccount = new SmsAccount(this);
            m_isTest = isTest;
        }



        public bool SendRequest()
        {
            return false;
        }

        internal string SendRequest(string smsUrl, StringBuilder builder)
        {
            var httpUrl ="";
            if (builder == null)
            {
                builder = new StringBuilder();
            }
            builder.Append(String.Format("{0}={1}&", "api_id", m_apiId));
            builder.Append(String.Format("{0}={1}&", "test", m_isTest ? 1 : 0));
            httpUrl = string.Format("{0}?{1}", smsUrl, builder.ToString());



            var webClient = new WebClient();
            var downloadString = webClient.DownloadString(httpUrl);


            return downloadString;
        }
    }
}
