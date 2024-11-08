namespace _1028_Chintya_Amanda_Firdausi_UTSPBO.model
{
    partial class HalamanLogin
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
            label2 = new Label();
            label3 = new Label();
            u = new TextBox();
            p = new TextBox();
            selesai = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 64);
            label1.Location = new Point(296, 104);
            label1.Name = "label1";
            label1.Size = new Size(224, 41);
            label1.TabIndex = 0;
            label1.Text = "LOGIN ADMIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 0, 64);
            label2.Location = new Point(228, 194);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 1;
            label2.Text = "USERNAME :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 0, 64);
            label3.Location = new Point(228, 252);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 2;
            label3.Text = "PASSWORD :";
            // 
            // u
            // 
            u.Location = new Point(333, 192);
            u.Name = "u";
            u.Size = new Size(235, 27);
            u.TabIndex = 3;
            u.TextChanged += u_TextChanged;
            // 
            // p
            // 
            p.Location = new Point(333, 249);
            p.Name = "p";
            p.Size = new Size(235, 27);
            p.TabIndex = 4;
            // 
            // selesai
            // 
            selesai.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selesai.ForeColor = Color.FromArgb(64, 0, 64);
            selesai.Location = new Point(356, 311);
            selesai.Name = "selesai";
            selesai.Size = new Size(117, 38);
            selesai.TabIndex = 5;
            selesai.Text = "selesai";
            selesai.UseVisualStyleBackColor = true;
            selesai.Click += selesai_Click;
            // 
            // HalamanLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(selesai);
            Controls.Add(p);
            Controls.Add(u);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HalamanLogin";
            Text = "HalamanLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox u;
        private TextBox p;
        private Button selesai;
    }
}