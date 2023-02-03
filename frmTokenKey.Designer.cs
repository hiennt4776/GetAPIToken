
namespace WindowsFormsApp1
{
    partial class frmTokenKey
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
            this.btnPost = new System.Windows.Forms.Button();
            this.btnGetToken = new System.Windows.Forms.Button();
            this.lblPostJSON = new System.Windows.Forms.Label();
            this.lblPostObejct = new System.Windows.Forms.Label();
            this.lblResponse = new System.Windows.Forms.Label();
            this.txtKetQuaSoDienThoai = new System.Windows.Forms.TextBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.btnSoDienThoai = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoCMND = new System.Windows.Forms.TextBox();
            this.btnSoCMND = new System.Windows.Forms.Button();
            this.txtKetQuaSoCMND = new System.Windows.Forms.TextBox();
            this.txtTokenAccess = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSoDienThoai = new System.Windows.Forms.TabPage();
            this.lsvSoDienThoai = new System.Windows.Forms.ListView();
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabSoCMND = new System.Windows.Forms.TabPage();
            this.lsvSoCMND = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabSoDienThoai.SuspendLayout();
            this.tabSoCMND.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(93, 12);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(105, 23);
            this.btnPost.TabIndex = 0;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnGetToken
            // 
            this.btnGetToken.Location = new System.Drawing.Point(93, 41);
            this.btnGetToken.Name = "btnGetToken";
            this.btnGetToken.Size = new System.Drawing.Size(105, 23);
            this.btnGetToken.TabIndex = 5;
            this.btnGetToken.Text = "Get";
            this.btnGetToken.UseVisualStyleBackColor = true;
            this.btnGetToken.Click += new System.EventHandler(this.btnGetToken_Click);
            // 
            // lblPostJSON
            // 
            this.lblPostJSON.AutoSize = true;
            this.lblPostJSON.Location = new System.Drawing.Point(201, 51);
            this.lblPostJSON.Name = "lblPostJSON";
            this.lblPostJSON.Size = new System.Drawing.Size(38, 13);
            this.lblPostJSON.TabIndex = 1;
            this.lblPostJSON.Text = "JSON:";
            // 
            // lblPostObejct
            // 
            this.lblPostObejct.AutoSize = true;
            this.lblPostObejct.Location = new System.Drawing.Point(201, 79);
            this.lblPostObejct.Name = "lblPostObejct";
            this.lblPostObejct.Size = new System.Drawing.Size(38, 13);
            this.lblPostObejct.TabIndex = 2;
            this.lblPostObejct.Text = "Object";
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(201, 18);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(0, 13);
            this.lblResponse.TabIndex = 3;
            // 
            // txtKetQuaSoDienThoai
            // 
            this.txtKetQuaSoDienThoai.Location = new System.Drawing.Point(9, 45);
            this.txtKetQuaSoDienThoai.Multiline = true;
            this.txtKetQuaSoDienThoai.Name = "txtKetQuaSoDienThoai";
            this.txtKetQuaSoDienThoai.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKetQuaSoDienThoai.Size = new System.Drawing.Size(1268, 95);
            this.txtKetQuaSoDienThoai.TabIndex = 11;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(12, 12);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 13;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Số điện thoại";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(9, 19);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(105, 20);
            this.txtSoDienThoai.TabIndex = 15;
            // 
            // btnSoDienThoai
            // 
            this.btnSoDienThoai.Location = new System.Drawing.Point(120, 19);
            this.btnSoDienThoai.Name = "btnSoDienThoai";
            this.btnSoDienThoai.Size = new System.Drawing.Size(75, 20);
            this.btnSoDienThoai.TabIndex = 16;
            this.btnSoDienThoai.Text = "Tra cứu";
            this.btnSoDienThoai.UseVisualStyleBackColor = true;
            this.btnSoDienThoai.Click += new System.EventHandler(this.btnSoDienThoai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Số CMND";
            // 
            // txtSoCMND
            // 
            this.txtSoCMND.Location = new System.Drawing.Point(67, 6);
            this.txtSoCMND.Name = "txtSoCMND";
            this.txtSoCMND.Size = new System.Drawing.Size(100, 20);
            this.txtSoCMND.TabIndex = 18;
            // 
            // btnSoCMND
            // 
            this.btnSoCMND.Location = new System.Drawing.Point(173, 4);
            this.btnSoCMND.Name = "btnSoCMND";
            this.btnSoCMND.Size = new System.Drawing.Size(75, 23);
            this.btnSoCMND.TabIndex = 19;
            this.btnSoCMND.Text = "Tra cứu";
            this.btnSoCMND.UseVisualStyleBackColor = true;
            this.btnSoCMND.Click += new System.EventHandler(this.btnSoCMND_Click);
            // 
            // txtKetQuaSoCMND
            // 
            this.txtKetQuaSoCMND.Location = new System.Drawing.Point(9, 32);
            this.txtKetQuaSoCMND.Multiline = true;
            this.txtKetQuaSoCMND.Name = "txtKetQuaSoCMND";
            this.txtKetQuaSoCMND.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKetQuaSoCMND.Size = new System.Drawing.Size(1268, 103);
            this.txtKetQuaSoCMND.TabIndex = 20;
            // 
            // txtTokenAccess
            // 
            this.txtTokenAccess.Location = new System.Drawing.Point(296, 106);
            this.txtTokenAccess.Name = "txtTokenAccess";
            this.txtTokenAccess.ReadOnly = true;
            this.txtTokenAccess.Size = new System.Drawing.Size(836, 20);
            this.txtTokenAccess.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Token Access";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSoDienThoai);
            this.tabControl1.Controls.Add(this.tabSoCMND);
            this.tabControl1.Location = new System.Drawing.Point(12, 132);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1291, 572);
            this.tabControl1.TabIndex = 23;
            // 
            // tabSoDienThoai
            // 
            this.tabSoDienThoai.Controls.Add(this.lsvSoDienThoai);
            this.tabSoDienThoai.Controls.Add(this.txtKetQuaSoDienThoai);
            this.tabSoDienThoai.Controls.Add(this.label1);
            this.tabSoDienThoai.Controls.Add(this.txtSoDienThoai);
            this.tabSoDienThoai.Controls.Add(this.btnSoDienThoai);
            this.tabSoDienThoai.Location = new System.Drawing.Point(4, 22);
            this.tabSoDienThoai.Name = "tabSoDienThoai";
            this.tabSoDienThoai.Padding = new System.Windows.Forms.Padding(3);
            this.tabSoDienThoai.Size = new System.Drawing.Size(1283, 546);
            this.tabSoDienThoai.TabIndex = 0;
            this.tabSoDienThoai.Text = "Số điện thoại";
            this.tabSoDienThoai.UseVisualStyleBackColor = true;
            // 
            // lsvSoDienThoai
            // 
            this.lsvSoDienThoai.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader27,
            this.columnHeader28,
            this.columnHeader29,
            this.columnHeader30,
            this.columnHeader1});
            this.lsvSoDienThoai.HideSelection = false;
            this.lsvSoDienThoai.Location = new System.Drawing.Point(9, 146);
            this.lsvSoDienThoai.Name = "lsvSoDienThoai";
            this.lsvSoDienThoai.Size = new System.Drawing.Size(1268, 394);
            this.lsvSoDienThoai.TabIndex = 17;
            this.lsvSoDienThoai.UseCompatibleStateImageBehavior = false;
            this.lsvSoDienThoai.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "ID";
            this.columnHeader20.Width = 50;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Họ và tên";
            this.columnHeader21.Width = 150;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Giới tính";
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Địa chỉ nơi đến";
            this.columnHeader23.Width = 150;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Số điện thoại";
            this.columnHeader24.Width = 100;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Ngày sửa";
            this.columnHeader25.Width = 100;
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "Quốc tịch ID";
            this.columnHeader27.Width = 90;
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "Ngày Sinh";
            this.columnHeader28.Width = 100;
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "Số CMND";
            this.columnHeader29.Width = 100;
            // 
            // columnHeader30
            // 
            this.columnHeader30.Text = "Nơi cư trú chi tiết";
            this.columnHeader30.Width = 150;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "nguoiKhaiTuDonViId ";
            this.columnHeader1.Width = 150;
            // 
            // tabSoCMND
            // 
            this.tabSoCMND.Controls.Add(this.lsvSoCMND);
            this.tabSoCMND.Controls.Add(this.label2);
            this.tabSoCMND.Controls.Add(this.txtSoCMND);
            this.tabSoCMND.Controls.Add(this.btnSoCMND);
            this.tabSoCMND.Controls.Add(this.txtKetQuaSoCMND);
            this.tabSoCMND.Location = new System.Drawing.Point(4, 22);
            this.tabSoCMND.Name = "tabSoCMND";
            this.tabSoCMND.Padding = new System.Windows.Forms.Padding(3);
            this.tabSoCMND.Size = new System.Drawing.Size(1283, 546);
            this.tabSoCMND.TabIndex = 1;
            this.tabSoCMND.Text = "số CMND";
            this.tabSoCMND.UseVisualStyleBackColor = true;
            // 
            // lsvSoCMND
            // 
            this.lsvSoCMND.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.lsvSoCMND.HideSelection = false;
            this.lsvSoCMND.Location = new System.Drawing.Point(8, 141);
            this.lsvSoCMND.Name = "lsvSoCMND";
            this.lsvSoCMND.Size = new System.Drawing.Size(1269, 399);
            this.lsvSoCMND.TabIndex = 21;
            this.lsvSoCMND.UseCompatibleStateImageBehavior = false;
            this.lsvSoCMND.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ID";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Họ và tên";
            this.columnHeader11.Width = 180;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Địa chỉ nơi đến";
            this.columnHeader12.Width = 120;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Số điện thoại";
            this.columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Ngày sửa";
            this.columnHeader14.Width = 100;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Quốc tịch";
            this.columnHeader15.Width = 100;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Ngày sinh";
            this.columnHeader16.Width = 100;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "số CMND";
            this.columnHeader17.Width = 100;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "nơi cư trú chi tiết";
            this.columnHeader18.Width = 180;
            // 
            // frmTokenKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 706);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTokenAccess);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnGetToken);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.lblPostObejct);
            this.Controls.Add(this.lblPostJSON);
            this.Controls.Add(this.btnPost);
            this.Name = "frmTokenKey";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmTokenKey_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSoDienThoai.ResumeLayout(false);
            this.tabSoDienThoai.PerformLayout();
            this.tabSoCMND.ResumeLayout(false);
            this.tabSoCMND.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnGetToken;
        private System.Windows.Forms.Label lblPostJSON;
        private System.Windows.Forms.Label lblPostObejct;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.TextBox txtKetQuaSoDienThoai;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Button btnSoDienThoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoCMND;
        private System.Windows.Forms.Button btnSoCMND;
        private System.Windows.Forms.TextBox txtKetQuaSoCMND;
        private System.Windows.Forms.TextBox txtTokenAccess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSoDienThoai;
        private System.Windows.Forms.TabPage tabSoCMND;
        private System.Windows.Forms.ListView lsvSoDienThoai;
        private System.Windows.Forms.ListView lsvSoCMND;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.ColumnHeader columnHeader29;
        private System.Windows.Forms.ColumnHeader columnHeader30;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

