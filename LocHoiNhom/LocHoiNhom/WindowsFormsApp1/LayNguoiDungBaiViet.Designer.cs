﻿namespace TaiAnhNettruyen
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
            this.tbLinkTarget.Text = "https://web.facebook.com/ho.lytien.1";
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
            6,
            0,
            0,
            0});
            // 
            // LayNguoiDungBaiViet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}