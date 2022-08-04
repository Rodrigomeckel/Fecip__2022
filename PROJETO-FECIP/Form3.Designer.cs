namespace PROJETO_FECIP
{
    partial class Form3
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mtxb_alterar_cpf = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_pesquizar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(283, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 37);
            this.label3.TabIndex = 18;
            this.label3.Text = "-";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(88, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 1);
            this.panel4.TabIndex = 5;
            // 
            // mtxb_alterar_cpf
            // 
            this.mtxb_alterar_cpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.mtxb_alterar_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxb_alterar_cpf.ForeColor = System.Drawing.SystemColors.Window;
            this.mtxb_alterar_cpf.Location = new System.Drawing.Point(88, 130);
            this.mtxb_alterar_cpf.Mask = "000.000.000-00";
            this.mtxb_alterar_cpf.Name = "mtxb_alterar_cpf";
            this.mtxb_alterar_cpf.Size = new System.Drawing.Size(191, 13);
            this.mtxb_alterar_cpf.TabIndex = 20;
            this.mtxb_alterar_cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxb_alterar_cpf_MaskInputRejected);
            this.mtxb_alterar_cpf.Click += new System.EventHandler(this.mtxb_alterar_cpf_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PROJETO_FECIP.Properties.Resources.CPF;
            this.pictureBox2.Location = new System.Drawing.Point(48, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(85, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Digite seu cpf";
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.Cyan;
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_alterar.Location = new System.Drawing.Point(97, 351);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(150, 35);
            this.btn_alterar.TabIndex = 27;
            this.btn_alterar.Text = "ALTERAR";
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_pesquizar
            // 
            this.btn_pesquizar.BackColor = System.Drawing.Color.Cyan;
            this.btn_pesquizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquizar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_pesquizar.Location = new System.Drawing.Point(97, 293);
            this.btn_pesquizar.Name = "btn_pesquizar";
            this.btn_pesquizar.Size = new System.Drawing.Size(150, 35);
            this.btn_pesquizar.TabIndex = 28;
            this.btn_pesquizar.Text = "PESQUISAR";
            this.btn_pesquizar.UseVisualStyleBackColor = false;
            this.btn_pesquizar.Click += new System.EventHandler(this.btn_pesquizar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PROJETO_FECIP.Properties.Resources.cadeado1;
            this.pictureBox3.Location = new System.Drawing.Point(48, 219);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // txb_password
            // 
            this.txb_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_password.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txb_password.Location = new System.Drawing.Point(88, 224);
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(200, 15);
            this.txb_password.TabIndex = 24;
            this.txb_password.Click += new System.EventHandler(this.txb_password_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(88, 247);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 1);
            this.panel5.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(85, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(11, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(324, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "DIGITE APENAS SEU CPF E CLIQUE EM PESQUISAR!!";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(366, 437);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_pesquizar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.mtxb_alterar_cpf);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseUp);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MaskedTextBox mtxb_alterar_cpf;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_pesquizar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}