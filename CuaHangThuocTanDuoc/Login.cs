using System.Data;

namespace CuaHangThuocTanDuoc
{
    public partial class DangNhap : Form
    {
        Function fn = new Function();
        String query;
        DataSet ds;

        public DangNhap()
        {
            InitializeComponent();
        }

        private void cbMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMatKhau.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (txtTenDN.Text == "admin" && txtMatKhau.Text == "1234")
            //{
            //    frmAdmin admin = new frmAdmin();
            //    admin.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không chính xác!", "Lỗi",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            query = "select * from users";
            ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0) 
            {
                if(txtTenDN.Text == "root" && txtMatKhau.Text == "root")
                {
                    frmAdmin admin = new frmAdmin();
                    admin.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "select * from users where username = '" + txtTenDN.Text + "' and pass = '" + txtMatKhau.Text + "'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    String role = ds.Tables[0].Rows[0][1].ToString();
                    if(role == "Admin")
                    {
                        frmAdmin admin = new frmAdmin(txtTenDN.Text);
                        admin.Show();
                        this.Hide();
                    }    
                    else if(role == "User")
                    {
                        frmUser user = new frmUser();
                        user.Show();
                        this.Hide();
                    }
                }  
                else
                {
                    MessageBox.Show("Tên người dùng hoặc mật khẩu sai", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }    
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            txtTenDN.Clear();
            txtMatKhau.Clear();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}