namespace random
{
    partial class MeanSquareMethod
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
            btn_calc = new Button();
            DataView = new DataGridView();
            label1 = new Label();
            txt_n = new TextBox();
            txt_count = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataView).BeginInit();
            SuspendLayout();
            // 
            // btn_calc
            // 
            btn_calc.Location = new Point(97, 244);
            btn_calc.Name = "btn_calc";
            btn_calc.Size = new Size(148, 52);
            btn_calc.TabIndex = 0;
            btn_calc.Text = "تولید عدد تصادفی";
            btn_calc.UseVisualStyleBackColor = true;
            btn_calc.Click += btn_calc_Click;
            // 
            // DataView
            // 
            DataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataView.Location = new Point(382, 85);
            DataView.Name = "DataView";
            DataView.RowHeadersWidth = 51;
            DataView.Size = new Size(406, 353);
            DataView.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Nazanin", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.Location = new Point(626, 33);
            label1.Name = "label1";
            label1.Size = new Size(149, 34);
            label1.TabIndex = 2;
            label1.Text = "روش میان مربعی";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // txt_n
            // 
            txt_n.Location = new Point(87, 138);
            txt_n.Multiline = true;
            txt_n.Name = "txt_n";
            txt_n.PlaceholderText = "عدد اولیه ";
            txt_n.Size = new Size(181, 38);
            txt_n.TabIndex = 3;
            txt_n.TextAlign = HorizontalAlignment.Center;
            txt_n.TextChanged += textBox1_TextChanged;
            // 
            // txt_count
            // 
            txt_count.ForeColor = SystemColors.InactiveCaptionText;
            txt_count.Location = new Point(87, 193);
            txt_count.Multiline = true;
            txt_count.Name = "txt_count";
            txt_count.PlaceholderText = "تعداد اعداد تصادفی";
            txt_count.Size = new Size(181, 41);
            txt_count.TabIndex = 7;
            txt_count.TextAlign = HorizontalAlignment.Center;
            txt_count.TextChanged += txt_count_TextChanged;
            // 
            // MeanSquareMethod
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_count);
            Controls.Add(txt_n);
            Controls.Add(label1);
            Controls.Add(DataView);
            Controls.Add(btn_calc);
            Name = "MeanSquareMethod";
            Text = "MeanSquareMethod";
            Load += MeanSquareMethod_Load;
            ((System.ComponentModel.ISupportInitialize)DataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_calc;
        private DataGridView DataView;
        private Label label1;
        private TextBox txt_n;
        private TextBox txt_count;
    }
}