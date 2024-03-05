namespace Windown_programming_17_1
{
    partial class TeacherForm
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
            this.ucInformation1 = new Windown_programming_17_1.UCInformation();
            this.SuspendLayout();
            // 
            // ucInformation1
            // 
            this.ucInformation1.Location = new System.Drawing.Point(12, -19);
            this.ucInformation1.Name = "ucInformation1";
            this.ucInformation1.Size = new System.Drawing.Size(776, 457);
            this.ucInformation1.TabIndex = 0;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 459);
            this.Controls.Add(this.ucInformation1);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UCInformation ucInformation1;
    }
}