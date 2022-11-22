using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Xml;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace WFAppGetCoins
{
    // Почта
    static class Mailer
    {
        static public String Send(String Title, String Message, String MailFrom, String MailTo, String Password, String Server, int Port) // Отправить сообщение на почту
        {

            String Answer = "ERR";
            try
            {
                // отправитель - устанавливаем адрес и отображаемое в письме имя
                MailAddress from = new MailAddress(MailFrom, "prog NewCoins v1");
                // кому отправляем
                MailAddress to = new MailAddress(MailTo);
                // создаем объект сообщения
                MailMessage m = new MailMessage(from, to);
                // тема письма
                m.Subject = Title;
                // текст письма
                m.Body = Message; //"<h2>Письмо-тест работы smtp-клиента</h2>";
                                  // письмо представляет код html
                m.IsBodyHtml = true;
                // адрес smtp-сервера и порт, с которого будем отправлять письмо
                SmtpClient smtp = new SmtpClient(Server, Port);
                // логин и пароль
                smtp.Credentials = new NetworkCredential(MailFrom, Password);
                smtp.EnableSsl = true;
                smtp.Send(m);
                Answer = "";
            }
            catch (Exception e)
            {
                Answer = e.Message;
            }
            return Answer;
        }

        static public void SimpleSend(string smtpServer, string from, string password, string mailto, string caption, string message, string attachFile = null)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from);
                mail.To.Add(new MailAddress(mailto));
                mail.Subject = caption;
                mail.Body = message;
                if (!string.IsNullOrEmpty(attachFile))
                    mail.Attachments.Add(new Attachment(attachFile));
                SmtpClient client = new SmtpClient();
                client.Host = smtpServer;
                client.Port = 465;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(from, password);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mail);
                mail.Dispose();
            }
            catch (Exception e)
            {
                throw new Exception("Mail.Send: " + e.Message);
            }
        }
    }
}
