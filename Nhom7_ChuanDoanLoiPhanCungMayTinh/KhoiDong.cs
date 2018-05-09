using System;
using System.Windows.Forms;

namespace Nhom7_ChuanDoanLoiPhanCungMayTinh
{
    public partial class KhoiDong : Form
    {
        #region Constructor

        private Random random;

        public KhoiDong()
        {
            InitializeComponent();
        }

        #endregion Constructor

        #region Event

        private void Random()
        {
            random = new Random();
            int i = random.Next(5);
            switch (i)
            {
                case 0:
                    label1.Text = "aaaaaaa";
                    break;

                case 1:
                    label1.Text = "bbbbbbb";
                    break;

                case 2:
                    label1.Text = "ccccccc";
                    break;

                case 3:
                    label1.Text = "dddddddddd";
                    break;

                case 4:
                    label1.Text = "eeeeeeeee";
                    break;

                case 5:
                    label1.Text = "fffffffffff";
                    break;
            }
        }

        private void KhoiDong_Load(object sender, EventArgs e)
        {
            timeProgress.Enabled = true;
        }

        private int i = 0;

        private void timeProgress_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value == progressBar.Maximum)
            {
                timeProgress.Stop();

                this.Hide();
               // _frmChuanDoanBenhTim ChuanDoanBenhTim = new _frmChuanDoanBenhTim();
               // ChuanDoanBenhTim.Show();
            }
            else
            {
                progressBar.Value += 1;
                if (progressBar.Value >= 10)
                {
                    i++;
                    if (i == 5)
                    {
                        i = 0;
                        Random();
                    }
                }
            }
        }

        #endregion Event
    }
}