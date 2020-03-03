namespace Laba5
{
    partial class AddContact
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
            this.FIO = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.TextBoxFIO = new System.Windows.Forms.TextBox();
            this.TextBoxPhone = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FIO
            // 
            this.FIO.AutoSize = true;
            this.FIO.Location = new System.Drawing.Point(12, 9);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(34, 13);
            this.FIO.TabIndex = 0;
            this.FIO.Text = "ФИО";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(12, 48);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(52, 13);
            this.Phone.TabIndex = 1;
            this.Phone.Text = "Телефон";
            // 
            // TextBoxFIO
            // 
            this.TextBoxFIO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxFIO.Location = new System.Drawing.Point(12, 25);
            this.TextBoxFIO.Name = "TextBoxFIO";
            this.TextBoxFIO.Size = new System.Drawing.Size(180, 20);
            this.TextBoxFIO.TabIndex = 2;
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPhone.Location = new System.Drawing.Point(12, 64);
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.Size = new System.Drawing.Size(180, 20);
            this.TextBoxPhone.TabIndex = 3;
            // 
            // Create
            // 
            this.Create.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Create.Location = new System.Drawing.Point(62, 90);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 4;
            this.Create.Text = "Создать";
            this.Create.UseVisualStyleBackColor = true;
            // 
            // AddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 121);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.TextBoxPhone);
            this.Controls.Add(this.TextBoxFIO);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.FIO);
            this.Name = "AddContact";
            this.Text = "Контакт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FIO;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.TextBox TextBoxFIO;
        private System.Windows.Forms.TextBox TextBoxPhone;
        private System.Windows.Forms.Button Create;
    }
}