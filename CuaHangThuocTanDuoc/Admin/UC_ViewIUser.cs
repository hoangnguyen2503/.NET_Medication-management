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
    
    public partial class UC_ViewIUser : UserControl
    {
        Function fn = new Function();
        String query;
        String currentUser = "";
        public UC_ViewIUser()
        {
            InitializeComponent();
        }
        public string ID
        {
            set { currentUser = value; }
        }
        private void UC_ViewIUser_Load(object sender, EventArgs e)
        {
            query = "select * from users";
            DataSet ds = fn.getData(query);
            dgvUsers.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username like '"+ txtSearch.Text + "%'";
            DataSet ds = fn.getData(query);
            dgvUsers.DataSource = ds.Tables[0];
        }

        String userName;
        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userName = dgvUsers.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch { }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn?", "Xoá thông tin!", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (currentUser != userName)
                {
                    query = "delete from users where username = '" + userName + "'";
                    fn.setData(query, "Bản ghi đã xoá.");
                    UC_ViewIUser_Load(this, null);
                }
                else
                {
                    MessageBox.Show("Bạn thử xoá lại \n Hồ sơ của bạn.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_ViewIUser_Load(this, null);
        }
    }
}
