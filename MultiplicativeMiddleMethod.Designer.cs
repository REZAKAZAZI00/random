namespace random
{
    partial class MultiplicativeMiddleMethod
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
            DataView = new DataGridView();
            btncalc = new Button();
            txt_xPrime = new TextBox();
            txt_x = new TextBox();
            num_count = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_count).BeginInit();
            SuspendLayout();
            // 
            // DataView
            // 
            DataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataView.Location = new Point(457, 108);
            DataView.Name = "DataView";
            DataView.RowHeadersWidth = 51;
            DataView.Size = new Size(341, 330);
            DataView.TabIndex = 0;
            // 
            // btncalc
            // 
            btncalc.Location = new Point(95, 275);
            btncalc.Name = "btncalc";
            btncalc.Size = new Size(307, 35);
            btncalc.TabIndex = 1;
            btncalc.Text = "محاسبه";
            btncalc.UseVisualStyleBackColor = true;
            btncalc.Click += btncalc_Click;
            // 
            // txt_xPrime
            // 
            txt_xPrime.ForeColor = SystemColors.InactiveCaptionText;
            txt_xPrime.Location = new Point(95, 177);
            txt_xPrime.Margin = new Padding(3, 4, 3, 4);
            txt_xPrime.Multiline = true;
            txt_xPrime.Name = "txt_xPrime";
            txt_xPrime.PlaceholderText = "مقدار xPrime";
            txt_xPrime.Size = new Size(309, 47);
            txt_xPrime.TabIndex = 5;
            txt_xPrime.TextAlign = HorizontalAlignment.Center;
            txt_xPrime.TextChanged += txt_xPrime_TextChanged;
            // 
            // txt_x
            // 
            txt_x.ForeColor = SystemColors.InactiveCaptionText;
            txt_x.Location = new Point(95, 122);
            txt_x.Multiline = true;
            txt_x.Name = "txt_x";
            txt_x.PlaceholderText = "مقدار x";
            txt_x.Size = new Size(309, 43);
            txt_x.TabIndex = 4;
            txt_x.TextAlign = HorizontalAlignment.Center;
            txt_x.TextChanged += txt_x_TextChanged;
            // 
            // num_count
            // 
            num_count.Location = new Point(95, 231);
            num_count.Name = "num_count";
            num_count.Size = new Size(307, 27);
            num_count.TabIndex = 6;
            num_count.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Nazanin", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.Location = new Point(602, 37);
            label1.Name = "label1";
            label1.Size = new Size(176, 41);
            label1.TabIndex = 7;
            label1.Text = "روش میان ضربی";
            // 
            // MultiplicativeMiddleMethod
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(num_count);
            Controls.Add(txt_xPrime);
            Controls.Add(txt_x);
            Controls.Add(btncalc);
            Controls.Add(DataView);
            Name = "MultiplicativeMiddleMethod";
            Text = "MultiplicativeMiddleMethod";
            Load += MultiplicativeMiddleMethod_Load;
            ((System.ComponentModel.ISupportInitialize)DataView).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_count).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataView;
        private Button btncalc;
        private TextBox txt_xPrime;
        private TextBox txt_x;
        private NumericUpDown num_count;
        private Label label1;
    }
}