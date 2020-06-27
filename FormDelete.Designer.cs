namespace Lec9
{
    partial class FormDelete
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
            this.delete = new System.Windows.Forms.Button();
            this.idText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(189, 240);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 11;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(164, 91);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(100, 20);
            this.idText.TabIndex = 9;
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
            this.label1.Location = new System.Drawing.Point(117, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "REMOVE RECORD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // deleteBack
            // 
            this.deleteBack.Location = new System.Drawing.Point(73, 240);
            this.deleteBack.Name = "deleteBack";
            this.deleteBack.Size = new System.Drawing.Size(75, 23);
            this.deleteBack.TabIndex = 12;
            this.deleteBack.Text = "Back";
            this.deleteBack.UseVisualStyleBackColor = true;
            this.deleteBack.Click += new System.EventHandler(this.deleteBack_Click);
            // 
            // FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.deleteBack);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDelete";
            this.Text = "FormDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteBack;
    }
}