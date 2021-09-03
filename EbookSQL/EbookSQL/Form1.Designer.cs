
namespace EbookSQL
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NamBan = new System.Windows.Forms.DateTimePicker();
            this.NamXuatBan = new System.Windows.Forms.TextBox();
            this.TenTacGia = new System.Windows.Forms.TextBox();
            this.GiaBan = new System.Windows.Forms.TextBox();
            this.MoTaSach = new System.Windows.Forms.TextBox();
            this.TenSach = new System.Windows.Forms.TextBox();
            this.GiaGoc = new System.Windows.Forms.TextBox();
            this.IDSach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBook = new System.Windows.Forms.Label();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_khoitao = new System.Windows.Forms.Button();
            this.cmdKey = new System.Windows.Forms.TextBox();
            this.cmdTim = new System.Windows.Forms.Button();
            this.deleteTim = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(925, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thongtin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(0, 22);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(919, 234);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NamBan);
            this.groupBox2.Controls.Add(this.NamXuatBan);
            this.groupBox2.Controls.Add(this.TenTacGia);
            this.groupBox2.Controls.Add(this.GiaBan);
            this.groupBox2.Controls.Add(this.MoTaSach);
            this.groupBox2.Controls.Add(this.TenSach);
            this.groupBox2.Controls.Add(this.GiaGoc);
            this.groupBox2.Controls.Add(this.IDSach);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(18, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thongtinchitiet";
            // 
            // NamBan
            // 
            this.NamBan.Location = new System.Drawing.Point(432, 149);
            this.NamBan.Name = "NamBan";
            this.NamBan.Size = new System.Drawing.Size(200, 23);
            this.NamBan.TabIndex = 15;
            // 
            // NamXuatBan
            // 
            this.NamXuatBan.Location = new System.Drawing.Point(432, 110);
            this.NamXuatBan.Name = "NamXuatBan";
            this.NamXuatBan.Size = new System.Drawing.Size(137, 23);
            this.NamXuatBan.TabIndex = 14;
            // 
            // TenTacGia
            // 
            this.TenTacGia.Location = new System.Drawing.Point(432, 68);
            this.TenTacGia.Name = "TenTacGia";
            this.TenTacGia.Size = new System.Drawing.Size(137, 23);
            this.TenTacGia.TabIndex = 13;
            // 
            // GiaBan
            // 
            this.GiaBan.Location = new System.Drawing.Point(432, 30);
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Size = new System.Drawing.Size(137, 23);
            this.GiaBan.TabIndex = 12;
            // 
            // MoTaSach
            // 
            this.MoTaSach.Location = new System.Drawing.Point(130, 152);
            this.MoTaSach.Name = "MoTaSach";
            this.MoTaSach.Size = new System.Drawing.Size(137, 23);
            this.MoTaSach.TabIndex = 11;
            // 
            // TenSach
            // 
            this.TenSach.Location = new System.Drawing.Point(130, 110);
            this.TenSach.Name = "TenSach";
            this.TenSach.Size = new System.Drawing.Size(137, 23);
            this.TenSach.TabIndex = 10;
            // 
            // GiaGoc
            // 
            this.GiaGoc.Location = new System.Drawing.Point(130, 68);
            this.GiaGoc.Name = "GiaGoc";
            this.GiaGoc.Size = new System.Drawing.Size(137, 23);
            this.GiaGoc.TabIndex = 9;
            // 
            // IDSach
            // 
            this.IDSach.Location = new System.Drawing.Point(130, 30);
            this.IDSach.Name = "IDSach";
            this.IDSach.Size = new System.Drawing.Size(137, 23);
            this.IDSach.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "PublisherTime";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "PublisherYear";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "BNamePublisher";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "BookPrice";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "BookSummary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "NameBook";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "CurrentBookPrice\t";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "IDBook";
            // 
            // SearchBook
            // 
            this.SearchBook.AutoSize = true;
            this.SearchBook.Location = new System.Drawing.Point(668, 329);
            this.SearchBook.Name = "SearchBook";
            this.SearchBook.Size = new System.Drawing.Size(72, 15);
            this.SearchBook.TabIndex = 16;
            this.SearchBook.Text = "Search Book";
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(38, 517);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(95, 33);
            this.bt_them.TabIndex = 2;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(190, 517);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(95, 33);
            this.bt_sua.TabIndex = 3;
            this.bt_sua.Text = "Cập nhật";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(346, 517);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(95, 33);
            this.bt_xoa.TabIndex = 4;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_khoitao
            // 
            this.bt_khoitao.Location = new System.Drawing.Point(503, 517);
            this.bt_khoitao.Name = "bt_khoitao";
            this.bt_khoitao.Size = new System.Drawing.Size(95, 33);
            this.bt_khoitao.TabIndex = 5;
            this.bt_khoitao.Text = "Khởi tạo lại";
            this.bt_khoitao.UseVisualStyleBackColor = true;
            this.bt_khoitao.Click += new System.EventHandler(this.bt_khoitao_Click);
            // 
            // cmdKey
            // 
            this.cmdKey.Location = new System.Drawing.Point(668, 347);
            this.cmdKey.Name = "cmdKey";
            this.cmdKey.Size = new System.Drawing.Size(189, 23);
            this.cmdKey.TabIndex = 17;
            // 
            // cmdTim
            // 
            this.cmdTim.Location = new System.Drawing.Point(863, 343);
            this.cmdTim.Name = "cmdTim";
            this.cmdTim.Size = new System.Drawing.Size(74, 28);
            this.cmdTim.TabIndex = 18;
            this.cmdTim.Text = "Tìm kiếm";
            this.cmdTim.UseVisualStyleBackColor = true;
            this.cmdTim.Click += new System.EventHandler(this.cmdTim_Click);
            // 
            // deleteTim
            // 
            this.deleteTim.Location = new System.Drawing.Point(782, 377);
            this.deleteTim.Name = "deleteTim";
            this.deleteTim.Size = new System.Drawing.Size(155, 28);
            this.deleteTim.TabIndex = 19;
            this.deleteTim.Text = "Xóa tìm kiếm";
            this.deleteTim.UseVisualStyleBackColor = true;
            this.deleteTim.Click += new System.EventHandler(this.deleteTim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 557);
            this.Controls.Add(this.deleteTim);
            this.Controls.Add(this.cmdTim);
            this.Controls.Add(this.cmdKey);
            this.Controls.Add(this.SearchBook);
            this.Controls.Add(this.bt_khoitao);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker NamBan;
        private System.Windows.Forms.TextBox NamXuatBan;
        private System.Windows.Forms.TextBox TenTacGia;
        private System.Windows.Forms.TextBox GiaBan;
        private System.Windows.Forms.TextBox MoTaSach;
        private System.Windows.Forms.TextBox TenSach;
        private System.Windows.Forms.TextBox GiaGoc;
        private System.Windows.Forms.TextBox IDSach;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_khoitao;
        private System.Windows.Forms.Label SearchBook;
        private System.Windows.Forms.TextBox cmdKey;
        private System.Windows.Forms.Button cmdTim;
        private System.Windows.Forms.Button deleteTim;
    }
}