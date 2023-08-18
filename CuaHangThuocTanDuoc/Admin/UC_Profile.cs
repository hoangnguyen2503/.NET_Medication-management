using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangThuocTanDuoc.Admin
{
    public partial class UC_Profile : UserControl
    {
        Function fn = new Function();
        String query;
        
        public UC_Profile()
        {
            InitializeComponent();
        }
        public string ID
        {
            set { username.Text = value; }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String role = cbUserRole.Text;
            String name = txtName.Text;
            String dob = txtBirthday.Text;
            Int64 mobile = Int64.Parse(txtPhoneNum.Text);
            String email = txtEmail.Text;
            String userName = username.Text;
            String pass = txtPassworrd.Text;

            query = "update users set userRole = '" + role + "', name = '" + name + "', dob = '" + dob + "', mobile = " + mobile + ", email = '" + email + "', pass = '" + pass + "' where username = '" + userName + '"';
            fn.setData(query, "Hồ sơ đã được cập nhật!");
        }

        private void UC_Profile_Enter(object sender, EventArgs e)
        {
            query = "select * from users where username = '" + username.Text + "'";
            DataSet ds = fn.getData(query);
            cbUserRole.Text = ds.Tables[0].Rows[0][1].ToString();
            txtName.Text = ds.Tables[0].Rows[0][2].ToString();
            txtBirthday.Text = ds.Tables[0].Rows[0][3].ToString();
            txtPhoneNum.Text = ds.Tables[0].Rows[0][4].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
            txtPassworrd.Text = ds.Tables[0].Rows[0][7].ToString();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            UC_Profile_Enter(this, null);
        }
    }
}
