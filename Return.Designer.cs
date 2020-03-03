namespace Laba5
{
    partial class Return
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
            this.Title = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Replace = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Result)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.Location = new System.Drawing.Point(12, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(200, 20);
            this.Title.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.Location = new System.Drawing.Point(218, 10);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 1;
            this.Search.Text = "Найти";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Replace
            // 
            this.Replace.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Replace.Location = new System.Drawing.Point(113, 246);
            this.Replace.Name = "Replace";
            this.Replace.Size = new System.Drawing.Size(75, 23);
            this.Replace.TabIndex = 3;
            this.Replace.Text = "Вернуть";
            this.Replace.UseVisualStyleBackColor = true;
            this.Replace.Click += new System.EventHandler(this.Replace_Click);
            // 
            // Result
            // 
            this.Result.AllowUserToAddRows = false;
            this.Result.AllowUserToDeleteRows = false;
            this.Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Result.Location = new System.Drawing.Point(12, 39);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(280, 201);
            this.Result.TabIndex = 4;
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 281);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Replace);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Title);
            this.Name = "Return";
            this.Text = "Отдать";
            ((System.ComponentModel.ISupportInitialize)(this.Result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Replace;
        private System.Windows.Forms.DataGridView Result;
    }
}