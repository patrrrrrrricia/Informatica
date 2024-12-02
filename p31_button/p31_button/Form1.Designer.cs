namespace p31_button
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
            this.ButtonIesire = new System.Windows.Forms.Button();
            this.ButtonImagine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonIesire
            // 
            this.ButtonIesire.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonIesire.Font = new System.Drawing.Font("Palace Script MT", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonIesire.Location = new System.Drawing.Point(195, 580);
            this.ButtonIesire.Name = "ButtonIesire";
            this.ButtonIesire.Size = new System.Drawing.Size(198, 89);
            this.ButtonIesire.TabIndex = 1;
            this.ButtonIesire.Text = "Iesire";
            this.ButtonIesire.UseVisualStyleBackColor = true;
            this.ButtonIesire.Click += new System.EventHandler(this.ButtonIesire_Click);
            // 
            // ButtonImagine
            // 
            this.ButtonImagine.BackgroundImage = global::p31_button.Properties.Resources._11;
            this.ButtonImagine.Location = new System.Drawing.Point(74, 57);
            this.ButtonImagine.Name = "ButtonImagine";
            this.ButtonImagine.Size = new System.Drawing.Size(458, 483);
            this.ButtonImagine.TabIndex = 0;
            this.ButtonImagine.UseVisualStyleBackColor = true;
            this.ButtonImagine.MouseEnter += new System.EventHandler(this.ButtonImagine_MouseEnter);
            this.ButtonImagine.MouseLeave += new System.EventHandler(this.ButtonImagine_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonIesire;
            this.ClientSize = new System.Drawing.Size(636, 741);
            this.Controls.Add(this.ButtonIesire);
            this.Controls.Add(this.ButtonImagine);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonImagine;
        private System.Windows.Forms.Button ButtonIesire;
    }
}

