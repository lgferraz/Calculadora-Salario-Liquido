namespace CalcIR
{
    partial class Inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicial));
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalarioB = new System.Windows.Forms.TextBox();
            this.txtDescontos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nmrcDependentes = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditarInss = new System.Windows.Forms.Button();
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcDependentes)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salario Bruto:";
            // 
            // txtSalarioB
            // 
            this.txtSalarioB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioB.Location = new System.Drawing.Point(67, 94);
            this.txtSalarioB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalarioB.Name = "txtSalarioB";
            this.txtSalarioB.Size = new System.Drawing.Size(151, 35);
            this.txtSalarioB.TabIndex = 2;
            this.txtSalarioB.Text = "0";
            this.txtSalarioB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDescontos
            // 
            this.txtDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontos.Location = new System.Drawing.Point(221, 94);
            this.txtDescontos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescontos.Name = "txtDescontos";
            this.txtDescontos.Size = new System.Drawing.Size(151, 35);
            this.txtDescontos.TabIndex = 4;
            this.txtDescontos.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descontos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(372, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dependentes:";
            // 
            // nmrcDependentes
            // 
            this.nmrcDependentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrcDependentes.Location = new System.Drawing.Point(377, 94);
            this.nmrcDependentes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmrcDependentes.Name = "nmrcDependentes";
            this.nmrcDependentes.Size = new System.Drawing.Size(149, 35);
            this.nmrcDependentes.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEditarInss);
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
            this.panel1.Location = new System.Drawing.Point(67, 169);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 260);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnEditarInss
            // 
            this.btnEditarInss.FlatAppearance.BorderSize = 0;
            this.btnEditarInss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarInss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnEditarInss.Location = new System.Drawing.Point(427, 228);
            this.btnEditarInss.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarInss.Name = "btnEditarInss";
            this.btnEditarInss.Size = new System.Drawing.Size(34, 31);
            this.btnEditarInss.TabIndex = 18;
            this.btnEditarInss.Text = "🖊️";
            this.btnEditarInss.UseVisualStyleBackColor = true;
            this.btnEditarInss.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // lbSalarioLiquido
            // 
            this.lbSalarioLiquido.AutoSize = true;
            this.lbSalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalarioLiquido.Location = new System.Drawing.Point(268, 210);
            this.lbSalarioLiquido.Name = "lbSalarioLiquido";
            this.lbSalarioLiquido.Size = new System.Drawing.Size(76, 29);
            this.lbSalarioLiquido.TabIndex = 24;
            this.lbSalarioLiquido.Text = "00,00";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(83, 210);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(188, 29);
            this.label30.TabIndex = 10;
            this.label30.Text = "Salario Liquido:";
            // 
            // lbTotal2
            // 
            this.lbTotal2.AutoSize = true;
            this.lbTotal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal2.Location = new System.Drawing.Point(325, 174);
            this.lbTotal2.Name = "lbTotal2";
            this.lbTotal2.Size = new System.Drawing.Size(30, 22);
            this.lbTotal2.TabIndex = 23;
            this.lbTotal2.Text = "00";
            // 
            // lbTotal1
            // 
            this.lbTotal1.AutoSize = true;
            this.lbTotal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal1.Location = new System.Drawing.Point(227, 174);
            this.lbTotal1.Name = "lbTotal1";
            this.lbTotal1.Size = new System.Drawing.Size(30, 22);
            this.lbTotal1.TabIndex = 22;
            this.lbTotal1.Text = "00";
            // 
            // lbTotal0
            // 
            this.lbTotal0.AutoSize = true;
            this.lbTotal0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal0.Location = new System.Drawing.Point(115, 174);
            this.lbTotal0.Name = "lbTotal0";
            this.lbTotal0.Size = new System.Drawing.Size(30, 22);
            this.lbTotal0.TabIndex = 21;
            this.lbTotal0.Text = "00";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(21, 174);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(51, 22);
            this.label29.TabIndex = 20;
            this.label29.Text = "Total";
            // 
            // lbIRFF2
            // 
            this.lbIRFF2.AutoSize = true;
            this.lbIRFF2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIRFF2.Location = new System.Drawing.Point(325, 144);
            this.lbIRFF2.Name = "lbIRFF2";
            this.lbIRFF2.Size = new System.Drawing.Size(30, 22);
            this.lbIRFF2.TabIndex = 19;
            this.lbIRFF2.Text = "00";
            // 
            // lbIRFF1
            // 
            this.lbIRFF1.AutoSize = true;
            this.lbIRFF1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIRFF1.Location = new System.Drawing.Point(227, 144);
            this.lbIRFF1.Name = "lbIRFF1";
            this.lbIRFF1.Size = new System.Drawing.Size(30, 22);
            this.lbIRFF1.TabIndex = 18;
            this.lbIRFF1.Text = "00";
            // 
            // lbIRFF0
            // 
            this.lbIRFF0.AutoSize = true;
            this.lbIRFF0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIRFF0.Location = new System.Drawing.Point(115, 144);
            this.lbIRFF0.Name = "lbIRFF0";
            this.lbIRFF0.Size = new System.Drawing.Size(30, 22);
            this.lbIRFF0.TabIndex = 17;
            this.lbIRFF0.Text = "00";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(21, 144);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(49, 22);
            this.label25.TabIndex = 16;
            this.label25.Text = "IRFF";
            // 
            // lbINSS2
            // 
            this.lbINSS2.AutoSize = true;
            this.lbINSS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbINSS2.Location = new System.Drawing.Point(325, 114);
            this.lbINSS2.Name = "lbINSS2";
            this.lbINSS2.Size = new System.Drawing.Size(30, 22);
            this.lbINSS2.TabIndex = 15;
            this.lbINSS2.Text = "00";
            // 
            // lbINSS1
            // 
            this.lbINSS1.AutoSize = true;
            this.lbINSS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbINSS1.Location = new System.Drawing.Point(227, 114);
            this.lbINSS1.Name = "lbINSS1";
            this.lbINSS1.Size = new System.Drawing.Size(30, 22);
            this.lbINSS1.TabIndex = 14;
            this.lbINSS1.Text = "00";
            // 
            // lbINSS0
            // 
            this.lbINSS0.AutoSize = true;
            this.lbINSS0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbINSS0.Location = new System.Drawing.Point(115, 114);
            this.lbINSS0.Name = "lbINSS0";
            this.lbINSS0.Size = new System.Drawing.Size(30, 22);
            this.lbINSS0.TabIndex = 13;
            this.lbINSS0.Text = "00";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(21, 114);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 22);
            this.label21.TabIndex = 12;
            this.label21.Text = "INSS";
            // 
            // lbOutros2
            // 
            this.lbOutros2.AutoSize = true;
            this.lbOutros2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutros2.Location = new System.Drawing.Point(325, 82);
            this.lbOutros2.Name = "lbOutros2";
            this.lbOutros2.Size = new System.Drawing.Size(30, 22);
            this.lbOutros2.TabIndex = 11;
            this.lbOutros2.Text = "00";
            // 
            // lbOutros1
            // 
            this.lbOutros1.AutoSize = true;
            this.lbOutros1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutros1.Location = new System.Drawing.Point(227, 82);
            this.lbOutros1.Name = "lbOutros1";
            this.lbOutros1.Size = new System.Drawing.Size(30, 22);
            this.lbOutros1.TabIndex = 10;
            this.lbOutros1.Text = "00";
            // 
            // lbOutros0
            // 
            this.lbOutros0.AutoSize = true;
            this.lbOutros0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutros0.Location = new System.Drawing.Point(115, 82);
            this.lbOutros0.Name = "lbOutros0";
            this.lbOutros0.Size = new System.Drawing.Size(30, 22);
            this.lbOutros0.TabIndex = 9;
            this.lbOutros0.Text = "00";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(21, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 22);
            this.label17.TabIndex = 8;
            this.label17.Text = "Outros";
            // 
            // lbSalario2
            // 
            this.lbSalario2.AutoSize = true;
            this.lbSalario2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalario2.Location = new System.Drawing.Point(325, 50);
            this.lbSalario2.Name = "lbSalario2";
            this.lbSalario2.Size = new System.Drawing.Size(30, 22);
            this.lbSalario2.TabIndex = 7;
            this.lbSalario2.Text = "00";
            // 
            // lbSalario1
            // 
            this.lbSalario1.AutoSize = true;
            this.lbSalario1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalario1.Location = new System.Drawing.Point(227, 50);
            this.lbSalario1.Name = "lbSalario1";
            this.lbSalario1.Size = new System.Drawing.Size(30, 22);
            this.lbSalario1.TabIndex = 6;
            this.lbSalario1.Text = "00";
            // 
            // lbSalario0
            // 
            this.lbSalario0.AutoSize = true;
            this.lbSalario0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalario0.Location = new System.Drawing.Point(115, 50);
            this.lbSalario0.Name = "lbSalario0";
            this.lbSalario0.Size = new System.Drawing.Size(30, 22);
            this.lbSalario0.TabIndex = 5;
            this.lbSalario0.Text = "00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 22);
            this.label13.TabIndex = 4;
            this.label13.Text = "Salario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(324, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 26);
            this.label9.TabIndex = 3;
            this.label9.Text = "Descontos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(227, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "Somas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(115, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "Alíquota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "O que";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Resultado";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(172, 458);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(300, 458);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 39);
            this.button2.TabIndex = 11;
            this.button2.Text = "Inserir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtFiltro.Location = new System.Drawing.Point(549, 99);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(239, 32);
            this.txtFiltro.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label10.Location = new System.Drawing.Point(61, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 26);
            this.label10.TabIndex = 12;
            this.label10.Text = "Nome:";
            // 
            // dataResultado
            // 
            this.dataResultado.BackgroundColor = System.Drawing.Color.DarkViolet;
            this.dataResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResultado.GridColor = System.Drawing.Color.DarkViolet;
            this.dataResultado.Location = new System.Drawing.Point(549, 169);
            this.dataResultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataResultado.Name = "dataResultado";
            this.dataResultado.RowHeadersWidth = 51;
            this.dataResultado.RowTemplate.Height = 24;
            this.dataResultado.Size = new System.Drawing.Size(463, 260);
            this.dataResultado.TabIndex = 14;
            this.dataResultado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataResultado_CellClick);
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
            this.comboFiltro.Location = new System.Drawing.Point(800, 98);
            this.comboFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.comboFiltro.Name = "comboFiltro";
            this.comboFiltro.Size = new System.Drawing.Size(161, 33);
            this.comboFiltro.TabIndex = 15;
            this.comboFiltro.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnProcurar
            // 
            this.btnProcurar.FlatAppearance.BorderSize = 0;
            this.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.Location = new System.Drawing.Point(974, 96);
            this.btnProcurar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(40, 37);
            this.btnProcurar.TabIndex = 16;
            this.btnProcurar.Text = "🔍︎";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtNome.Location = new System.Drawing.Point(144, 27);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(228, 32);
            this.txtNome.TabIndex = 17;
            // 
            // txtAno
            // 
            this.txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtAno.Location = new System.Drawing.Point(444, 27);
            this.txtAno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(82, 32);
            this.txtAno.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label11.Location = new System.Drawing.Point(381, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 26);
            this.label11.TabIndex = 18;
            this.label11.Text = "Ano:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label1.Location = new System.Drawing.Point(544, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "Pesquisa:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label12.Location = new System.Drawing.Point(795, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 26);
            this.label12.TabIndex = 21;
            this.label12.Text = "Filtro:";
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(1041, 513);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.comboFiltro);
            this.Controls.Add(this.dataResultado);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nmrcDependentes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescontos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSalarioB);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Inicial";
            this.Text = "Calculadora Salario Liquido";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrcDependentes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalarioB;
        private System.Windows.Forms.TextBox txtDescontos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmrcDependentes;
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
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnEditarInss;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
    }
}

