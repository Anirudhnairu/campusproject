namespace SmartCampusDashboard
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle, lblUser, lblPass;
        private System.Windows.Forms.TextBox txtUser, txtPass;
        private System.Windows.Forms.Button btnLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new System.Windows.Forms.Label();
            lblUser = new System.Windows.Forms.Label();
            lblPass = new System.Windows.Forms.Label();
            txtUser = new System.Windows.Forms.TextBox();
            txtPass = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            SuspendLayout();

            lblTitle.Text = "AI Based Smart Campus System";
            lblTitle.Location = new System.Drawing.Point(60, 20);
            lblTitle.AutoSize = true;

            lblUser.Text = "Username:";
            lblUser.Location = new System.Drawing.Point(40, 80);
            lblUser.AutoSize = true;

            lblPass.Text = "Password:";
            lblPass.Location = new System.Drawing.Point(40, 120);
            lblPass.AutoSize = true;

            txtUser.Location = new System.Drawing.Point(120, 78);
            txtUser.Size = new System.Drawing.Size(200, 23);

            txtPass.Location = new System.Drawing.Point(120, 118);
            txtPass.PasswordChar = '*';
            txtPass.Size = new System.Drawing.Size(200, 23);

            btnLogin.Text = "Login";
            btnLogin.Location = new System.Drawing.Point(120, 160);
            btnLogin.Size = new System.Drawing.Size(90,30);
            btnLogin.Click += new System.EventHandler(btnLogin_Click);

            ClientSize = new System.Drawing.Size(380, 230);
            Controls.Add(lblTitle);
            Controls.Add(lblUser);
            Controls.Add(lblPass);
            Controls.Add(txtUser);
            Controls.Add(txtPass);
            Controls.Add(btnLogin);
            Text = "Admin Login - Smart Campus";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
