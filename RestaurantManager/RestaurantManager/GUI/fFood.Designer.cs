namespace RestaurantManager.GUI
{
    partial class fFood
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
            this.components = new System.ComponentModel.Container();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvThucDon = new System.Windows.Forms.DataGridView();
            this.btnXoaDM = new System.Windows.Forms.Button();
            this.cbDanhMuc = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSuaDV = new System.Windows.Forms.Button();
            this.btnThemDM = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(123, 28);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(123, 28);
            this.thêmToolStripMenuItem.Text = "Thêm";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 88);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(123, 28);
            this.sửaToolStripMenuItem.Text = "Sửa";
            // 
            // clID
            // 
            this.clID.DataPropertyName = "ID";
            this.clID.HeaderText = "ID";
            this.clID.MinimumWidth = 6;
            this.clID.Name = "clID";
            this.clID.ReadOnly = true;
            this.clID.Visible = false;
            this.clID.Width = 125;
            // 
            // clDonVi
            // 
            this.clDonVi.DataPropertyName = "DonVi";
            this.clDonVi.HeaderText = "Đơn vị";
            this.clDonVi.MinimumWidth = 6;
            this.clDonVi.Name = "clDonVi";
            this.clDonVi.ReadOnly = true;
            this.clDonVi.Width = 80;
            // 
            // clGia
            // 
            this.clGia.DataPropertyName = "DonGia";
            this.clGia.HeaderText = "Đơn giá";
            this.clGia.MinimumWidth = 6;
            this.clGia.Name = "clGia";
            this.clGia.ReadOnly = true;
            this.clGia.Width = 90;
            // 
            // clTenMonAn
            // 
            this.clTenMonAn.DataPropertyName = "TenMonAn";
            this.clTenMonAn.HeaderText = "Tên";
            this.clTenMonAn.MinimumWidth = 6;
            this.clTenMonAn.Name = "clTenMonAn";
            this.clTenMonAn.ReadOnly = true;
            this.clTenMonAn.Width = 170;
            // 
            // clSTT
            // 
            this.clSTT.HeaderText = "STT";
            this.clSTT.MinimumWidth = 6;
            this.clSTT.Name = "clSTT";
            this.clSTT.ReadOnly = true;
            this.clSTT.Width = 50;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvThucDon);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 111);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(567, 583);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thực đơn";
            // 
            // dgvThucDon
            // 
            this.dgvThucDon.AllowUserToAddRows = false;
            this.dgvThucDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clTenMonAn,
            this.clGia,
            this.clDonVi,
            this.clID});
            this.dgvThucDon.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvThucDon.Location = new System.Drawing.Point(16, 31);
            this.dgvThucDon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThucDon.Name = "dgvThucDon";
            this.dgvThucDon.ReadOnly = true;
            this.dgvThucDon.RowHeadersVisible = false;
            this.dgvThucDon.RowHeadersWidth = 51;
            this.dgvThucDon.Size = new System.Drawing.Size(529, 542);
            this.dgvThucDon.TabIndex = 0;
            // 
            // btnXoaDM
            // 
            this.btnXoaDM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaDM.FlatAppearance.BorderSize = 0;
            this.btnXoaDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDM.Image = global::RestaurantManager.Properties.Resources.huy;
            this.btnXoaDM.Location = new System.Drawing.Point(460, 20);
            this.btnXoaDM.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaDM.Name = "btnXoaDM";
            this.btnXoaDM.Size = new System.Drawing.Size(60, 64);
            this.btnXoaDM.TabIndex = 1;
            this.btnXoaDM.UseVisualStyleBackColor = true;
            this.btnXoaDM.Click += new System.EventHandler(this.btnXoaDM_Click);
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDanhMuc.FormattingEnabled = true;
            this.cbDanhMuc.Items.AddRange(new object[] {
            "Toàn bộ"});
            this.cbDanhMuc.Location = new System.Drawing.Point(8, 31);
            this.cbDanhMuc.Margin = new System.Windows.Forms.Padding(4);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(307, 34);
            this.cbDanhMuc.TabIndex = 0;
            this.cbDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cbDanhMuc_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoaDM);
            this.groupBox1.Controls.Add(this.btnSuaDV);
            this.groupBox1.Controls.Add(this.btnThemDM);
            this.groupBox1.Controls.Add(this.cbDanhMuc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(545, 97);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục";
            // 
            // btnSuaDV
            // 
            this.btnSuaDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuaDV.FlatAppearance.BorderSize = 0;
            this.btnSuaDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaDV.Image = global::RestaurantManager.Properties.Resources.suachua;
            this.btnSuaDV.Location = new System.Drawing.Point(392, 15);
            this.btnSuaDV.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaDV.Name = "btnSuaDV";
            this.btnSuaDV.Size = new System.Drawing.Size(60, 74);
            this.btnSuaDV.TabIndex = 1;
            this.btnSuaDV.UseVisualStyleBackColor = true;
            this.btnSuaDV.Click += new System.EventHandler(this.btnSuaDV_Click);
            // 
            // btnThemDM
            // 
            this.btnThemDM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemDM.FlatAppearance.BorderSize = 0;
            this.btnThemDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDM.Image = global::RestaurantManager.Properties.Resources._2961710;
            this.btnThemDM.Location = new System.Drawing.Point(324, 28);
            this.btnThemDM.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemDM.Name = "btnThemDM";
            this.btnThemDM.Size = new System.Drawing.Size(60, 49);
            this.btnThemDM.TabIndex = 1;
            this.btnThemDM.UseVisualStyleBackColor = true;
            this.btnThemDM.Click += new System.EventHandler(this.btnThemDM_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(44, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 698);
            this.panel1.TabIndex = 4;
            // 
            // fFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 710);
            this.Controls.Add(this.panel1);
            this.Name = "fFood";
            this.Text = "fFood";
            this.Load += new System.EventHandler(this.fFood_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvThucDon;
        private System.Windows.Forms.Button btnXoaDM;
        private System.Windows.Forms.Button btnSuaDV;
        private System.Windows.Forms.Button btnThemDM;
        private System.Windows.Forms.ComboBox cbDanhMuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}