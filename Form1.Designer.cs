using System;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            
            System.Drawing.Drawing2D.GraphicsPath gPath = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath gPat = new System.Drawing.Drawing2D.GraphicsPath();
            this.upDate = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Label();
            this.pointFire = new System.Windows.Forms.Label();
            this.namePointFire = new System.Windows.Forms.Label();
            this.namePoint = new System.Windows.Forms.Label();
            this.buttonNextTeam = new System.Windows.Forms.Button();
            this.pointTeam1 = new System.Windows.Forms.Label();
            this.pointTeam2 = new System.Windows.Forms.Label();
            this.nameTeam1 = new System.Windows.Forms.Label();
            this.nameTeam2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 

            // upDate
            // 
            gPath.AddEllipse(20,7, this.upDate.Width+20, this.upDate.Height+5);
            this.upDate.Region = new Region(gPath);
            this.upDate.AutoSize = true;
            this.upDate.Location = new System.Drawing.Point(300, 500);
            this.upDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.upDate.Name = "upDate";
            this.upDate.Size = new System.Drawing.Size(140, 40);
            this.upDate.TabIndex = 3;
            this.upDate.Text = "обновить";
            this.upDate.UseVisualStyleBackColor = true;
            this.upDate.Click += new System.EventHandler(this.button1_Click);
            // 
            // point
            // 
            this.point.AutoSize = true;
            this.point.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.point.Location = new System.Drawing.Point(185, 605);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(91, 106);
            this.point.TabIndex = 8;
            this.point.Text = "0";
            this.point.BackColor = Color.Transparent;
            // 
            // pointFire
            // 
            this.pointFire.AutoSize = true;
            this.pointFire.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pointFire.Location = new System.Drawing.Point(607, 605);
            this.pointFire.Name = "pointFire";
            this.pointFire.Size = new System.Drawing.Size(91, 106);
            this.pointFire.TabIndex = 23;
            this.pointFire.Text = "0";
            this.pointFire.BackColor = Color.Transparent;
            // 
            // namePointFire
            // 
            this.namePointFire.AutoSize = true;
            this.namePointFire.Location = new System.Drawing.Point(607, 705);
            this.namePointFire.Name = "namePointFire";
            this.namePointFire.Size = new System.Drawing.Size(104, 15);
            this.namePointFire.TabIndex = 24;
            this.namePointFire.Text = "Сгоревшие очки";
            this.namePointFire.BackColor = Color.Transparent;
            // 
            // namePoint
            // 
            this.namePoint.AutoSize = true;
            this.namePoint.Location = new System.Drawing.Point(193, 705);
            this.namePoint.Name = "namePoint";
            this.namePoint.Size = new System.Drawing.Size(124, 15);
            this.namePoint.TabIndex = 25;
            this.namePoint.Text = "Колличество очков ";
            this.namePoint.BackColor = Color.Transparent;
            // 
            // buttonNextTeam
            // 
            gPat.AddEllipse(0, 7, this.buttonNextTeam.Width + 20, this.buttonNextTeam.Height + 5);
            this.buttonNextTeam.Region = new Region(gPat);
            this.buttonNextTeam.AutoSize = true;
            this.buttonNextTeam.Location = new System.Drawing.Point(480, 500);
            this.buttonNextTeam.Name = "buttonNextTeam";
            this.buttonNextTeam.Size = new System.Drawing.Size(96, 45);
            this.buttonNextTeam.TabIndex = 26;
            this.buttonNextTeam.Text = "переход хода";
            this.buttonNextTeam.UseVisualStyleBackColor = true;
            this.buttonNextTeam.Click += new System.EventHandler(this.button2_Click);
            // 
            // pointTeam1
            // 
            this.pointTeam1.AutoSize = true;
            this.pointTeam1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pointTeam1.Location = new System.Drawing.Point(41, 618);
            this.pointTeam1.Name = "pointTeam1";
            this.pointTeam1.Size = new System.Drawing.Size(46, 54);
            this.pointTeam1.TabIndex = 37;
            this.pointTeam1.Tag = "1";
            this.pointTeam1.Text = "0";
            this.pointTeam1.BackColor = Color.Transparent;
            // 
            // pointTeam2
            // 
            this.pointTeam2.AutoSize = true;
            this.pointTeam2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pointTeam2.Location = new System.Drawing.Point(811, 614);
            this.pointTeam2.Name = "pointTeam2";
            this.pointTeam2.Size = new System.Drawing.Size(46, 54);
            this.pointTeam2.TabIndex = 38;
            this.pointTeam2.Text = "0";
            this.pointTeam2.BackColor = Color.Transparent;
            // 
            // nameTeam1
            // 
            this.nameTeam1.AutoSize = true;
            this.nameTeam1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameTeam1.Location = new System.Drawing.Point(16, 582);
            this.nameTeam1.Name = "nameTeam1";
            this.nameTeam1.Size = new System.Drawing.Size(150, 36);
            this.nameTeam1.TabIndex = 39;
            this.nameTeam1.Tag = "1";
            this.nameTeam1.Text = "Команда 1";
            this.nameTeam1.BackColor = Color.Transparent;
            // 
            // nameTeam2
            // 
            this.nameTeam2.AutoSize = true;
            this.nameTeam2.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameTeam2.Location = new System.Drawing.Point(789, 578);
            this.nameTeam2.Name = "nameTeam2";
            this.nameTeam2.Size = new System.Drawing.Size(150, 36);
            this.nameTeam2.TabIndex = 40;
            this.nameTeam2.Text = "Команда 2";
            this.nameTeam2.BackColor = Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = Properties.Resources.fon;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.nameTeam2);
            this.Controls.Add(this.nameTeam1);
            this.Controls.Add(this.pointTeam2);
            this.Controls.Add(this.pointTeam1);
            this.Controls.Add(this.buttonNextTeam);
            this.Controls.Add(this.namePoint);
            this.Controls.Add(this.namePointFire);
            this.Controls.Add(this.pointFire);
            this.Controls.Add(this.point);
            this.Controls.Add(this.upDate);
            for (int i = 1, 
                        l = 16 ,
                         t = 12; i < 25; i++ )
            { 
                this.pb = new WinFormsApp1.PanelBilder();
                this.Controls.Add(this.pb.PanelInit(i, l,t));

                if (i % 6 == 0 && i > 0) 
                {
                    t = t + 125+5;
                    l = 16;
                }
                else l = l  + 144+10;
                
            }
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Шарики 1.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
        #endregion
        private Button upDate;
        private Label point;
        private Label pointFire;
        private Label namePointFire;
        private Label namePoint;
        private Button buttonNextTeam;
        private Label pointTeam1;
        private Label pointTeam2;
        private Label nameTeam1;
        private Label nameTeam2;
        private PanelBilder pb;
        
    }
}