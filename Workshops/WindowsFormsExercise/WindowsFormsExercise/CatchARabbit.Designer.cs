namespace WindowsFormsExercise
{
    partial class CatchARabbit
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
            this.btnRabbit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRabbit
            // 
            this.btnRabbit.BackgroundImage = global::WindowsFormsExercise.Properties.Resources.rabbit;
            this.btnRabbit.Location = new System.Drawing.Point(111, 23);
            this.btnRabbit.Name = "btnRabbit";
            this.btnRabbit.Size = new System.Drawing.Size(106, 113);
            this.btnRabbit.TabIndex = 0;
            this.btnRabbit.Text = "button1";
            this.btnRabbit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRabbit.UseVisualStyleBackColor = true;
            this.btnRabbit.Click += new System.EventHandler(this.btnRabbit_Click);
            this.btnRabbit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRabbit_MouseDown);
            this.btnRabbit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRabbit_MouseMove);
            this.btnRabbit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRabbit_MouseUp);
            // 
            // CatchARabbit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnRabbit);
            this.Name = "CatchARabbit";
            this.Text = "CatchARabbit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRabbit;
    }
}