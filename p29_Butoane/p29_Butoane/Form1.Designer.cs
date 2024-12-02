namespace p29_Butoane
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
            this.ButtonAfisare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonAfisare
            // 
            this.ButtonAfisare.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonAfisare.Font = new System.Drawing.Font("Palace Script MT", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAfisare.ForeColor = System.Drawing.Color.Pink;
            this.ButtonAfisare.Location = new System.Drawing.Point(155, 219);
            this.ButtonAfisare.Name = "ButtonAfisare";
            this.ButtonAfisare.Size = new System.Drawing.Size(307, 81);
            this.ButtonAfisare.TabIndex = 0;
            this.ButtonAfisare.Text = "Apasa aici";
            this.ButtonAfisare.UseVisualStyleBackColor = false;
            this.ButtonAfisare.Click += new System.EventHandler(this.ButtonAfisare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 559);
            this.Controls.Add(this.ButtonAfisare);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAfisare;
    }
}

