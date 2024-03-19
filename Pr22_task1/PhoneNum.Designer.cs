namespace Pr22_task1
{
    partial class PhoneNumbersForm
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
            this.dgvMainTable = new System.Windows.Forms.DataGridView();
            this.btExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMainTable
            // 
            this.dgvMainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainTable.Location = new System.Drawing.Point(12, 12);
            this.dgvMainTable.Name = "dgvMainTable";
            this.dgvMainTable.Size = new System.Drawing.Size(282, 267);
            this.dgvMainTable.TabIndex = 0;
            // 
            // btExcel
            // 
            this.btExcel.Location = new System.Drawing.Point(12, 285);
            this.btExcel.Name = "btExcel";
            this.btExcel.Size = new System.Drawing.Size(282, 35);
            this.btExcel.TabIndex = 1;
            this.btExcel.Text = "В экзель";
            this.btExcel.UseVisualStyleBackColor = true;
            this.btExcel.Click += new System.EventHandler(this.btExcel_Click);
            // 
            // PhoneNumbersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 332);
            this.Controls.Add(this.btExcel);
            this.Controls.Add(this.dgvMainTable);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "PhoneNumbersForm";
            this.Text = "Справочник телефонов";
            this.Load += new System.EventHandler(this.PhoneNumbersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMainTable;
        private System.Windows.Forms.Button btExcel;
    }
}

