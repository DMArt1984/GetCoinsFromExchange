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
    public partial class Form1 : Form
    {
        private CryptoCoins AllCoins = new CryptoCoins(); // списки монет
        private int SecondsReq = 0; // секунд опроса сервера

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetDataFromFile(); // получение данных из файла
            GetServerData(); // получение данных с сервера биржи
            GetNewCoins(); // получение новых монет

            if (AllCoins.newCoins.Count > 0) // зачем я это сделал? 
            {
                GetDataFromFile();
                GetNewCoins();
            }

        }


        // Получение списка монет с сервера биржи https://...
        private String GetDataFromServer(String URI, String Frm, String Bse, String Delim)
        {
            String BaseCoins = Bse; // базовые монеты
            var AllCoins = new List<string>(); // список монет
            String tempText = ""; // временная строка

            SimpleGETData SGD = new SimpleGETData(); // объект работы с данными
            string Answer = "";
            Answer = SGD.GetPublicInfo(URI); // ответ сервера в строке
            if (!String.IsNullOrEmpty(Answer))
            {
                Answer = SGD.fromFormat(Answer, Frm, ","); // список пар монет в строке
                String[] ListPairs = Answer.Split(','); // массив пар монет

                // выделение монет из пар в список
                foreach (string element in ListPairs)
                {
                    tempText = SGD.GetCoinFromPair(element, BaseCoins);
                    if (!String.IsNullOrEmpty(tempText))
                    {
                        AllCoins.Add(tempText);
                    }
                }
                AllCoins.AddRange(BaseCoins.Split(',')); // Добавление к списку базовых монет

                var readyCoins = new List<string>(AllCoins.Distinct()); // удаление дубликатов
                readyCoins.Sort(); // сортировка списка
                Answer = String.Join(Delim, readyCoins.ToArray()); // список монет
            }
            return Answer;
        }

        // Получение списка монета#время из файла XML
        private String GetFromXMLfile(String FileName, String DelimData, String Delim)
        {           
            var doc = new XmlDocument(); // Создаем экземпляр Xml документа.
            String Answer = "";

            try
            {
                doc.Load(FileName); // / Загружаем данные из файла. (например: BC.xml)
                foreach (XmlNode node in doc.DocumentElement)
                {
                    string name = node.Attributes["name"].Value;
                    string date = node.Attributes["date"].InnerText;
                    string see = node.Attributes["see"].Value;
                    if (!String.IsNullOrEmpty(Answer))
                    {
                        Answer += Delim;
                    }
                    Answer += name + DelimData + date + DelimData + see;
                }
            } catch (Exception ex)
            {
                Answer = "Файл не найден: "+FileName;
                MessageBox.Show(ex.Message, Answer);
                this.Close();
            }
                
            return Answer;
        }

        // Сохранение списка монета#время в файл XML
        private Boolean SaveXMLfile(String FileName, Boolean OnlyADD,List<String> L,char DelimData)
        {       
            var doc = new XmlDocument(); // Создаем экземпляр Xml документа.
            Boolean OK = false;
            try
            {               
                doc.Load(FileName); // // Загружаем данные из файла. (например: BC.xml)
                var root = doc.DocumentElement;
                if (OnlyADD == false) // полностью заменяем файл
                {
                    root.RemoveAll();
                }

                foreach (String bcoin in L) // перебор сохраненных монет
                {
                    XmlElement elem = doc.CreateElement("Сoin");
                    elem.InnerText = "19.95";
                    if (bcoin.IndexOf(DelimData) > 0) // есть поле времени
                    {
                        String[] value1 = bcoin.Split(DelimData);
                        elem.SetAttribute("name", value1[0]);
                        elem.SetAttribute("date", value1[1]);
                        if (value1.Length >=3)
                        {
                            elem.SetAttribute("see", value1[2]);
                        }
                    }
                    else // записываем тек. время и ставим бит просмотра 0
                    {
                        elem.SetAttribute("name", bcoin);
                        elem.SetAttribute("date", DateTime.Now.ToString());
                        elem.SetAttribute("see", "0");
                    }
                    root.AppendChild(elem); // Добавить новую монету
                }
                doc.Save(FileName); // сохранить в файл
                OK = true;
            } catch // ошибки
            {
                // ничего не делаем)
            }
            return OK;
        }

        // Загрузка данных из файла(базы)
        private void GetDataFromFile()
        {
            // инфо
            InfoText( "Загрузка данных из базы...");
            this.Refresh();

            String tmpText;
            // получение монет из файла в объект
            tmpText = GetFromXMLfile("BC.xml", "#", ",");
            AllCoins.StringCoinsToGroup(tmpText, AllCoins.cbase);

            // вывод в окно
            textBox_File.Text = tmpText;
            listBox_File.Items.Clear();
            dataGridView1.Rows.Clear();

            int Index = 0;
            Boolean See = false;
            String Str1 = "";
            String Str2 = "";

            foreach (String Value in AllCoins.baseCoins)
            {
                Index++;
                if (AllCoins.GetSeeFromString(Value,'#')=="1") {
                    See = true;
                } else
                {
                    See = false;
                }

                Str1 = Value.Replace("#", "\t");
                listBox_File.Items.Add(Index.ToString() + "\t" + Str1);
                Str2 = Index.ToString("D4");
                
                dataGridView1.Rows.Add(Str2, AllCoins.GetCoinFromString(Value, '#'), "B [база]", AllCoins.GetDateTimeFromString(Value, '#'), See);
            }

            if (Index > 0)
            {
                listBox_File.SelectedIndex = listBox_File.Items.Count - 1;
            }

            // Стираем список новых монет
            AllCoins.newCoins.Clear();

            // инфо
            InfoText( "Данные загружены из базы");

            // Обновить список не подтвержденных монет
            SetUnAckCoins();

        } // Процесс получения данных из файла

        private void GetServerData() // Процесс получения данных с сервера биржи
        {
            // инфо
            InfoText( "Получение данных с сервера биржи...");
            this.Refresh();

            String BCoins = textBox_BCoins.Text;
            if (String.IsNullOrEmpty(BCoins))
            {
                BCoins = "BTC";
                textBox_BCoins.Text = BCoins;
            }

            // получение монет с сервера...
            string coinsText = GetDataFromServer("https://api.binance.com/api/v3/ticker/price", "\"symbol\":\"([A-Z]+)\"", BCoins, ",");
            
            // ...в объект
            AllCoins.StringCoinsToGroup(coinsText, AllCoins.cnet);
            
            // монеты в окно
            textBox_Server.Text = coinsText;
            listBox_CoinServer.Items.Clear();
            int Index = 0;
            foreach (String Value in AllCoins.netCoins)
            {
                Index++;
                listBox_CoinServer.Items.Add(Index.ToString() + "\t" + Value);
            }
            if (Index > 0)
            {
                listBox_CoinServer.SelectedIndex = listBox_CoinServer.Items.Count - 1;
            }

            // инфо
            if (!String.IsNullOrEmpty(coinsText))
            {
                InfoText( "Данные с сервера загружены");
                toolStripStatusLabel_SS.Text = "Связь с сервером";
                toolStripStatusLabel_SS.BackColor = Color.GreenYellow;
            }
            else
            {
                InfoText("Сервер не вернул данные!");
                toolStripStatusLabel_SS.Text = "Нет связи";
                toolStripStatusLabel_SS.BackColor = Color.Red;
            }

        }

        // Процесс получения новых монет
        private void GetNewCoins() 
        {
            // инфо
            InfoText( "Поиск новых монет...");
            this.Refresh();

            String coinsText;
            // получение списка новых монет в объект
            coinsText = AllCoins.GetStringOfNewCoins('#', ",");
            AllCoins.StringCoinsToGroup(coinsText, AllCoins.cnew);

            // вывод в окно
            textBox_News.Text = coinsText;
            listBox_NewCoins.Items.Clear();

            if (AllCoins.newCoins.Count > 0) // если есть новые монеты
            { 
                int Index = 0;
                String Str1 = "";
                String Str2 = "";
                foreach (String Value in AllCoins.newCoins)
                {
                    Index++;
                    Str1 = Value.Replace("#", "\t");
                    listBox_NewCoins.Items.Add(Index.ToString() + "\t" + Str1);
                    Str2 = Index.ToString("D4");
                    dataGridView1.Rows.Add(Str2, AllCoins.GetCoinFromString(Value, '#'), "A [новая]", AllCoins.GetDateTimeFromString(Value, '#'));
                }
                if (Index > 0)
                {
                    listBox_NewCoins.SelectedIndex = listBox_NewCoins.Items.Count - 1;
                }

                // Сохраняем монеты в файл, если есть новые монеты
                if (AllCoins.newCoins.Count > 0) // зачем это условие?
                {
                    Boolean B = SaveXMLfile("BC.xml", true,AllCoins.newCoins, '#');
                }

                // инфо
                InfoText( "Обнаружены новые монеты");

                // Почта...
                if (this.checkBox_SendMail.Checked) // отправка данных на почту!
                {
                    String Message = "";
                    foreach (String item in AllCoins.newCoins)
                    {
                        Message+= AllCoins.GetCoinFromString(item, '#') +";  ";
                    }

                    SendCoinsMail("Новые монеты!", "Список: \n" + Message, "Отправка нового сообщения...");
                }

            } else
            {
                // инфо
                InfoText( "Новых монет нет");
            }
        }

        // Установить все подтверждения
        private void AckAll() 
        {
            // инфо
            InfoText("Установка подтверждений");
            this.Refresh();

            String Name;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                Name = Convert.ToString(dataGridView1.Rows[i].Cells["Coin"].Value);
                dataGridView1.Rows[i].Cells["See"].Value = true;

            }
        }

        // Вывод в окно список не подтвержденных монет
        private void SetUnAckCoins() 
        {
            String Answer = " - ";
            String Name;

            textBox_UnAskC.Text = "";
            foreach (String item in AllCoins.baseCoins)
            {
                Name = AllCoins.GetCoinFromString(item, '#');
                if (AllCoins.GetSeeFromString(item, '#') != "1")
                {
                    Answer += Name + " - ";
                }

            }
            textBox_UnAskC.Text = Answer;

        }

        // Сохранить подтверждения
        private void SaveSee(String DelimData) 
        {

            // инфо
            InfoText("Сохранение подтверждений в базу...");
            this.Refresh();

            String Name;
            Boolean See;
            String SeeTxt;
            String Message = "";
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {

                Name = Convert.ToString(dataGridView1.Rows[i].Cells["Coin"].Value);
                See = Convert.ToBoolean(dataGridView1.Rows[i].Cells["See"].Value);
                if (See == true)
                {
                    SeeTxt = "1";
                }
                else
                {
                    SeeTxt = "0";
                }

                int item = AllCoins.baseCoins.FindIndex(x => AllCoins.GetCoinFromString(x, '#') == Name);
                AllCoins.baseCoins[item] = Name + DelimData + AllCoins.GetDateTimeFromString(AllCoins.baseCoins[item], '#') + DelimData + SeeTxt;

                Message += Name + "=" + SeeTxt + ", ";

            }

            Boolean B = SaveXMLfile("BC.xml", false, AllCoins.baseCoins, '#');

            // инфо
            InfoText("Сохранение в базу закончено...");

            //
            GetDataFromFile();

        }

        // Почта
        private void SendCoinsMail(String Title, String Message, String Info) // блок отправки сообщения
        {
            String MailFrom = textBox_MFrom.Text;
            String MailTo = textBox_MTo.Text;
            String mServer = textBox_MServer.Text;
            int mPort = Convert.ToInt16(textBox_MPort.Text);
            String mPassword = textBox_MPassword.Text;

            InfoText(Info);
            this.Refresh();

            String txtReturn = Mailer.Send(Title, Message, MailFrom, MailTo, mPassword, mServer, mPort); // отправка почты
            if (String.IsNullOrEmpty(txtReturn))
            {
                InfoText("Сообщение отправлено");
            }
            else
            {
                InfoText("Ошибка mail: " + txtReturn);
            }
        }

        
        // инфо
        private void InfoText(String text)
        {
            toolStripStatusLabel_Info.Text = text;
        }

        // ================ события ===================================================

        private void button_fromServer_Click(object sender, EventArgs e)
        {
            GetServerData();           
        }

        private void button_fromFile_Click(object sender, EventArgs e)
        {
            GetDataFromFile();
        }

        private void button_NewCoins_Click(object sender, EventArgs e)
        {
            GetNewCoins();
        }  

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            int WaitValue = Convert.ToInt16(textBox1.Text);

            if (WaitValue == 0)
            {
                timer1.Enabled = false;
                label_ServerON.Text = "Отключено";
                // инфо
                InfoText( "Автообновление данных ОТКЛЮЧЕНО!");
            } else
            {
                // инфо
                InfoText( "Параметры автообновления изменены");

                timer1.Enabled = true;
                label_ServerON.Text = "Включено";
                
                if (WaitValue < 60)
                {               
                    WaitValue = 60;              
                }
                if (WaitValue > 6000)
                {
                    WaitValue = 6000;
                }
                timer1.Interval = WaitValue * 1000;
            }
            
            textBox1.Text = WaitValue.ToString();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(timer1.Interval / 1000);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SaveSee("#");
        }

        
        private void button_TestMail_Click(object sender, EventArgs e)
        {
            SendCoinsMail("Тестовое сообщение", "Отправка сообщений в норме. \n{" + DateTime.Now.Millisecond + "}", "Отправка тестового сообщения...");
            
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            AckAll(); // подтвердить все
            SaveSee("#"); // и записить в базу
        }

        private void button_ClearBase_Click(object sender, EventArgs e)
        {
            AllCoins.baseCoins.Clear();

            Boolean B = SaveXMLfile("BC.xml", false, AllCoins.baseCoins, '#');
            GetDataFromFile();

            // инфо
            InfoText("База очищена");

        }


        // Таймеры
        private void timer1_Tick(object sender, EventArgs e) // периодический опрос сервера!
        {
            SecondsReq = 0;
            progressBar_Server.Value = 0;

            GetServerData();
            GetNewCoins();
            if (AllCoins.newCoins.Count > 0)
            {
                GetDataFromFile();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                SecondsReq++;
                try
                {
                    progressBar_Server.Value = SecondsReq;
                    progressBar_Server.Maximum = Convert.ToInt16(timer1.Interval / 1000)+5;

                } catch
                {
                    SecondsReq = 0;
                }
            } else
            {
                SecondsReq = 0;
                progressBar_Server.Value = 0;
            }
        }

        
        
        
    }
}
