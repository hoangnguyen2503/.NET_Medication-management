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
    public partial class US_UpdateMedicine : UserControl
    {
        Function fn = new Function();
        String query;
        public US_UpdateMedicine()
        {
            InitializeComponent();
        }
        private void clearAll()
        {
            txtMedicineID.Clear();
            txtMediName.Clear();
            txtMediNumber.Clear();
            txtQuantity.Clear();
            txtAddQuantity.Clear();
            txtPricePerUnit.Clear();
            dtpExpire.ResetText();
            dtpManufacture.ResetText();

            if(txtAddQuantity.Text != "0")
            {
                txtAddQuantity.Text = "0";
            }    
            else
            {
                txtAddQuantity.Text = "0";
            }    
        }
        Int64 totalQuantity;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String mname = txtMediName.Text;
            String mnumber = txtMediNumber.Text;
            String mDate = dtpManufacture.Text;
            String eDate = dtpExpire.Text;
            Int64 quantity = Int64.Parse(txtQuantity.Text);
            Int64 addQuantity = Int64.Parse(txtAddQuantity.Text);
            Int64 unitprice = Int64.Parse(txtPricePerUnit.Text);

            totalQuantity = quantity + addQuantity;

            query = "update medic set mname = '" + mname + "', mnumber = '" + mnumber + "', mDate = '" + mDate + "', eDate = '" + eDate + "', quantity = '" + totalQuantity + "', perUnit = '" + unitprice + "' where mid = '" + txtMedicineID.Text + "'";
            fn.setData(query, "Đã cập nhật chi tiết thuốc.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtMedicineID.Text != "") 
            {
                query = "select * from medic where mid = '" + txtMedicineID.Text + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtMediName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMediNumber.Text = ds.Tables[0].Rows[0][3].ToString();
                    dtpManufacture.Text = ds.Tables[0].Rows[0][4].ToString();
                    dtpExpire.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtPricePerUnit.Text = ds.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    MessageBox.Show("Không có thuốc giống ID này: " + txtMedicineID.Text + " Hiện hữu.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                clearAll();
            }    
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
