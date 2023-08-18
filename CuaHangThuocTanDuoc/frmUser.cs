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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DangNhap fm = new DangNhap();
            fm.Show();
            this.Hide();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            uS_AddMedicine1.Visible = false;
            uS_ViewMedicine1.Visible = false;
            uS_UpdateMedicine1.Visible = false;
            uS_CheckValidity1.Visible = false;
            uS_SellMedicine1.Visible = false;
        }

        private void btnAddmedicine_Click(object sender, EventArgs e)
        {
            uS_AddMedicine1.Visible = true;
            uS_AddMedicine1.BringToFront();
        }

        private void btnViewmedicine_Click(object sender, EventArgs e)
        {
            uS_ViewMedicine1.Visible = true;
            uS_ViewMedicine1.BringToFront();
        }

        private void btnUpdateMedi_Click(object sender, EventArgs e)
        {
            uS_UpdateMedicine1.Visible = true;
            uS_UpdateMedicine1.BringToFront();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            uS_CheckValidity1.Visible = true;
            uS_CheckValidity1.BringToFront();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            uS_SellMedicine1.Visible = true;
            uS_SellMedicine1.BringToFront();
        }
    }
}
