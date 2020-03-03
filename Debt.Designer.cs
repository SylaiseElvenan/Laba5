namespace Laba5
{
    partial class Debt
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
            this.DebtResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DebtResult)).BeginInit();
            this.SuspendLayout();
            // 
            // DebtResult
            // 
            this.DebtResult.AllowUserToAddRows = false;
            this.DebtResult.AllowUserToDeleteRows = false;
            this.DebtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DebtResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DebtResult.Location = new System.Drawing.Point(12, 12);
            this.DebtResult.Name = "DebtResult";
            this.DebtResult.ReadOnly = true;
            this.DebtResult.Size = new System.Drawing.Size(250, 162);
            this.DebtResult.TabIndex = 0;
            // 
            // Debt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 186);
            this.Controls.Add(this.DebtResult);
            this.Name = "Debt";
            this.Text = "Долги";
            ((System.ComponentModel.ISupportInitialize)(this.DebtResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DebtResult;
    }
}