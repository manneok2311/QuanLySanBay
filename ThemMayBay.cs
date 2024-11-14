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
    public partial class ThemMayBay : Form
    {
        public ThemMayBay()
        {
            InitializeComponent();
        }
        KetNoi kn=new KetNoi();
        private void ThemMayBay_Load(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "insert into maybay VALUES('{0}', N'{1}', {2}, {3})",
                txtmamaybay.Text,
                txttenmaybay.Text,
                txtnamsanxuat.Text,
                txtsogiobay.Text
            );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Thêm mới thành công!");
                MayBay mayBay = new MayBay();
                mayBay.Show();
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại!");
            }
        }
    }
}
