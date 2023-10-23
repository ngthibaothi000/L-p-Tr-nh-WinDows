namespace RestaurantManager.GUI
{
    partial class fNextTable
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
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbToTalbe = new System.Windows.Forms.ComboBox();
            this.lbBan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChuyen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clTenMon,
            this.clSoLuong,
            this.clDonGia,
            this.clThanhTien});
            this.dgvHoaDon.Location = new System.Drawing.Point(64, 142);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.Size = new System.Drawing.Size(497, 231);
            this.dgvHoaDon.TabIndex = 17;
            // 
            // clSTT
            // 
            this.clSTT.HeaderText = "STT";
            this.clSTT.MinimumWidth = 6;
            this.clSTT.Name = "clSTT";
            this.clSTT.ReadOnly = true;
            this.clSTT.Width = 50;
            // 
            // clTenMon
            // 
            this.clTenMon.DataPropertyName = "TenMonAn";
            this.clTenMon.HeaderText = "Tên";
            this.clTenMon.MinimumWidth = 6;
            this.clTenMon.Name = "clTenMon";
            this.clTenMon.ReadOnly = true;
            this.clTenMon.Width = 150;
            // 
            // clSoLuong
            // 
            this.clSoLuong.DataPropertyName = "SoLuong";
            this.clSoLuong.HeaderText = "Số lượng";
            this.clSoLuong.MinimumWidth = 6;
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.ReadOnly = true;
            this.clSoLuong.Width = 90;
            // 
            // clDonGia
            // 
            this.clDonGia.DataPropertyName = "DonGia";
            this.clDonGia.HeaderText = "Đơn Giá";
            this.clDonGia.MinimumWidth = 6;
            this.clDonGia.Name = "clDonGia";
            this.clDonGia.ReadOnly = true;
            this.clDonGia.Width = 125;
            // 
            // clThanhTien
            // 
            this.clThanhTien.DataPropertyName = "ThanhTien";
            this.clThanhTien.HeaderText = "Thành tiền";
            this.clThanhTien.MinimumWidth = 6;
            this.clThanhTien.Name = "clThanhTien";
            this.clThanhTien.ReadOnly = true;
            this.clThanhTien.Width = 125;
            // 
            // cbToTalbe
            // 
            this.cbToTalbe.BackColor = System.Drawing.Color.White;
            this.cbToTalbe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbToTalbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbToTalbe.FormattingEnabled = true;
            this.cbToTalbe.Location = new System.Drawing.Point(135, 385);
            this.cbToTalbe.Margin = new System.Windows.Forms.Padding(4);
            this.cbToTalbe.Name = "cbToTalbe";
            this.cbToTalbe.Size = new System.Drawing.Size(181, 33);
            this.cbToTalbe.TabIndex = 15;
            // 
            // lbBan
            // 
            this.lbBan.BackColor = System.Drawing.Color.White;
            this.lbBan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBan.ForeColor = System.Drawing.Color.Red;
            this.lbBan.Location = new System.Drawing.Point(126, 85);
            this.lbBan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBan.Name = "lbBan";
            this.lbBan.Size = new System.Drawing.Size(181, 28);
            this.lbBan.TabIndex = 14;
            this.lbBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Từ bàn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 402);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Xác nhận chuyển:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 391);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Đến bàn:";
            // 
            // btnChuyen
            // 
            this.btnChuyen.BackColor = System.Drawing.Color.Transparent;
            this.btnChuyen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChuyen.FlatAppearance.BorderSize = 0;
            this.btnChuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChuyen.Image = global::RestaurantManager.Properties.Resources.okne;
            this.btnChuyen.Location = new System.Drawing.Point(499, 380);
            this.btnChuyen.Margin = new System.Windows.Forms.Padding(4);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(52, 53);
            this.btnChuyen.TabIndex = 16;
            this.btnChuyen.UseVisualStyleBackColor = false;
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // fNextTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(623, 502);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.btnChuyen);
            this.Controls.Add(this.cbToTalbe);
            this.Controls.Add(this.lbBan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "fNextTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fNextTable";
            this.Load += new System.EventHandler(this.fNextTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThanhTien;
        private System.Windows.Forms.Button btnChuyen;
        private System.Windows.Forms.ComboBox cbToTalbe;
        private System.Windows.Forms.Label lbBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}