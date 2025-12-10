using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace SmartCampusDashboard
{
    public partial class DashboardForm : Form
    {
        DataTable students, attendance, library;
        string _user;

        public DashboardForm(string user)
        {
            _user = user;
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            lblHeader.Text = "Admin Dashboard - " + _user;

            try { LoadDb(); }
            catch { LoadDummy(); }

            UpdateLabels();
        }

        private void LoadDb()
        {
            students = Db.ExecuteDataTable("SELECT * FROM students");
            attendance = Db.ExecuteDataTable("SELECT * FROM attendance");
            library = Db.ExecuteDataTable("SELECT * FROM library");
        }

        private void LoadDummy()
        {
            students = new DataTable();
            students.Columns.Add("StudentID");
            students.Columns.Add("Name");
            students.Columns.Add("Email");
            students.Columns.Add("Department");
            students.Rows.Add(1,"Rahul","rahul@example.com","CSE");

            attendance = new DataTable();
            attendance.Columns.Add("AttendanceID");
            attendance.Columns.Add("StudentID");
            attendance.Columns.Add("Date");
            attendance.Columns.Add("Status");
            attendance.Rows.Add(1,1,DateTime.Today,"Present");

            library = new DataTable();
            library.Columns.Add("BookID");
            library.Columns.Add("Title");
            library.Columns.Add("Author");
            library.Columns.Add("IssuedTo");
            library.Columns.Add("IssueDate");
            library.Rows.Add(101,"Data Structures","Karumanchi","Rahul",DateTime.Today);
        }

        private void UpdateLabels()
        {
            lblTotalStudents.Text = "Total Students: " + students.Rows.Count;
            lblTotalBooks.Text = "Total Books: " + library.Rows.Count;

            int issued = 0;
            foreach (DataRow r in library.Rows)
                if (!string.IsNullOrEmpty(r["IssuedTo"].ToString())) issued++;

            lblIssuedBooks.Text = "Issued Books: " + issued;
        }

        private void btnStudents_Click(object sender, EventArgs e) => dgv.DataSource = students;
        private void btnAttendance_Click(object sender, EventArgs e) => dgv.DataSource = attendance;
        private void btnLibrary_Click(object sender, EventArgs e) => dgv.DataSource = library;

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgv.DataSource == null) return;

            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "CSV|*.csv";
            s.FileName = "report.csv";
            if (s.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    sb.Append(dgv.Columns[i].HeaderText);
                    if (i < dgv.Columns.Count - 1) sb.Append(",");
                }
                sb.AppendLine();

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow) continue;
                    for (int i=0;i<dgv.Columns.Count;i++)
                    {
                        sb.Append(row.Cells[i].Value);
                        if (i < dgv.Columns.Count -1) sb.Append(",");
                    }
                    sb.AppendLine();
                }

                File.WriteAllText(s.FileName, sb.ToString());
            }
        }
    }
}
