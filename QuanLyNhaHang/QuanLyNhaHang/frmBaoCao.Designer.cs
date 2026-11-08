namespace QuanLyNhaHang
{
    partial class frmBaoCao
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTongSoNV = new System.Windows.Forms.Label();
            this.lblTongSoNV_TieuDe = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDoanhThuThang = new System.Windows.Forms.Label();
            this.lblDoanhThuThang_TieuDe = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTongSoKH = new System.Windows.Forms.Label();
            this.lblTongSoKH_TieuDe = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartDoanhThu6Thang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chartTyLeGioiTinh = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTaoBaoCao = new System.Windows.Forms.Button();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.cboLoaiBaoCao = new System.Windows.Forms.ComboBox();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu6Thang)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTyLeGioiTinh)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1380, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lblTongSoNV);
            this.panel1.Controls.Add(this.lblTongSoNV_TieuDe);
            this.panel1.Location = new System.Drawing.Point(6, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 145);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTongSoNV
            // 
            this.lblTongSoNV.AutoSize = true;
            this.lblTongSoNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongSoNV.ForeColor = System.Drawing.Color.White;
            this.lblTongSoNV.Location = new System.Drawing.Point(142, 65);
            this.lblTongSoNV.Name = "lblTongSoNV";
            this.lblTongSoNV.Size = new System.Drawing.Size(0, 46);
            this.lblTongSoNV.TabIndex = 1;
            this.lblTongSoNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTongSoNV.Click += new System.EventHandler(this.lblTongSoNV_Click);
            // 
            // lblTongSoNV_TieuDe
            // 
            this.lblTongSoNV_TieuDe.AutoSize = true;
            this.lblTongSoNV_TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongSoNV_TieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTongSoNV_TieuDe.Location = new System.Drawing.Point(93, 22);
            this.lblTongSoNV_TieuDe.Name = "lblTongSoNV_TieuDe";
            this.lblTongSoNV_TieuDe.Size = new System.Drawing.Size(217, 25);
            this.lblTongSoNV_TieuDe.TabIndex = 0;
            this.lblTongSoNV_TieuDe.Text = "TỔNG SỐ NHÂN VIÊN";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.lblDoanhThuThang);
            this.panel3.Controls.Add(this.lblDoanhThuThang_TieuDe);
            this.panel3.Location = new System.Drawing.Point(873, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(492, 145);
            this.panel3.TabIndex = 2;
            // 
            // lblDoanhThuThang
            // 
            this.lblDoanhThuThang.AutoSize = true;
            this.lblDoanhThuThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDoanhThuThang.ForeColor = System.Drawing.Color.White;
            this.lblDoanhThuThang.Location = new System.Drawing.Point(97, 65);
            this.lblDoanhThuThang.Name = "lblDoanhThuThang";
            this.lblDoanhThuThang.Size = new System.Drawing.Size(128, 42);
            this.lblDoanhThuThang.TabIndex = 1;
            this.lblDoanhThuThang.Text = "0 VNĐ";
            // 
            // lblDoanhThuThang_TieuDe
            // 
            this.lblDoanhThuThang_TieuDe.AutoSize = true;
            this.lblDoanhThuThang_TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDoanhThuThang_TieuDe.ForeColor = System.Drawing.Color.White;
            this.lblDoanhThuThang_TieuDe.Location = new System.Drawing.Point(100, 26);
            this.lblDoanhThuThang_TieuDe.Name = "lblDoanhThuThang_TieuDe";
            this.lblDoanhThuThang_TieuDe.Size = new System.Drawing.Size(294, 22);
            this.lblDoanhThuThang_TieuDe.TabIndex = 0;
            this.lblDoanhThuThang_TieuDe.Text = "DOANH THU THÁNG (11/2026)";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.lblTongSoKH);
            this.panel2.Controls.Add(this.lblTongSoKH_TieuDe);
            this.panel2.Location = new System.Drawing.Point(439, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 145);
            this.panel2.TabIndex = 1;
            // 
            // lblTongSoKH
            // 
            this.lblTongSoKH.AutoSize = true;
            this.lblTongSoKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongSoKH.ForeColor = System.Drawing.Color.White;
            this.lblTongSoKH.Location = new System.Drawing.Point(175, 65);
            this.lblTongSoKH.Name = "lblTongSoKH";
            this.lblTongSoKH.Size = new System.Drawing.Size(0, 46);
            this.lblTongSoKH.TabIndex = 2;
            this.lblTongSoKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTongSoKH_TieuDe
            // 
            this.lblTongSoKH_TieuDe.AutoSize = true;
            this.lblTongSoKH_TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongSoKH_TieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTongSoKH_TieuDe.Location = new System.Drawing.Point(103, 22);
            this.lblTongSoKH_TieuDe.Name = "lblTongSoKH_TieuDe";
            this.lblTongSoKH_TieuDe.Size = new System.Drawing.Size(243, 25);
            this.lblTongSoKH_TieuDe.TabIndex = 1;
            this.lblTongSoKH_TieuDe.Text = "TỔNG SỐ KHÁCH HÀNG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartDoanhThu6Thang);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(12, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 238);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tăng trưởng doanh thu 6 tháng gần nhất";
            // 
            // chartDoanhThu6Thang
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu6Thang.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDoanhThu6Thang.Legends.Add(legend1);
            this.chartDoanhThu6Thang.Location = new System.Drawing.Point(23, 26);
            this.chartDoanhThu6Thang.Name = "chartDoanhThu6Thang";
            this.chartDoanhThu6Thang.Size = new System.Drawing.Size(699, 193);
            this.chartDoanhThu6Thang.TabIndex = 0;
            this.chartDoanhThu6Thang.Text = "chart1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chartTyLeGioiTinh);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(787, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(605, 238);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tỷ lệ giới tính khách hàng";
            // 
            // chartTyLeGioiTinh
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTyLeGioiTinh.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTyLeGioiTinh.Legends.Add(legend2);
            this.chartTyLeGioiTinh.Location = new System.Drawing.Point(174, 26);
            this.chartTyLeGioiTinh.Name = "chartTyLeGioiTinh";
            this.chartTyLeGioiTinh.Size = new System.Drawing.Size(300, 193);
            this.chartTyLeGioiTinh.TabIndex = 0;
            this.chartTyLeGioiTinh.Text = "chart1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnLamMoi);
            this.groupBox4.Controls.Add(this.btnTaoBaoCao);
            this.groupBox4.Controls.Add(this.cboNhanVien);
            this.groupBox4.Controls.Add(this.cboLoaiBaoCao);
            this.groupBox4.Controls.Add(this.dtpDenNgay);
            this.groupBox4.Controls.Add(this.dtpTuNgay);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox4.Location = new System.Drawing.Point(12, 479);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(540, 275);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BỘ LỌC BÁO CÁO";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLamMoi.Location = new System.Drawing.Point(260, 213);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(141, 41);
            this.btnLamMoi.TabIndex = 9;
            this.btnLamMoi.Text = "[ Làm mới ]";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTaoBaoCao
            // 
            this.btnTaoBaoCao.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTaoBaoCao.Location = new System.Drawing.Point(48, 213);
            this.btnTaoBaoCao.Name = "btnTaoBaoCao";
            this.btnTaoBaoCao.Size = new System.Drawing.Size(141, 41);
            this.btnTaoBaoCao.TabIndex = 8;
            this.btnTaoBaoCao.Text = "[ Tạo báo cáo ]";
            this.btnTaoBaoCao.UseVisualStyleBackColor = false;
            this.btnTaoBaoCao.Click += new System.EventHandler(this.btnTaoBaoCao_Click);
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(156, 156);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(222, 28);
            this.cboNhanVien.TabIndex = 7;
            // 
            // cboLoaiBaoCao
            // 
            this.cboLoaiBaoCao.FormattingEnabled = true;
            this.cboLoaiBaoCao.Location = new System.Drawing.Point(156, 24);
            this.cboLoaiBaoCao.Name = "cboLoaiBaoCao";
            this.cboLoaiBaoCao.Size = new System.Drawing.Size(222, 28);
            this.cboLoaiBaoCao.TabIndex = 6;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(156, 114);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(369, 27);
            this.dtpDenNgay.TabIndex = 5;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(156, 68);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(369, 27);
            this.dtpTuNgay.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đến ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại báo cáo:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvBaoCao);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox5.Location = new System.Drawing.Point(558, 479);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(834, 275);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DANH SÁCH BÁO CÁO CHI TIẾT";
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCao.Location = new System.Drawing.Point(16, 26);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.RowHeadersWidth = 51;
            this.dgvBaoCao.RowTemplate.Height = 24;
            this.dgvBaoCao.Size = new System.Drawing.Size(803, 243);
            this.dgvBaoCao.TabIndex = 0;
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 766);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ BÁO CÁO THỐNG KÊ - frmBaoCao";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu6Thang)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTyLeGioiTinh)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.ComboBox cboLoaiBaoCao;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTongSoKH_TieuDe;
        private System.Windows.Forms.Label lblTongSoNV_TieuDe;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTongSoNV;
        private System.Windows.Forms.Label lblDoanhThuThang;
        private System.Windows.Forms.Label lblDoanhThuThang_TieuDe;
        private System.Windows.Forms.Label lblTongSoKH;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu6Thang;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTyLeGioiTinh;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTaoBaoCao;
        private System.Windows.Forms.DataGridView dgvBaoCao;
    }
}