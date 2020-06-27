namespace Lec9
{
    partial class FormUpdate
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
            this.updateSubmit = new System.Windows.Forms.Button();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.idText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updateBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updateSubmit
            // 
            this.updateSubmit.Location = new System.Drawing.Point(189, 240);
            this.updateSubmit.Name = "updateSubmit";
            this.updateSubmit.Size = new System.Drawing.Size(75, 23);
            this.updateSubmit.TabIndex = 11;
            this.updateSubmit.Text = "Submit";
            this.updateSubmit.UseVisualStyleBackColor = true;
            this.updateSubmit.Click += new System.EventHandler(this.updateSubmit_Click);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(164, 145);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(100, 20);
            this.passwordText.TabIndex = 10;
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(164, 91);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(100, 20);
            this.idText.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "CHANGE PASSWORD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // updateBack
            // 
            this.updateBack.Location = new System.Drawing.Point(73, 240);
            this.updateBack.Name = "updateBack";
            this.updateBack.Size = new System.Drawing.Size(75, 23);
            this.updateBack.TabIndex = 12;
            this.updateBack.Text = "Back";
            this.updateBack.UseVisualStyleBackColor = true;
            this.updateBack.Click += new System.EventHandler(this.updateBack_Click);
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.updateBack);
            this.Controls.Add(this.updateSubmit);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdate";
            this.Text = "FormUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateSubmit;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateBack;
    }
}