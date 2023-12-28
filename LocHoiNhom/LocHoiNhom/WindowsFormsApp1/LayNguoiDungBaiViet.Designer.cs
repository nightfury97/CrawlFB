namespace TaiAnhNettruyen
{
    partial class LayNguoiDungBaiViet
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
            this.tbLinkTarget = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbThongBao = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numberRow = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lbDuongDan = new System.Windows.Forms.LinkLabel();
            this.lbNguoiDung = new System.Windows.Forms.LinkLabel();
            this.lbKetQua = new System.Windows.Forms.LinkLabel();
            this.SaveCookie = new System.Windows.Forms.Button();
            this.LoadCookie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberRow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Tài khoản mục tiêu";
            // 
            // tbLinkTarget
            // 
            this.tbLinkTarget.Location = new System.Drawing.Point(465, 126);
            this.tbLinkTarget.Name = "tbLinkTarget";
            this.tbLinkTarget.Size = new System.Drawing.Size(246, 22);
            this.tbLinkTarget.TabIndex = 41;
            this.tbLinkTarget.Text = "https://www.facebook.com/ho.lytien.1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 74);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 32);
            this.button1.TabIndex = 43;
            this.button1.Text = "1. Vào Facebook";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 121);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(294, 32);
            this.button2.TabIndex = 44;
            this.button2.Text = "2. Đăng nhập xong, vào tk mục tiêu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbThongBao
            // 
            this.lbThongBao.AutoSize = true;
            this.lbThongBao.ForeColor = System.Drawing.Color.Red;
            this.lbThongBao.Location = new System.Drawing.Point(38, 378);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(10, 16);
            this.lbThongBao.TabIndex = 45;
            this.lbThongBao.Text = ".";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 168);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(294, 32);
            this.button3.TabIndex = 46;
            this.button3.Text = "3. Xuất file danh sách bài đăng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Số lượng bài viết";
            // 
            // numberRow
            // 
            this.numberRow.Location = new System.Drawing.Point(465, 174);
            this.numberRow.Name = "numberRow";
            this.numberRow.Size = new System.Drawing.Size(120, 22);
            this.numberRow.TabIndex = 47;
            this.numberRow.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 217);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(294, 32);
            this.button4.TabIndex = 49;
            this.button4.Text = "4. Xem File bài đăng cần phân tích";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(23, 264);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(294, 32);
            this.button5.TabIndex = 51;
            this.button5.Text = "5. Phân tích bài đăng: lấy UID người bình luận";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(23, 310);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(294, 32);
            this.button6.TabIndex = 52;
            this.button6.Text = "6. Xác định thông tin người dùng";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lbDuongDan
            // 
            this.lbDuongDan.AutoSize = true;
            this.lbDuongDan.Location = new System.Drawing.Point(323, 233);
            this.lbDuongDan.Name = "lbDuongDan";
            this.lbDuongDan.Size = new System.Drawing.Size(68, 16);
            this.lbDuongDan.TabIndex = 54;
            this.lbDuongDan.TabStop = true;
            this.lbDuongDan.Text = "linkLabel1";
            this.lbDuongDan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbDuongDan_LinkClicked);
            // 
            // lbNguoiDung
            // 
            this.lbNguoiDung.AutoSize = true;
            this.lbNguoiDung.Location = new System.Drawing.Point(323, 272);
            this.lbNguoiDung.Name = "lbNguoiDung";
            this.lbNguoiDung.Size = new System.Drawing.Size(68, 16);
            this.lbNguoiDung.TabIndex = 54;
            this.lbNguoiDung.TabStop = true;
            this.lbNguoiDung.Text = "linkLabel1";
            this.lbNguoiDung.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbNguoiDung_LinkClicked);
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Location = new System.Drawing.Point(323, 318);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(68, 16);
            this.lbKetQua.TabIndex = 54;
            this.lbKetQua.TabStop = true;
            this.lbKetQua.Text = "linkLabel1";
            this.lbKetQua.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbKetQua_LinkClicked);
            // 
            // SaveCookie
            // 
            this.SaveCookie.Location = new System.Drawing.Point(323, 74);
            this.SaveCookie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveCookie.Name = "SaveCookie";
            this.SaveCookie.Size = new System.Drawing.Size(162, 32);
            this.SaveCookie.TabIndex = 55;
            this.SaveCookie.Text = "1.1 Save cookie";
            this.SaveCookie.UseVisualStyleBackColor = true;
            this.SaveCookie.Click += new System.EventHandler(this.SaveCookie_Click);
            // 
            // LoadCookie
            // 
            this.LoadCookie.Location = new System.Drawing.Point(502, 74);
            this.LoadCookie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoadCookie.Name = "LoadCookie";
            this.LoadCookie.Size = new System.Drawing.Size(162, 32);
            this.LoadCookie.TabIndex = 56;
            this.LoadCookie.Text = "1.2 Load Cookie";
            this.LoadCookie.UseVisualStyleBackColor = true;
            this.LoadCookie.Click += new System.EventHandler(this.LoadCookie_Click);
            // 
            // LayNguoiDungBaiViet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 406);
            this.Controls.Add(this.LoadCookie);
            this.Controls.Add(this.SaveCookie);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.lbNguoiDung);
            this.Controls.Add(this.lbDuongDan);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberRow);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbThongBao);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLinkTarget);
            this.Name = "LayNguoiDungBaiViet";
            this.Text = "Lấy người dùng từ bài đăng trên trang cá nhân";
            this.Load += new System.EventHandler(this.LayNguoiDungBaiViet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberRow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLinkTarget;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbThongBao;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numberRow;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.LinkLabel lbDuongDan;
        private System.Windows.Forms.LinkLabel lbNguoiDung;
        private System.Windows.Forms.LinkLabel lbKetQua;
        private System.Windows.Forms.Button SaveCookie;
        private System.Windows.Forms.Button LoadCookie;
    }
}