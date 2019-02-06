namespace Exam_Grades
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
            this.GradeCmd = new System.Windows.Forms.Button();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GradeCmd
            // 
            this.GradeCmd.Location = new System.Drawing.Point(155, 127);
            this.GradeCmd.Name = "GradeCmd";
            this.GradeCmd.Size = new System.Drawing.Size(75, 23);
            this.GradeCmd.TabIndex = 0;
            this.GradeCmd.Text = "Grade";
            this.GradeCmd.UseVisualStyleBackColor = true;
            this.GradeCmd.Click += new System.EventHandler(this.GradeCmd_Click);
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(66, 72);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(258, 20);
            this.txtMark.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter a exam mark from 0-100:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 173);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMark);
            this.Controls.Add(this.GradeCmd);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GradeCmd;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Label label1;
    }
}

