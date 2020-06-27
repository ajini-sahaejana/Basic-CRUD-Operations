namespace Lec9
{
    partial class FormInsert
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.insertSubmit = new System.Windows.Forms.Button();
            this.insertBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(160, 83);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(100, 20);
            this.usernameText.TabIndex = 3;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(160, 137);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(100, 20);
            this.passwordText.TabIndex = 4;
            // 
            // insertSubmit
            // 
            this.insertSubmit.Location = new System.Drawing.Point(185, 232);
            this.insertSubmit.Name = "insertSubmit";
            this.insertSubmit.Size = new System.Drawing.Size(75, 23);
            this.insertSubmit.TabIndex = 5;
            this.insertSubmit.Text = "Submit";
            this.insertSubmit.UseVisualStyleBackColor = true;
            this.insertSubmit.Click += new System.EventHandler(this.insertSubmit_Click);
            // 
            // insertBack
            // 
            this.insertBack.Location = new System.Drawing.Point(69, 232);
            this.insertBack.Name = "insertBack";
            this.insertBack.Size = new System.Drawing.Size(75, 23);
            this.insertBack.TabIndex = 6;
            this.insertBack.Text = "Back";
            this.insertBack.UseVisualStyleBackColor = true;
            this.insertBack.Click += new System.EventHandler(this.insertBack_Click);
            // 
            // FormInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.insertBack);
            this.Controls.Add(this.insertSubmit);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormInsert";
            this.RightToLeftLayout = true;
            this.Text = "FormInsert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button insertSubmit;
        private System.Windows.Forms.Button insertBack;
    }
}

