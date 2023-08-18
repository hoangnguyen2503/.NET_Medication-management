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
    public partial class US_AddMedicine : UserControl
    {
        Function fn = new Function();
        String query;
        public US_AddMedicine()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMedicineID.Text != "" && txtMediName.Text != "" && txtMediNumber.Text != "" && txtQuantity.Text != "" && txtPricePerUnit.Text != "")
            {
                String mid = txtMedicineID.Text;
                String mname = txtMediName.Text;
                String mnumber = txtMediNumber.Text;
                String mDate = dtpManufacture.Text;
                String eDate = dtpExpire.Text;
                Int64 quantity = Int64.Parse(txtQuantity.Text);
                Int64 perUnit = Int64.Parse(txtPricePerUnit.Text);

                query = "insert into medic (mid, mname, mnumber, mDate, eDate, quantity, perUnit) values ('" + mid + "', '" + mname + "', '" + mnumber + "', '" + mDate + "', '" + eDate + "', '" + quantity + "', '" + perUnit + "')";
                fn.setData(query, "Thuốc được thêm vào dữ liệu");
            }
            else
            {
                MessageBox.Show("Nhập tất cả dữ liệu", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtMedicineID.Clear();
            txtMediName.Clear();
            txtMediNumber.Clear();
            txtQuantity.Clear();
            txtPricePerUnit.Clear();
            dtpExpire.ResetText();
            dtpManufacture.ResetText();
        }

       
    }
}
