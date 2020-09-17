namespace AutoTranslator
{
    partial class FormTranslate
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
            this.components = new System.ComponentModel.Container();
            this.labelSentence = new System.Windows.Forms.Label();
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelSentence
            // 
            this.labelSentence.AutoEllipsis = true;
            this.labelSentence.Location = new System.Drawing.Point(12, 9);
            this.labelSentence.Name = "labelSentence";
            this.labelSentence.Size = new System.Drawing.Size(72, 15);
            this.labelSentence.TabIndex = 0;
            this.labelSentence.Text = "복사된 값";
            this.labelSentence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSentence.Click += new System.EventHandler(this.label1_Click);
            // 
            // timerClose
            // 
            this.timerClose.Interval = 3000;
            // 
            // FormTranslate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1095, 132);
            this.Controls.Add(this.labelSentence);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTranslate";
            this.Text = "FormTranslate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSentence;
        private System.Windows.Forms.Timer timerClose;
    }
}