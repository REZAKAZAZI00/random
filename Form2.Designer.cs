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
            SuspendLayout();
            // 
            // btncalc
            // 
            btncalc.Location = new Point(186, 235);
            btncalc.Margin = new Padding(3, 2, 3, 2);
            btncalc.Name = "btncalc";
            btncalc.Size = new Size(99, 26);
            btncalc.TabIndex = 0;
            btncalc.Text = "محاسبه";
            btncalc.UseVisualStyleBackColor = true;
            btncalc.Click += btncalc_Click;
            // 
            // txt_x
            // 
            txt_x.AccessibleName = "";
            txt_x.Location = new Point(186, 101);
            txt_x.Margin = new Padding(3, 2, 3, 2);
            txt_x.Multiline = true;
            txt_x.Name = "txt_x";
            txt_x.PlaceholderText = "مقدار اولیه هسته";
            txt_x.Size = new Size(112, 27);
            txt_x.TabIndex = 1;
            txt_x.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_a
            // 
            txt_a.Location = new Point(188, 132);
            txt_a.Margin = new Padding(3, 2, 3, 2);
            txt_a.Multiline = true;
            txt_a.Name = "txt_a";
            txt_a.PlaceholderText = "ضریب ثابت مولد";
            txt_a.Size = new Size(110, 25);
            txt_a.TabIndex = 2;
            txt_a.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_c
            // 
            txt_c.Location = new Point(188, 162);
            txt_c.Multiline = true;
            txt_c.Name = "txt_c";
            txt_c.PlaceholderText = "مقدار ثابت مولد";
            txt_c.Size = new Size(110, 28);
            txt_c.TabIndex = 3;
            txt_c.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_m
            // 
            txt_m.Location = new Point(186, 196);
            txt_m.Multiline = true;
            txt_m.Name = "txt_m";
            txt_m.PlaceholderText = "مقدار پیمانه";
            txt_m.Size = new Size(110, 23);
            txt_m.TabIndex = 4;
            txt_m.TextAlign = HorizontalAlignment.Center;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(txt_m);
            Controls.Add(txt_c);
            Controls.Add(txt_a);
            Controls.Add(txt_x);
            Controls.Add(btncalc);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}