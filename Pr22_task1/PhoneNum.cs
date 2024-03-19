using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Pr22_task1
{
    public partial class PhoneNumbersForm : Form
    {
        public PhoneNumbersForm()
        {
            InitializeComponent();
        }

        string[] names = { "Alex", "Bonnie", "Clara", "Drake", "Egor" };
        int[] numbers = { 144, 3232, 335, 4224, 5453 };

        private void PhoneNumbersForm_Load(object sender, EventArgs e)
        {
            var phoneCol = new DataGridViewColumn();
            phoneCol.HeaderText = "Телефон";
            phoneCol.Name = "phone";
            phoneCol.CellTemplate = new DataGridViewTextBoxCell();

            var fioCol = new DataGridViewColumn();
            fioCol.HeaderText = "ФИО";
            fioCol.Name = "fio";
            fioCol.CellTemplate = new DataGridViewTextBoxCell();


            dgvMainTable.Columns.Add(fioCol);
            dgvMainTable.Columns.Add(phoneCol);

            for (int row = 0; row < names.Length; row++)
            {
                dgvMainTable.Rows.Add(names[row]);
                dgvMainTable.Rows[row].Cells[1].Value = numbers[row];
            }

        }

        private void btExcel_Click(object sender, EventArgs e)
        {
            var ExcelApp = new Excel.Application();
            ExcelApp.SheetsInNewWorkbook = 1;
            Excel.Workbook workbook = ExcelApp.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = ExcelApp.Worksheets.Item[1];
            worksheet.Name = "Справочник телефонов";
            worksheet.Cells[1, 1] = dgvMainTable.Columns[0].HeaderCell.Value;
            worksheet.Cells[1, 2] = dgvMainTable.Columns[1].HeaderCell.Value;

            for (int row = 0; row < names.Length; row++)
            {
                worksheet.Cells[row+2, 1] = dgvMainTable[0, row].Value;
                worksheet.Cells[row+2, 2] = dgvMainTable[1, row].Value;
            }

            ExcelApp.Visible = true;
        }
    }
}
