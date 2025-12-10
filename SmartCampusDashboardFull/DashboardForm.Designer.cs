namespace SmartCampusDashboard
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblHeader, lblTotalStudents, lblTotalBooks, lblIssuedBooks;
        private System.Windows.Forms.Button btnStudents, btnAttendance, btnLibrary, btnExport;
        private System.Windows.Forms.DataGridView dgv;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblHeader = new System.Windows.Forms.Label();
            lblTotalStudents = new System.Windows.Forms.Label();
            lblTotalBooks = new System.Windows.Forms.Label();
            lblIssuedBooks = new System.Windows.Forms.Label();
            btnStudents = new System.Windows.Forms.Button();
            btnAttendance = new System.Windows.Forms.Button();
            btnLibrary = new System.Windows.Forms.Button();
            btnExport = new System.Windows.Forms.Button();
            dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(dgv)).BeginInit();
            SuspendLayout();

            lblHeader.Location = new System.Drawing.Point(20, 10);
            lblHeader.AutoSize = true;

            lblTotalStudents.Location = new System.Drawing.Point(20, 40);
            lblTotalBooks.Location = new System.Drawing.Point(20, 60);
            lblIssuedBooks.Location = new System.Drawing.Point(20, 80);

            btnStudents.Text = "Students";
            btnStudents.Location = new System.Drawing.Point(20, 110);
            btnStudents.Click += new System.EventHandler(btnStudents_Click);

            btnAttendance.Text = "Attendance";
            btnAttendance.Location = new System.Drawing.Point(120, 110);
            btnAttendance.Click += new System.EventHandler(btnAttendance_Click);

            btnLibrary.Text = "Library";
            btnLibrary.Location = new System.Drawing.Point(240, 110);
            btnLibrary.Click += new System.EventHandler(btnLibrary_Click);

            btnExport.Text = "Export CSV";
            btnExport.Location = new System.Drawing.Point(350, 110);
            btnExport.Click += new System.EventHandler(btnExport_Click);

            dgv.Location = new System.Drawing.Point(20, 150);
            dgv.Size = new System.Drawing.Size(600, 250);

            ClientSize = new System.Drawing.Size(650, 420);
            Controls.Add(lblHeader);
            Controls.Add(lblTotalStudents);
            Controls.Add(lblTotalBooks);
            Controls.Add(lblIssuedBooks);
            Controls.Add(btnStudents);
            Controls.Add(btnAttendance);
            Controls.Add(btnLibrary);
            Controls.Add(btnExport);
            Controls.Add(dgv);
            Load += new System.EventHandler(DashboardForm_Load);

            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(dgv)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
