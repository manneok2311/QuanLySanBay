using System.Data;

namespace QuanLySanBay
{
    public partial class MayBay : Form
    {
        public MayBay()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void MayBay_Load(object sender, EventArgs e)
        {
            getData();
        }
        private void getData()
        {
            string query = "select * from maybay";
            DataSet ds = kn.LayDuLieu(query);
            dgvsanbay.DataSource = ds.Tables[0];
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            ThemMayBay frm =new ThemMayBay();
            frm.Show();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            SuaMayBay frm =new SuaMayBay();
            frm.Show();
        }
    }
}
