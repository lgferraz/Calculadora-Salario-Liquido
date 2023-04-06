namespace CalcIR
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalarioB = new System.Windows.Forms.TextBox();
            this.txtDescontos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nmrDependentes = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSalarioLiquido = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lbTotal2 = new System.Windows.Forms.Label();
            this.lbTotal1 = new System.Windows.Forms.Label();
            this.lbTotal0 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lbIRFF2 = new System.Windows.Forms.Label();
            this.lbIRFF1 = new System.Windows.Forms.Label();
            this.lbIRFF0 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lbINSS2 = new System.Windows.Forms.Label();
            this.lbINSS1 = new System.Windows.Forms.Label();
            this.lbINSS0 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbOutros2 = new System.Windows.Forms.Label();
            this.lbOutros1 = new System.Windows.Forms.Label();
            this.lbOutros0 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbSalario2 = new System.Windows.Forms.Label();
            this.lbSalario1 = new System.Windows.Forms.Label();
            this.lbSalario0 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataResultado = new System.Windows.Forms.DataGridView();
            this.comboFiltro = new System.Windows.Forms.ComboBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDependentes)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora Salario Liquido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salario Bruto:";
            // 
            // txtSalarioB
            // 
            this.txtSalarioB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioB.Location = new System.Drawing.Point(50, 115);
            this.txtSalarioB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSalarioB.Name = "txtSalarioB";
            this.txtSalarioB.Size = new System.Drawing.Size(114, 30);
            this.txtSalarioB.TabIndex = 2;
            this.txtSalarioB.Text = "0";
            this.txtSalarioB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDescontos
            // 
            this.txtDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontos.Location = new System.Drawing.Point(166, 115);
            this.txtDescontos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescontos.Name = "txtDescontos";
            this.txtDescontos.Size = new System.Drawing.Size(114, 30);
            this.txtDescontos.TabIndex = 4;
            this.txtDescontos.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descontos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(279, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dependentes:";
            // 
            // nmrDependentes
            // 
            this.nmrDependentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrDependentes.Location = new System.Drawing.Point(283, 115);
            this.nmrDependentes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nmrDependentes.Name = "nmrDependentes";
            this.nmrDependentes.Size = new System.Drawing.Size(112, 30);
            this.nmrDependentes.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbSalarioLiquido);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.lbTotal2);
            this.panel1.Controls.Add(this.lbTotal1);
            this.panel1.Controls.Add(this.lbTotal0);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.lbIRFF2);
            this.panel1.Controls.Add(this.lbIRFF1);
            this.panel1.Controls.Add(this.lbIRFF0);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.lbINSS2);
            this.panel1.Controls.Add(this.lbINSS1);
            this.panel1.Controls.Add(this.lbINSS0);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.lbOutros2);
            this.panel1.Controls.Add(this.lbOutros1);
            this.panel1.Controls.Add(this.lbOutros0);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.lbSalario2);
            this.panel1.Controls.Add(this.lbSalario1);
            this.panel1.Controls.Add(this.lbSalario0);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(50, 176);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 212);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbSalarioLiquido
            // 
            this.lbSalarioLiquido.AutoSize = true;
            this.lbSalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalarioLiquido.Location = new System.Drawing.Point(201, 171);
            this.lbSalarioLiquido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSalarioLiquido.Name = "lbSalarioLiquido";
            this.lbSalarioLiquido.Size = new System.Drawing.Size(61, 25);
            this.lbSalarioLiquido.TabIndex = 24;
            this.lbSalarioLiquido.Text = "00,00";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(62, 171);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(147, 25);
            this.label30.TabIndex = 10;
            this.label30.Text = "Salario Liquido:";
            // 
            // lbTotal2
            // 
            this.lbTotal2.AutoSize = true;
            this.lbTotal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal2.Location = new System.Drawing.Point(244, 141);
            this.lbTotal2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotal2.Name = "lbTotal2";
            this.lbTotal2.Size = new System.Drawing.Size(24, 18);
            this.lbTotal2.TabIndex = 23;
            this.lbTotal2.Text = "00";
            // 
            // lbTotal1
            // 
            this.lbTotal1.AutoSize = true;
            this.lbTotal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal1.Location = new System.Drawing.Point(170, 141);
            this.lbTotal1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotal1.Name = "lbTotal1";
            this.lbTotal1.Size = new System.Drawing.Size(24, 18);
            this.lbTotal1.TabIndex = 22;
            this.lbTotal1.Text = "00";
            // 
            // lbTotal0
            // 
            this.lbTotal0.AutoSize = true;
            this.lbTotal0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal0.Location = new System.Drawing.Point(86, 141);
            this.lbTotal0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotal0.Name = "lbTotal0";
            this.lbTotal0.Size = new System.Drawing.Size(24, 18);
            this.lbTotal0.TabIndex = 21;
            this.lbTotal0.Text = "00";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(16, 141);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(41, 18);
            this.label29.TabIndex = 20;
            this.label29.Text = "Total";
            // 
            // lbIRFF2
            // 
            this.lbIRFF2.AutoSize = true;
            this.lbIRFF2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIRFF2.Location = new System.Drawing.Point(244, 117);
            this.lbIRFF2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIRFF2.Name = "lbIRFF2";
            this.lbIRFF2.Size = new System.Drawing.Size(24, 18);
            this.lbIRFF2.TabIndex = 19;
            this.lbIRFF2.Text = "00";
            // 
            // lbIRFF1
            // 
            this.lbIRFF1.AutoSize = true;
            this.lbIRFF1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIRFF1.Location = new System.Drawing.Point(170, 117);
            this.lbIRFF1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIRFF1.Name = "lbIRFF1";
            this.lbIRFF1.Size = new System.Drawing.Size(24, 18);
            this.lbIRFF1.TabIndex = 18;
            this.lbIRFF1.Text = "00";
            // 
            // lbIRFF0
            // 
            this.lbIRFF0.AutoSize = true;
            this.lbIRFF0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIRFF0.Location = new System.Drawing.Point(86, 117);
            this.lbIRFF0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIRFF0.Name = "lbIRFF0";
            this.lbIRFF0.Size = new System.Drawing.Size(24, 18);
            this.lbIRFF0.TabIndex = 17;
            this.lbIRFF0.Text = "00";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(16, 117);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(40, 18);
            this.label25.TabIndex = 16;
            this.label25.Text = "IRFF";
            // 
            // lbINSS2
            // 
            this.lbINSS2.AutoSize = true;
            this.lbINSS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbINSS2.Location = new System.Drawing.Point(244, 93);
            this.lbINSS2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbINSS2.Name = "lbINSS2";
            this.lbINSS2.Size = new System.Drawing.Size(24, 18);
            this.lbINSS2.TabIndex = 15;
            this.lbINSS2.Text = "00";
            // 
            // lbINSS1
            // 
            this.lbINSS1.AutoSize = true;
            this.lbINSS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbINSS1.Location = new System.Drawing.Point(170, 93);
            this.lbINSS1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbINSS1.Name = "lbINSS1";
            this.lbINSS1.Size = new System.Drawing.Size(24, 18);
            this.lbINSS1.TabIndex = 14;
            this.lbINSS1.Text = "00";
            // 
            // lbINSS0
            // 
            this.lbINSS0.AutoSize = true;
            this.lbINSS0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbINSS0.Location = new System.Drawing.Point(86, 93);
            this.lbINSS0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbINSS0.Name = "lbINSS0";
            this.lbINSS0.Size = new System.Drawing.Size(24, 18);
            this.lbINSS0.TabIndex = 13;
            this.lbINSS0.Text = "00";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(16, 93);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 18);
            this.label21.TabIndex = 12;
            this.label21.Text = "INSS";
            // 
            // lbOutros2
            // 
            this.lbOutros2.AutoSize = true;
            this.lbOutros2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutros2.Location = new System.Drawing.Point(244, 67);
            this.lbOutros2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOutros2.Name = "lbOutros2";
            this.lbOutros2.Size = new System.Drawing.Size(24, 18);
            this.lbOutros2.TabIndex = 11;
            this.lbOutros2.Text = "00";
            // 
            // lbOutros1
            // 
            this.lbOutros1.AutoSize = true;
            this.lbOutros1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutros1.Location = new System.Drawing.Point(170, 67);
            this.lbOutros1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOutros1.Name = "lbOutros1";
            this.lbOutros1.Size = new System.Drawing.Size(24, 18);
            this.lbOutros1.TabIndex = 10;
            this.lbOutros1.Text = "00";
            // 
            // lbOutros0
            // 
            this.lbOutros0.AutoSize = true;
            this.lbOutros0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutros0.Location = new System.Drawing.Point(86, 67);
            this.lbOutros0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOutros0.Name = "lbOutros0";
            this.lbOutros0.Size = new System.Drawing.Size(24, 18);
            this.lbOutros0.TabIndex = 9;
            this.lbOutros0.Text = "00";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(16, 67);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 18);
            this.label17.TabIndex = 8;
            this.label17.Text = "Outros";
            // 
            // lbSalario2
            // 
            this.lbSalario2.AutoSize = true;
            this.lbSalario2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalario2.Location = new System.Drawing.Point(244, 41);
            this.lbSalario2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSalario2.Name = "lbSalario2";
            this.lbSalario2.Size = new System.Drawing.Size(24, 18);
            this.lbSalario2.TabIndex = 7;
            this.lbSalario2.Text = "00";
            // 
            // lbSalario1
            // 
            this.lbSalario1.AutoSize = true;
            this.lbSalario1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalario1.Location = new System.Drawing.Point(170, 41);
            this.lbSalario1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSalario1.Name = "lbSalario1";
            this.lbSalario1.Size = new System.Drawing.Size(24, 18);
            this.lbSalario1.TabIndex = 6;
            this.lbSalario1.Text = "00";
            // 
            // lbSalario0
            // 
            this.lbSalario0.AutoSize = true;
            this.lbSalario0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalario0.Location = new System.Drawing.Point(86, 41);
            this.lbSalario0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSalario0.Name = "lbSalario0";
            this.lbSalario0.Size = new System.Drawing.Size(24, 18);
            this.lbSalario0.TabIndex = 5;
            this.lbSalario0.Text = "00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 41);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 18);
            this.label13.TabIndex = 4;
            this.label13.Text = "Salario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(243, 13);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "Descontos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(170, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Somas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Alíquota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "O que";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Resultado";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(129, 411);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(225, 411);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "Inserir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtFiltro.Location = new System.Drawing.Point(49, 465);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(180, 27);
            this.txtFiltro.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label10.Location = new System.Drawing.Point(46, 63);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 22);
            this.label10.TabIndex = 12;
            this.label10.Text = "Nome:";
            // 
            // dataResultado
            // 
            this.dataResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResultado.Location = new System.Drawing.Point(50, 498);
            this.dataResultado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataResultado.Name = "dataResultado";
            this.dataResultado.RowHeadersWidth = 51;
            this.dataResultado.RowTemplate.Height = 24;
            this.dataResultado.Size = new System.Drawing.Size(347, 122);
            this.dataResultado.TabIndex = 14;
            this.dataResultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboFiltro
            // 
            this.comboFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.comboFiltro.FormattingEnabled = true;
            this.comboFiltro.Items.AddRange(new object[] {
            "NOME",
            "SALARIO_BRUTO",
            "DESCONTO_OUTROS",
            "QTD_DEPENDENTES",
            "INSS",
            "IRRF",
            "SALARIO_LIQUIDO"});
            this.comboFiltro.Location = new System.Drawing.Point(237, 464);
            this.comboFiltro.Name = "comboFiltro";
            this.comboFiltro.Size = new System.Drawing.Size(122, 28);
            this.comboFiltro.TabIndex = 15;
            this.comboFiltro.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.Location = new System.Drawing.Point(367, 463);
            this.btnProcurar.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(30, 30);
            this.btnProcurar.TabIndex = 16;
            this.btnProcurar.Text = "🔍︎";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 655);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.comboFiltro);
            this.Controls.Add(this.dataResultado);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nmrDependentes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescontos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSalarioB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Calculadora Salario Liquido";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrDependentes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalarioB;
        private System.Windows.Forms.TextBox txtDescontos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmrDependentes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTotal2;
        private System.Windows.Forms.Label lbTotal1;
        private System.Windows.Forms.Label lbTotal0;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lbIRFF2;
        private System.Windows.Forms.Label lbIRFF1;
        private System.Windows.Forms.Label lbIRFF0;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lbINSS2;
        private System.Windows.Forms.Label lbINSS1;
        private System.Windows.Forms.Label lbINSS0;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbOutros2;
        private System.Windows.Forms.Label lbOutros1;
        private System.Windows.Forms.Label lbOutros0;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbSalario2;
        private System.Windows.Forms.Label lbSalario1;
        private System.Windows.Forms.Label lbSalario0;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbSalarioLiquido;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataResultado;
        private System.Windows.Forms.ComboBox comboFiltro;
        private System.Windows.Forms.Button btnProcurar;
    }
}

