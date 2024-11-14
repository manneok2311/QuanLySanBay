namespace QuanLySanBay
{
    partial class SuaMayBay
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
            btnok = new Button();
            txtsogio = new TextBox();
            txtnamsx = new TextBox();
            txttenmb = new TextBox();
            txtmamb = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvsua = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvsua).BeginInit();
            SuspendLayout();
            // 
            // btnok
            // 
            btnok.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnok.Location = new Point(318, 378);
            btnok.Name = "btnok";
            btnok.Size = new Size(94, 29);
            btnok.TabIndex = 19;
            btnok.Text = "OK";
            btnok.UseVisualStyleBackColor = true;
            btnok.Click += btnok_Click;
            // 
            // txtsogio
            // 
            txtsogio.Location = new Point(515, 304);
            txtsogio.Name = "txtsogio";
            txtsogio.Size = new Size(125, 27);
            txtsogio.TabIndex = 18;
            // 
            // txtnamsx
            // 
            txtnamsx.Location = new Point(515, 246);
            txtnamsx.Name = "txtnamsx";
            txtnamsx.Size = new Size(125, 27);
            txtnamsx.TabIndex = 17;
            // 
            // txttenmb
            // 
            txttenmb.Location = new Point(210, 304);
            txttenmb.Name = "txttenmb";
            txttenmb.Size = new Size(125, 27);
            txttenmb.TabIndex = 16;
            // 
            // txtmamb
            // 
            txtmamb.Location = new Point(210, 249);
            txtmamb.Name = "txtmamb";
            txtmamb.Size = new Size(125, 27);
            txtmamb.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(424, 311);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 14;
            label5.Text = "Số giờ bay:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(399, 249);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 13;
            label4.Text = "Năm sản xuất:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(106, 249);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 12;
            label3.Text = "Mã máy bay:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(103, 311);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 11;
            label2.Text = "Tên máy bay:";
         //   label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(239, 22);
            label1.Name = "label1";
            label1.Size = new Size(279, 28);
            label1.TabIndex = 10;
            label1.Text = "Form sửa thông tin máy bay";
            // 
            // dgvsua
            // 
            dgvsua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsua.Location = new Point(126, 53);
            dgvsua.Name = "dgvsua";
            dgvsua.RowHeadersWidth = 51;
            dgvsua.Size = new Size(514, 177);
            dgvsua.TabIndex = 20;
            dgvsua.CellClick += dgvsua_CellClick;
            // 
            // SuaMayBay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvsua);
            Controls.Add(btnok);
            Controls.Add(txtsogio);
            Controls.Add(txtnamsx);
            Controls.Add(txttenmb);
            Controls.Add(txtmamb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SuaMayBay";
            Text = "SuaMayBay";
            Load += SuaMayBay_Load;
            ((System.ComponentModel.ISupportInitialize)dgvsua).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnok;
        private TextBox txtsogio;
        private TextBox txtnamsx;
        private TextBox txttenmb;
        private TextBox txtmamb;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvsua;
    }
}