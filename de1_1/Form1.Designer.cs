namespace de1_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chinhanhtxt = new System.Windows.Forms.ComboBox();
            this.makhtxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.diachitxt = new System.Windows.Forms.TextBox();
            this.sdttxt = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.chinhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(763, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT THÔNG TIN KHÁC HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chi nhánh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Họ tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số điện thoại";
            // 
            // chinhanhtxt
            // 
            this.chinhanhtxt.FormattingEnabled = true;
            this.chinhanhtxt.Items.AddRange(new object[] {
            "Ha Nam",
            "Ha Noi"});
            this.chinhanhtxt.Location = new System.Drawing.Point(372, 161);
            this.chinhanhtxt.Name = "chinhanhtxt";
            this.chinhanhtxt.Size = new System.Drawing.Size(287, 33);
            this.chinhanhtxt.TabIndex = 6;
            this.chinhanhtxt.Text = "<<chon chi nhanh>>";
            // 
            // makhtxt
            // 
            this.makhtxt.Location = new System.Drawing.Point(372, 234);
            this.makhtxt.Name = "makhtxt";
            this.makhtxt.Size = new System.Drawing.Size(287, 31);
            this.makhtxt.TabIndex = 7;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(372, 307);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(287, 31);
            this.nametxt.TabIndex = 8;
            this.nametxt.Text = " ";
            // 
            // diachitxt
            // 
            this.diachitxt.Location = new System.Drawing.Point(372, 380);
            this.diachitxt.Name = "diachitxt";
            this.diachitxt.Size = new System.Drawing.Size(287, 31);
            this.diachitxt.TabIndex = 9;
            // 
            // sdttxt
            // 
            this.sdttxt.Location = new System.Drawing.Point(372, 453);
            this.sdttxt.Name = "sdttxt";
            this.sdttxt.Size = new System.Drawing.Size(287, 31);
            this.sdttxt.TabIndex = 10;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(803, 152);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(190, 53);
            this.add.TabIndex = 11;
            this.add.Text = "Thêm";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(803, 245);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(190, 53);
            this.change.TabIndex = 12;
            this.change.Text = "Sửa";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(803, 338);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(190, 53);
            this.delete.TabIndex = 13;
            this.delete.Text = "Xóa";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(803, 431);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(190, 53);
            this.cancel.TabIndex = 14;
            this.cancel.Text = "Thoát";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // dataGV
            // 
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chinhanh,
            this.maKH,
            this.hoten,
            this.diachi,
            this.sdt});
            this.dataGV.Location = new System.Drawing.Point(1, 537);
            this.dataGV.Name = "dataGV";
            this.dataGV.RowTemplate.Height = 33;
            this.dataGV.Size = new System.Drawing.Size(1131, 421);
            this.dataGV.TabIndex = 15;
            this.dataGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellclick);
            // 
            // chinhanh
            // 
            this.chinhanh.HeaderText = "Mã Khách hàng";
            this.chinhanh.Name = "chinhanh";
            // 
            // maKH
            // 
            this.maKH.HeaderText = "Chi nhánh";
            this.maKH.Name = "maKH";
            // 
            // hoten
            // 
            this.hoten.HeaderText = "Họ Tên";
            this.hoten.Name = "hoten";
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.Name = "diachi";
            // 
            // sdt
            // 
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.Name = "sdt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 952);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.change);
            this.Controls.Add(this.add);
            this.Controls.Add(this.sdttxt);
            this.Controls.Add(this.diachitxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.makhtxt);
            this.Controls.Add(this.chinhanhtxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox chinhanhtxt;
        private System.Windows.Forms.TextBox makhtxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox diachitxt;
        private System.Windows.Forms.TextBox sdttxt;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn chinhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
    }
}

