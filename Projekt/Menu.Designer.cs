namespace Projekt
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.autorzy = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.koniec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-15, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // autorzy
            // 
            this.autorzy.Location = new System.Drawing.Point(30, 340);
            this.autorzy.Name = "autorzy";
            this.autorzy.Size = new System.Drawing.Size(150, 50);
            this.autorzy.TabIndex = 1;
            this.autorzy.Text = "Autorzy";
            this.autorzy.UseVisualStyleBackColor = true;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(30, 140);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(150, 50);
            this.start.TabIndex = 2;
            this.start.Text = "Rozpocznij gre";
            this.start.UseVisualStyleBackColor = true;
            // 
            // koniec
            // 
            this.koniec.Location = new System.Drawing.Point(30, 440);
            this.koniec.Name = "koniec";
            this.koniec.Size = new System.Drawing.Size(150, 50);
            this.koniec.TabIndex = 3;
            this.koniec.Text = "Koniec gry";
            this.koniec.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.koniec);
            this.Controls.Add(this.start);
            this.Controls.Add(this.autorzy);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button autorzy;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button koniec;
    }
}