using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Đề_thi_thử1
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            String hovaten = "Ho Tan Thanh";
            String mssv = "1231231234";
            String monthi = "Lập Trình Windows 2, C#";


            lblInfo.Text = "họ và tên: " + hovaten;
            lblInfo.Text += " \nMSSV " + mssv;
            lblInfo.Text += " \nNgày thi " + System.DateTime.Now.ToString();
            lblInfo.Text += " \nMôn Thi " + monthi;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaiPhuongTrinhBac2 gpt = new GiaiPhuongTrinhBac2();
            gpt.Show();
        }

        private void giớiThiệuCậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trương Trình tiện ích", "Thông tin");
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DinhDang dd = new DinhDang();
            dd.Show();
        }

        private void đăngKíMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangkimonhoc dkmh = new Dangkimonhoc();
            dkmh.Show();
        }
    }
}
