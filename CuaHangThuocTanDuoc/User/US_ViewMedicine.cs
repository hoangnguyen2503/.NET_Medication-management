using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CuaHangThuocTanDuoc.User
{
    public partial class US_ViewMedicine : UserControl
    {
        Function fn = new Function();
        String query;
        String currentID = "";

        public US_ViewMedicine()
        {
            InitializeComponent();
        }
        public string ID
        {
            set { currentID = value; }
        }
        private void US_ViewMedicine_Load(object sender, EventArgs e)
        {
            query = "select * from medic";
            setDataGridView(query);
        }

        private void setDataGridView(String query)
        {
            DataSet ds = fn.getData(query);
            dgvMedic.DataSource = ds.Tables[0];
        }
        String medicineID;
        private void dgvMedic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineID = dgvMedic.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch { }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn không?", "Xác nhận xóa !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (currentID != medicineID)
                {
                    query = "delete from medic where mid = '" + medicineID + "'";
                    fn.setData(query, "Bản ghi đã xoá.");
                    US_ViewMedicine_Load(this, null);
                }
                else
                {
                    MessageBox.Show("Bạn thử xoá lại \n Thuốc của bạn.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //query = "delete from medic where mid = '" + medicineID + "'";
                //fn.setData(query, "Hồ sơ đã bị xóa");
                //US_ViewMedicine_Load(this, null);
            }
        }
       
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from medic where mname like '" + txtSearch.Text + "%'";
            setDataGridView(query);
        }

        

        private void btnSync_Click(object sender, EventArgs e)
        {
            US_ViewMedicine_Load(this, null);
        }

       
    }
}
