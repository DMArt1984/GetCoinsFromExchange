namespace WFAppGetCoins
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_fromServer = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_UnAck = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox_UnAskC = new System.Windows.Forms.TextBox();
            this.tabList = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.See = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabBase = new System.Windows.Forms.TabPage();
            this.button_ClearBase = new System.Windows.Forms.Button();
            this.textBox_File = new System.Windows.Forms.TextBox();
            this.listBox_File = new System.Windows.Forms.ListBox();
            this.button_fromFile = new System.Windows.Forms.Button();
            this.tabServer = new System.Windows.Forms.TabPage();
            this.listBox_CoinServer = new System.Windows.Forms.ListBox();
            this.textBox_Server = new System.Windows.Forms.TextBox();
            this.tabNewCoins = new System.Windows.Forms.TabPage();
            this.listBox_NewCoins = new System.Windows.Forms.ListBox();
            this.button_NewCoins = new System.Windows.Forms.Button();
            this.textBox_News = new System.Windows.Forms.TextBox();
            this.tabSetting = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_MTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_TestMail = new System.Windows.Forms.Button();
            this.checkBox_SendMail = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_BCoins = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar_Server = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.label_ServerON = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox_Mail = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox_MPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_MPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_MServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_MFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_SS = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Info = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tab_UnAck.SuspendLayout();
            this.tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabBase.SuspendLayout();
            this.tabServer.SuspendLayout();
            this.tabNewCoins.SuspendLayout();
            this.tabSetting.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_Mail.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_fromServer
            // 
            this.button_fromServer.Location = new System.Drawing.Point(8, 320);
            this.button_fromServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_fromServer.Name = "button_fromServer";
            this.button_fromServer.Size = new System.Drawing.Size(121, 32);
            this.button_fromServer.TabIndex = 7;
            this.button_fromServer.Text = "Получить";
            this.button_fromServer.UseVisualStyleBackColor = true;
            this.button_fromServer.Click += new System.EventHandler(this.button_fromServer_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_UnAck);
            this.tabControl1.Controls.Add(this.tabList);
            this.tabControl1.Controls.Add(this.tabBase);
            this.tabControl1.Controls.Add(this.tabServer);
            this.tabControl1.Controls.Add(this.tabNewCoins);
            this.tabControl1.Controls.Add(this.tabSetting);
            this.tabControl1.Location = new System.Drawing.Point(8, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(895, 391);
            this.tabControl1.TabIndex = 8;
            // 
            // tab_UnAck
            // 
            this.tab_UnAck.Controls.Add(this.button3);
            this.tab_UnAck.Controls.Add(this.textBox_UnAskC);
            this.tab_UnAck.Location = new System.Drawing.Point(4, 25);
            this.tab_UnAck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_UnAck.Name = "tab_UnAck";
            this.tab_UnAck.Size = new System.Drawing.Size(887, 362);
            this.tab_UnAck.TabIndex = 5;
            this.tab_UnAck.Text = "Новые монеты";
            this.tab_UnAck.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(329, 314);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 42);
            this.button3.TabIndex = 1;
            this.button3.Text = "Подтвердить все";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox_UnAskC
            // 
            this.textBox_UnAskC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_UnAskC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_UnAskC.Location = new System.Drawing.Point(23, 21);
            this.textBox_UnAskC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_UnAskC.Multiline = true;
            this.textBox_UnAskC.Name = "textBox_UnAskC";
            this.textBox_UnAskC.ReadOnly = true;
            this.textBox_UnAskC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_UnAskC.Size = new System.Drawing.Size(838, 283);
            this.textBox_UnAskC.TabIndex = 0;
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.label7);
            this.tabList.Controls.Add(this.button2);
            this.tabList.Controls.Add(this.dataGridView1);
            this.tabList.Location = new System.Drawing.Point(4, 25);
            this.tabList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabList.Name = "tabList";
            this.tabList.Size = new System.Drawing.Size(887, 362);
            this.tabList.TabIndex = 3;
            this.tabList.Text = "Список монет";
            this.tabList.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 329);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(504, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Чтобы убрать монету из списка новых следует установить подтверждение";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(585, 319);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Сохранить подтверждения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Coin,
            this.Info,
            this.DT,
            this.See});
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(800, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // Num
            // 
            this.Num.HeaderText = "Номер";
            this.Num.MinimumWidth = 6;
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Width = 50;
            // 
            // Coin
            // 
            this.Coin.HeaderText = "Монета";
            this.Coin.MinimumWidth = 6;
            this.Coin.Name = "Coin";
            this.Coin.ReadOnly = true;
            this.Coin.Width = 125;
            // 
            // Info
            // 
            this.Info.HeaderText = "Информ";
            this.Info.MinimumWidth = 6;
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            this.Info.Width = 125;
            // 
            // DT
            // 
            this.DT.HeaderText = "Дата Время";
            this.DT.MinimumWidth = 6;
            this.DT.Name = "DT";
            this.DT.ReadOnly = true;
            this.DT.Width = 150;
            // 
            // See
            // 
            this.See.HeaderText = "Подтверждение";
            this.See.MinimumWidth = 6;
            this.See.Name = "See";
            this.See.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.See.Width = 125;
            // 
            // tabBase
            // 
            this.tabBase.BackColor = System.Drawing.Color.LightGray;
            this.tabBase.Controls.Add(this.button_ClearBase);
            this.tabBase.Controls.Add(this.textBox_File);
            this.tabBase.Controls.Add(this.listBox_File);
            this.tabBase.Controls.Add(this.button_fromFile);
            this.tabBase.Location = new System.Drawing.Point(4, 25);
            this.tabBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabBase.Name = "tabBase";
            this.tabBase.Size = new System.Drawing.Size(887, 362);
            this.tabBase.TabIndex = 2;
            this.tabBase.Text = "База данных";
            // 
            // button_ClearBase
            // 
            this.button_ClearBase.Location = new System.Drawing.Point(716, 324);
            this.button_ClearBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_ClearBase.Name = "button_ClearBase";
            this.button_ClearBase.Size = new System.Drawing.Size(147, 30);
            this.button_ClearBase.TabIndex = 13;
            this.button_ClearBase.Text = "Очистка базы";
            this.button_ClearBase.UseVisualStyleBackColor = true;
            this.button_ClearBase.Click += new System.EventHandler(this.button_ClearBase_Click);
            // 
            // textBox_File
            // 
            this.textBox_File.Location = new System.Drawing.Point(416, 7);
            this.textBox_File.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_File.Multiline = true;
            this.textBox_File.Name = "textBox_File";
            this.textBox_File.ReadOnly = true;
            this.textBox_File.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_File.Size = new System.Drawing.Size(445, 308);
            this.textBox_File.TabIndex = 12;
            // 
            // listBox_File
            // 
            this.listBox_File.FormattingEnabled = true;
            this.listBox_File.ItemHeight = 16;
            this.listBox_File.Location = new System.Drawing.Point(4, 7);
            this.listBox_File.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_File.Name = "listBox_File";
            this.listBox_File.Size = new System.Drawing.Size(403, 308);
            this.listBox_File.TabIndex = 10;
            // 
            // button_fromFile
            // 
            this.button_fromFile.Location = new System.Drawing.Point(4, 324);
            this.button_fromFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_fromFile.Name = "button_fromFile";
            this.button_fromFile.Size = new System.Drawing.Size(121, 32);
            this.button_fromFile.TabIndex = 9;
            this.button_fromFile.Text = "Получить";
            this.button_fromFile.UseVisualStyleBackColor = true;
            this.button_fromFile.Click += new System.EventHandler(this.button_fromFile_Click);
            // 
            // tabServer
            // 
            this.tabServer.BackColor = System.Drawing.Color.LightGray;
            this.tabServer.Controls.Add(this.listBox_CoinServer);
            this.tabServer.Controls.Add(this.textBox_Server);
            this.tabServer.Controls.Add(this.button_fromServer);
            this.tabServer.Location = new System.Drawing.Point(4, 25);
            this.tabServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabServer.Name = "tabServer";
            this.tabServer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabServer.Size = new System.Drawing.Size(887, 362);
            this.tabServer.TabIndex = 0;
            this.tabServer.Text = "Сервер биржи";
            this.tabServer.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // listBox_CoinServer
            // 
            this.listBox_CoinServer.FormattingEnabled = true;
            this.listBox_CoinServer.ItemHeight = 16;
            this.listBox_CoinServer.Location = new System.Drawing.Point(8, 7);
            this.listBox_CoinServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_CoinServer.Name = "listBox_CoinServer";
            this.listBox_CoinServer.Size = new System.Drawing.Size(313, 308);
            this.listBox_CoinServer.TabIndex = 8;
            // 
            // textBox_Server
            // 
            this.textBox_Server.Location = new System.Drawing.Point(331, 7);
            this.textBox_Server.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Server.Multiline = true;
            this.textBox_Server.Name = "textBox_Server";
            this.textBox_Server.ReadOnly = true;
            this.textBox_Server.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Server.Size = new System.Drawing.Size(544, 308);
            this.textBox_Server.TabIndex = 7;
            // 
            // tabNewCoins
            // 
            this.tabNewCoins.BackColor = System.Drawing.Color.LightGray;
            this.tabNewCoins.Controls.Add(this.listBox_NewCoins);
            this.tabNewCoins.Controls.Add(this.button_NewCoins);
            this.tabNewCoins.Controls.Add(this.textBox_News);
            this.tabNewCoins.Location = new System.Drawing.Point(4, 25);
            this.tabNewCoins.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabNewCoins.Name = "tabNewCoins";
            this.tabNewCoins.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabNewCoins.Size = new System.Drawing.Size(887, 362);
            this.tabNewCoins.TabIndex = 1;
            this.tabNewCoins.Text = "Монеты вне базы";
            // 
            // listBox_NewCoins
            // 
            this.listBox_NewCoins.FormattingEnabled = true;
            this.listBox_NewCoins.ItemHeight = 16;
            this.listBox_NewCoins.Location = new System.Drawing.Point(8, 7);
            this.listBox_NewCoins.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_NewCoins.Name = "listBox_NewCoins";
            this.listBox_NewCoins.Size = new System.Drawing.Size(401, 308);
            this.listBox_NewCoins.TabIndex = 11;
            // 
            // button_NewCoins
            // 
            this.button_NewCoins.Location = new System.Drawing.Point(8, 320);
            this.button_NewCoins.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_NewCoins.Name = "button_NewCoins";
            this.button_NewCoins.Size = new System.Drawing.Size(121, 32);
            this.button_NewCoins.TabIndex = 10;
            this.button_NewCoins.Text = "Получить";
            this.button_NewCoins.UseVisualStyleBackColor = true;
            this.button_NewCoins.Click += new System.EventHandler(this.button_NewCoins_Click);
            // 
            // textBox_News
            // 
            this.textBox_News.Location = new System.Drawing.Point(419, 7);
            this.textBox_News.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_News.Multiline = true;
            this.textBox_News.Name = "textBox_News";
            this.textBox_News.ReadOnly = true;
            this.textBox_News.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_News.Size = new System.Drawing.Size(460, 308);
            this.textBox_News.TabIndex = 9;
            // 
            // tabSetting
            // 
            this.tabSetting.BackColor = System.Drawing.Color.LightGray;
            this.tabSetting.Controls.Add(this.groupBox2);
            this.tabSetting.Controls.Add(this.label8);
            this.tabSetting.Controls.Add(this.textBox_BCoins);
            this.tabSetting.Controls.Add(this.groupBox1);
            this.tabSetting.Controls.Add(this.groupBox_Mail);
            this.tabSetting.Location = new System.Drawing.Point(4, 25);
            this.tabSetting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.Size = new System.Drawing.Size(887, 362);
            this.tabSetting.TabIndex = 4;
            this.tabSetting.Text = "Настройки";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_MTo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button_TestMail);
            this.groupBox2.Controls.Add(this.checkBox_SendMail);
            this.groupBox2.Location = new System.Drawing.Point(25, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(489, 119);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Почта";
            // 
            // textBox_MTo
            // 
            this.textBox_MTo.Location = new System.Drawing.Point(231, 23);
            this.textBox_MTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_MTo.Name = "textBox_MTo";
            this.textBox_MTo.Size = new System.Drawing.Size(227, 22);
            this.textBox_MTo.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Адрес получателя:";
            // 
            // button_TestMail
            // 
            this.button_TestMail.Location = new System.Drawing.Point(196, 81);
            this.button_TestMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_TestMail.Name = "button_TestMail";
            this.button_TestMail.Size = new System.Drawing.Size(263, 31);
            this.button_TestMail.TabIndex = 13;
            this.button_TestMail.Text = "Отправка тестового сообщения";
            this.button_TestMail.UseVisualStyleBackColor = true;
            this.button_TestMail.Click += new System.EventHandler(this.button_TestMail_Click);
            // 
            // checkBox_SendMail
            // 
            this.checkBox_SendMail.AutoSize = true;
            this.checkBox_SendMail.Location = new System.Drawing.Point(33, 55);
            this.checkBox_SendMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_SendMail.Name = "checkBox_SendMail";
            this.checkBox_SendMail.Size = new System.Drawing.Size(270, 21);
            this.checkBox_SendMail.TabIndex = 21;
            this.checkBox_SendMail.Text = "Отправлять новые монеты на почту";
            this.checkBox_SendMail.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(524, 299);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Базовые монеты (через запятую):";
            // 
            // textBox_BCoins
            // 
            this.textBox_BCoins.Location = new System.Drawing.Point(524, 319);
            this.textBox_BCoins.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_BCoins.Name = "textBox_BCoins";
            this.textBox_BCoins.ReadOnly = true;
            this.textBox_BCoins.Size = new System.Drawing.Size(324, 22);
            this.textBox_BCoins.TabIndex = 17;
            this.textBox_BCoins.Text = "BTC,ETH,BNB,USDT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar_Server);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label_ServerON);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(528, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(325, 170);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сервер";
            // 
            // progressBar_Server
            // 
            this.progressBar_Server.Location = new System.Drawing.Point(15, 117);
            this.progressBar_Server.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar_Server.Maximum = 60;
            this.progressBar_Server.Name = "progressBar_Server";
            this.progressBar_Server.Size = new System.Drawing.Size(303, 32);
            this.progressBar_Server.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 27);
            this.button1.TabIndex = 15;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label_ServerON
            // 
            this.label_ServerON.AutoSize = true;
            this.label_ServerON.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_ServerON.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ServerON.Location = new System.Drawing.Point(13, 87);
            this.label_ServerON.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ServerON.Name = "label_ServerON";
            this.label_ServerON.Size = new System.Drawing.Size(89, 20);
            this.label_ServerON.TabIndex = 16;
            this.label_ServerON.Text = "Включено";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Время опроса сервера (сек):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 59);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 22);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "60";
            // 
            // groupBox_Mail
            // 
            this.groupBox_Mail.Controls.Add(this.textBox5);
            this.groupBox_Mail.Controls.Add(this.textBox_MPassword);
            this.groupBox_Mail.Controls.Add(this.label6);
            this.groupBox_Mail.Controls.Add(this.textBox_MPort);
            this.groupBox_Mail.Controls.Add(this.label5);
            this.groupBox_Mail.Controls.Add(this.textBox_MServer);
            this.groupBox_Mail.Controls.Add(this.label4);
            this.groupBox_Mail.Controls.Add(this.textBox_MFrom);
            this.groupBox_Mail.Controls.Add(this.label2);
            this.groupBox_Mail.Location = new System.Drawing.Point(25, 146);
            this.groupBox_Mail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Mail.Name = "groupBox_Mail";
            this.groupBox_Mail.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Mail.Size = new System.Drawing.Size(492, 197);
            this.groupBox_Mail.TabIndex = 11;
            this.groupBox_Mail.TabStop = false;
            this.groupBox_Mail.Text = "Почтовый сервер";
            this.groupBox_Mail.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox5.Location = new System.Drawing.Point(33, 145);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(425, 43);
            this.textBox5.TabIndex = 22;
            this.textBox5.Text = "ВАЖНО: Сервер должен разрешить доступ к аккаунту от неизвестного приложения";
            this.textBox5.Visible = false;
            // 
            // textBox_MPassword
            // 
            this.textBox_MPassword.Location = new System.Drawing.Point(232, 53);
            this.textBox_MPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_MPassword.Name = "textBox_MPassword";
            this.textBox_MPassword.PasswordChar = '*';
            this.textBox_MPassword.Size = new System.Drawing.Size(227, 22);
            this.textBox_MPassword.TabIndex = 20;
            this.textBox_MPassword.Text = "hahaha";
            this.textBox_MPassword.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Пароль:";
            this.label6.Visible = false;
            // 
            // textBox_MPort
            // 
            this.textBox_MPort.Location = new System.Drawing.Point(232, 117);
            this.textBox_MPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_MPort.Name = "textBox_MPort";
            this.textBox_MPort.Size = new System.Drawing.Size(111, 22);
            this.textBox_MPort.TabIndex = 18;
            this.textBox_MPort.Text = "587";
            this.textBox_MPort.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Порт:";
            this.label5.Visible = false;
            // 
            // textBox_MServer
            // 
            this.textBox_MServer.Location = new System.Drawing.Point(232, 85);
            this.textBox_MServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_MServer.Name = "textBox_MServer";
            this.textBox_MServer.Size = new System.Drawing.Size(227, 22);
            this.textBox_MServer.TabIndex = 16;
            this.textBox_MServer.Text = "smtp.gmail.com";
            this.textBox_MServer.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Почтовый сервер:";
            this.label4.Visible = false;
            // 
            // textBox_MFrom
            // 
            this.textBox_MFrom.Location = new System.Drawing.Point(232, 21);
            this.textBox_MFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_MFrom.Name = "textBox_MFrom";
            this.textBox_MFrom.Size = new System.Drawing.Size(227, 22);
            this.textBox_MFrom.TabIndex = 12;
            this.textBox_MFrom.Text = "new.coin.082018@gmail.com";
            this.textBox_MFrom.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Адрес отправителя (логин):";
            this.label2.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel_SS,
            this.toolStripStatusLabel_Info});
            this.statusStrip1.Location = new System.Drawing.Point(0, 450);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(909, 26);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.toolStripStatusLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(123, 20);
            this.toolStripStatusLabel2.Text = "DM Art 2018";
            // 
            // toolStripStatusLabel_SS
            // 
            this.toolStripStatusLabel_SS.Name = "toolStripStatusLabel_SS";
            this.toolStripStatusLabel_SS.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.toolStripStatusLabel_SS.Size = new System.Drawing.Size(45, 20);
            this.toolStripStatusLabel_SS.Text = "- - -";
            // 
            // toolStripStatusLabel_Info
            // 
            this.toolStripStatusLabel_Info.Name = "toolStripStatusLabel_Info";
            this.toolStripStatusLabel_Info.Size = new System.Drawing.Size(161, 20);
            this.toolStripStatusLabel_Info.Text = "Приложение открыто";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 476);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Монеты [ binance.com ]";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_UnAck.ResumeLayout(false);
            this.tab_UnAck.PerformLayout();
            this.tabList.ResumeLayout(false);
            this.tabList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabBase.ResumeLayout(false);
            this.tabBase.PerformLayout();
            this.tabServer.ResumeLayout(false);
            this.tabServer.PerformLayout();
            this.tabNewCoins.ResumeLayout(false);
            this.tabNewCoins.PerformLayout();
            this.tabSetting.ResumeLayout(false);
            this.tabSetting.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Mail.ResumeLayout(false);
            this.groupBox_Mail.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_fromServer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabServer;
        private System.Windows.Forms.TextBox textBox_Server;
        private System.Windows.Forms.TabPage tabNewCoins;
        private System.Windows.Forms.ListBox listBox_CoinServer;
        private System.Windows.Forms.TabPage tabBase;
        private System.Windows.Forms.Button button_fromFile;
        private System.Windows.Forms.ListBox listBox_File;
        private System.Windows.Forms.TextBox textBox_News;
        private System.Windows.Forms.Button button_NewCoins;
        private System.Windows.Forms.ListBox listBox_NewCoins;
        private System.Windows.Forms.TabPage tabList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabSetting;
        private System.Windows.Forms.GroupBox groupBox_Mail;
        private System.Windows.Forms.CheckBox checkBox_SendMail;
        private System.Windows.Forms.TextBox textBox_MPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_MPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_MServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_MTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_MFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_TestMail;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Info;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn See;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_ServerON;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_File;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.TabPage tab_UnAck;
        private System.Windows.Forms.TextBox textBox_UnAskC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_ClearBase;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_BCoins;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_SS;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar progressBar_Server;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

