namespace Windown_programming_17_1
{
    partial class StudentFormFinal
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
            this.ucInformation2 = new Windown_programming_17_1.UCInformation();
            this.SuspendLayout();
            // 
            // ucInformation2
            // 
            this.ucInformation2.Location = new System.Drawing.Point(28, 12);
            this.ucInformation2.Name = "ucInformation2";
            this.ucInformation2.Size = new System.Drawing.Size(832, 473);
            this.ucInformation2.TabIndex = 0;
            // 
            // StudentFormFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 528);
            this.Controls.Add(this.ucInformation2);
            this.Name = "StudentFormFinal";
            this.Text = "StudentFormFinal";
            this.Load += new System.EventHandler(this.StudentFormFinal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UCInformation ucInformation1;
        private UCInformation ucInformation2;
    }
}