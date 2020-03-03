namespace Laba5
{
    partial class Take
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
            this.NameFilm = new System.Windows.Forms.TextBox();
            this.SearchContact = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Contact = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Give = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameFilm
            // 
            this.NameFilm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameFilm.Location = new System.Drawing.Point(12, 12);
            this.NameFilm.Name = "NameFilm";
            this.NameFilm.Size = new System.Drawing.Size(400, 20);
            this.NameFilm.TabIndex = 0;
            // 
            // SearchContact
            // 
            this.SearchContact.Location = new System.Drawing.Point(12, 38);
            this.SearchContact.Name = "SearchContact";
            this.SearchContact.Size = new System.Drawing.Size(100, 20);
            this.SearchContact.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(12, 64);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 2;
            this.Search.Text = "Найти";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Contact
            // 
            this.Contact.AutoSize = true;
            this.Contact.Location = new System.Drawing.Point(118, 41);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(48, 13);
            this.Contact.TabIndex = 3;
            this.Contact.Text = "Контакт";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(93, 64);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 4;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Give
            // 
            this.Give.Location = new System.Drawing.Point(174, 64);
            this.Give.Name = "Give";
            this.Give.Size = new System.Drawing.Size(75, 23);
            this.Give.TabIndex = 5;
            this.Give.Text = "Дать";
            this.Give.UseVisualStyleBackColor = true;
            this.Give.Click += new System.EventHandler(this.Give_Click);
            // 
            // Take
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 96);
            this.Controls.Add(this.Give);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchContact);
            this.Controls.Add(this.NameFilm);
            this.Name = "Take";
            this.Text = "Взять";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameFilm;
        private System.Windows.Forms.TextBox SearchContact;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Give;
    }
}