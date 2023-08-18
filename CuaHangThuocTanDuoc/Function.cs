using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace CuaHangThuocTanDuoc
{
    internal class Function
    {
        protected SqlConnection getConnection() 
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P087J36\HIEN;Initial Catalog=pharmacity;Integrated Security=True");
            return con;
            //con.ConnectionString = @"data source = DESKTOP-P087J36\HIEN;Initial Catalog=pharmacity;Integrated Security=True";
            //return con;
        }
        public DataSet getData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(String query, String msg)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
