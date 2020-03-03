namespace Laba5
{
    partial class NewFilm
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
            this.Add = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.ReleaseDate = new System.Windows.Forms.Label();
            this.TextBoxPrice = new System.Windows.Forms.TextBox();
            this.TextBoxTitle = new System.Windows.Forms.TextBox();
            this.TextBoxDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Add.Location = new System.Drawing.Point(51, 129);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 0;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(12, 9);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(33, 13);
            this.Price.TabIndex = 1;
            this.Price.Text = "Цена";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(12, 48);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(57, 13);
            this.Title.TabIndex = 2;
            this.Title.Text = "Название";
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.AutoSize = true;
            this.ReleaseDate.Location = new System.Drawing.Point(12, 87);
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.Size = new System.Drawing.Size(73, 13);
            this.ReleaseDate.TabIndex = 3;
            this.ReleaseDate.Text = "Дата выхода";
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPrice.Location = new System.Drawing.Point(12, 25);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(160, 20);
            this.TextBoxPrice.TabIndex = 4;
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxTitle.Location = new System.Drawing.Point(12, 64);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.Size = new System.Drawing.Size(160, 20);
            this.TextBoxTitle.TabIndex = 5;
            // 
            // TextBoxDate
            // 
            this.TextBoxDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDate.Location = new System.Drawing.Point(12, 103);
            this.TextBoxDate.Name = "TextBoxDate";
            this.TextBoxDate.Size = new System.Drawing.Size(160, 20);
            this.TextBoxDate.TabIndex = 6;
            // 
            // NewFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.TextBoxDate);
            this.Controls.Add(this.TextBoxTitle);
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(this.ReleaseDate);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Add);
            this.Name = "NewFilm";
            this.Text = "Новый";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label ReleaseDate;
        private System.Windows.Forms.TextBox TextBoxPrice;
        private System.Windows.Forms.TextBox TextBoxTitle;
        private System.Windows.Forms.TextBox TextBoxDate;
    }
}