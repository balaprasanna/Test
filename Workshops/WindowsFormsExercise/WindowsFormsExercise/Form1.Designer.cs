namespace WindowsFormsExercise
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
            this.btnbutton1 = new System.Windows.Forms.Button();
            this.btnbutton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbutton1
            // 
            this.btnbutton1.BackColor = System.Drawing.Color.LightCoral;
            this.btnbutton1.Location = new System.Drawing.Point(46, 62);
            this.btnbutton1.Name = "btnbutton1";
            this.btnbutton1.Size = new System.Drawing.Size(95, 40);
            this.btnbutton1.TabIndex = 0;
            this.btnbutton1.Text = "button1";
            this.btnbutton1.UseVisualStyleBackColor = false;
            this.btnbutton1.Click += new System.EventHandler(this.btnbutton1_Click);
            // 
            // btnbutton2
            // 
            this.btnbutton2.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnbutton2.Location = new System.Drawing.Point(173, 62);
            this.btnbutton2.Name = "btnbutton2";
            this.btnbutton2.Size = new System.Drawing.Size(75, 23);
            this.btnbutton2.TabIndex = 1;
            this.btnbutton2.Text = "button2";
            this.btnbutton2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnbutton2);
            this.Controls.Add(this.btnbutton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbutton1;
        private System.Windows.Forms.Button btnbutton2;
    }
}

