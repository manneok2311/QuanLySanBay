using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanBay
{
    public partial class SuaMayBay : Form
    {
        public SuaMayBay()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void btnok_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "update maybay set tenmb = N'{1}',namsx = {2}, sogiobay = {3} where mamb = '{0}'",
                txtmamb.Text,
                txttenmb.Text,
                txtnamsx.Text,
                txtsogio.Text
            );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Sửa thành công!");
                MayBay frm = new MayBay();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

      

        private void SuaMayBay_Load(object sender, EventArgs e)
        {
            getData();
        }
        private void getData()
        {
            string query = "select * from maybay";
            DataSet ds = kn.LayDuLieu(query);
            dgvsua.DataSource = ds.Tables[0];
        }
       

        private void dgvsua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {

                txtmamb.Text = dgvsua.Rows[r].Cells["mamb"].Value.ToString();
                txttenmb.Text = dgvsua.Rows[r].Cells["tenmb"].Value.ToString();
                txtnamsx.Text = dgvsua.Rows[r].Cells["namsx"].Value.ToString();
                txtsogio.Text = dgvsua.Rows[r].Cells["sogiobay"].Value.ToString();

            }
        }
    }
}
