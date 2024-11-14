namespace QuanLySanBay
{
    partial class ThemMayBay
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtmamaybay = new TextBox();
            txttenmaybay = new TextBox();
            txtnamsanxuat = new TextBox();
            txtsogiobay = new TextBox();
            btnok = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(207, 68);
            label1.Name = "label1";
            label1.Size = new Size(295, 28);
            label1.TabIndex = 0;
            label1.Text = "Form thêm thông tin máy bay";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(96, 234);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên máy bay:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(99, 172);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 2;
            label3.Text = "Mã máy bay:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(392, 172);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 3;
            label4.Text = "Năm sản xuất:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(417, 234);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 4;
            label5.Text = "Số giờ bay:";
            // 
            // txtmamaybay
            // 
            txtmamaybay.Location = new Point(203, 172);
            txtmamaybay.Name = "txtmamaybay";
            txtmamaybay.Size = new Size(125, 27);
            txtmamaybay.TabIndex = 5;
            // 
            // txttenmaybay
            // 
            txttenmaybay.Location = new Point(203, 227);
            txttenmaybay.Name = "txttenmaybay";
            txttenmaybay.Size = new Size(125, 27);
            txttenmaybay.TabIndex = 6;
            // 
            // txtnamsanxuat
            // 
            txtnamsanxuat.Location = new Point(508, 169);
            txtnamsanxuat.Name = "txtnamsanxuat";
            txtnamsanxuat.Size = new Size(125, 27);
            txtnamsanxuat.TabIndex = 7;
            // 
            // txtsogiobay
            // 
            txtsogiobay.Location = new Point(508, 227);
            txtsogiobay.Name = "txtsogiobay";
            txtsogiobay.Size = new Size(125, 27);
            txtsogiobay.TabIndex = 8;
            // 
            // btnok
            // 
            btnok.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnok.Location = new Point(311, 323);
            btnok.Name = "btnok";
            btnok.Size = new Size(94, 29);
            btnok.TabIndex = 9;
            btnok.Text = "OK";
            btnok.UseVisualStyleBackColor = true;
            btnok.Click += btnok_Click;
            // 
            // ThemMayBay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnok);
            Controls.Add(txtsogiobay);
            Controls.Add(txtnamsanxuat);
            Controls.Add(txttenmaybay);
            Controls.Add(txtmamaybay);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ThemMayBay";
            Text = "ThemMayBay";
            Load += ThemMayBay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtmamaybay;
        private TextBox txttenmaybay;
        private TextBox txtnamsanxuat;
        private TextBox txtsogiobay;
        private Button btnok;
    }
}