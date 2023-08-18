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
    public partial class UC_AddUser : UserControl
    {
        Function fn = new Function();
        String query;

        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            String role = cbRole.Text;
            String name = txtName.Text;
            String dob = dtpBirthday.Text;
            Int64 mobile = Int64.Parse(txtPhoneNumber.Text);
            String email = txtEmail.Text;
            String username = txtUsername.Text;
            String pass = txtPassword.Text;

            try
            {
                query = "insert into users (userRole,name,dob,mobile,email,username,pass) values " +
                    "('" + role + "', '" + name + "', '" + dob + "', " + mobile + ", '" + email + "', '" + username + "','" + pass + "')";
                fn.setData(query, "Đăng ký thành công!"); 
            }catch(Exception)
            {
                MessageBox.Show("Người dùng đã tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtName.Clear();
            dtpBirthday.ResetText();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            cbRole.SelectedIndex = -1;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username = '" + txtUsername.Text + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                picAddUser.ImageLocation = @"C:\Users\admin\source\repos\windown forn\CuaHangThuocTanDuoc\picture\check.png";
            }    
            else
            {
                picAddUser.ImageLocation = @"C:\Users\admin\source\repos\windown forn\CuaHangThuocTanDuoc\picture\cancel.png";
            }    

        }
    }
}
