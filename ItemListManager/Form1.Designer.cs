namespace ItemListManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox grpNhapLieu;
        private System.Windows.Forms.GroupBox grpDanhSach;

        private System.Windows.Forms.Label lblMaVT;
        private System.Windows.Forms.Label lblTenVT;
        private System.Windows.Forms.Label lblDonViTinh;
        private System.Windows.Forms.Label lblDonGia;

        private System.Windows.Forms.TextBox txtMaVT;
        private System.Windows.Forms.TextBox txtTenVT;
        private System.Windows.Forms.TextBox txtDonGia;

        private System.Windows.Forms.ComboBox cboDonViTinh;

        private System.Windows.Forms.ListView listViewVatTu;

        private System.Windows.Forms.ColumnHeader colMaVT;
        private System.Windows.Forms.ColumnHeader colTenVT;
        private System.Windows.Forms.ColumnHeader colDonViTinh;
        private System.Windows.Forms.ColumnHeader colDonGia;

        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoaDong;
        private System.Windows.Forms.Button btnXoaToanBo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpNhapLieu = new System.Windows.Forms.GroupBox();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();

            this.lblMaVT = new System.Windows.Forms.Label();
            this.lblTenVT = new System.Windows.Forms.Label();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();

            this.txtMaVT = new System.Windows.Forms.TextBox();
            this.txtTenVT = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();

            this.cboDonViTinh = new System.Windows.Forms.ComboBox();

            this.listViewVatTu = new System.Windows.Forms.ListView();

            this.colMaVT = new System.Windows.Forms.ColumnHeader();
            this.colTenVT = new System.Windows.Forms.ColumnHeader();
            this.colDonViTinh = new System.Windows.Forms.ColumnHeader();
            this.colDonGia = new System.Windows.Forms.ColumnHeader();

            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoaDong = new System.Windows.Forms.Button();
            this.btnXoaToanBo = new System.Windows.Forms.Button();

            this.grpNhapLieu.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            this.SuspendLayout();

            // 
            // grpNhapLieu
            // 
            this.grpNhapLieu.Controls.Add(this.lblMaVT);
            this.grpNhapLieu.Controls.Add(this.txtMaVT);
            this.grpNhapLieu.Controls.Add(this.lblTenVT);
            this.grpNhapLieu.Controls.Add(this.txtTenVT);
            this.grpNhapLieu.Controls.Add(this.lblDonViTinh);
            this.grpNhapLieu.Controls.Add(this.cboDonViTinh);
            this.grpNhapLieu.Controls.Add(this.lblDonGia);
            this.grpNhapLieu.Controls.Add(this.txtDonGia);
            this.grpNhapLieu.Controls.Add(this.btnThemMoi);
            this.grpNhapLieu.Controls.Add(this.btnCapNhat);
            this.grpNhapLieu.Controls.Add(this.btnXoaDong);
            this.grpNhapLieu.Controls.Add(this.btnXoaToanBo);

            this.grpNhapLieu.Location = new System.Drawing.Point(15, 15);
            this.grpNhapLieu.Name = "grpNhapLieu";
            this.grpNhapLieu.Size = new System.Drawing.Size(300, 430);
            this.grpNhapLieu.TabIndex = 0;
            this.grpNhapLieu.TabStop = false;
            this.grpNhapLieu.Text = "Nhập thông tin vật tư";

            // 
            // lblMaVT
            // 
            this.lblMaVT.AutoSize = true;
            this.lblMaVT.Location = new System.Drawing.Point(20, 35);
            this.lblMaVT.Name = "lblMaVT";
            this.lblMaVT.Size = new System.Drawing.Size(75, 20);
            this.lblMaVT.Text = "Mã vật tư:";

            // 
            // txtMaVT
            // 
            this.txtMaVT.Location = new System.Drawing.Point(20, 60);
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(250, 27);
            this.txtMaVT.TabIndex = 0;

            // 
            // lblTenVT
            // 
            this.lblTenVT.AutoSize = true;
            this.lblTenVT.Location = new System.Drawing.Point(20, 100);
            this.lblTenVT.Name = "lblTenVT";
            this.lblTenVT.Size = new System.Drawing.Size(78, 20);
            this.lblTenVT.Text = "Tên vật tư:";

            // 
            // txtTenVT
            // 
            this.txtTenVT.Location = new System.Drawing.Point(20, 125);
            this.txtTenVT.Name = "txtTenVT";
            this.txtTenVT.Size = new System.Drawing.Size(250, 27);
            this.txtTenVT.TabIndex = 1;

            // 
            // lblDonViTinh
            // 
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.Location = new System.Drawing.Point(20, 165);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Size = new System.Drawing.Size(91, 20);
            this.lblDonViTinh.Text = "Đơn vị tính:";

            // 
            // cboDonViTinh
            // 
            this.cboDonViTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDonViTinh.FormattingEnabled = true;
            this.cboDonViTinh.Location = new System.Drawing.Point(20, 190);
            this.cboDonViTinh.Name = "cboDonViTinh";
            this.cboDonViTinh.Size = new System.Drawing.Size(250, 28);
            this.cboDonViTinh.TabIndex = 2;

            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(20, 230);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(102, 20);
            this.lblDonGia.Text = "Đơn giá nhập:";

            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(20, 255);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(250, 27);
            this.txtDonGia.TabIndex = 3;

            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(20, 305);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(115, 40);
            this.btnThemMoi.TabIndex = 4;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);

            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(155, 305);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(115, 40);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);

            // 
            // btnXoaDong
            // 
            this.btnXoaDong.Location = new System.Drawing.Point(20, 360);
            this.btnXoaDong.Name = "btnXoaDong";
            this.btnXoaDong.Size = new System.Drawing.Size(115, 40);
            this.btnXoaDong.TabIndex = 6;
            this.btnXoaDong.Text = "Xóa dòng";
            this.btnXoaDong.UseVisualStyleBackColor = true;
            this.btnXoaDong.Click += new System.EventHandler(this.btnXoaDong_Click);

            // 
            // btnXoaToanBo
            // 
            this.btnXoaToanBo.Location = new System.Drawing.Point(155, 360);
            this.btnXoaToanBo.Name = "btnXoaToanBo";
            this.btnXoaToanBo.Size = new System.Drawing.Size(115, 40);
            this.btnXoaToanBo.TabIndex = 7;
            this.btnXoaToanBo.Text = "Xóa toàn bộ";
            this.btnXoaToanBo.UseVisualStyleBackColor = true;
            this.btnXoaToanBo.Click += new System.EventHandler(this.btnXoaToanBo_Click);

            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.listViewVatTu);
            this.grpDanhSach.Location = new System.Drawing.Point(330, 15);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(620, 430);
            this.grpDanhSach.TabIndex = 1;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách vật tư";

            // 
            // listViewVatTu
            // 
            this.listViewVatTu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
            {
                this.colMaVT,
                this.colTenVT,
                this.colDonViTinh,
                this.colDonGia
            });

            this.listViewVatTu.FullRowSelect = true;
            this.listViewVatTu.GridLines = true;
            this.listViewVatTu.HideSelection = false;
            this.listViewVatTu.Location = new System.Drawing.Point(15, 30);
            this.listViewVatTu.Name = "listViewVatTu";
            this.listViewVatTu.Size = new System.Drawing.Size(590, 380);
            this.listViewVatTu.TabIndex = 0;
            this.listViewVatTu.UseCompatibleStateImageBehavior = false;
            this.listViewVatTu.View = System.Windows.Forms.View.Details;
            this.listViewVatTu.SelectedIndexChanged += new System.EventHandler(this.listViewVatTu_SelectedIndexChanged);

            // 
            // colMaVT
            // 
            this.colMaVT.Text = "Mã VT";
            this.colMaVT.Width = 100;

            // 
            // colTenVT
            // 
            this.colTenVT.Text = "Tên VT";
            this.colTenVT.Width = 200;

            // 
            // colDonViTinh
            // 
            this.colDonViTinh.Text = "Đơn vị tính";
            this.colDonViTinh.Width = 120;

            // 
            // colDonGia
            // 
            this.colDonGia.Text = "Đơn giá";
            this.colDonGia.Width = 130;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 470);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.grpNhapLieu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý danh mục Vật tư / Linh kiện";

            this.grpNhapLieu.ResumeLayout(false);
            this.grpNhapLieu.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}