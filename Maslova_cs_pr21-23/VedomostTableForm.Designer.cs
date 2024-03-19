namespace Maslova_cs_pr21_23
{
    partial class VedomostTableForm
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
            this.lbGroupName = new System.Windows.Forms.Label();
            this.dgvMainTable = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btDeleteSubject = new System.Windows.Forms.Button();
            this.btAddSubject = new System.Windows.Forms.Button();
            this.cbSubjectName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btFillTable = new System.Windows.Forms.Button();
            this.btCalcAverage = new System.Windows.Forms.Button();
            this.btLoadExcel = new System.Windows.Forms.Button();
            this.openStudentGroupFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbGroupName
            // 
            this.lbGroupName.AutoSize = true;
            this.lbGroupName.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGroupName.Location = new System.Drawing.Point(12, 9);
            this.lbGroupName.Name = "lbGroupName";
            this.lbGroupName.Size = new System.Drawing.Size(196, 33);
            this.lbGroupName.TabIndex = 0;
            this.lbGroupName.Text = "Группа AA-00-00";
            // 
            // dgvMainTable
            // 
            this.dgvMainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainTable.Location = new System.Drawing.Point(18, 57);
            this.dgvMainTable.Name = "dgvMainTable";
            this.dgvMainTable.ReadOnly = true;
            this.dgvMainTable.Size = new System.Drawing.Size(667, 446);
            this.dgvMainTable.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btDeleteSubject);
            this.groupBox1.Controls.Add(this.btAddSubject);
            this.groupBox1.Controls.Add(this.cbSubjectName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(711, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 258);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Предметы";
            // 
            // btDeleteSubject
            // 
            this.btDeleteSubject.Location = new System.Drawing.Point(22, 199);
            this.btDeleteSubject.Name = "btDeleteSubject";
            this.btDeleteSubject.Size = new System.Drawing.Size(187, 37);
            this.btDeleteSubject.TabIndex = 5;
            this.btDeleteSubject.Text = "Удалить последний";
            this.btDeleteSubject.UseVisualStyleBackColor = true;
            this.btDeleteSubject.Click += new System.EventHandler(this.BtDeleteSubject_Click);
            // 
            // btAddSubject
            // 
            this.btAddSubject.Location = new System.Drawing.Point(22, 138);
            this.btAddSubject.Name = "btAddSubject";
            this.btAddSubject.Size = new System.Drawing.Size(187, 37);
            this.btAddSubject.TabIndex = 4;
            this.btAddSubject.Text = "Добавить";
            this.btAddSubject.UseVisualStyleBackColor = true;
            this.btAddSubject.Click += new System.EventHandler(this.BtAddSubject_Click);
            // 
            // cbSubjectName
            // 
            this.cbSubjectName.FormattingEnabled = true;
            this.cbSubjectName.Location = new System.Drawing.Point(25, 81);
            this.cbSubjectName.Name = "cbSubjectName";
            this.cbSubjectName.Size = new System.Drawing.Size(182, 33);
            this.cbSubjectName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название";
            // 
            // btFillTable
            // 
            this.btFillTable.Location = new System.Drawing.Point(711, 338);
            this.btFillTable.Name = "btFillTable";
            this.btFillTable.Size = new System.Drawing.Size(230, 37);
            this.btFillTable.TabIndex = 5;
            this.btFillTable.Text = "Заполнить ведомость";
            this.btFillTable.UseVisualStyleBackColor = true;
            this.btFillTable.Click += new System.EventHandler(this.BtFillTable_Click);
            // 
            // btCalcAverage
            // 
            this.btCalcAverage.Enabled = false;
            this.btCalcAverage.Location = new System.Drawing.Point(711, 390);
            this.btCalcAverage.Name = "btCalcAverage";
            this.btCalcAverage.Size = new System.Drawing.Size(230, 37);
            this.btCalcAverage.TabIndex = 6;
            this.btCalcAverage.Text = "Диаграмма по Ср. Баллу";
            this.btCalcAverage.UseVisualStyleBackColor = true;
            this.btCalcAverage.Click += new System.EventHandler(this.BtCalcAverage_Click);
            // 
            // btLoadExcel
            // 
            this.btLoadExcel.Location = new System.Drawing.Point(711, 445);
            this.btLoadExcel.Name = "btLoadExcel";
            this.btLoadExcel.Size = new System.Drawing.Size(230, 37);
            this.btLoadExcel.TabIndex = 7;
            this.btLoadExcel.Text = "Открыть в Excel";
            this.btLoadExcel.UseVisualStyleBackColor = true;
            this.btLoadExcel.Click += new System.EventHandler(this.BtLoadExcel_Click);
            // 
            // VedomostTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 525);
            this.Controls.Add(this.btLoadExcel);
            this.Controls.Add(this.btCalcAverage);
            this.Controls.Add(this.btFillTable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMainTable);
            this.Controls.Add(this.lbGroupName);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "VedomostTableForm";
            this.Text = "Сводная ведомость";
            this.Load += new System.EventHandler(this.VedomostTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbGroupName;
        private System.Windows.Forms.DataGridView dgvMainTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAddSubject;
        private System.Windows.Forms.ComboBox cbSubjectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btFillTable;
        private System.Windows.Forms.Button btCalcAverage;
        private System.Windows.Forms.Button btLoadExcel;
        private System.Windows.Forms.OpenFileDialog openStudentGroupFileDialog;
        private System.Windows.Forms.Button btDeleteSubject;
    }
}

