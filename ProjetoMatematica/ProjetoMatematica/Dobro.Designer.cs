namespace ProjetoMatematica
{
    partial class Frm_Dobro
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
            this.Lbl_MostrarDobro = new System.Windows.Forms.Label();
            this.Lbl_DigiteUmNumero = new System.Windows.Forms.Label();
            this.Txt_NumDobro = new System.Windows.Forms.TextBox();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_MostrarDobro
            // 
            this.Lbl_MostrarDobro.BackColor = System.Drawing.Color.DarkGray;
            this.Lbl_MostrarDobro.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MostrarDobro.Location = new System.Drawing.Point(12, 9);
            this.Lbl_MostrarDobro.Name = "Lbl_MostrarDobro";
            this.Lbl_MostrarDobro.Size = new System.Drawing.Size(910, 54);
            this.Lbl_MostrarDobro.TabIndex = 2;
            this.Lbl_MostrarDobro.Text = "Mostrar o Dobro do Número";
            this.Lbl_MostrarDobro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_DigiteUmNumero
            // 
            this.Lbl_DigiteUmNumero.AutoSize = true;
            this.Lbl_DigiteUmNumero.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DigiteUmNumero.Location = new System.Drawing.Point(238, 206);
            this.Lbl_DigiteUmNumero.Name = "Lbl_DigiteUmNumero";
            this.Lbl_DigiteUmNumero.Size = new System.Drawing.Size(282, 40);
            this.Lbl_DigiteUmNumero.TabIndex = 4;
            this.Lbl_DigiteUmNumero.Text = "Digite um Número:";
            this.Lbl_DigiteUmNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_NumDobro
            // 
            this.Txt_NumDobro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Txt_NumDobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NumDobro.Location = new System.Drawing.Point(526, 206);
            this.Txt_NumDobro.Multiline = true;
            this.Txt_NumDobro.Name = "Txt_NumDobro";
            this.Txt_NumDobro.Size = new System.Drawing.Size(193, 37);
            this.Txt_NumDobro.TabIndex = 5;
            this.Txt_NumDobro.TextChanged += new System.EventHandler(this.Txt_NumDobro_TextChanged);
            this.Txt_NumDobro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NumDobro_KeyPress);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Btn_Voltar.FlatAppearance.BorderSize = 3;
            this.Btn_Voltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Voltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.Location = new System.Drawing.Point(793, 465);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(129, 64);
            this.Btn_Voltar.TabIndex = 6;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Frm_Dobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ProjetoMatematica.Properties.Resources.Dobro3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 541);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Txt_NumDobro);
            this.Controls.Add(this.Lbl_DigiteUmNumero);
            this.Controls.Add(this.Lbl_MostrarDobro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Dobro";
            this.Text = "Dobro";
            this.Load += new System.EventHandler(this.Frm_Dobro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_MostrarDobro;
        private System.Windows.Forms.Label Lbl_DigiteUmNumero;
        private System.Windows.Forms.TextBox Txt_NumDobro;
        private System.Windows.Forms.Button Btn_Voltar;
    }
}