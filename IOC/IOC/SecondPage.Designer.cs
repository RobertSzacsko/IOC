namespace IOC
{
    partial class SecondPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecondPage));
            this.labelReducere = new System.Windows.Forms.Label();
            this.labelRefolosire = new System.Windows.Forms.Label();
            this.labelReciclare = new System.Windows.Forms.Label();
            this.timerRecycleSymbol = new System.Windows.Forms.Timer(this.components);
            this.next_button = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.next_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelReducere
            // 
            this.labelReducere.AutoSize = true;
            this.labelReducere.BackColor = System.Drawing.Color.Transparent;
            this.labelReducere.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReducere.Location = new System.Drawing.Point(448, 0);
            this.labelReducere.Name = "labelReducere";
            this.labelReducere.Size = new System.Drawing.Size(209, 57);
            this.labelReducere.TabIndex = 3;
            this.labelReducere.Text = "REDUCERE";
            // 
            // labelRefolosire
            // 
            this.labelRefolosire.AutoSize = true;
            this.labelRefolosire.BackColor = System.Drawing.Color.Transparent;
            this.labelRefolosire.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRefolosire.Location = new System.Drawing.Point(847, 336);
            this.labelRefolosire.Name = "labelRefolosire";
            this.labelRefolosire.Size = new System.Drawing.Size(236, 57);
            this.labelRefolosire.TabIndex = 4;
            this.labelRefolosire.Text = "REFOLOSIRE";
            // 
            // labelReciclare
            // 
            this.labelReciclare.AutoSize = true;
            this.labelReciclare.BackColor = System.Drawing.Color.Transparent;
            this.labelReciclare.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelReciclare.Location = new System.Drawing.Point(-7, 336);
            this.labelReciclare.Name = "labelReciclare";
            this.labelReciclare.Size = new System.Drawing.Size(214, 57);
            this.labelReciclare.TabIndex = 5;
            this.labelReciclare.Text = "RECICLARE";
            // 
            // next_button
            // 
            this.next_button.BackColor = System.Drawing.Color.Transparent;
            this.next_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next_button.BackgroundImage")));
            this.next_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.next_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_button.Location = new System.Drawing.Point(1002, 12);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(70, 70);
            this.next_button.TabIndex = 6;
            this.next_button.TabStop = false;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 251);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // SecondPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::IOC.Properties.Resources.second;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.labelReciclare);
            this.Controls.Add(this.labelRefolosire);
            this.Controls.Add(this.labelReducere);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "SecondPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecondPage";
            this.Load += new System.EventHandler(this.SecondPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.next_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelReducere;
        private System.Windows.Forms.Label labelRefolosire;
        private System.Windows.Forms.Label labelReciclare;
        private System.Windows.Forms.Timer timerRecycleSymbol;
        private System.Windows.Forms.PictureBox next_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}