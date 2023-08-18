using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangThuocTanDuoc.User
{
    public partial class US_CheckValidity : UserControl
    {
        Function fn = new Function();
        String query;
        public US_CheckValidity()
        {
            InitializeComponent();
        }

        private void setDataGridView(String query, String lblName, Color col)
        {
            DataSet ds = fn.getData(query);
            dgvCheckVali.DataSource = ds.Tables[0];
            lblSet.Text = lblName;
            lblSet.ForeColor = col;
        }
        private void US_CheckValidity_Load(object sender, EventArgs e)
        {
            lblSet.Text = "";
        }

        private void cbCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCheck.SelectedIndex == 0)
            {
                query = "select * from medic where eDate >= getdate()";
                setDataGridView(query, "Thuốc còn HSD", Color.Black);
            } 
            else if (cbCheck.SelectedIndex == 1)
            {
                query = "select * from medic where eDate <= getdate()";
                setDataGridView(query, "Thuốc hết HSD", Color.Red);
            }
            else if(cbCheck.SelectedIndex == 2)
            {
                query = "select * from medic";
                setDataGridView(query, "", Color.Black);
            }
        }
    }
}
