namespace SMauto
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
            this.B_Clear = new System.Windows.Forms.Button();
            this.B_FileCheck = new System.Windows.Forms.Button();
            this.L_SMauto = new System.Windows.Forms.Label();
            this.TB_Tweet1 = new System.Windows.Forms.TextBox();
            this.L_Tweet1 = new System.Windows.Forms.Label();
            this.B_Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_Clear
            // 
            this.B_Clear.Location = new System.Drawing.Point(103, 129);
            this.B_Clear.Name = "B_Clear";
            this.B_Clear.Size = new System.Drawing.Size(75, 23);
            this.B_Clear.TabIndex = 1;
            this.B_Clear.Text = "Clear";
            this.B_Clear.UseVisualStyleBackColor = true;
            this.B_Clear.Click += new System.EventHandler(this.B_Clear_Click);
            // 
            // B_FileCheck
            // 
            this.B_FileCheck.Location = new System.Drawing.Point(103, 100);
            this.B_FileCheck.Name = "B_FileCheck";
            this.B_FileCheck.Size = new System.Drawing.Size(75, 23);
            this.B_FileCheck.TabIndex = 2;
            this.B_FileCheck.Text = "File Check";
            this.B_FileCheck.UseVisualStyleBackColor = true;
            this.B_FileCheck.Click += new System.EventHandler(this.B_File_Click);
            // 
            // L_SMauto
            // 
            this.L_SMauto.AutoSize = true;
            this.L_SMauto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_SMauto.Location = new System.Drawing.Point(12, 9);
            this.L_SMauto.Name = "L_SMauto";
            this.L_SMauto.Size = new System.Drawing.Size(86, 25);
            this.L_SMauto.TabIndex = 3;
            this.L_SMauto.Text = "SMauto";
            // 
            // TB_Tweet1
            // 
            this.TB_Tweet1.Location = new System.Drawing.Point(306, 100);
            this.TB_Tweet1.Name = "TB_Tweet1";
            this.TB_Tweet1.Size = new System.Drawing.Size(100, 20);
            this.TB_Tweet1.TabIndex = 4;
            // 
            // L_Tweet1
            // 
            this.L_Tweet1.AutoSize = true;
            this.L_Tweet1.Location = new System.Drawing.Point(257, 103);
            this.L_Tweet1.Name = "L_Tweet1";
            this.L_Tweet1.Size = new System.Drawing.Size(43, 13);
            this.L_Tweet1.TabIndex = 5;
            this.L_Tweet1.Text = "Tweet1";
            this.L_Tweet1.Click += new System.EventHandler(this.L_Tweet1_Click);
            // 
            // B_Update
            // 
            this.B_Update.Location = new System.Drawing.Point(103, 158);
            this.B_Update.Name = "B_Update";
            this.B_Update.Size = new System.Drawing.Size(75, 23);
            this.B_Update.TabIndex = 6;
            this.B_Update.Text = "Update";
            this.B_Update.UseVisualStyleBackColor = true;
            this.B_Update.Click += new System.EventHandler(this.B_Update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B_Update);
            this.Controls.Add(this.L_Tweet1);
            this.Controls.Add(this.TB_Tweet1);
            this.Controls.Add(this.L_SMauto);
            this.Controls.Add(this.B_FileCheck);
            this.Controls.Add(this.B_Clear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button B_Clear;
        private System.Windows.Forms.Button B_FileCheck;
        private System.Windows.Forms.Label L_SMauto;
        private System.Windows.Forms.TextBox TB_Tweet1;
        private System.Windows.Forms.Label L_Tweet1;
        private System.Windows.Forms.Button B_Update;
    }
}

