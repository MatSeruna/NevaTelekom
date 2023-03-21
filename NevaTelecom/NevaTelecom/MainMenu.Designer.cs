namespace NevaTelecom
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_tarifs = new System.Windows.Forms.Button();
            this.button_check = new System.Windows.Forms.Button();
            this.button_news = new System.Windows.Forms.Button();
            this.button_connect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 58);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(229, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 108);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // button_tarifs
            // 
            this.button_tarifs.Location = new System.Drawing.Point(91, 229);
            this.button_tarifs.Name = "button_tarifs";
            this.button_tarifs.Size = new System.Drawing.Size(176, 41);
            this.button_tarifs.TabIndex = 2;
            this.button_tarifs.Text = "Тарифы";
            this.button_tarifs.UseVisualStyleBackColor = true;
            this.button_tarifs.Click += new System.EventHandler(this.button_tarifs_Click);
            // 
            // button_check
            // 
            this.button_check.Location = new System.Drawing.Point(91, 285);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(176, 41);
            this.button_check.TabIndex = 3;
            this.button_check.Text = "Проверка возможности\nподключения";
            this.button_check.UseVisualStyleBackColor = true;
            // 
            // button_news
            // 
            this.button_news.Location = new System.Drawing.Point(91, 342);
            this.button_news.Name = "button_news";
            this.button_news.Size = new System.Drawing.Size(176, 41);
            this.button_news.TabIndex = 4;
            this.button_news.Text = "Новости";
            this.button_news.UseVisualStyleBackColor = true;
            this.button_news.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(91, 400);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(176, 41);
            this.button_connect.TabIndex = 5;
            this.button_connect.Text = "Подключить услугу";
            this.button_connect.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 630);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.button_news);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.button_tarifs);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button_tarifs;
        private Button button_check;
        private Button button_news;
        private Button button_connect;
    }
}