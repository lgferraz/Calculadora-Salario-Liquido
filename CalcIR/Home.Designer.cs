namespace CalcIR
{
    partial class Home
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnCentro = new System.Windows.Forms.Panel();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnTabelasINSSIRRF = new System.Windows.Forms.Button();
            this.btnCadastrarUsuarios = new System.Windows.Forms.Button();
            this.btnFecharForm = new System.Windows.Forms.Button();
            this.pnTop.SuspendLayout();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTop.BackColor = System.Drawing.Color.DarkViolet;
            this.pnTop.Controls.Add(this.btnFecharForm);
            this.pnTop.Location = new System.Drawing.Point(157, 1);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1093, 120);
            this.pnTop.TabIndex = 0;
            // 
            // pnMenu
            // 
            this.pnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnMenu.BackColor = System.Drawing.Color.DarkViolet;
            this.pnMenu.Controls.Add(this.btnCadastrarUsuarios);
            this.pnMenu.Controls.Add(this.btnTabelasINSSIRRF);
            this.pnMenu.Controls.Add(this.btnCalcular);
            this.pnMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnMenu.Location = new System.Drawing.Point(0, 114);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(158, 547);
            this.pnMenu.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 112);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pnCentro
            // 
            this.pnCentro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnCentro.BackColor = System.Drawing.Color.DarkViolet;
            this.pnCentro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnCentro.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnCentro.Location = new System.Drawing.Point(157, 114);
            this.pnCentro.Name = "pnCentro";
            this.pnCentro.Size = new System.Drawing.Size(1093, 547);
            this.pnCentro.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(0, 0);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(158, 52);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnTabelasINSSIRRF
            // 
            this.btnTabelasINSSIRRF.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTabelasINSSIRRF.FlatAppearance.BorderSize = 0;
            this.btnTabelasINSSIRRF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabelasINSSIRRF.ForeColor = System.Drawing.Color.White;
            this.btnTabelasINSSIRRF.Location = new System.Drawing.Point(0, 52);
            this.btnTabelasINSSIRRF.Name = "btnTabelasINSSIRRF";
            this.btnTabelasINSSIRRF.Size = new System.Drawing.Size(158, 52);
            this.btnTabelasINSSIRRF.TabIndex = 2;
            this.btnTabelasINSSIRRF.Text = "Tabelas INSS/IRRF";
            this.btnTabelasINSSIRRF.UseVisualStyleBackColor = true;
            this.btnTabelasINSSIRRF.Click += new System.EventHandler(this.btnTabelaIRRF_Click);
            // 
            // btnCadastrarUsuarios
            // 
            this.btnCadastrarUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastrarUsuarios.FlatAppearance.BorderSize = 0;
            this.btnCadastrarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarUsuarios.Location = new System.Drawing.Point(0, 104);
            this.btnCadastrarUsuarios.Name = "btnCadastrarUsuarios";
            this.btnCadastrarUsuarios.Size = new System.Drawing.Size(158, 52);
            this.btnCadastrarUsuarios.TabIndex = 3;
            this.btnCadastrarUsuarios.Text = "Cadastrar Usuarios";
            this.btnCadastrarUsuarios.UseVisualStyleBackColor = true;
            this.btnCadastrarUsuarios.Click += new System.EventHandler(this.btnCadastrarUsuarios_Click);
            // 
            // btnFecharForm
            // 
            this.btnFecharForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFecharForm.FlatAppearance.BorderSize = 0;
            this.btnFecharForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharForm.Location = new System.Drawing.Point(958, 0);
            this.btnFecharForm.Name = "btnFecharForm";
            this.btnFecharForm.Size = new System.Drawing.Size(135, 120);
            this.btnFecharForm.TabIndex = 0;
            this.btnFecharForm.Text = "x";
            this.btnFecharForm.UseVisualStyleBackColor = true;
            this.btnFecharForm.Visible = false;
            this.btnFecharForm.Click += new System.EventHandler(this.btnFecharForm_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 661);
            this.Controls.Add(this.pnCentro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.pnTop);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Home";
            this.Text = "Home";
            this.pnTop.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btnCadastrarUsuarios;
        private System.Windows.Forms.Button btnTabelasINSSIRRF;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnCentro;
        private System.Windows.Forms.Button btnFecharForm;
    }
}