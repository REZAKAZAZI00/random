namespace random
{
    partial class MainForm
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
            btnCollectiveCooccurrence = new Button();
            btn_squar = new Button();
            btn_multipli = new Button();
            btn_maltipleiconst = new Button();
            btn_liener = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Nazanin", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 178);
            label1.Location = new Point(193, 30);
            label1.Name = "label1";
            label1.Size = new Size(150, 34);
            label1.TabIndex = 0;
            label1.Text = "تولید اعداد تصادفی";
            label1.Click += label1_Click;
            // 
            // btnCollectiveCooccurrence
            // 
            btnCollectiveCooccurrence.Location = new Point(56, 272);
            btnCollectiveCooccurrence.Name = "btnCollectiveCooccurrence";
            btnCollectiveCooccurrence.Size = new Size(198, 41);
            btnCollectiveCooccurrence.TabIndex = 1;
            btnCollectiveCooccurrence.Text = "روش همنهشتی جمعی";
            btnCollectiveCooccurrence.UseVisualStyleBackColor = true;
            btnCollectiveCooccurrence.Click += button1_Click;
            // 
            // btn_squar
            // 
            btn_squar.Location = new Point(56, 77);
            btn_squar.Name = "btn_squar";
            btn_squar.Size = new Size(198, 41);
            btn_squar.TabIndex = 2;
            btn_squar.Text = "روش میان مربعی";
            btn_squar.UseVisualStyleBackColor = true;
            btn_squar.Click += btn_squar_Click;
            // 
            // btn_multipli
            // 
            btn_multipli.Location = new Point(56, 126);
            btn_multipli.Name = "btn_multipli";
            btn_multipli.Size = new Size(198, 39);
            btn_multipli.TabIndex = 3;
            btn_multipli.Text = "روش میان ضربی";
            btn_multipli.UseVisualStyleBackColor = true;
            btn_multipli.Click += btn_multipli_Click;
            // 
            // btn_maltipleiconst
            // 
            btn_maltipleiconst.Location = new Point(56, 173);
            btn_maltipleiconst.Name = "btn_maltipleiconst";
            btn_maltipleiconst.Size = new Size(198, 39);
            btn_maltipleiconst.TabIndex = 5;
            btn_maltipleiconst.Text = "روش مضرب ثابت";
            btn_maltipleiconst.UseVisualStyleBackColor = true;
            btn_maltipleiconst.Click += btn_maltipleiconst_Click;
            // 
            // btn_liener
            // 
            btn_liener.Location = new Point(56, 223);
            btn_liener.Name = "btn_liener";
            btn_liener.Size = new Size(198, 41);
            btn_liener.TabIndex = 4;
            btn_liener.Text = "مولدهای همنهشتی خطی";
            btn_liener.UseVisualStyleBackColor = true;
            btn_liener.Click += btn_liener_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(355, 374);
            Controls.Add(btn_maltipleiconst);
            Controls.Add(btn_liener);
            Controls.Add(btn_multipli);
            Controls.Add(btn_squar);
            Controls.Add(btnCollectiveCooccurrence);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "تولید اعداد تصادفی";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCollectiveCooccurrence;
        private Button btn_squar;
        private Button btn_multipli;
        private Button btn_maltipleiconst;
        private Button btn_liener;
    }
}