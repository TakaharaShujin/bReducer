namespace bReducer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuKapat = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.iconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checker = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.readedDataLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.portStatusLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveSettings = new System.Windows.Forms.Button();
            this.autoStart = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.yuzdeScroll = new System.Windows.Forms.TrackBar();
            this.yuzdeText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.iconMenu.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yuzdeScroll)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuKapat
            // 
            this.menuKapat.Name = "menuKapat";
            this.menuKapat.Size = new System.Drawing.Size(104, 22);
            this.menuKapat.Text = "Kapat";
            this.menuKapat.Click += new System.EventHandler(this.menuKapat_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.iconMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "ß-Reducer";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseUp);
            // 
            // iconMenu
            // 
            this.iconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKapat});
            this.iconMenu.Name = "iconMenu";
            this.iconMenu.Size = new System.Drawing.Size(105, 26);
            // 
            // checker
            // 
            this.checker.Interval = 450;
            this.checker.Tick += new System.EventHandler(this.checker_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Square721 BT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 46);
            this.label1.TabIndex = 17;
            this.label1.Text = "ß-Reducer";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.readedDataLbl);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.portStatusLbl);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.close);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(17, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 30);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // readedDataLbl
            // 
            this.readedDataLbl.AutoSize = true;
            this.readedDataLbl.BackColor = System.Drawing.Color.Transparent;
            this.readedDataLbl.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold);
            this.readedDataLbl.Location = new System.Drawing.Point(257, 10);
            this.readedDataLbl.Name = "readedDataLbl";
            this.readedDataLbl.Size = new System.Drawing.Size(43, 16);
            this.readedDataLbl.TabIndex = 20;
            this.readedDataLbl.Text = "N / A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Square721 BT", 9.75F);
            this.label6.Location = new System.Drawing.Point(157, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sensör Değeri : ";
            // 
            // portStatusLbl
            // 
            this.portStatusLbl.AutoSize = true;
            this.portStatusLbl.BackColor = System.Drawing.Color.Transparent;
            this.portStatusLbl.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold);
            this.portStatusLbl.Location = new System.Drawing.Point(100, 10);
            this.portStatusLbl.Name = "portStatusLbl";
            this.portStatusLbl.Size = new System.Drawing.Size(43, 16);
            this.portStatusLbl.TabIndex = 20;
            this.portStatusLbl.Text = "N / A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Square721 BT", 9.75F);
            this.label4.Location = new System.Drawing.Point(9, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Port Durumu : ";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.White;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.close.Location = new System.Drawing.Point(504, 6);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(54, 24);
            this.close.TabIndex = 18;
            this.close.Text = "GİZLE";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImage = global::bReducer.Properties.Resources.dialogBg;
            this.groupBox2.Controls.Add(this.saveSettings);
            this.groupBox2.Controls.Add(this.autoStart);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.yuzdeScroll);
            this.groupBox2.Controls.Add(this.yuzdeText);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(304, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 146);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // saveSettings
            // 
            this.saveSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(44)))), ((int)(((byte)(32)))));
            this.saveSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveSettings.FlatAppearance.BorderSize = 0;
            this.saveSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.saveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSettings.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveSettings.ForeColor = System.Drawing.Color.White;
            this.saveSettings.Location = new System.Drawing.Point(9, 112);
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.Size = new System.Drawing.Size(252, 28);
            this.saveSettings.TabIndex = 14;
            this.saveSettings.Text = "Ayarları Kaydet";
            this.saveSettings.UseVisualStyleBackColor = false;
            this.saveSettings.Click += new System.EventHandler(this.saveSettings_Click);
            // 
            // autoStart
            // 
            this.autoStart.AutoSize = true;
            this.autoStart.BackColor = System.Drawing.Color.Transparent;
            this.autoStart.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.autoStart.Location = new System.Drawing.Point(15, 75);
            this.autoStart.Name = "autoStart";
            this.autoStart.Size = new System.Drawing.Size(251, 20);
            this.autoStart.TabIndex = 10;
            this.autoStart.Text = "Windows açılışında otomatik başlat ?";
            this.autoStart.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ekran parlaklığı yüzdesi ?";
            // 
            // yuzdeScroll
            // 
            this.yuzdeScroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.yuzdeScroll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.yuzdeScroll.Location = new System.Drawing.Point(6, 34);
            this.yuzdeScroll.Maximum = 100;
            this.yuzdeScroll.Name = "yuzdeScroll";
            this.yuzdeScroll.Size = new System.Drawing.Size(231, 45);
            this.yuzdeScroll.TabIndex = 12;
            this.yuzdeScroll.TickFrequency = 5;
            this.yuzdeScroll.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.yuzdeScroll.Scroll += new System.EventHandler(this.yuzdeScroll_Scroll);
            // 
            // yuzdeText
            // 
            this.yuzdeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yuzdeText.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yuzdeText.Location = new System.Drawing.Point(234, 37);
            this.yuzdeText.MaxLength = 3;
            this.yuzdeText.Name = "yuzdeText";
            this.yuzdeText.Size = new System.Drawing.Size(27, 20);
            this.yuzdeText.TabIndex = 13;
            this.yuzdeText.Text = "0";
            this.yuzdeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yuzdeText.TextChanged += new System.EventHandler(this.yuzdeText_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::bReducer.Properties.Resources.dialogBg;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(17, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 146);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Square721 BT", 9.75F);
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 41);
            this.label2.TabIndex = 7;
            this.label2.Text = "Işığın durumuna göre bilgisayarın ekran parlaklığını değiştiren uygulama projesi." +
    "";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Square721 BT", 9F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 45);
            this.label3.TabIndex = 7;
            this.label3.Text = "Üsame Fethullah AVCI\r\nYusup ÇARİYEW\r\nİbrahim PATIR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(6, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Katkıda Bulunanlar";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(6, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Proje Açıklaması";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::bReducer.Properties.Resources.bReducer;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(26, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 32);
            this.button2.TabIndex = 22;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(590, 246);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(44)))), ((int)(((byte)(32)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ß-Reducer";
            this.TransparencyKey = System.Drawing.Color.DarkRed;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.iconMenu.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yuzdeScroll)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox autoStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar yuzdeScroll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem menuKapat;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip iconMenu;
        private System.Windows.Forms.Timer checker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label readedDataLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label portStatusLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveSettings;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox yuzdeText;

    }
}

