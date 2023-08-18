using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using System;
using DGVPrinterHelper;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace CuaHangThuocTanDuoc.User
{
   
    public partial class US_SellMedicine : UserControl
    {
        Function fn = new Function();
        String query;
        DataSet ds;
        public US_SellMedicine()
        {
            InitializeComponent();
        }

        private void US_SellMedicine_Load(object sender, EventArgs e)
        {
            lstBoxMedicine.Items.Clear();
            query = "select mname from medic where eDate >= getdate() and quantity > '0'";
            ds = fn.getData(query);

            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                lstBoxMedicine.Items.Add(ds.Tables[0].Rows[i][0].ToString()); 
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lstBoxMedicine.Items.Clear();
            query ="select mname from medic where mname like '"+ txtSearch.Text +"' and eDate >= getdate() and quantity > '0'";
            ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                lstBoxMedicine.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

        }

        private void lstBoxMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNoOfUnit.Clear();

            String name = lstBoxMedicine.GetItemText(lstBoxMedicine.SelectedItem);
            txtMediName.Text = name;
            query = "select mid, eDate, perUnit from medic where mname = '"+ name +"' ";
            ds = fn.getData(query);
            txtMedicineID.Text = ds.Tables[0].Rows[0][0].ToString();
            dtpExpire.Text = ds.Tables[0].Rows[0][1].ToString();
            txtPricePerUnit.Text = ds.Tables[0].Rows[0][2].ToString();

        }

        private void txtNoOfUnit_TextChanged(object sender, EventArgs e)
        {
            if(txtNoOfUnit.Text != "")
            {
                Int64 unitPrice = Int64.Parse(txtPricePerUnit.Text);
                Int64 noOfUnit = Int64.Parse(txtNoOfUnit.Text);
                Int64 totalAmount = unitPrice * noOfUnit;
                txtTotalPrice.Text = totalAmount.ToString();
            } else
            {
                txtTotalPrice.Clear();
            }

        }
        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;
        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if(txtMedicineID.Text != "")
            {
                query = "select quantity from medic where mid = '" +txtMedicineID.Text +"' ";
                DataSet ds = fn.getData(query);

                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newQuantity = Int64.Parse(txtNoOfUnit.Text);

                if (newQuantity >= 0)
                {
                    n = dgvHoadon.Rows.Add();
                    dgvHoadon.Rows[n].Cells[0].Value = txtMedicineID.Text;
                    dgvHoadon.Rows[n].Cells[1].Value = txtMediName.Text;
                    dgvHoadon.Rows[n].Cells[2].Value = dtpExpire.Text;
                    dgvHoadon.Rows[n].Cells[3].Value = txtPricePerUnit.Text;
                    dgvHoadon.Rows[n].Cells[4].Value = txtNoOfUnit.Text;
                    dgvHoadon.Rows[n].Cells[5].Value = txtTotalPrice.Text;

                    totalAmount = totalAmount + int.Parse(txtTotalPrice.Text);
                    lblTotal.Text = "Rs. " + totalAmount.ToString();

                    query ="update medic set quantity = '"+ newQuantity +"' where mid = '" + txtMedicineID.Text +"' ";
                    fn.setData(query, "Thuốc đã được thêm vào giỏ hàng.");
                }
                else
                {
                    MessageBox.Show("Thuốc hết hàng.\n Chỉ số " + quantity + " Sau ", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                clearAll();
                US_SellMedicine_Load(this, null);
            }else
            {
                MessageBox.Show("Chọn thuốc trước tiên.","Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        int valueAmount;
        String valueId;
        protected Int64 noOfUnit;



        private void dgvHoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(dgvHoadon.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueId = dgvHoadon.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfUnit = Int64.Parse(dgvHoadon.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception)
            {
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (valueId != null)
            {
                try
                {
                    dgvHoadon.Rows.RemoveAt(this.dgvHoadon.SelectedRows[0].Index);
                }
                catch
                {
                }
                finally
                {
                    query = "select quantity from medic where mid = '"+ valueId +"'  ";
                    ds = fn.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + noOfUnit;

                    query = "update medic set quantity = '" + newQuantity + "' where mid = '"+ valueId +"'";
                    fn.setData(query,"Thuốc đã được loại bỏ khỏi giỏ hàng!");
                    totalAmount = totalAmount - valueAmount;
                    lblTotal.Text = "Rs. " + totalAmount.ToString();

                }
                US_SellMedicine_Load(this, null);
            }
        }

      
        private void btnPurchasePrint_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Hoá đơn thuốc";
            print.SubTitle = String.Format("Ngày: {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Tổng số tiền phải trả: " + lblTotal.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(dgvHoadon);

            totalAmount = 0;
            lblTotal.Text = "Rs. 00";
            dgvHoadon.DataSource = 0;

        }

       

        private void btnSync_Click(object sender, EventArgs e)
        {
            US_SellMedicine_Load(this, null);
        }

        private void clearAll()
        {
            txtMedicineID.Clear();
            txtMediName.Clear();
	        dtpExpire.ResetText();
            txtPricePerUnit.Clear();
            txtNoOfUnit.Clear();
        }

    }
}
