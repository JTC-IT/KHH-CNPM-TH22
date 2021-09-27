namespace DesignSRS
{
    partial class QuanLyKho
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
            this.iconBtnThem = new FontAwesome.Sharp.IconButton();
            this.iconBtnSua = new FontAwesome.Sharp.IconButton();
            this.iconBtnXoa = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconBtnThem
            // 
            this.iconBtnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(115)))), ((int)(((byte)(167)))));
            this.iconBtnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnThem.ForeColor = System.Drawing.Color.White;
            this.iconBtnThem.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconBtnThem.IconColor = System.Drawing.Color.White;
            this.iconBtnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnThem.IconSize = 28;
            this.iconBtnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnThem.Location = new System.Drawing.Point(576, 160);
            this.iconBtnThem.Name = "iconBtnThem";
            this.iconBtnThem.Size = new System.Drawing.Size(97, 33);
            this.iconBtnThem.TabIndex = 59;
            this.iconBtnThem.Text = "Thêm";
            this.iconBtnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnThem.UseVisualStyleBackColor = false;
            this.iconBtnThem.Click += new System.EventHandler(this.iconBtnThem_Click);
            // 
            // iconBtnSua
            // 
            this.iconBtnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(115)))), ((int)(((byte)(167)))));
            this.iconBtnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnSua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnSua.ForeColor = System.Drawing.Color.White;
            this.iconBtnSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconBtnSua.IconColor = System.Drawing.Color.White;
            this.iconBtnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnSua.IconSize = 28;
            this.iconBtnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnSua.Location = new System.Drawing.Point(679, 160);
            this.iconBtnSua.Name = "iconBtnSua";
            this.iconBtnSua.Size = new System.Drawing.Size(97, 33);
            this.iconBtnSua.TabIndex = 60;
            this.iconBtnSua.Text = "Sửa";
            this.iconBtnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnSua.UseVisualStyleBackColor = false;
            this.iconBtnSua.Click += new System.EventHandler(this.iconBtnSua_Click);
            // 
            // iconBtnXoa
            // 
            this.iconBtnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(115)))), ((int)(((byte)(167)))));
            this.iconBtnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnXoa.ForeColor = System.Drawing.Color.White;
            this.iconBtnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconBtnXoa.IconColor = System.Drawing.Color.White;
            this.iconBtnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnXoa.IconSize = 28;
            this.iconBtnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnXoa.Location = new System.Drawing.Point(782, 160);
            this.iconBtnXoa.Name = "iconBtnXoa";
            this.iconBtnXoa.Size = new System.Drawing.Size(97, 33);
            this.iconBtnXoa.TabIndex = 61;
            this.iconBtnXoa.Text = "Xóa";
            this.iconBtnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnXoa.UseVisualStyleBackColor = false;
            this.iconBtnXoa.Click += new System.EventHandler(this.iconBtnXoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 322);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.DonVT,
            this.GiaBL,
            this.GiaBS,
            this.GiaM,
            this.GhiChu});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(863, 296);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 23);
            this.label1.TabIndex = 63;
            this.label1.Text = "QUẢN LÍ TỒN KHO";
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 130;
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 130;
            // 
            // DonVT
            // 
            this.DonVT.HeaderText = "Đơn vị tính";
            this.DonVT.Name = "DonVT";
            this.DonVT.Width = 130;
            // 
            // GiaBL
            // 
            this.GiaBL.HeaderText = "Giá bán lẻ";
            this.GiaBL.Name = "GiaBL";
            // 
            // GiaBS
            // 
            this.GiaBS.HeaderText = "Giá bán sỉ";
            this.GiaBS.Name = "GiaBS";
            // 
            // GiaM
            // 
            this.GiaM.HeaderText = "Giá mua";
            this.GiaM.Name = "GiaM";
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Width = 120;
            // 
            // QuanLyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 533);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.iconBtnXoa);
            this.Controls.Add(this.iconBtnSua);
            this.Controls.Add(this.iconBtnThem);
            this.Name = "QuanLyKho";
            this.Text = "QuanLyKho";
            this.Load += new System.EventHandler(this.QuanLyKho_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconBtnThem;
        private FontAwesome.Sharp.IconButton iconBtnSua;
        private FontAwesome.Sharp.IconButton iconBtnXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaM;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}