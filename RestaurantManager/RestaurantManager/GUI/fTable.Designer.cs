namespace RestaurantManager.GUI
{
    partial class fTable
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
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTongCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbDanhMuc = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaDM = new System.Windows.Forms.Button();
            this.btnSuaDV = new System.Windows.Forms.Button();
            this.btnThemDM = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(157, 28);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(157, 28);
            this.thêmToolStripMenuItem.Text = "Thêm mới";
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 88);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(157, 28);
            this.sửaToolStripMenuItem.Text = "Chỉnh sửa";
            // 
            // colSTT
            // 
            this.colSTT.DataPropertyName = "STT";
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Visible = false;
            this.colSTT.Width = 125;
            // 
            // clTrangThai
            // 
            this.clTrangThai.DataPropertyName = "TrangThai";
            this.clTrangThai.HeaderText = "Trạng thái";
            this.clTrangThai.MinimumWidth = 6;
            this.clTrangThai.Name = "clTrangThai";
            this.clTrangThai.ReadOnly = true;
            this.clTrangThai.Width = 125;
            // 
            // clTongCong
            // 
            this.clTongCong.DataPropertyName = "TongCong";
            this.clTongCong.HeaderText = "Tổng cộng";
            this.clTongCong.MinimumWidth = 6;
            this.clTongCong.Name = "clTongCong";
            this.clTongCong.ReadOnly = true;
            this.clTongCong.Width = 125;
            // 
            // clTenBan
            // 
            this.clTenBan.DataPropertyName = "TenBan";
            this.clTenBan.HeaderText = "Tên bàn";
            this.clTenBan.MinimumWidth = 6;
            this.clTenBan.Name = "clTenBan";
            this.clTenBan.ReadOnly = true;
            this.clTenBan.Width = 125;
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
            // clSTT
            // 
            this.clSTT.HeaderText = "STT";
            this.clSTT.MinimumWidth = 6;
            this.clSTT.Name = "clSTT";
            this.clSTT.ReadOnly = true;
            this.clSTT.Width = 50;
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.BackgroundColor = System.Drawing.Color.White;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clID,
            this.clTenBan,
            this.clTongCong,
            this.clTrangThai,
            this.colSTT});
            this.dgvTable.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTable.Location = new System.Drawing.Point(28, 41);
            this.dgvTable.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.RowHeadersVisible = false;
            this.dgvTable.RowHeadersWidth = 51;
            this.dgvTable.Size = new System.Drawing.Size(473, 450);
            this.dgvTable.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTable);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 111);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(528, 514);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách bàn";
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
            this.groupBox1.Location = new System.Drawing.Point(24, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(545, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khu vực";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(134, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 639);
            this.panel1.TabIndex = 5;
            // 
            // btnXoaDM
            // 
            this.btnXoaDM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaDM.FlatAppearance.BorderSize = 0;
            this.btnXoaDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDM.Image = global::RestaurantManager.Properties.Resources.huy;
            this.btnXoaDM.Location = new System.Drawing.Point(466, 17);
            this.btnXoaDM.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaDM.Name = "btnXoaDM";
            this.btnXoaDM.Size = new System.Drawing.Size(77, 67);
            this.btnXoaDM.TabIndex = 1;
            this.btnXoaDM.UseVisualStyleBackColor = true;
            this.btnXoaDM.Click += new System.EventHandler(this.btnXoaDM_Click);
            // 
            // btnSuaDV
            // 
            this.btnSuaDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuaDV.FlatAppearance.BorderSize = 0;
            this.btnSuaDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaDV.Image = global::RestaurantManager.Properties.Resources.icon_contract;
            this.btnSuaDV.Location = new System.Drawing.Point(392, 17);
            this.btnSuaDV.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaDV.Name = "btnSuaDV";
            this.btnSuaDV.Size = new System.Drawing.Size(70, 64);
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
            this.btnThemDM.Location = new System.Drawing.Point(324, 25);
            this.btnThemDM.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemDM.Name = "btnThemDM";
            this.btnThemDM.Size = new System.Drawing.Size(60, 49);
            this.btnThemDM.TabIndex = 1;
            this.btnThemDM.UseVisualStyleBackColor = true;
            this.btnThemDM.Click += new System.EventHandler(this.btnThemDM_Click);
            // 
            // fTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(839, 719);
            this.Controls.Add(this.panel1);
            this.Name = "fTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTable";
            this.Load += new System.EventHandler(this.fTable_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTongCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoaDM;
        private System.Windows.Forms.Button btnSuaDV;
        private System.Windows.Forms.Button btnThemDM;
        private System.Windows.Forms.ComboBox cbDanhMuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}