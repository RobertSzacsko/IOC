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
            this.Grass = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grass)).BeginInit();
            this.SuspendLayout();
            // 
            // Grass
            // 
            this.Grass.BackColor = System.Drawing.Color.Transparent;
            this.Grass.BackgroundImage = global::IOC.Properties.Resources.Grass_PNG;
            this.Grass.Image = global::IOC.Properties.Resources.Grass_PNG;
            this.Grass.InitialImage = global::IOC.Properties.Resources.Grass_PNG;
            this.Grass.Location = new System.Drawing.Point(-5, 388);
            this.Grass.Name = "Grass";
            this.Grass.Size = new System.Drawing.Size(1093, 278);
            this.Grass.TabIndex = 0;
            this.Grass.TabStop = false;
            // 
            // GamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.Grass);
            this.MaximumSize = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "GamePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GamePage";
            this.Load += new System.EventHandler(this.GamePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Grass;
    }
}