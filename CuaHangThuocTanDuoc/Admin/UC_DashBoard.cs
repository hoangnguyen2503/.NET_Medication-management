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
    public partial class UC_DashBoard : UserControl
    {
        Function fn = new Function();
        String query;
        DataSet ds;
        public UC_DashBoard()
        {
            InitializeComponent();
        }

        private void UC_DashBoard_Load(object sender, EventArgs e)
        {
            query = "select count(userRole) from users where userRole = 'Admin'";
            ds = fn.getData(query);
            setLabel(ds, lblAdmin);

            query = "select count(userRole) from users where userRole = 'User'";
            ds = fn.getData(query);
            setLabel(ds, lblUser);
        }
        private void setLabel(DataSet ds, Label lbl)
        {
            if (ds.Tables[0].Rows.Count != 0) 
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbl.Text = "0";
            }    
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_DashBoard_Load(this, null);
        }
    }
}
