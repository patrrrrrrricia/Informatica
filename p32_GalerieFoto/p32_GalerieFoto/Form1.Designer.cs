namespace p32_GalerieFoto
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
            this.LabelNr = new System.Windows.Forms.Label();
            this.PictureBoxImagini = new System.Windows.Forms.PictureBox();
            this.ButtonFirst = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelNrTotal = new System.Windows.Forms.Label();
            this.ButtonPrivious = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonLast = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImagini)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelNr
            // 
            this.LabelNr.AutoSize = true;
            this.LabelNr.Font = new System.Drawing.Font("Palace Script MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNr.Location = new System.Drawing.Point(140, 82);
            this.LabelNr.Name = "LabelNr";
            this.LabelNr.Size = new System.Drawing.Size(45, 60);
            this.LabelNr.TabIndex = 0;
            this.LabelNr.Text = "1";
            // 
            // PictureBoxImagini
            // 
            this.PictureBoxImagini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxImagini.Location = new System.Drawing.Point(113, 154);
            this.PictureBoxImagini.Name = "PictureBoxImagini";
            this.PictureBoxImagini.Size = new System.Drawing.Size(374, 288);
            this.PictureBoxImagini.TabIndex = 3;
            this.PictureBoxImagini.TabStop = false;
            // 
            // ButtonFirst
            // 
            this.ButtonFirst.BackColor = System.Drawing.Color.Pink;
            this.ButtonFirst.Font = new System.Drawing.Font("Palace Script MT", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFirst.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonFirst.Location = new System.Drawing.Point(56, 479);
            this.ButtonFirst.Name = "ButtonFirst";
            this.ButtonFirst.Size = new System.Drawing.Size(94, 40);
            this.ButtonFirst.TabIndex = 4;
            this.ButtonFirst.Text = "<<";
            this.ButtonFirst.UseVisualStyleBackColor = false;
            this.ButtonFirst.Click += new System.EventHandler(this.ButtonFirst_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palace Script MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 60);
            this.label2.TabIndex = 9;
            this.label2.Text = "/";
            // 
            // LabelNrTotal
            // 
            this.LabelNrTotal.AutoSize = true;
            this.LabelNrTotal.Font = new System.Drawing.Font("Palace Script MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNrTotal.Location = new System.Drawing.Point(427, 82);
            this.LabelNrTotal.Name = "LabelNrTotal";
            this.LabelNrTotal.Size = new System.Drawing.Size(46, 60);
            this.LabelNrTotal.TabIndex = 10;
            this.LabelNrTotal.Text = "n";
            // 
            // ButtonPrivious
            // 
            this.ButtonPrivious.BackColor = System.Drawing.Color.Pink;
            this.ButtonPrivious.Enabled = false;
            this.ButtonPrivious.Font = new System.Drawing.Font("Palace Script MT", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPrivious.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonPrivious.Location = new System.Drawing.Point(187, 479);
            this.ButtonPrivious.Name = "ButtonPrivious";
            this.ButtonPrivious.Size = new System.Drawing.Size(94, 40);
            this.ButtonPrivious.TabIndex = 11;
            this.ButtonPrivious.Text = "<";
            this.ButtonPrivious.UseVisualStyleBackColor = false;
            this.ButtonPrivious.Click += new System.EventHandler(this.ButtonPrivious_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.BackColor = System.Drawing.Color.Pink;
            this.ButtonNext.Font = new System.Drawing.Font("Palace Script MT", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonNext.Location = new System.Drawing.Point(318, 479);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(94, 40);
            this.ButtonNext.TabIndex = 12;
            this.ButtonNext.Text = ">";
            this.ButtonNext.UseVisualStyleBackColor = false;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonLast
            // 
            this.ButtonLast.BackColor = System.Drawing.Color.Pink;
            this.ButtonLast.Font = new System.Drawing.Font("Palace Script MT", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLast.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonLast.Location = new System.Drawing.Point(451, 479);
            this.ButtonLast.Name = "ButtonLast";
            this.ButtonLast.Size = new System.Drawing.Size(94, 40);
            this.ButtonLast.TabIndex = 13;
            this.ButtonLast.Text = ">>";
            this.ButtonLast.UseVisualStyleBackColor = false;
            this.ButtonLast.Click += new System.EventHandler(this.ButtonLast_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.Pink;
            this.ButtonExit.Font = new System.Drawing.Font("Palace Script MT", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonExit.Location = new System.Drawing.Point(214, 540);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(170, 44);
            this.ButtonExit.TabIndex = 14;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(605, 635);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonLast);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.ButtonPrivious);
            this.Controls.Add(this.LabelNrTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonFirst);
            this.Controls.Add(this.PictureBoxImagini);
            this.Controls.Add(this.LabelNr);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GalerieFoto";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImagini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNr;
        private System.Windows.Forms.PictureBox PictureBoxImagini;
        private System.Windows.Forms.Button ButtonFirst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelNrTotal;
        private System.Windows.Forms.Button ButtonPrivious;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonLast;
        private System.Windows.Forms.Button ButtonExit;
    }
}

