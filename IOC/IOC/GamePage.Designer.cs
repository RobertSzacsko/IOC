namespace IOC
{
    partial class GamePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePage));
            this.pictureStartGame = new System.Windows.Forms.PictureBox();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.pictureCosHartie = new System.Windows.Forms.PictureBox();
            this.pictureCosPlastic = new System.Windows.Forms.PictureBox();
            this.pictureCosSticla = new System.Windows.Forms.PictureBox();
            this.paharPlastic = new System.Windows.Forms.PictureBox();
            this.newsPapaerHartie = new System.Windows.Forms.PictureBox();
            this.paharSticla = new System.Windows.Forms.PictureBox();
            this.sucPlastic = new System.Windows.Forms.PictureBox();
            this.sticlaNeagra = new System.Windows.Forms.PictureBox();
            this.cerealeBoxHartie = new System.Windows.Forms.PictureBox();
            this.masinaPlastic = new System.Windows.Forms.PictureBox();
            this.oglindaSticla = new System.Windows.Forms.PictureBox();
            this.lebadaHartie = new System.Windows.Forms.PictureBox();
            this.sound = new System.ComponentModel.BackgroundWorker();
            this.timerIncepeSunetDeIndeput = new System.Windows.Forms.Timer(this.components);
            this.workerForTimerIncepeSunetDeInceput = new System.ComponentModel.BackgroundWorker();
            this.pictureRepeta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStartGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCosHartie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCosPlastic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCosSticla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paharPlastic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsPapaerHartie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paharSticla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucPlastic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sticlaNeagra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerealeBoxHartie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masinaPlastic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oglindaSticla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lebadaHartie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRepeta)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureStartGame
            // 
            this.pictureStartGame.BackColor = System.Drawing.Color.Transparent;
            this.pictureStartGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureStartGame.BackgroundImage")));
            this.pictureStartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureStartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureStartGame.Enabled = false;
            this.pictureStartGame.Location = new System.Drawing.Point(846, 9);
            this.pictureStartGame.Margin = new System.Windows.Forms.Padding(0);
            this.pictureStartGame.Name = "pictureStartGame";
            this.pictureStartGame.Size = new System.Drawing.Size(100, 100);
            this.pictureStartGame.TabIndex = 0;
            this.pictureStartGame.TabStop = false;
            this.pictureStartGame.Click += new System.EventHandler(this.pictureStartGame_Click);
            // 
            // timerGame
            // 
            this.timerGame.Interval = 1000;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Showcard Gothic", 18F);
            this.timeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.timeLabel.Location = new System.Drawing.Point(474, 32);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 30);
            this.timeLabel.TabIndex = 1;
            // 
            // pictureCosHartie
            // 
            this.pictureCosHartie.BackColor = System.Drawing.Color.Transparent;
            this.pictureCosHartie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureCosHartie.BackgroundImage")));
            this.pictureCosHartie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureCosHartie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureCosHartie.Enabled = false;
            this.pictureCosHartie.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureCosHartie.Location = new System.Drawing.Point(230, 255);
            this.pictureCosHartie.Margin = new System.Windows.Forms.Padding(0);
            this.pictureCosHartie.Name = "pictureCosHartie";
            this.pictureCosHartie.Size = new System.Drawing.Size(193, 252);
            this.pictureCosHartie.TabIndex = 2;
            this.pictureCosHartie.TabStop = false;
            this.pictureCosHartie.Click += new System.EventHandler(this.pictureCosHartie_Click);
            // 
            // pictureCosPlastic
            // 
            this.pictureCosPlastic.BackColor = System.Drawing.Color.Transparent;
            this.pictureCosPlastic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureCosPlastic.BackgroundImage")));
            this.pictureCosPlastic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureCosPlastic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureCosPlastic.Enabled = false;
            this.pictureCosPlastic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureCosPlastic.Location = new System.Drawing.Point(435, 270);
            this.pictureCosPlastic.Margin = new System.Windows.Forms.Padding(0);
            this.pictureCosPlastic.Name = "pictureCosPlastic";
            this.pictureCosPlastic.Size = new System.Drawing.Size(206, 252);
            this.pictureCosPlastic.TabIndex = 3;
            this.pictureCosPlastic.TabStop = false;
            this.pictureCosPlastic.Click += new System.EventHandler(this.pictureCosPlastic_Click);
            // 
            // pictureCosSticla
            // 
            this.pictureCosSticla.BackColor = System.Drawing.Color.Transparent;
            this.pictureCosSticla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureCosSticla.BackgroundImage")));
            this.pictureCosSticla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureCosSticla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureCosSticla.Enabled = false;
            this.pictureCosSticla.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureCosSticla.Location = new System.Drawing.Point(656, 290);
            this.pictureCosSticla.Margin = new System.Windows.Forms.Padding(0);
            this.pictureCosSticla.Name = "pictureCosSticla";
            this.pictureCosSticla.Size = new System.Drawing.Size(177, 216);
            this.pictureCosSticla.TabIndex = 4;
            this.pictureCosSticla.TabStop = false;
            this.pictureCosSticla.Click += new System.EventHandler(this.pictureCosSticla_Click);
            // 
            // paharPlastic
            // 
            this.paharPlastic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(146)))), ((int)(((byte)(11)))));
            this.paharPlastic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paharPlastic.BackgroundImage")));
            this.paharPlastic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paharPlastic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paharPlastic.Enabled = false;
            this.paharPlastic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.paharPlastic.Location = new System.Drawing.Point(38, 542);
            this.paharPlastic.Margin = new System.Windows.Forms.Padding(0);
            this.paharPlastic.Name = "paharPlastic";
            this.paharPlastic.Size = new System.Drawing.Size(46, 76);
            this.paharPlastic.TabIndex = 5;
            this.paharPlastic.TabStop = false;
            this.paharPlastic.Click += new System.EventHandler(this.paharPlastic_Click);
            // 
            // newsPapaerHartie
            // 
            this.newsPapaerHartie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(146)))), ((int)(((byte)(11)))));
            this.newsPapaerHartie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newsPapaerHartie.BackgroundImage")));
            this.newsPapaerHartie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newsPapaerHartie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newsPapaerHartie.Enabled = false;
            this.newsPapaerHartie.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.newsPapaerHartie.Location = new System.Drawing.Point(129, 504);
            this.newsPapaerHartie.Margin = new System.Windows.Forms.Padding(0);
            this.newsPapaerHartie.Name = "newsPapaerHartie";
            this.newsPapaerHartie.Size = new System.Drawing.Size(71, 79);
            this.newsPapaerHartie.TabIndex = 6;
            this.newsPapaerHartie.TabStop = false;
            this.newsPapaerHartie.Click += new System.EventHandler(this.newsPapaerHartie_Click);
            // 
            // paharSticla
            // 
            this.paharSticla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(146)))), ((int)(((byte)(11)))));
            this.paharSticla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paharSticla.BackgroundImage")));
            this.paharSticla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paharSticla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paharSticla.Enabled = false;
            this.paharSticla.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.paharSticla.Location = new System.Drawing.Point(230, 542);
            this.paharSticla.Margin = new System.Windows.Forms.Padding(0);
            this.paharSticla.Name = "paharSticla";
            this.paharSticla.Size = new System.Drawing.Size(67, 64);
            this.paharSticla.TabIndex = 7;
            this.paharSticla.TabStop = false;
            this.paharSticla.Click += new System.EventHandler(this.paharSticla_Click);
            // 
            // sucPlastic
            // 
            this.sucPlastic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(146)))), ((int)(((byte)(11)))));
            this.sucPlastic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sucPlastic.BackgroundImage")));
            this.sucPlastic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sucPlastic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sucPlastic.Enabled = false;
            this.sucPlastic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sucPlastic.Location = new System.Drawing.Point(445, 542);
            this.sucPlastic.Margin = new System.Windows.Forms.Padding(0);
            this.sucPlastic.Name = "sucPlastic";
            this.sucPlastic.Size = new System.Drawing.Size(81, 64);
            this.sucPlastic.TabIndex = 8;
            this.sucPlastic.TabStop = false;
            this.sucPlastic.Click += new System.EventHandler(this.sucPlastic_Click);
            // 
            // sticlaNeagra
            // 
            this.sticlaNeagra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(146)))), ((int)(((byte)(11)))));
            this.sticlaNeagra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sticlaNeagra.BackgroundImage")));
            this.sticlaNeagra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sticlaNeagra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sticlaNeagra.Enabled = false;
            this.sticlaNeagra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sticlaNeagra.Location = new System.Drawing.Point(331, 531);
            this.sticlaNeagra.Margin = new System.Windows.Forms.Padding(0);
            this.sticlaNeagra.Name = "sticlaNeagra";
            this.sticlaNeagra.Size = new System.Drawing.Size(81, 118);
            this.sticlaNeagra.TabIndex = 9;
            this.sticlaNeagra.TabStop = false;
            this.sticlaNeagra.Click += new System.EventHandler(this.sticlaNeagra_Click);
            // 
            // cerealeBoxHartie
            // 
            this.cerealeBoxHartie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(146)))), ((int)(((byte)(11)))));
            this.cerealeBoxHartie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cerealeBoxHartie.BackgroundImage")));
            this.cerealeBoxHartie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cerealeBoxHartie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerealeBoxHartie.Enabled = false;
            this.cerealeBoxHartie.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cerealeBoxHartie.Location = new System.Drawing.Point(700, 525);
            this.cerealeBoxHartie.Margin = new System.Windows.Forms.Padding(0);
            this.cerealeBoxHartie.Name = "cerealeBoxHartie";
            this.cerealeBoxHartie.Size = new System.Drawing.Size(115, 93);
            this.cerealeBoxHartie.TabIndex = 10;
            this.cerealeBoxHartie.TabStop = false;
            this.cerealeBoxHartie.Click += new System.EventHandler(this.cerealeBoxHartie_Click);
            // 
            // masinaPlastic
            // 
            this.masinaPlastic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(146)))), ((int)(((byte)(11)))));
            this.masinaPlastic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("masinaPlastic.BackgroundImage")));
            this.masinaPlastic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.masinaPlastic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.masinaPlastic.Enabled = false;
            this.masinaPlastic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.masinaPlastic.Location = new System.Drawing.Point(832, 549);
            this.masinaPlastic.Margin = new System.Windows.Forms.Padding(0);
            this.masinaPlastic.Name = "masinaPlastic";
            this.masinaPlastic.Size = new System.Drawing.Size(114, 100);
            this.masinaPlastic.TabIndex = 11;
            this.masinaPlastic.TabStop = false;
            this.masinaPlastic.Click += new System.EventHandler(this.masinaPlastic_Click);
            // 
            // oglindaSticla
            // 
            this.oglindaSticla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(146)))), ((int)(((byte)(11)))));
            this.oglindaSticla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("oglindaSticla.BackgroundImage")));
            this.oglindaSticla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.oglindaSticla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oglindaSticla.Enabled = false;
            this.oglindaSticla.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.oglindaSticla.Location = new System.Drawing.Point(968, 504);
            this.oglindaSticla.Margin = new System.Windows.Forms.Padding(0);
            this.oglindaSticla.Name = "oglindaSticla";
            this.oglindaSticla.Size = new System.Drawing.Size(104, 89);
            this.oglindaSticla.TabIndex = 12;
            this.oglindaSticla.TabStop = false;
            this.oglindaSticla.Click += new System.EventHandler(this.oglindaSticla_Click);
            // 
            // lebadaHartie
            // 
            this.lebadaHartie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(146)))), ((int)(((byte)(11)))));
            this.lebadaHartie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lebadaHartie.BackgroundImage")));
            this.lebadaHartie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lebadaHartie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lebadaHartie.Enabled = false;
            this.lebadaHartie.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lebadaHartie.Location = new System.Drawing.Point(565, 549);
            this.lebadaHartie.Margin = new System.Windows.Forms.Padding(0);
            this.lebadaHartie.Name = "lebadaHartie";
            this.lebadaHartie.Size = new System.Drawing.Size(97, 100);
            this.lebadaHartie.TabIndex = 13;
            this.lebadaHartie.TabStop = false;
            this.lebadaHartie.Click += new System.EventHandler(this.lebadaHartie_Click);
            // 
            // sound
            // 
            this.sound.DoWork += new System.ComponentModel.DoWorkEventHandler(this.checkIsDone_DoWork);
            // 
            // timerIncepeSunetDeIndeput
            // 
            this.timerIncepeSunetDeIndeput.Enabled = true;
            this.timerIncepeSunetDeIndeput.Interval = 1000;
            this.timerIncepeSunetDeIndeput.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // workerForTimerIncepeSunetDeInceput
            // 
            this.workerForTimerIncepeSunetDeInceput.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerForTimerIncepeSunetDeInceput_DoWork);
            this.workerForTimerIncepeSunetDeInceput.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerForTimerIncepeSunetDeInceput_RunWorkerCompleted);
            // 
            // pictureRepeta
            // 
            this.pictureRepeta.BackColor = System.Drawing.Color.Transparent;
            this.pictureRepeta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureRepeta.BackgroundImage")));
            this.pictureRepeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureRepeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureRepeta.Location = new System.Drawing.Point(749, 23);
            this.pictureRepeta.Margin = new System.Windows.Forms.Padding(0);
            this.pictureRepeta.Name = "pictureRepeta";
            this.pictureRepeta.Size = new System.Drawing.Size(90, 90);
            this.pictureRepeta.TabIndex = 14;
            this.pictureRepeta.TabStop = false;
            this.pictureRepeta.Visible = false;
            this.pictureRepeta.Click += new System.EventHandler(this.pictureRepeta_Click);
            // 
            // GamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.pictureRepeta);
            this.Controls.Add(this.lebadaHartie);
            this.Controls.Add(this.oglindaSticla);
            this.Controls.Add(this.masinaPlastic);
            this.Controls.Add(this.cerealeBoxHartie);
            this.Controls.Add(this.sticlaNeagra);
            this.Controls.Add(this.sucPlastic);
            this.Controls.Add(this.paharSticla);
            this.Controls.Add(this.newsPapaerHartie);
            this.Controls.Add(this.paharPlastic);
            this.Controls.Add(this.pictureCosSticla);
            this.Controls.Add(this.pictureCosPlastic);
            this.Controls.Add(this.pictureCosHartie);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.pictureStartGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "GamePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.GamePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureStartGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCosHartie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCosPlastic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCosSticla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paharPlastic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsPapaerHartie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paharSticla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucPlastic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sticlaNeagra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerealeBoxHartie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masinaPlastic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oglindaSticla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lebadaHartie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRepeta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureStartGame;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.PictureBox pictureCosHartie;
        private System.Windows.Forms.PictureBox pictureCosPlastic;
        private System.Windows.Forms.PictureBox pictureCosSticla;
        private System.Windows.Forms.PictureBox paharPlastic;
        private System.Windows.Forms.PictureBox newsPapaerHartie;
        private System.Windows.Forms.PictureBox paharSticla;
        private System.Windows.Forms.PictureBox sucPlastic;
        private System.Windows.Forms.PictureBox sticlaNeagra;
        private System.Windows.Forms.PictureBox cerealeBoxHartie;
        private System.Windows.Forms.PictureBox masinaPlastic;
        private System.Windows.Forms.PictureBox oglindaSticla;
        private System.Windows.Forms.PictureBox lebadaHartie;
        private System.ComponentModel.BackgroundWorker sound;
        private System.Windows.Forms.Timer timerIncepeSunetDeIndeput;
        private System.ComponentModel.BackgroundWorker workerForTimerIncepeSunetDeInceput;
        private System.Windows.Forms.PictureBox pictureRepeta;
    }
}