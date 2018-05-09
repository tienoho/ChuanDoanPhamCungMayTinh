using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using Nhom7_ChuanDoanLoiPhanCungMayTinh.DTO;

namespace Nhom7_ChuanDoanLoiPhanCungMayTinh
{
    public partial class TrangChu : UserControl
    {
        #region Field
        List<string> GT = new List<string>();
        List<int> kq;
        ConnectFile kn = new ConnectFile();
        public string view;
        public string path = Application.StartupPath + "\\";
        string str = string.Empty;
        string id = string.Empty;
        string moTa = string.Empty;
        int dong = 0;
        #endregion Field

        #region Constructor
        public TrangChu()
        {
            InitializeComponent();
        }
        #endregion Constructor

        #region Event
        private void OnTrangChuLoad(object sender, EventArgs e)
        {
            kn.LoadToDataGridView(dgvTrieuChung, path+ "TrieuChung.txt");
        }

        private void OnBtnChonClick(object sender, EventArgs e)
        {
            try
            {
                lstTrieuChung.Items.Add(dgvTrieuChung.CurrentRow.Cells[0].Value.ToString() + ": " + dgvTrieuChung.CurrentRow.Cells[1].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn triệu chứng, xin mời chọn triệu chứng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OnBtnHuyClick(object sender, EventArgs e)
        {
            try
            {
                lstTrieuChung.Items.RemoveAt(lstTrieuChung.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn dữ kiện cần xóa, mời chọn dữ kiện cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OnBtnChuanDoanClick(object sender, EventArgs e)
        {
            if (lstTrieuChung.Items.Count == 0)
            {
                MessageBox.Show("Không có thông tin dữ kiện, không thể chuẩn đoán được lỗi phần cứng máy tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                GT = new List<string>();
                lstKetQua.Items.Clear();
                Regex RE = new Regex(": ");
                for (int i = 0; i < lstTrieuChung.Items.Count; i++)
                {
                    string[] r;
                    r = RE.Split(lstTrieuChung.Items[i].ToString());
                    GT.Add(r[0]);
                }
                
                Process xl = new Process(GT, kn.DocFile(path + "MoTaKetLuan.txt"), kn.DocFile(path + "Rules.txt"));

                kq = new List<int>();
                kq.AddRange(xl.forward_reasoning());
                if (kq.Count != 0)
                {
                    for (int i = 0; i < kq.Count; i++)
                    {
                        lstKetQua.Items.Add(kn.DocFile(path + "MoTaKetLuan.txt").Rows[kq[i]][1]);
                    }
                }
                else
                {
                    lstKetQua.Items.Add("Các dữ kiện chưa đủ để đưa ra lỗi cụ thể!");
                    lstKetQua.Items.Add("\t" + "==> Không thể chuẩn đoán được lỗi của máy tính!");
                }
                view = xl.view;
                rtbGiaiThich.Text = view;
            }
        }

        #endregion Event

        private void btnHuyAll_Click(object sender, EventArgs e)
        {
            lstTrieuChung.Items.Clear();
        }
    }
}
