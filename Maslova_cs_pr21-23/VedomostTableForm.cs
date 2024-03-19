using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Maslova_cs_pr21_23
{
    public partial class VedomostTableForm : Form
    {
        public VedomostTableForm()
        {
            InitializeComponent();
        }

        #region paths

        static public readonly string mainPath = Directory.GetCurrentDirectory();
        static public readonly string subjectListPath = mainPath + @"/subject_list.txt";
        static public string studentListPath;

        #endregion

        #region data

        Random rnd = new Random();

        static public List<double> averageMarks = new List<double>();
        static public List<string> subjectNames = new List<string>();
        static public string groupName;

        #endregion

        #region form events

        /// <summary>
        /// Load the form
        /// </summary>
        private void VedomostTableForm_Load(object sender, EventArgs e)
        {
            ReadSubjectList(subjectListPath);
            InitStudentListPath();
            SetupDataGRidView();
            ReadStudentList(studentListPath);
        }

        /// <summary>
        /// Add a subject collumn to the table
        /// </summary>
        private void BtAddSubject_Click(object sender, EventArgs e)
        {
            var NewSubjectCol = new DataGridViewColumn();
            NewSubjectCol.HeaderText = cbSubjectName.Text;
            NewSubjectCol.Name = dgvMainTable.ColumnCount + cbSubjectName.Text;
            NewSubjectCol.CellTemplate = new DataGridViewTextBoxCell();
            dgvMainTable.Columns.Add(NewSubjectCol);
            subjectNames.Add(cbSubjectName.Text);
            btCalcAverage.Enabled = false;
        }

        /// <summary>
        /// Delete last collumn
        /// </summary>
        private void BtDeleteSubject_Click(object sender, EventArgs e)
        {
            if (dgvMainTable.Columns.Count > 1)
                dgvMainTable.Columns.Remove(dgvMainTable.Columns[dgvMainTable.Columns.Count - 1].Name);
            subjectNames.RemoveAt(subjectNames.Count - 1);
        }

        /// <summary>
        /// Put random marks and their averages to the table; Color cells
        /// </summary>
        private void BtFillTable_Click(object sender, EventArgs e)
        {
            GenerateMarks();
            ColorMarks();
            if (dgvMainTable.Columns.Count > 1) btCalcAverage.Enabled = true;
        }

        /// <summary>
        /// Load the form with the average mark diagram
        /// </summary>
        private void BtCalcAverage_Click(object sender, EventArgs e)
        {
            SaveAverageMarkList();
            DiagramForm diagramForm = new DiagramForm();
            diagramForm.Show();
        }

        /// <summary>
        /// Start Excel and load the table into it
        /// </summary>
        private void BtLoadExcel_Click(object sender, EventArgs e)
        {
            var ExcelApp = new Excel.Application();
            ExcelApp.SheetsInNewWorkbook = 1;
            Excel.Workbook workbook = ExcelApp.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = ExcelApp.Worksheets.Item[1];
            worksheet.Name = groupName + " - отметки";

            for (int col = 0; col < dgvMainTable.Columns.Count; col++)
            {
                worksheet.Cells[1, col + 1] = dgvMainTable.Columns[col].HeaderCell.Value;
            }

            for (int col = 0; col < dgvMainTable.Columns.Count; col++)
            {
                for (int row = 0; row < dgvMainTable.Rows.Count; row++)
                {
                    worksheet.Cells[row + 2, col + 1] = dgvMainTable[col, row].Value;
                }
            }
            ExcelApp.Visible = true;
        }

        #endregion

        #region calc

        /// <summary>
        /// Calc average mark from a col
        /// </summary>
        private double AverageFromCol(int col)
        {
            double output = 0;

            for (int row = 0; row < dgvMainTable.Rows.Count - 1; row++)
            {
                output += int.Parse(dgvMainTable.Rows[row].Cells[col].Value.ToString());
            }

            output /= dgvMainTable.Rows.Count - 1;

            return output;
        }

        #endregion  

        #region init

        /// <summary>
        /// Put average marks to a list that will be sent to the second form
        /// </summary>
        private void SaveAverageMarkList()
        {
            for (int col = 1; col < dgvMainTable.Columns.Count; col++)
            {
                averageMarks.Add(double.Parse(dgvMainTable.Rows[dgvMainTable.Rows.Count - 1].Cells[col].Value.ToString()));
            }
        }

        /// <summary>
        /// Generate random marks and put them to the table
        /// </summary>
        private void GenerateMarks()
        {
            for (int col = 1; col < dgvMainTable.Columns.Count; col++)
            {
                for (int row = 0; row < dgvMainTable.Rows.Count - 1; row++)
                {
                    dgvMainTable.Rows[row].Cells[col].Value = rnd.Next(2, 6);
                }
                dgvMainTable.Rows[dgvMainTable.Rows.Count - 1].Cells[col].Value = AverageFromCol(col);
            }
        }

        /// <summary>
        /// Color "2" marks red
        /// </summary>
        private void ColorMarks()
        {
            for (int col = 1; col < dgvMainTable.Columns.Count; col++)
            {
                for (int row = 0; row < dgvMainTable.Rows.Count - 1; row++)
                {
                    if (dgvMainTable.Rows[row].Cells[col].Value.ToString() == "2")
                        dgvMainTable.Rows[row].Cells[col].Style.BackColor = Color.OrangeRed;
                    else
                        dgvMainTable.Rows[row].Cells[col].Style.BackColor = Color.White;
                }
                dgvMainTable.Rows[dgvMainTable.Rows.Count - 1].Cells[col].Value = AverageFromCol(col);
            }
        }

        /// <summary>
        /// Read the list of subjects from a file
        /// </summary>
        private void ReadSubjectList(string subjectListPath_)
        {
            try
            {
                StreamReader sr = new StreamReader(subjectListPath_);
                string @iterator;
                while ((@iterator = sr.ReadLine()) != null)
                {
                    if (@iterator != string.Empty)
                    {
                        cbSubjectName.Items.Add(@iterator);
                    }
                }
                sr.Close();
                cbSubjectName.Text = cbSubjectName.Items[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка чтения списка предметов \n\n" + ex.ToString(), "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Windows.Forms.Application.Exit();
            }
        }

        /// <summary>
        /// Open file dialog and get the name of the student list file
        /// </summary>
        private void InitStudentListPath()
        {
            openStudentGroupFileDialog.ShowDialog();
            studentListPath = openStudentGroupFileDialog.FileName;
        }

        /// <summary>
        /// Initialize data grid view
        /// </summary>
        private void SetupDataGRidView()
        {
            var FIOcol = new DataGridViewColumn();
            FIOcol.HeaderText = "ФИО";
            FIOcol.Name = "NewSubjectCol";
            FIOcol.CellTemplate = new DataGridViewTextBoxCell();
            dgvMainTable.Columns.Add(FIOcol);
        }

        /// <summary>
        /// Read the name of a group and list of students from a file
        /// </summary>
        private void ReadStudentList(string studentListPath_)
        {
            try
            {
                StreamReader sr = new StreamReader(studentListPath_);
                string @iterator;
                lbGroupName.Text = "Группа " + sr.ReadLine();
                groupName = lbGroupName.Text;
                for (int i = 0; (@iterator = sr.ReadLine()) != null; i++)
                {
                    if (@iterator != string.Empty)
                    {
                        dgvMainTable.Rows.Add(@iterator);
                    }
                }
                sr.Close();
                dgvMainTable.Rows[dgvMainTable.Rows.Count - 1].SetValues("Ср.Балл");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка чтения списка студентов \n\n" + ex.ToString(), "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Windows.Forms.Application.Exit();
            }
        }



        #endregion


    }
}
