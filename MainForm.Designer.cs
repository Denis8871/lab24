namespace MultiThreadingEncryption
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelRedoc;
        private System.Windows.Forms.Panel panelSha;
        private System.Windows.Forms.Panel panelLuc;
        private System.Windows.Forms.TextBox textBoxRedoc;
        private System.Windows.Forms.TextBox textBoxSha;
        private System.Windows.Forms.TextBox textBoxLuc;
        private System.Windows.Forms.Button btnStartRedoc;
        private System.Windows.Forms.Button btnStopRedoc;
        private System.Windows.Forms.Button btnStartSha;
        private System.Windows.Forms.Button btnStopSha;
        private System.Windows.Forms.Button btnStartLuc;
        private System.Windows.Forms.Button btnStopLuc;
        private System.Windows.Forms.Button btnStartAll;
        private System.Windows.Forms.Button btnStopAll;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelRedoc = new System.Windows.Forms.Panel();
            this.textBoxRedoc = new System.Windows.Forms.TextBox();
            this.btnStartRedoc = new System.Windows.Forms.Button();
            this.btnStopRedoc = new System.Windows.Forms.Button();
            this.panelSha = new System.Windows.Forms.Panel();
            this.textBoxSha = new System.Windows.Forms.TextBox();
            this.btnStartSha = new System.Windows.Forms.Button();
            this.btnStopSha = new System.Windows.Forms.Button();
            this.panelLuc = new System.Windows.Forms.Panel();
            this.textBoxLuc = new System.Windows.Forms.TextBox();
            this.btnStartLuc = new System.Windows.Forms.Button();
            this.btnStopLuc = new System.Windows.Forms.Button();
            this.btnStartAll = new System.Windows.Forms.Button();
            this.btnStopAll = new System.Windows.Forms.Button();
            this.panelRedoc.SuspendLayout();
            this.panelSha.SuspendLayout();
            this.panelLuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRedoc
            // 
            this.panelRedoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRedoc.Controls.Add(this.textBoxRedoc);
            this.panelRedoc.Location = new System.Drawing.Point(12, 12);
            this.panelRedoc.Name = "panelRedoc";
            this.panelRedoc.Size = new System.Drawing.Size(245, 240);
            this.panelRedoc.TabIndex = 0;
            // 
            // textBoxRedoc
            // 
            this.textBoxRedoc.Location = new System.Drawing.Point(3, 3);
            this.textBoxRedoc.Name = "textBoxRedoc";
            this.textBoxRedoc.Size = new System.Drawing.Size(237, 20);
            this.textBoxRedoc.TabIndex = 3;
            // 
            // btnStartRedoc
            // 
            this.btnStartRedoc.Location = new System.Drawing.Point(12, 271);
            this.btnStartRedoc.Name = "btnStartRedoc";
            this.btnStartRedoc.Size = new System.Drawing.Size(245, 23);
            this.btnStartRedoc.TabIndex = 6;
            this.btnStartRedoc.Text = "Запустити 1 потік";
            this.btnStartRedoc.UseVisualStyleBackColor = true;
            this.btnStartRedoc.Click += new System.EventHandler(this.btnStartRedoc_Click);
            // 
            // btnStopRedoc
            // 
            this.btnStopRedoc.ForeColor = System.Drawing.Color.Red;
            this.btnStopRedoc.Location = new System.Drawing.Point(12, 300);
            this.btnStopRedoc.Name = "btnStopRedoc";
            this.btnStopRedoc.Size = new System.Drawing.Size(245, 23);
            this.btnStopRedoc.TabIndex = 7;
            this.btnStopRedoc.Text = "Зупинити 1 потік";
            this.btnStopRedoc.UseVisualStyleBackColor = true;
            this.btnStopRedoc.Click += new System.EventHandler(this.btnStopRedoc_Click);
            // 
            // panelSha
            // 
            this.panelSha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSha.Controls.Add(this.textBoxSha);
            this.panelSha.Location = new System.Drawing.Point(263, 12);
            this.panelSha.Name = "panelSha";
            this.panelSha.Size = new System.Drawing.Size(245, 240);
            this.panelSha.TabIndex = 1;
            // 
            // textBoxSha
            // 
            this.textBoxSha.Location = new System.Drawing.Point(3, 3);
            this.textBoxSha.Name = "textBoxSha";
            this.textBoxSha.Size = new System.Drawing.Size(237, 20);
            this.textBoxSha.TabIndex = 4;
            // 
            // btnStartSha
            // 
            this.btnStartSha.Location = new System.Drawing.Point(263, 271);
            this.btnStartSha.Name = "btnStartSha";
            this.btnStartSha.Size = new System.Drawing.Size(245, 23);
            this.btnStartSha.TabIndex = 8;
            this.btnStartSha.Text = "Запустити 2 потік";
            this.btnStartSha.UseVisualStyleBackColor = true;
            this.btnStartSha.Click += new System.EventHandler(this.btnStartSha_Click);
            // 
            // btnStopSha
            // 
            this.btnStopSha.ForeColor = System.Drawing.Color.Red;
            this.btnStopSha.Location = new System.Drawing.Point(263, 300);
            this.btnStopSha.Name = "btnStopSha";
            this.btnStopSha.Size = new System.Drawing.Size(245, 23);
            this.btnStopSha.TabIndex = 9;
            this.btnStopSha.Text = "Зупинити 2 потік";
            this.btnStopSha.UseVisualStyleBackColor = true;
            this.btnStopSha.Click += new System.EventHandler(this.btnStopSha_Click);
            // 
            // panelLuc
            // 
            this.panelLuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLuc.Controls.Add(this.textBoxLuc);
            this.panelLuc.Location = new System.Drawing.Point(514, 12);
            this.panelLuc.Name = "panelLuc";
            this.panelLuc.Size = new System.Drawing.Size(245, 240);
            this.panelLuc.TabIndex = 2;
            // 
            // textBoxLuc
            // 
            this.textBoxLuc.Location = new System.Drawing.Point(3, 3);
            this.textBoxLuc.Name = "textBoxLuc";
            this.textBoxLuc.Size = new System.Drawing.Size(237, 20);
            this.textBoxLuc.TabIndex = 5;
            // 
            // btnStartLuc
            // 
            this.btnStartLuc.Location = new System.Drawing.Point(514, 271);
            this.btnStartLuc.Name = "btnStartLuc";
            this.btnStartLuc.Size = new System.Drawing.Size(245, 23);
            this.btnStartLuc.TabIndex = 10;
            this.btnStartLuc.Text = "Запустити 3 потік";
            this.btnStartLuc.UseVisualStyleBackColor = true;
            this.btnStartLuc.Click += new System.EventHandler(this.btnStartLuc_Click);
            // 
            // btnStopLuc
            // 
            this.btnStopLuc.ForeColor = System.Drawing.Color.Red;
            this.btnStopLuc.Location = new System.Drawing.Point(514, 300);
            this.btnStopLuc.Name = "btnStopLuc";
            this.btnStopLuc.Size = new System.Drawing.Size(245, 23);
            this.btnStopLuc.TabIndex = 11;
            this.btnStopLuc.Text = "Зупинити 3 потік";
            this.btnStopLuc.UseVisualStyleBackColor = true;
            this.btnStopLuc.Click += new System.EventHandler(this.btnStopLuc_Click);
            // 
            // btnStartAll
            // 
            this.btnStartAll.Location = new System.Drawing.Point(12, 338);
            this.btnStartAll.Name = "btnStartAll";
            this.btnStartAll.Size = new System.Drawing.Size(747, 23);
            this.btnStartAll.TabIndex = 12;
            this.btnStartAll.Text = "Запустити всі потоки";
            this.btnStartAll.UseVisualStyleBackColor = true;
            this.btnStartAll.Click += new System.EventHandler(this.btnStartAll_Click);
            // 
            // btnStopAll
            // 
            this.btnStopAll.ForeColor = System.Drawing.Color.Red;
            this.btnStopAll.Location = new System.Drawing.Point(12, 367);
            this.btnStopAll.Name = "btnStopAll";
            this.btnStopAll.Size = new System.Drawing.Size(747, 23);
            this.btnStopAll.TabIndex = 13;
            this.btnStopAll.Text = "Зупинити всі потоки";
            this.btnStopAll.UseVisualStyleBackColor = true;
            this.btnStopAll.Click += new System.EventHandler(this.btnStopAll_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(771, 407);
            this.Controls.Add(this.btnStopAll);
            this.Controls.Add(this.btnStopLuc);
            this.Controls.Add(this.btnStartLuc);
            this.Controls.Add(this.btnStopSha);
            this.Controls.Add(this.btnStartSha);
            this.Controls.Add(this.btnStopRedoc);
            this.Controls.Add(this.btnStartRedoc);
            this.Controls.Add(this.btnStartAll);
            this.Controls.Add(this.panelLuc);
            this.Controls.Add(this.panelSha);
            this.Controls.Add(this.panelRedoc);
            this.Name = "MainForm";
            this.Text = "Багатопотоковість .NET Шифрування";
            this.panelRedoc.ResumeLayout(false);
            this.panelRedoc.PerformLayout();
            this.panelSha.ResumeLayout(false);
            this.panelSha.PerformLayout();
            this.panelLuc.ResumeLayout(false);
            this.panelLuc.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}