namespace Nhom7_ChuanDoanLoiPhanCungMayTinh
{
    partial class Luat
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTrieuChung = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLuatSo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVePhai = new System.Windows.Forms.TextBox();
            this.txtVeTrai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChonVeTrai = new System.Windows.Forms.Button();
            this.btnChonVePhai = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvMoTaLuat = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCountRules = new System.Windows.Forms.Label();
            this.dgvLuat = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuyChon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrieuChung)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoTaLuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTrieuChung);
            this.groupBox1.Location = new System.Drawing.Point(90, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sự kiện";
            // 
            // dgvTrieuChung
            // 
            this.dgvTrieuChung.AllowUserToAddRows = false;
            this.dgvTrieuChung.AllowUserToDeleteRows = false;
            this.dgvTrieuChung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrieuChung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.Column2});
            this.dgvTrieuChung.Location = new System.Drawing.Point(9, 28);
            this.dgvTrieuChung.Name = "dgvTrieuChung";
            this.dgvTrieuChung.RowHeadersVisible = false;
            this.dgvTrieuChung.Size = new System.Drawing.Size(353, 197);
            this.dgvTrieuChung.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mô tả";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLuatSo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtVePhai);
            this.groupBox2.Controls.Add(this.txtVeTrai);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(617, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 232);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tập luật";
            // 
            // txtLuatSo
            // 
            this.txtLuatSo.Enabled = false;
            this.txtLuatSo.Location = new System.Drawing.Point(73, 69);
            this.txtLuatSo.Name = "txtLuatSo";
            this.txtLuatSo.Size = new System.Drawing.Size(195, 22);
            this.txtLuatSo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Luật số";
            // 
            // txtVePhai
            // 
            this.txtVePhai.Enabled = false;
            this.txtVePhai.Location = new System.Drawing.Point(73, 152);
            this.txtVePhai.Name = "txtVePhai";
            this.txtVePhai.Size = new System.Drawing.Size(195, 22);
            this.txtVePhai.TabIndex = 7;
            // 
            // txtVeTrai
            // 
            this.txtVeTrai.Enabled = false;
            this.txtVeTrai.Location = new System.Drawing.Point(73, 110);
            this.txtVeTrai.Name = "txtVeTrai";
            this.txtVeTrai.Size = new System.Drawing.Size(195, 22);
            this.txtVeTrai.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vế phải";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vế trái";
            // 
            // btnChonVeTrai
            // 
            this.btnChonVeTrai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChonVeTrai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonVeTrai.Location = new System.Drawing.Point(473, 73);
            this.btnChonVeTrai.Name = "btnChonVeTrai";
            this.btnChonVeTrai.Size = new System.Drawing.Size(124, 29);
            this.btnChonVeTrai.TabIndex = 11;
            this.btnChonVeTrai.Text = "Chọn vế trái >>";
            this.btnChonVeTrai.UseVisualStyleBackColor = true;
            this.btnChonVeTrai.Click += new System.EventHandler(this.OnBtnChonVeTraiClick);
            // 
            // btnChonVePhai
            // 
            this.btnChonVePhai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChonVePhai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonVePhai.Location = new System.Drawing.Point(473, 127);
            this.btnChonVePhai.Name = "btnChonVePhai";
            this.btnChonVePhai.Size = new System.Drawing.Size(124, 29);
            this.btnChonVePhai.TabIndex = 12;
            this.btnChonVePhai.Text = "Chọn vế phải >>";
            this.btnChonVePhai.UseVisualStyleBackColor = true;
            this.btnChonVePhai.Click += new System.EventHandler(this.OnBtnChonVePhaiClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvMoTaLuat);
            this.groupBox3.Controls.Add(this.lblCountRules);
            this.groupBox3.Controls.Add(this.dgvLuat);
            this.groupBox3.Location = new System.Drawing.Point(90, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(604, 293);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách tập luật";
            // 
            // dgvMoTaLuat
            // 
            this.dgvMoTaLuat.AllowUserToAddRows = false;
            this.dgvMoTaLuat.AllowUserToDeleteRows = false;
            this.dgvMoTaLuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoTaLuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.dgvMoTaLuat.Location = new System.Drawing.Point(306, 29);
            this.dgvMoTaLuat.Name = "dgvMoTaLuat";
            this.dgvMoTaLuat.RowHeadersVisible = false;
            this.dgvMoTaLuat.Size = new System.Drawing.Size(289, 258);
            this.dgvMoTaLuat.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 40;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Mô tả luật";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 205;
            // 
            // lblCountRules
            // 
            this.lblCountRules.AutoSize = true;
            this.lblCountRules.Location = new System.Drawing.Point(526, 10);
            this.lblCountRules.Name = "lblCountRules";
            this.lblCountRules.Size = new System.Drawing.Size(0, 16);
            this.lblCountRules.TabIndex = 12;
            // 
            // dgvLuat
            // 
            this.dgvLuat.AllowUserToAddRows = false;
            this.dgvLuat.AllowUserToDeleteRows = false;
            this.dgvLuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dataGridViewTextBoxColumn1});
            this.dgvLuat.Location = new System.Drawing.Point(-6, 29);
            this.dgvLuat.Name = "dgvLuat";
            this.dgvLuat.RowHeadersVisible = false;
            this.dgvLuat.Size = new System.Drawing.Size(289, 258);
            this.dgvLuat.TabIndex = 10;
            this.dgvLuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLuat_CellClick);
            this.dgvLuat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLuat_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Luật";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 220;
            // 
            // btnLuu
            // 
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Location = new System.Drawing.Point(807, 404);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(95, 35);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.OnBtnLuuClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(807, 352);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 35);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(700, 404);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 35);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.OnBtnSuaClick);
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(700, 352);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 35);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.OnBtnThemClick);
            // 
            // btnHuyChon
            // 
            this.btnHuyChon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyChon.Location = new System.Drawing.Point(473, 181);
            this.btnHuyChon.Name = "btnHuyChon";
            this.btnHuyChon.Size = new System.Drawing.Size(124, 29);
            this.btnHuyChon.TabIndex = 15;
            this.btnHuyChon.Text = "<< Hủy chọn";
            this.btnHuyChon.UseVisualStyleBackColor = true;
            this.btnHuyChon.Click += new System.EventHandler(this.OnBtnHuyChonClick);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(743, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "<< Hủy >>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // Luat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHuyChon);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChonVePhai);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnChonVeTrai);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Luat";
            this.Size = new System.Drawing.Size(1000, 565);
            this.Load += new System.EventHandler(this.OnLuatLoad);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrieuChung)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoTaLuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtVePhai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChonVeTrai;
        private System.Windows.Forms.Button btnChonVePhai;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvLuat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtVeTrai;
        private System.Windows.Forms.DataGridView dgvTrieuChung;
        private System.Windows.Forms.Button btnHuyChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox txtLuatSo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvMoTaLuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label lblCountRules;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button1;
    }
}
