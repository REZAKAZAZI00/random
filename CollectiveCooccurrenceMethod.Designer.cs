namespace random
{
    partial class CollectiveCooccurrenceMethod
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
            num_n = new NumericUpDown();
            txt_m = new TextBox();
            btncalc = new Button();
            DataView = new DataGridView();
            txt_x = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)num_n).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Nazanin", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.Location = new Point(560, 9);
            label1.Name = "label1";
            label1.Size = new Size(230, 41);
            label1.TabIndex = 19;
            label1.Text = "روش همنهشتی جمعی";
            label1.Click += label1_Click;
            // 
            // num_n
            // 
            num_n.Location = new Point(73, 259);
            num_n.Name = "num_n";
            num_n.Size = new Size(307, 27);
            num_n.TabIndex = 18;
            num_n.ValueChanged += num_n_ValueChanged;
            // 
            // txt_m
            // 
            txt_m.ForeColor = SystemColors.InactiveCaptionText;
            txt_m.Location = new Point(73, 213);
            txt_m.Margin = new Padding(3, 4, 3, 4);
            txt_m.Multiline = true;
            txt_m.Name = "txt_m";
            txt_m.PlaceholderText = "مقدار m";
            txt_m.Size = new Size(309, 39);
            txt_m.TabIndex = 17;
            txt_m.TextAlign = HorizontalAlignment.Center;
            txt_m.TextChanged += txt_m_TextChanged;
            // 
            // btncalc
            // 
            btncalc.Location = new Point(73, 303);
            btncalc.Name = "btncalc";
            btncalc.Size = new Size(307, 35);
            btncalc.TabIndex = 15;
            btncalc.Text = "محاسبه";
            btncalc.UseVisualStyleBackColor = true;
            btncalc.Click += btncalc_Click;
            // 
            // DataView
            // 
            DataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataView.Location = new Point(459, 82);
            DataView.Name = "DataView";
            DataView.RowHeadersWidth = 51;
            DataView.Size = new Size(341, 330);
            DataView.TabIndex = 14;
            DataView.CellContentClick += DataView_CellContentClick;
            // 
            // txt_x
            // 
            txt_x.Location = new Point(77, 142);
            txt_x.Multiline = true;
            txt_x.Name = "txt_x";
            txt_x.PlaceholderText = "مجموعه ای ا ز اعداد";
            txt_x.Size = new Size(307, 64);
            txt_x.TabIndex = 20;
            txt_x.TextAlign = HorizontalAlignment.Center;
            txt_x.TextChanged += txt_x_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("B Nazanin", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            label2.Location = new Point(77, 110);
            label2.Name = "label2";
            label2.Size = new Size(305, 29);
            label2.TabIndex = 21;
            label2.Text = "به این روش مقدار دهی کنید   20,25,59,99,72";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 19);
            label3.Name = "label3";
            label3.Size = new Size(160, 20);
            label3.TabIndex = 22;
            label3.Text = "بارگشت به صفحه اصلی";
            label3.Click += label3_Click;
            // 
            // CollectiveCooccurrenceMethod
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 414);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_x);
            Controls.Add(label1);
            Controls.Add(num_n);
            Controls.Add(txt_m);
            Controls.Add(btncalc);
            Controls.Add(DataView);
            Name = "CollectiveCooccurrenceMethod";
            Text = "CollectiveCooccurrenceMethod";
            Load += CollectiveCooccurrenceMethod_Load;
            ((System.ComponentModel.ISupportInitialize)num_n).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown num_n;
        private TextBox txt_m;
        private Button btncalc;
        private DataGridView DataView;
        private TextBox txt_x;
        private Label label2;
        private Label label3;
    }
}