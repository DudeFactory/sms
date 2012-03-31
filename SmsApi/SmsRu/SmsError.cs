using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmsApi.Domain;

namespace SmsRu
{
    public class SmsError : ISmsError
    {


        Dictionary<int, ErrorData> m_errorDatas = new Dictionary<int, ErrorData>()
                                                   {
                                                       {-1,new ErrorData(-1,"Сообщение не найдено.")},
                                                     {100, new ErrorData(100,"Сообщение принято к отправке. На следующих строчках вы найдете идентификаторы отправленных сообщений в том же порядке, в котором вы указали номера, на которых совершалась отправка.")},
                                                     {200, new ErrorData(200,"Неправильный api_id")},
                                                     {201, new ErrorData(201,"Не хватает средств на лицевом счету")},
                                                     {202, new ErrorData(202,"Неправильно указан получатель")},
                                                     {203, new ErrorData(203,"Нет текста сообщения")},
                                                     {204, new ErrorData(204,"Имя отправителя не согласовано с администрацией")},
                                                     {205, new ErrorData(205,"Сообщение слишком длинное (превышает 8 СМС)")},
                                                     {206, new ErrorData(206,"Будет превышен или уже превышен дневной лимит на отправку сообщений")},
                                                     {207, new ErrorData(207,"На этот номер (или один из номеров) нельзя отправлять сообщения, либо указано более 100 номеров в списке получателей")},
                                                     {208, new ErrorData(208,"Параметр time указан неправильно")},
                                                     {209, new ErrorData(209,"Вы добавили этот номер (или один из номеров) в стоп-лист")},
                                                     {210, new ErrorData(210,"Используется GET, где необходимо использовать POST")},
                                                     {211, new ErrorData(211,"Метод не найден")},
                                                     {220, new ErrorData(220,"Сервис временно недоступен, попробуйте чуть позже.")}
                                                   };



        #region ISmsError Members

        public IErrorData GetError(string responceStr)
        {
            if(responceStr.Contains("\n"))
                responceStr = responceStr.Substring(0, responceStr.IndexOf("\n"));
            int temp = -1;
            if (int.TryParse(responceStr, out temp))
            {
                ErrorData errorData = null;
                if (m_errorDatas.TryGetValue(temp, out errorData))
                {
                    return errorData;
                }
                throw new NotImplementedException("Не известная ошибка " + responceStr);

            }
            throw new NotImplementedException("Не известный ответ " + responceStr);
        }

        #endregion
    }
}
