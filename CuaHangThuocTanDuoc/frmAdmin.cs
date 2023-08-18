using CuaHangThuocTanDuoc.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangThuocTanDuoc
{
    public partial class frmAdmin : Form
    {
        String user = "";

        public frmAdmin()
        {
            InitializeComponent();
        }
        public string ID
        {
            get { return user.ToString(); }
        }
        public frmAdmin(string userName) 
        {
            InitializeComponent();
            lblUsername.Text = userName;
            user = userName;
            uC_ViewiUser1.ID = ID;
            uC_Profile1.ID = ID;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DangNhap f1 = new DangNhap();
            f1.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_DashBoard2.Visible = true;
            uC_DashBoard2.BringToFront();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            uC_DashBoard2.Visible = false;
            uC_AddUser1.Visible = false;
            uC_ViewiUser1.Visible = false;
            uC_Profile1.Visible = false;
            btnDashboard.PerformClick();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            uC_AddUser1.Visible = true;
            uC_AddUser1.BringToFront();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            uC_ViewiUser1.Visible = true;
            uC_ViewiUser1.BringToFront();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            uC_Profile1.Visible = true;
            uC_Profile1.BringToFront();
        }
    }
}
