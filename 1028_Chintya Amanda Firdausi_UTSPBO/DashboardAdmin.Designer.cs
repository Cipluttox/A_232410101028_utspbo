namespace _1028_Chintya_Amanda_Firdausi_UTSPBO
{
    partial class DashboardAdmin
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
            label4 = new Label();
            label5 = new Label();
            NM = new TextBox();
            JB = new TextBox();
            hr = new TextBox();
            k = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 64);
            label1.Location = new Point(119, 26);
            label1.Name = "label1";
            label1.Size = new Size(320, 41);
            label1.TabIndex = 0;
            label1.Text = "DASHBOARD ADMIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(75, 111);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "NAMA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(75, 173);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = "KATEGORI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(75, 237);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 3;
            label4.Text = "JUMLAH BARANG";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(75, 301);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 4;
            label5.Text = "HARGA";
            // 
            // NM
            // 
            NM.Location = new Point(221, 111);
            NM.Name = "NM";
            NM.Size = new Size(239, 27);
            NM.TabIndex = 5;
            // 
            // JB
            // 
            JB.Location = new Point(221, 230);
            JB.Name = "JB";
            JB.Size = new Size(239, 27);
            JB.TabIndex = 6;
            // 
            // hr
            // 
            hr.Location = new Point(221, 301);
            hr.Name = "hr";
            hr.Size = new Size(239, 27);
            hr.TabIndex = 7;
            // 
            // k
            // 
            k.FormattingEnabled = true;
            k.Location = new Point(221, 165);
            k.Name = "k";
            k.Size = new Size(239, 28);
            k.TabIndex = 8;
            k.SelectedIndexChanged += k_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 0, 64);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(349, 353);
            button1.Name = "button1";
            button1.Size = new Size(111, 40);
            button1.TabIndex = 9;
            button1.Text = "Input";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(550, 450);
            Controls.Add(button1);
            Controls.Add(k);
            Controls.Add(hr);
            Controls.Add(JB);
            Controls.Add(NM);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DashboardAdmin";
            Text = "DashboardAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox NM;
        private TextBox JB;
        private TextBox hr;
        private ComboBox k;
        private Button button1;
    }
}