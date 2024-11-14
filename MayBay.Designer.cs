namespace QuanLySanBay
{
    partial class MayBay
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dgvsanbay = new DataGridView();
            btnthem = new Button();
            btnsua = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvsanbay).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(286, 42);
            label1.Name = "label1";
            label1.Size = new Size(240, 28);
            label1.TabIndex = 1;
            label1.Text = "Bảng thông tin máy bay";
            // 
            // dgvsanbay
            // 
            dgvsanbay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsanbay.Location = new Point(77, 73);
            dgvsanbay.Name = "dgvsanbay";
            dgvsanbay.RowHeadersWidth = 51;
            dgvsanbay.Size = new Size(624, 188);
            dgvsanbay.TabIndex = 2;
            // 
            // btnthem
            // 
            btnthem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnthem.Location = new Point(199, 319);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 36);
            btnthem.TabIndex = 3;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // btnsua
            // 
            btnsua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnsua.Location = new Point(461, 319);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 36);
            btnsua.TabIndex = 4;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // MayBay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnsua);
            Controls.Add(btnthem);
            Controls.Add(dgvsanbay);
            Controls.Add(label1);
            Name = "MayBay";
            Text = "Form1";
            Load += MayBay_Load;
            ((System.ComponentModel.ISupportInitialize)dgvsanbay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnlammoi;
        private Button button2;
        private DataGridView dgvsanbay;
        private Button btnthem;
        private Button btnsua;
    }
}
