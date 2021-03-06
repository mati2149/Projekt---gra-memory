﻿namespace Projekt
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.latwe = new System.Windows.Forms.Button();
            this.trudne = new System.Windows.Forms.Button();
            this.instrukcja = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.autorzy.Location = new System.Drawing.Point(30, 370);
            this.autorzy.Name = "autorzy";
            this.autorzy.Size = new System.Drawing.Size(150, 50);
            this.autorzy.TabIndex = 1;
            this.autorzy.Text = "Autorzy";
            this.autorzy.UseVisualStyleBackColor = true;
            this.autorzy.Click += new System.EventHandler(this.klawiszAutorzy_Klik);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(30, 140);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(150, 50);
            this.start.TabIndex = 2;
            this.start.Text = "Rozpocznij gre";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.klawiszStart_Klik);
            // 
            // koniec
            // 
            this.koniec.Location = new System.Drawing.Point(30, 470);
            this.koniec.Name = "koniec";
            this.koniec.Size = new System.Drawing.Size(150, 50);
            this.koniec.TabIndex = 3;
            this.koniec.Text = "Koniec gry";
            this.koniec.UseVisualStyleBackColor = true;
            this.koniec.Click += new System.EventHandler(this.klawiszZakończ_Klik);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(400, 350);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 200);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.DoubleClick += new System.EventHandler(this.pictureBox2_DoubleClick);
            // 
            // latwe
            // 
            this.latwe.Location = new System.Drawing.Point(300, 200);
            this.latwe.Name = "latwe";
            this.latwe.Size = new System.Drawing.Size(150, 50);
            this.latwe.TabIndex = 5;
            this.latwe.Text = "Łatwe";
            this.latwe.UseVisualStyleBackColor = true;
            this.latwe.Visible = false;
            this.latwe.Click += new System.EventHandler(this.klawiszLatwe_Klik);
            // 
            // trudne
            // 
            this.trudne.Location = new System.Drawing.Point(550, 200);
            this.trudne.Name = "trudne";
            this.trudne.Size = new System.Drawing.Size(150, 50);
            this.trudne.TabIndex = 6;
            this.trudne.Text = "Trudne";
            this.trudne.UseVisualStyleBackColor = true;
            this.trudne.Visible = false;
            this.trudne.Click += new System.EventHandler(this.klawiszTrudne_Klik);
            // 
            // instrukcja
            // 
            this.instrukcja.Location = new System.Drawing.Point(30, 270);
            this.instrukcja.Name = "instrukcja";
            this.instrukcja.Size = new System.Drawing.Size(150, 50);
            this.instrukcja.TabIndex = 7;
            this.instrukcja.Text = "Jak grać?";
            this.instrukcja.UseVisualStyleBackColor = true;
            this.instrukcja.Click += new System.EventHandler(this.klawiszInstrukcja_Klik);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(30, 270);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(457, 50);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.Visible = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.instrukcja);
            this.Controls.Add(this.trudne);
            this.Controls.Add(this.latwe);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.koniec);
            this.Controls.Add(this.start);
            this.Controls.Add(this.autorzy);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button autorzy;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button koniec;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button latwe;
        private System.Windows.Forms.Button trudne;
        private System.Windows.Forms.Button instrukcja;
        private System.Windows.Forms.TextBox textBox1;
    }
}