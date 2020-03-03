namespace Laba5
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Result = new System.Windows.Forms.DataGridView();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonGenre = new System.Windows.Forms.Button();
            this.ButtonTake = new System.Windows.Forms.Button();
            this.ButtonReturn = new System.Windows.Forms.Button();
            this.ButtonDebt = new System.Windows.Forms.Button();
            this.NewFilm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Result)).BeginInit();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.AllowUserToAddRows = false;
            this.Result.AllowUserToDeleteRows = false;
            this.Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Result.Location = new System.Drawing.Point(12, 41);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(400, 148);
            this.Result.TabIndex = 1;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSearch.Location = new System.Drawing.Point(12, 12);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(400, 20);
            this.TextBoxSearch.TabIndex = 2;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSearch.Location = new System.Drawing.Point(418, 12);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(75, 23);
            this.ButtonSearch.TabIndex = 3;
            this.ButtonSearch.Text = "Найти";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonGenre
            // 
            this.ButtonGenre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonGenre.Location = new System.Drawing.Point(418, 41);
            this.ButtonGenre.Name = "ButtonGenre";
            this.ButtonGenre.Size = new System.Drawing.Size(75, 23);
            this.ButtonGenre.TabIndex = 4;
            this.ButtonGenre.Text = "Жанры";
            this.ButtonGenre.UseVisualStyleBackColor = true;
            this.ButtonGenre.Click += new System.EventHandler(this.ButtonGenre_Click);
            // 
            // ButtonTake
            // 
            this.ButtonTake.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonTake.Location = new System.Drawing.Point(418, 70);
            this.ButtonTake.Name = "ButtonTake";
            this.ButtonTake.Size = new System.Drawing.Size(75, 23);
            this.ButtonTake.TabIndex = 5;
            this.ButtonTake.Text = "Взять";
            this.ButtonTake.UseVisualStyleBackColor = true;
            this.ButtonTake.Click += new System.EventHandler(this.ButtonTake_Click);
            // 
            // ButtonReturn
            // 
            this.ButtonReturn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonReturn.Location = new System.Drawing.Point(418, 99);
            this.ButtonReturn.Name = "ButtonReturn";
            this.ButtonReturn.Size = new System.Drawing.Size(75, 23);
            this.ButtonReturn.TabIndex = 6;
            this.ButtonReturn.Text = "Отдать";
            this.ButtonReturn.UseVisualStyleBackColor = true;
            this.ButtonReturn.Click += new System.EventHandler(this.ButtonReturn_Click);
            // 
            // ButtonDebt
            // 
            this.ButtonDebt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonDebt.Location = new System.Drawing.Point(418, 128);
            this.ButtonDebt.Name = "ButtonDebt";
            this.ButtonDebt.Size = new System.Drawing.Size(75, 23);
            this.ButtonDebt.TabIndex = 7;
            this.ButtonDebt.Text = "Долги";
            this.ButtonDebt.UseVisualStyleBackColor = true;
            this.ButtonDebt.Click += new System.EventHandler(this.ButtonDebt_Click);
            // 
            // NewFilm
            // 
            this.NewFilm.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NewFilm.Location = new System.Drawing.Point(418, 157);
            this.NewFilm.Name = "NewFilm";
            this.NewFilm.Size = new System.Drawing.Size(75, 23);
            this.NewFilm.TabIndex = 8;
            this.NewFilm.Text = "Новый";
            this.NewFilm.UseVisualStyleBackColor = true;
            this.NewFilm.Click += new System.EventHandler(this.NewFilm_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 201);
            this.Controls.Add(this.NewFilm);
            this.Controls.Add(this.ButtonDebt);
            this.Controls.Add(this.ButtonReturn);
            this.Controls.Add(this.ButtonTake);
            this.Controls.Add(this.ButtonGenre);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.Result);
            this.Name = "Main";
            this.Text = "Прокат";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Result;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonGenre;
        private System.Windows.Forms.Button ButtonTake;
        private System.Windows.Forms.Button ButtonReturn;
        private System.Windows.Forms.Button ButtonDebt;
        private System.Windows.Forms.Button NewFilm;
    }
}

