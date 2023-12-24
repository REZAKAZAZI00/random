namespace random
{
    partial class Form2
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
            SuspendLayout();
            // 
            // btncalc
            // 
            btncalc.Location = new Point(213, 313);
            btncalc.Name = "btncalc";
            btncalc.Size = new Size(113, 35);
            btncalc.TabIndex = 0;
            btncalc.Text = "محاسبه";
            btncalc.UseVisualStyleBackColor = true;
            btncalc.Click += btncalc_Click;
            // 
            // txt_x
            // 
            txt_x.AccessibleName = "";
            txt_x.Location = new Point(213, 135);
            txt_x.Multiline = true;
            txt_x.Name = "txt_x";
            txt_x.PlaceholderText = "مقدار اولیه هسته";
            txt_x.Size = new Size(127, 35);
            txt_x.TabIndex = 1;
            txt_x.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_a
            // 
            txt_a.Location = new Point(215, 176);
            txt_a.Multiline = true;
            txt_a.Name = "txt_a";
            txt_a.PlaceholderText = "ضریب ثابت مولد";
            txt_a.Size = new Size(125, 32);
            txt_a.TabIndex = 2;
            txt_a.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_c
            // 
            txt_c.Location = new Point(215, 216);
            txt_c.Margin = new Padding(3, 4, 3, 4);
            txt_c.Multiline = true;
            txt_c.Name = "txt_c";
            txt_c.PlaceholderText = "مقدار ثابت مولد";
            txt_c.Size = new Size(125, 36);
            txt_c.TabIndex = 3;
            txt_c.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_m
            // 
            txt_m.Location = new Point(213, 261);
            txt_m.Margin = new Padding(3, 4, 3, 4);
            txt_m.Multiline = true;
            txt_m.Name = "txt_m";
            txt_m.PlaceholderText = "مقدار پیمانه";
            txt_m.Size = new Size(125, 29);
            txt_m.TabIndex = 4;
            txt_m.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(604, 19);
            label1.Name = "label1";
            label1.Size = new Size(174, 20);
            label1.TabIndex = 5;
            label1.Text = " مولدهای همنهشتی خطی";
            label1.Click += label1_Click;
            // 
            // txt_count
            // 
            txt_count.Location = new Point(355, 181);
            txt_count.Multiline = true;
            txt_count.Name = "txt_count";
            txt_count.PlaceholderText = "تعداد اعداد تصادفی";
            txt_count.Size = new Size(163, 41);
            txt_count.TabIndex = 6;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
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
    }
}