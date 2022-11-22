using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.Security.Cryptography;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;


class SimpleGETData // Получение публичных данных
{
    // Получение информации по запросу
    public string GetPublicInfo(string uri)
    {
        string Answer = ""; // ответ сервера
        try
        {
            // Создать объект запроса (наприер uri = https://api.binance.com/api/v3/ticker/price)
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            // Получить ответ с сервера
            WebResponse response = request.GetResponse();

            // Получаем поток данных из ответа
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                // Выводим результат
                string line;
                Answer = "";
                while ((line = stream.ReadLine()) != null)
                    Answer += line; // Например: [{"symbol":"ETHBTC","price":"0.04300600"},...

            }
        }
        catch
        {
            Answer = "";
        }
        return Answer;
    }

    // Разбор данных
    public string fromFormat(string DataSite, string FormatData, string Delim)
    {
        string Answer = ""; // Разобранные данные

        // Получаем совпадения в экземпляре класса Match
        Regex regex = new Regex(FormatData); // например: "\"symbol\":\"([A-Z]+)\""
        Match match = regex.Match(DataSite);
        // отображаем все совпадения
        while (match.Success)
        {
            // Т.к. мы выделили в шаблоне одну группу (одни круглые скобки),
            // ссылаемся на найденное значение через свойство Groups класса Match
            if (!String.IsNullOrEmpty(Answer))
            {
                Answer += Delim; // например Delim = ","
            }
            Answer += (match.Groups[1].ToString());

            // Переходим к следующему совпадению
            match = match.NextMatch();
        }

        return Answer;
    }

    // Получение монеты из пары
    public string GetCoinFromPair(string Pair, string SecCoins)
    {
        String[] substrings = SecCoins.Split(','); // массив базовых монет
        string FirstCoin = "";
        if (substrings.Length > 0)
        {
            int Ind;
            foreach (string element in substrings)
            {
                Ind = Pair.LastIndexOf(element);
                if (Ind >= 0)
                {
                    if (Ind == 0) // если базовая монета в начале
                    {
                        FirstCoin = Pair.Substring(element.Length);
                    }
                    else // если базовая монета в конце (норма)
                    {
                        FirstCoin = Pair.Substring(0, (Pair.LastIndexOf(element)));
                    }
                    break;
                }
            }
        }
        // если совпадений базовых монет нет, то возвращаем ""
        return FirstCoin;
    }

}