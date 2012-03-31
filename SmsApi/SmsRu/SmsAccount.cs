using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmsApi.Domain;

namespace SmsRu
{
    public class SmsAccount : ISmsAccount
    {
        private SmsBase m_base;
        public SmsAccount(SmsBase baseSms)
        {
            m_base = baseSms;
        }
        #region Implementation of IAccount

        public IResponceFromServer GetBalance()
        {
            const string balanceUrl = "http://sms.ru/my/balance";
            var data =  m_base.SendRequest(balanceUrl, null);
            var responceFromServer = new ResponceFromServer(data);
            
            return responceFromServer;
        }

        public IResponceFromServer GetLimitSms()
        {
            const string balanceUrl = "http://sms.ru/my/limit";
            throw new NotImplementedException();
        }

        #endregion
	}
}
