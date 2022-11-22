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


class CryptoCoins // Список монет
{
    // может enum? 
    public readonly int cbase = 0;
    public readonly int cnet = 1;
    public readonly int cnew = 2;

    public List<String> netCoins = new List<string>(); // массив монет с сервера
    public List<String> baseCoins = new List<string>(); // массив монет сохраненный в базе
    public List<String> newCoins = new List<string>(); // новые монеты

    // Очистка списков монет
    public void Clear()
    {
        netCoins.Clear(); // или new ()
        baseCoins.Clear();
        newCoins.Clear();
    }

    // Копирование монет в группу
    public void CopyCoinsToGroup(List<String> inCoins, int group)
    {
        switch (group)
        {
            case 1:
                netCoins = inCoins;
                break;
            case 2:
                newCoins = inCoins;
                break;
            default:
                baseCoins = inCoins;
                break;
        }
    }

    // Строку в список монет
    public void StringCoinsToGroup(String data, int group)
    {
        List<String> inCoins = (String.IsNullOrEmpty(data)) ? new List<string>(): data.Split(',').ToList();

        switch (group)
        {
            case 1:
                netCoins = inCoins;
                break;
            case 2:
                newCoins = inCoins;
                break;
            default:
                baseCoins = inCoins;
                break;
        }
    }

    // получение строки со списком новых монет
    public String GetStringOfNewCoins(char DelimData, String Delim) 
    {
        foreach (String coin in netCoins) // перебор загруженных монет с сервера
        {
                
            if (baseCoins.Any(x => GetCoinFromString(x, '#') == coin) == false) // совпадений нет - новая монета!
            {
                var item = newCoins.Find(x => GetCoinFromString(x,'#') == coin);
                if (item == null) // в списке новых монет еще нет такой монеты
                {
                    String myDT = DateTime.Now.ToString();
                    newCoins.Add(coin + DelimData + myDT + DelimData + "0");
                }
                
            }

        }
        return String.Join(Delim, newCoins.ToArray());
    }

    #region Подумать про создание одной функции с параметром index

    // Получение монеты из текста
    public String GetCoinFromString(String data, char Delim)
    {
        String Answer = data;

        if (data.IndexOf(Delim) > 0)
        {
            String[] values = data.Split(Delim);
            if (values.Length >= 3)
            {
                Answer = values[0];
            }
        }

        return Answer;
    } 

    // Получение даты и времени из текста
    public String GetDateTimeFromString(String data, char Delim)
    {
        String Answer = DateTime.Now.ToString();

        if (data.IndexOf(Delim) > 0)
        {
            String[] values = data.Split(Delim);
            if (values.Length >= 3)
            {
                Answer = values[1];
            }
        }
        return Answer;
    } 

    // Получение подтверждения из текста
    public String GetSeeFromString(String data, char Delim)
    {
        String Answer = "0";

        if (data.IndexOf(Delim) > 0)
        {
            String[] values = data.Split(Delim);
            if (values.Length >= 3)
            {
                Answer = values[2];
            }
        }

        return Answer;
    }

    #endregion
}
