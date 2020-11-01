namespace Supermarket
{
    partial class Supermarkt
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.lbProduct = new System.Windows.Forms.Label();
            this.lbCountOfProduct = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.btExportToCsv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.SuspendLayout();
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(163, 34);
            this.tbItemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(167, 22);
            this.tbItemName.TabIndex = 0;
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(269, 75);
            this.nudCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(61, 22);
            this.nudCount.TabIndex = 1;
            this.nudCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbProduct
            // 
            this.lbProduct.AutoSize = true;
            this.lbProduct.Location = new System.Drawing.Point(27, 34);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(92, 17);
            this.lbProduct.TabIndex = 2;
            this.lbProduct.Text = "Produktname";
            // 
            // lbCountOfProduct
            // 
            this.lbCountOfProduct.AutoSize = true;
            this.lbCountOfProduct.Location = new System.Drawing.Point(27, 76);
            this.lbCountOfProduct.Name = "lbCountOfProduct";
            this.lbCountOfProduct.Size = new System.Drawing.Size(51, 17);
            this.lbCountOfProduct.TabIndex = 2;
            this.lbCountOfProduct.Text = "Anzahl";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(30, 114);
            this.btAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(128, 31);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Hinzufügen";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(200, 114);
            this.btRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(128, 31);
            this.btRemove.TabIndex = 3;
            this.btRemove.Text = "Entfernen";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.ItemHeight = 16;
            this.lbItems.Location = new System.Drawing.Point(30, 206);
            this.lbItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(300, 196);
            this.lbItems.TabIndex = 4;

            // 
            // btExportToCsv
            // 
            this.btExportToCsv.Location = new System.Drawing.Point(30, 158);
            this.btExportToCsv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExportToCsv.Name = "btExportToCsv";
            this.btExportToCsv.Size = new System.Drawing.Size(298, 31);
            this.btExportToCsv.TabIndex = 5;
            this.btExportToCsv.Text = "Exportieren";
            this.btExportToCsv.UseVisualStyleBackColor = true;
            this.btExportToCsv.Click += new System.EventHandler(this.btExportToCsv_Click);
            // 
            // Supermarkt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 434);
            this.Controls.Add(this.btExportToCsv);
            this.Controls.Add(this.lbItems);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lbCountOfProduct);
            this.Controls.Add(this.lbProduct);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.tbItemName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Supermarkt";
            this.Text = "Supermarkt";
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.Label lbProduct;
        private System.Windows.Forms.Label lbCountOfProduct;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.Button btExportToCsv;
    }
}

