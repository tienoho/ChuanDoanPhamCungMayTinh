using Nhom7_ChuanDoanLoiPhanCungMayTinh.DTO;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Nhom7_ChuanDoanLoiPhanCungMayTinh
{
    public partial class Luat : UserControl
    {
        #region Field

        public string path = Application.StartupPath + "\\";
        private ConnectFile kn = new ConnectFile();
        private string str = string.Empty;
        private string veTrai = string.Empty;
        private string vePhai = string.Empty;
        private Boolean _luu = false;
        public int count_Rule = 0;
        private TTLuat[] R = new TTLuat[200];

        #endregion Field

        #region Constructor

        public Luat()
        {
            InitializeComponent();
        }

        #endregion Constructor

        #region Event

        private void OnLuatLoad(object sender, EventArgs e)
        {
            btnChonVeTrai.Enabled = true;
            btnChonVePhai.Enabled = true;
            btnHuyChon.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;

            kn.LoadToDataGridView(dgvTrieuChung, path + "TrieuChung.txt");
            kn.LoadToDataGridView(dgvTrieuChung, path + "MoTaKetLuan.txt");
            kn.LoadToDataGridView(dgvLuat, path + "Rules.txt");
            kn.LoadToDataGridView(dgvMoTaLuat, path + "MoTaKetLuan.txt");
            LoadRules();
        }

        private void EventThem()
        {
            txtLuatSo.Enabled = true;
            txtVePhai.Enabled = false;
            txtVeTrai.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void EventSua()
        {
            txtLuatSo.Enabled = true;
            txtVePhai.Enabled = true;
            txtVeTrai.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void EventLuu()
        {
            txtLuatSo.Enabled = false;
            txtVePhai.Enabled = false;
            txtVeTrai.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }

        /// <summary>
        /// sử lý sự kiện btnVeTrai khi được click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnBtnChonVeTraiClick(object sender, EventArgs e)
        {
            if (txtVeTrai.Text == string.Empty)
            {
                txtVeTrai.Text = dgvTrieuChung.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                txtVeTrai.Text = txtVeTrai.Text.Trim() + " ^ " + dgvTrieuChung.CurrentRow.Cells[0].Value.ToString();
            }
        }

        /// <summary>
        /// xử lý sự kiện btnVePhai được click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnBtnChonVePhaiClick(object sender, EventArgs e)
        {
            txtVePhai.Text = dgvTrieuChung.CurrentRow.Cells[0].Value.ToString();
        }

        /// <summary>
        /// xử lý sự kiện btnHuyChon được click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnBtnHuyChonClick(object sender, EventArgs e)
        {
            txtVePhai.Text = string.Empty;
            txtVeTrai.Text = string.Empty;
        }

        /// <summary>
        /// xử lý sự kiện btnThem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnBtnThemClick(object sender, EventArgs e)
        {
            _luu = true;
            EventThem();
            // txtLuatSo.Enabled = true;
        }

        /// <summary>
        /// xử lý sự kiện btnSua
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnBtnSuaClick(object sender, EventArgs e)
        {
            _luu = false;
            EventSua();
            // txtVePhai.Enabled = true;
            //txtVeTrai.Enabled = true;
        }

        /// <summary>
        /// xử lý sự kiện btnLuu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnBtnLuuClick(object sender, EventArgs e)
        {
            if (_luu == true)
            {
                GhiFile();
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OnLuatLoad(sender, e);
                SetNull();
                LockText();
            }
            else
            {
                SuaFile();
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OnLuatLoad(sender, e);
                SetNull();
                LockText();
            }
            EventLuu();
        }

        /// <summary>
        /// xử lý sự kiện btnXoa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                XoaFile();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OnLuatLoad(sender, e);
                SetNull();
                LockText();
            }
        }

        /// <summary>
        /// xử lý sự kiện CellClick trên dgvLuat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvLuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtLuatSo.Text = dgvLuat.CurrentRow.Cells[0].Value.ToString();
            string luat = dgvLuat.CurrentRow.Cells[1].Value.ToString();
            int length = luat.Length;
            for (int i = 0; i < length; i++)
            {
                str = luat.ToString();
                veTrai = str.Substring(str.LastIndexOf(":") + 1, str.LastIndexOf("->") - str.LastIndexOf(":") - 1);
                vePhai = str.Substring(str.LastIndexOf("->") + 2, str.Length - str.LastIndexOf("->") - 2);
            }
            txtVeTrai.Text = veTrai.ToString();
            txtVePhai.Text = vePhai.ToString();
        }

        #endregion Event

        #region Method

        /// <summary>
        /// hàm khóa các textbox
        /// </summary>
        public void LockText()
        {
            txtLuatSo.Enabled = false;
            txtVeTrai.Enabled = false;
            txtVePhai.Enabled = false;
        }

        /// <summary>
        /// hàm làm rỗng các textbox
        /// </summary>
        public void SetNull()
        {
            txtLuatSo.Text = string.Empty;
            txtVeTrai.Text = string.Empty;
            txtVePhai.Text = string.Empty;
        }

        /// <summary>
        /// hàm thực hiện ghi dữ liệu vào file Rules.txt
        /// </summary>
        public void GhiFile()
        {
            FileStream fs = new FileStream(path + "Rules.txt", FileMode.Append, FileAccess.Write);
            StreamWriter stw = new StreamWriter(fs, Encoding.UTF8);
            stw.WriteLine(txtLuatSo.Text.Trim() + ": " + txtVeTrai.Text.Trim() + " -> " + txtVePhai.Text.Trim());
            stw.Flush();
            stw.Close();
            fs.Close();
        }

        /// <summary>
        /// hàm thực hiện sửa dữ liệu trong file Rules.txt
        /// </summary>
        public void SuaFile()
        {
            StreamReader sr = File.OpenText("Rules.txt");
            string[] tam = new string[count_Rule];
            TTLuat ttLuat = new TTLuat();
            ttLuat._ruleName = txtLuatSo.Text;
            ttLuat._veTrai = txtVeTrai.Text;
            ttLuat._vePhai = txtVePhai.Text;
            for (int i = 0; i < count_Rule; i++)
            {
                if (R[i]._ruleName == ttLuat._ruleName)
                {
                    R[i] = ttLuat;
                    tam[i] = txtLuatSo.Text.Trim() + ": " + txtVeTrai.Text.Trim() + " -> " + txtVePhai.Text.Trim();
                    sr.ReadLine();
                }
                else
                    tam[i] = sr.ReadLine();
            }
            sr.Close();
            FileStream outtream = new FileStream("Rules.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(outtream, Encoding.UTF8);
            for (int i = 0; i < count_Rule; i++)
            {
                sw.WriteLine(tam[i]);
            }
            sw.Close();
        }

        /// <summary>
        /// hàm thực hiện xóa dữ liệu trong file Rules.txt
        /// </summary>
        public void XoaFile()
        {
            StreamReader sr = File.OpenText("Rules.txt");
            string[] tam = new string[count_Rule];
            TTLuat ttLuat = new TTLuat();
            ttLuat._ruleName = txtLuatSo.Text;
            ttLuat._vePhai = txtVePhai.Text;
            ttLuat._veTrai = txtVeTrai.Text;
            for (int i = 0; i < count_Rule; i++)
            {
                if (R[i]._ruleName == ttLuat._ruleName)
                {
                    DeleteRules(i);
                    i--;
                }
                else
                    tam[i] = sr.ReadLine();
            }
            sr.Close();
            FileStream outtream = new FileStream("Rules.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(outtream, Encoding.UTF8);
            for (int i = 0; i < count_Rule; i++)
            {
                sw.WriteLine(tam[i]);
            }
            sw.Close();
        }

        public int countRule()
        {
            int i = 0;
            StreamReader sr = File.OpenText("Rules.txt");
            while (sr.ReadLine() != null)
            {
                i++;
            }
            sr.Close();
            return i;
        }

        private TTLuat Tach_Rule(string input)
        {
            int len = input.Length;
            TTLuat ttLuat = new TTLuat();
            int i = 0;
            while (i < len && input[i] != ':')
            {
                ttLuat._ruleName += input[i].ToString();
                i++;
            }
            i++;
            while (i < len && input[i] != '-')
            {
                if (input[i] != '^' && input[i] != ' ')
                    ttLuat._veTrai += input[i].ToString();
                i++;
            }
            i += 2;
            while (i < len)
            {
                ttLuat._vePhai += input[i].ToString();
                i++;
            }
            return ttLuat;
        }

        private void LoadRules()
        {
            count_Rule = countRule();
            StreamReader sr = File.OpenText("Rules.txt");
            string tg = "";
            for (int i = 0; i < count_Rule; i++)
            {
                tg = sr.ReadLine();
                R[i] = Tach_Rule(tg);
            }
            sr.Close();
        }

        private void DeleteRules(int i)
        {
            for (int j = i; j < count_Rule - 1; j++)
                R[j] = R[j + 1];
            count_Rule--;
        }

        #endregion Method

        private void dgvLuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtLuatSo.Text = "";
            txtVePhai.Text = "";
            txtVeTrai.Text = "";
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;

        }
    }
}