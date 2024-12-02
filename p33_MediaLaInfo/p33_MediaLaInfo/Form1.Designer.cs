namespace p33_MediaLaInfo
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
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMedia = new System.Windows.Forms.Label();
            this.buttonIesire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(205, 194);
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(416, 42);
            this.textBoxNote.TabIndex = 0;
            this.textBoxNote.TextChanged += new System.EventHandler(this.textBoxNote_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palace Script MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "scrie notele fara spatii:";
            // 
            // labelMedia
            // 
            this.labelMedia.AutoSize = true;
            this.labelMedia.Font = new System.Drawing.Font("Palace Script MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedia.Location = new System.Drawing.Point(195, 266);
            this.labelMedia.Name = "labelMedia";
            this.labelMedia.Size = new System.Drawing.Size(270, 60);
            this.labelMedia.TabIndex = 2;
            this.labelMedia.Text = "media apare aici:";
            // 
            // buttonIesire
            // 
            this.buttonIesire.BackColor = System.Drawing.Color.Pink;
            this.buttonIesire.Font = new System.Drawing.Font("Palace Script MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIesire.Location = new System.Drawing.Point(649, 430);
            this.buttonIesire.Name = "buttonIesire";
            this.buttonIesire.Size = new System.Drawing.Size(127, 61);
            this.buttonIesire.TabIndex = 3;
            this.buttonIesire.Text = "iesire";
            this.buttonIesire.UseVisualStyleBackColor = false;
            this.buttonIesire.Click += new System.EventHandler(this.buttonIesire_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(817, 520);
            this.Controls.Add(this.buttonIesire);
            this.Controls.Add(this.labelMedia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNote);
            this.Font = new System.Drawing.Font("Palace Script MT", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMedia;
        private System.Windows.Forms.Button buttonIesire;
    }
}

