namespace random
{
    partial class LinearCongruentialGenerator
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
            btncalc = new Button();
            txt_x = new TextBox();
            txt_a = new TextBox();
            txt_c = new TextBox();
            txt_m = new TextBox();
            label1 = new Label();
            txt_count = new TextBox();
            DataView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataView).BeginInit();
            SuspendLayout();
            // 
            // btncalc
            // 
            btncalc.Location = new Point(67, 370);
            btncalc.Name = "btncalc";
            btncalc.Size = new Size(307, 35);
            btncalc.TabIndex = 0;
            btncalc.Text = "محاسبه";
            btncalc.UseVisualStyleBackColor = true;
            btncalc.Click += btncalc_Click;
            // 
            // txt_x
            // 
            txt_x.AccessibleName = "";
            txt_x.ForeColor = SystemColors.InactiveCaptionText;
            txt_x.Location = new Point(67, 72);
            txt_x.Multiline = true;
            txt_x.Name = "txt_x";
            txt_x.PlaceholderText = "مقدار اولیه هسته";
            txt_x.Size = new Size(307, 38);
            txt_x.TabIndex = 1;
            txt_x.TextAlign = HorizontalAlignment.Center;
            txt_x.TextChanged += txt_x_TextChanged;
            // 
            // txt_a
            // 
            txt_a.ForeColor = SystemColors.InactiveCaptionText;
            txt_a.Location = new Point(65, 126);
            txt_a.Multiline = true;
            txt_a.Name = "txt_a";
            txt_a.PlaceholderText = "ضریب ثابت مولد";
            txt_a.Size = new Size(309, 43);
            txt_a.TabIndex = 2;
            txt_a.TextAlign = HorizontalAlignment.Center;
            txt_a.TextChanged += txt_a_TextChanged;
            // 
            // txt_c
            // 
            txt_c.ForeColor = SystemColors.InactiveCaptionText;
            txt_c.Location = new Point(65, 181);
            txt_c.Margin = new Padding(3, 4, 3, 4);
            txt_c.Multiline = true;
            txt_c.Name = "txt_c";
            txt_c.PlaceholderText = "مقدار ثابت مولد";
            txt_c.Size = new Size(309, 47);
            txt_c.TabIndex = 3;
            txt_c.TextAlign = HorizontalAlignment.Center;
            txt_c.TextChanged += txt_c_TextChanged;
            // 
            // txt_m
            // 
            txt_m.ForeColor = SystemColors.InactiveCaptionText;
            txt_m.Location = new Point(63, 240);
            txt_m.Margin = new Padding(3, 4, 3, 4);
            txt_m.Multiline = true;
            txt_m.Name = "txt_m";
            txt_m.PlaceholderText = "مقدار پیمانه";
            txt_m.Size = new Size(309, 40);
            txt_m.TabIndex = 4;
            txt_m.TextAlign = HorizontalAlignment.Center;
            txt_m.TextChanged += txt_m_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Nazanin", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.Location = new Point(610, 9);
            label1.Name = "label1";
            label1.Size = new Size(168, 41);
            label1.TabIndex = 5;
            label1.Text = "همنهشتی خطی";
            label1.Click += label1_Click;
            // 
            // txt_count
            // 
            txt_count.ForeColor = SystemColors.InactiveCaptionText;
            txt_count.Location = new Point(65, 293);
            txt_count.Multiline = true;
            txt_count.Name = "txt_count";
            txt_count.PlaceholderText = "تعداد اعداد تصادفی";
            txt_count.Size = new Size(309, 41);
            txt_count.TabIndex = 6;
            txt_count.TextAlign = HorizontalAlignment.Center;
            txt_count.TextChanged += txt_count_TextChanged;
            // 
            // DataView
            // 
            DataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataView.Location = new Point(420, 61);
            DataView.Name = "DataView";
            DataView.RowHeadersWidth = 51;
            DataView.Size = new Size(368, 378);
            DataView.TabIndex = 7;
            DataView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(DataView);
            Controls.Add(txt_count);
            Controls.Add(label1);
            Controls.Add(txt_m);
            Controls.Add(txt_c);
            Controls.Add(txt_a);
            Controls.Add(txt_x);
            Controls.Add(btncalc);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)DataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalc;
        private TextBox txt_x;
        private TextBox txt_a;
        private TextBox txt_c;
        private TextBox txt_m;
        private Label label1;
        private TextBox txt_count;
        private DataGridView DataView;
    }
}