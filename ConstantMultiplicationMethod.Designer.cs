namespace random
{
    partial class ConstantMultiplicationMethod
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
            num_count = new NumericUpDown();
            txt_k = new TextBox();
            txt_x = new TextBox();
            btncalc = new Button();
            DataView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)num_count).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Nazanin", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.Location = new Point(592, 37);
            label1.Name = "label1";
            label1.Size = new Size(182, 41);
            label1.TabIndex = 13;
            label1.Text = "روش مضرب ثابت";
            // 
            // num_count
            // 
            num_count.Location = new Point(85, 231);
            num_count.Name = "num_count";
            num_count.Size = new Size(307, 27);
            num_count.TabIndex = 12;
            num_count.ValueChanged += num_count_ValueChanged;
            // 
            // txt_k
            // 
            txt_k.ForeColor = SystemColors.InactiveCaptionText;
            txt_k.Location = new Point(85, 177);
            txt_k.Margin = new Padding(3, 4, 3, 4);
            txt_k.Multiline = true;
            txt_k.Name = "txt_k";
            txt_k.PlaceholderText = "مقدار ثابت k";
            txt_k.Size = new Size(309, 47);
            txt_k.TabIndex = 11;
            txt_k.TextAlign = HorizontalAlignment.Center;
            txt_k.TextChanged += txt_k_TextChanged;
            // 
            // txt_x
            // 
            txt_x.ForeColor = SystemColors.InactiveCaptionText;
            txt_x.Location = new Point(85, 122);
            txt_x.Multiline = true;
            txt_x.Name = "txt_x";
            txt_x.PlaceholderText = "مقدار x";
            txt_x.Size = new Size(309, 43);
            txt_x.TabIndex = 10;
            txt_x.TextAlign = HorizontalAlignment.Center;
            txt_x.TextChanged += txt_x_TextChanged;
            // 
            // btncalc
            // 
            btncalc.Location = new Point(85, 275);
            btncalc.Name = "btncalc";
            btncalc.Size = new Size(307, 35);
            btncalc.TabIndex = 9;
            btncalc.Text = "محاسبه";
            btncalc.UseVisualStyleBackColor = true;
            btncalc.Click += btncalc_Click;
            // 
            // DataView
            // 
            DataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataView.Location = new Point(447, 108);
            DataView.Name = "DataView";
            DataView.RowHeadersWidth = 51;
            DataView.Size = new Size(341, 330);
            DataView.TabIndex = 8;
            // 
            // ConstantMultiplicationMethod
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(num_count);
            Controls.Add(txt_k);
            Controls.Add(txt_x);
            Controls.Add(btncalc);
            Controls.Add(DataView);
            Name = "ConstantMultiplicationMethod";
            Text = "ConstantMultiplicationMethod";
            Load += ConstantMultiplicationMethod_Load;
            ((System.ComponentModel.ISupportInitialize)num_count).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown num_count;
        private TextBox txt_k;
        private TextBox txt_x;
        private Button btncalc;
        private DataGridView DataView;
    }
}