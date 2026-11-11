namespace ProjetoMatematica
{
    partial class Frm_Antecessor
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
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_DigiteNum = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Btn_Sucessor = new System.Windows.Forms.Button();
            this.Btn_Antecessor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.Color.Blue;
            this.Lbl_Titulo.Location = new System.Drawing.Point(325, 35);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(304, 35);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Antecessor e Sucessor";
            // 
            // Lbl_DigiteNum
            // 
            this.Lbl_DigiteNum.AutoSize = true;
            this.Lbl_DigiteNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DigiteNum.ForeColor = System.Drawing.Color.Green;
            this.Lbl_DigiteNum.Location = new System.Drawing.Point(197, 164);
            this.Lbl_DigiteNum.Name = "Lbl_DigiteNum";
            this.Lbl_DigiteNum.Size = new System.Drawing.Size(283, 25);
            this.Lbl_DigiteNum.TabIndex = 1;
            this.Lbl_DigiteNum.Text = "Digite um número inteiro: ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(500, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 80);
            this.textBox1.TabIndex = 2;
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Btn_Voltar.FlatAppearance.BorderSize = 3;
            this.Btn_Voltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Voltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.Location = new System.Drawing.Point(777, 426);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(129, 64);
            this.Btn_Voltar.TabIndex = 4;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Btn_Sucessor
            // 
            this.Btn_Sucessor.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sucessor.ForeColor = System.Drawing.Color.Blue;
            this.Btn_Sucessor.Location = new System.Drawing.Point(554, 282);
            this.Btn_Sucessor.Name = "Btn_Sucessor";
            this.Btn_Sucessor.Size = new System.Drawing.Size(122, 47);
            this.Btn_Sucessor.TabIndex = 5;
            this.Btn_Sucessor.Text = "Sucessor";
            this.Btn_Sucessor.UseVisualStyleBackColor = true;
            // 
            // Btn_Antecessor
            // 
            this.Btn_Antecessor.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Antecessor.ForeColor = System.Drawing.Color.Red;
            this.Btn_Antecessor.Location = new System.Drawing.Point(266, 282);
            this.Btn_Antecessor.Name = "Btn_Antecessor";
            this.Btn_Antecessor.Size = new System.Drawing.Size(154, 47);
            this.Btn_Antecessor.TabIndex = 6;
            this.Btn_Antecessor.Text = "Antecessor";
            this.Btn_Antecessor.UseVisualStyleBackColor = true;
            // 
            // Frm_Antecessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoMatematica.Properties.Resources._7449401_desenho_escola_criancas_com_lousa_gratis_vetor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 502);
            this.Controls.Add(this.Btn_Antecessor);
            this.Controls.Add(this.Btn_Sucessor);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lbl_DigiteNum);
            this.Controls.Add(this.Lbl_Titulo);
            this.Name = "Frm_Antecessor";
            this.Text = "Antecessor Ou Sucessor";
            this.Load += new System.EventHandler(this.Frm_Antecessor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_DigiteNum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Button Btn_Sucessor;
        private System.Windows.Forms.Button Btn_Antecessor;
    }
}