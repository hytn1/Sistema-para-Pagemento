namespace ProjetoAula;

partial class Form1
{
    private System.ComponentModel.IContainer components = null!;
    private Label lblTitulo = null!;
    private Label lblSubtitulo = null!;
    private Label lblMesa = null!;
    private TextBox txtMesa = null!;
    private Label lblPedidos = null!;
    private Label lblQuantidade = null!;
    private Label lblTotalParcial = null!;
    private CheckBox chkChopp = null!;
    private CheckBox chkPetiscos = null!;
    private CheckBox chkRefeicao = null!;
    private NumericUpDown nudChopp = null!;
    private NumericUpDown nudPetiscos = null!;
    private NumericUpDown nudRefeicao = null!;
    private TextBox txtTotalChopp = null!;
    private TextBox txtTotalPetiscos = null!;
    private TextBox txtTotalRefeicao = null!;
    private Label lblTaxaTitulo = null!;
    private TextBox txtTaxa = null!;
    private Label lblTotalTitulo = null!;
    private TextBox txtTotalPagar = null!;
    private Button btnCalcular = null!;
    private Button btnPagamento = null!;
    private Button btnSair = null!;
    private Panel panelHeader = null!;
    private Panel panelPrincipal = null!;
    private Panel panelLinha = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        panelHeader = new Panel();
        lblSubtitulo = new Label();
        lblTitulo = new Label();
        panelPrincipal = new Panel();
        lblTotalTitulo = new Label();
        txtTaxa = new TextBox();
        lblTaxaTitulo = new Label();
        panelLinha = new Panel();
        txtTotalRefeicao = new TextBox();
        txtTotalPetiscos = new TextBox();
        txtTotalChopp = new TextBox();
        nudRefeicao = new NumericUpDown();
        nudPetiscos = new NumericUpDown();
        nudChopp = new NumericUpDown();
        chkRefeicao = new CheckBox();
        chkPetiscos = new CheckBox();
        chkChopp = new CheckBox();
        lblTotalParcial = new Label();
        lblQuantidade = new Label();
        lblPedidos = new Label();
        txtMesa = new TextBox();
        lblMesa = new Label();
        txtTotalPagar = new TextBox();
        btnCalcular = new Button();
        btnPagamento = new Button();
        btnSair = new Button();
        panelHeader.SuspendLayout();
        panelPrincipal.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudRefeicao).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudPetiscos).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudChopp).BeginInit();
        SuspendLayout();
        // 
        // panelHeader
        // 
        panelHeader.BackColor = Color.Teal;
        panelHeader.Controls.Add(lblSubtitulo);
        panelHeader.Controls.Add(lblTitulo);
        panelHeader.Dock = DockStyle.Top;
        panelHeader.Location = new Point(0, 0);
        panelHeader.Name = "panelHeader";
        panelHeader.Size = new Size(920, 92);
        panelHeader.TabIndex = 0;
        // 
        // lblSubtitulo
        // 
        lblSubtitulo.AutoSize = true;
        lblSubtitulo.Font = new Font("Segoe UI", 10.5F);
        lblSubtitulo.ForeColor = Color.FromArgb(255, 235, 215);
        lblSubtitulo.Location = new Point(33, 57);
        lblSubtitulo.Name = "lblSubtitulo";
        lblSubtitulo.Size = new Size(362, 25);
        lblSubtitulo.TabIndex = 0;
        lblSubtitulo.Text = "Controle de pedidos e fechamento da conta";
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.White;
        lblTitulo.Location = new Point(30, 15);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(462, 50);
        lblTitulo.TabIndex = 1;
        lblTitulo.Text = "Sistema para Restaurante\r\n";
        lblTitulo.Click += lblTitulo_Click;
        // 
        // panelPrincipal
        // 
        panelPrincipal.BackColor = Color.White;
        panelPrincipal.BorderStyle = BorderStyle.FixedSingle;
        panelPrincipal.Controls.Add(lblTotalTitulo);
        panelPrincipal.Controls.Add(txtTaxa);
        panelPrincipal.Controls.Add(lblTaxaTitulo);
        panelPrincipal.Controls.Add(panelLinha);
        panelPrincipal.Controls.Add(txtTotalRefeicao);
        panelPrincipal.Controls.Add(txtTotalPetiscos);
        panelPrincipal.Controls.Add(txtTotalChopp);
        panelPrincipal.Controls.Add(nudRefeicao);
        panelPrincipal.Controls.Add(nudPetiscos);
        panelPrincipal.Controls.Add(nudChopp);
        panelPrincipal.Controls.Add(chkRefeicao);
        panelPrincipal.Controls.Add(chkPetiscos);
        panelPrincipal.Controls.Add(chkChopp);
        panelPrincipal.Controls.Add(lblTotalParcial);
        panelPrincipal.Controls.Add(lblQuantidade);
        panelPrincipal.Controls.Add(lblPedidos);
        panelPrincipal.Controls.Add(txtMesa);
        panelPrincipal.Controls.Add(lblMesa);
        panelPrincipal.Location = new Point(25, 115);
        panelPrincipal.Name = "panelPrincipal";
        panelPrincipal.Size = new Size(870, 390);
        panelPrincipal.TabIndex = 1;
        // 
        // lblTotalTitulo
        // 
        lblTotalTitulo.AutoSize = true;
        lblTotalTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTotalTitulo.Location = new Point(470, 360);
        lblTotalTitulo.Name = "lblTotalTitulo";
        lblTotalTitulo.Size = new Size(154, 25);
        lblTotalTitulo.TabIndex = 0;
        lblTotalTitulo.Text = "TOTAL A PAGAR";
        // 
        // txtTaxa
        // 
        txtTaxa.BackColor = Color.FromArgb(248, 248, 248);
        txtTaxa.Location = new Point(690, 320);
        txtTaxa.Name = "txtTaxa";
        txtTaxa.ReadOnly = true;
        txtTaxa.Size = new Size(150, 30);
        txtTaxa.TabIndex = 1;
        txtTaxa.TextAlign = HorizontalAlignment.Right;
        // 
        // lblTaxaTitulo
        // 
        lblTaxaTitulo.AutoSize = true;
        lblTaxaTitulo.Font = new Font("Segoe UI", 10F);
        lblTaxaTitulo.Location = new Point(470, 325);
        lblTaxaTitulo.Name = "lblTaxaTitulo";
        lblTaxaTitulo.Size = new Size(171, 23);
        lblTaxaTitulo.TabIndex = 2;
        lblTaxaTitulo.Text = "Taxa de serviço (10%)";
        // 
        // panelLinha
        // 
        panelLinha.BackColor = Color.FromArgb(225, 225, 225);
        panelLinha.Location = new Point(28, 304);
        panelLinha.Name = "panelLinha";
        panelLinha.Size = new Size(815, 1);
        panelLinha.TabIndex = 3;
        // 
        // txtTotalRefeicao
        // 
        txtTotalRefeicao.BackColor = Color.FromArgb(248, 248, 248);
        txtTotalRefeicao.Location = new Point(615, 240);
        txtTotalRefeicao.Name = "txtTotalRefeicao";
        txtTotalRefeicao.ReadOnly = true;
        txtTotalRefeicao.Size = new Size(150, 30);
        txtTotalRefeicao.TabIndex = 4;
        txtTotalRefeicao.TextAlign = HorizontalAlignment.Right;
        // 
        // txtTotalPetiscos
        // 
        txtTotalPetiscos.BackColor = Color.FromArgb(248, 248, 248);
        txtTotalPetiscos.Location = new Point(615, 180);
        txtTotalPetiscos.Name = "txtTotalPetiscos";
        txtTotalPetiscos.ReadOnly = true;
        txtTotalPetiscos.Size = new Size(150, 30);
        txtTotalPetiscos.TabIndex = 5;
        txtTotalPetiscos.TextAlign = HorizontalAlignment.Right;
        // 
        // txtTotalChopp
        // 
        txtTotalChopp.BackColor = Color.FromArgb(248, 248, 248);
        txtTotalChopp.Location = new Point(615, 120);
        txtTotalChopp.Name = "txtTotalChopp";
        txtTotalChopp.ReadOnly = true;
        txtTotalChopp.Size = new Size(150, 30);
        txtTotalChopp.TabIndex = 6;
        txtTotalChopp.TextAlign = HorizontalAlignment.Right;
        // 
        // nudRefeicao
        // 
        nudRefeicao.Location = new Point(380, 240);
        nudRefeicao.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
        nudRefeicao.Name = "nudRefeicao";
        nudRefeicao.Size = new Size(100, 30);
        nudRefeicao.TabIndex = 7;
        nudRefeicao.TextAlign = HorizontalAlignment.Center;
        nudRefeicao.ValueChanged += Quantidade_ValueChanged;
        // 
        // nudPetiscos
        // 
        nudPetiscos.Location = new Point(380, 180);
        nudPetiscos.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
        nudPetiscos.Name = "nudPetiscos";
        nudPetiscos.Size = new Size(100, 30);
        nudPetiscos.TabIndex = 8;
        nudPetiscos.TextAlign = HorizontalAlignment.Center;
        nudPetiscos.ValueChanged += Quantidade_ValueChanged;
        // 
        // nudChopp
        // 
        nudChopp.Location = new Point(380, 120);
        nudChopp.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
        nudChopp.Name = "nudChopp";
        nudChopp.Size = new Size(100, 30);
        nudChopp.TabIndex = 9;
        nudChopp.TextAlign = HorizontalAlignment.Center;
        nudChopp.ValueChanged += Quantidade_ValueChanged;
        // 
        // chkRefeicao
        // 
        chkRefeicao.AutoSize = true;
        chkRefeicao.Location = new Point(28, 244);
        chkRefeicao.Name = "chkRefeicao";
        chkRefeicao.Size = new Size(187, 27);
        chkRefeicao.TabIndex = 10;
        chkRefeicao.Text = "Refeição  -  R$ 15,90";
        chkRefeicao.CheckedChanged += chkPedido_CheckedChanged;
        // 
        // chkPetiscos
        // 
        chkPetiscos.AutoSize = true;
        chkPetiscos.Location = new Point(28, 184);
        chkPetiscos.Name = "chkPetiscos";
        chkPetiscos.Size = new Size(174, 27);
        chkPetiscos.TabIndex = 11;
        chkPetiscos.Text = "Petiscos  -  R$ 7,90";
        chkPetiscos.CheckedChanged += chkPedido_CheckedChanged;
        // 
        // chkChopp
        // 
        chkChopp.AutoSize = true;
        chkChopp.Location = new Point(28, 124);
        chkChopp.Name = "chkChopp";
        chkChopp.Size = new Size(165, 27);
        chkChopp.TabIndex = 12;
        chkChopp.Text = "Chopp  -  R$ 4,50";
        chkChopp.CheckedChanged += chkPedido_CheckedChanged;
        // 
        // lblTotalParcial
        // 
        lblTotalParcial.AutoSize = true;
        lblTotalParcial.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblTotalParcial.Location = new Point(615, 78);
        lblTotalParcial.Name = "lblTotalParcial";
        lblTotalParcial.Size = new Size(135, 23);
        lblTotalParcial.TabIndex = 13;
        lblTotalParcial.Text = "TOTAL PARCIAL";
        // 
        // lblQuantidade
        // 
        lblQuantidade.AutoSize = true;
        lblQuantidade.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblQuantidade.Location = new Point(380, 78);
        lblQuantidade.Name = "lblQuantidade";
        lblQuantidade.Size = new Size(122, 23);
        lblQuantidade.TabIndex = 14;
        lblQuantidade.Text = "QUANTIDADE";
        // 
        // lblPedidos
        // 
        lblPedidos.AutoSize = true;
        lblPedidos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblPedidos.Location = new Point(28, 78);
        lblPedidos.Name = "lblPedidos";
        lblPedidos.Size = new Size(83, 23);
        lblPedidos.TabIndex = 15;
        lblPedidos.Text = "PEDIDOS";
        // 
        // txtMesa
        // 
        txtMesa.BackColor = Color.FromArgb(255, 244, 232);
        txtMesa.Font = new Font("Segoe UI", 11F);
        txtMesa.Location = new Point(112, 18);
        txtMesa.Name = "txtMesa";
        txtMesa.Size = new Size(120, 32);
        txtMesa.TabIndex = 16;
        // 
        // lblMesa
        // 
        lblMesa.AutoSize = true;
        lblMesa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblMesa.Location = new Point(28, 22);
        lblMesa.Name = "lblMesa";
        lblMesa.Size = new Size(83, 23);
        lblMesa.TabIndex = 17;
        lblMesa.Text = "Nº MESA";
        // 
        // txtTotalPagar
        // 
        txtTotalPagar.BackColor = Color.FromArgb(255, 244, 232);
        txtTotalPagar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        txtTotalPagar.ForeColor = Color.FromArgb(173, 91, 19);
        txtTotalPagar.Location = new Point(690, 355);
        txtTotalPagar.Name = "txtTotalPagar";
        txtTotalPagar.ReadOnly = true;
        txtTotalPagar.Size = new Size(150, 34);
        txtTotalPagar.TabIndex = 0;
        txtTotalPagar.TextAlign = HorizontalAlignment.Right;
        // 
        // btnCalcular
        // 
        btnCalcular.BackColor = Color.Teal;
        btnCalcular.FlatAppearance.BorderSize = 0;
        btnCalcular.FlatStyle = FlatStyle.Flat;
        btnCalcular.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnCalcular.ForeColor = Color.White;
        btnCalcular.Location = new Point(25, 535);
        btnCalcular.Name = "btnCalcular";
        btnCalcular.Size = new Size(190, 48);
        btnCalcular.TabIndex = 2;
        btnCalcular.Text = "Calcular";
        btnCalcular.UseVisualStyleBackColor = false;
        btnCalcular.Click += btnCalcular_Click;
        // 
        // btnPagamento
        // 
        btnPagamento.BackColor = Color.FromArgb(0, 64, 64);
        btnPagamento.FlatAppearance.BorderSize = 0;
        btnPagamento.FlatStyle = FlatStyle.Flat;
        btnPagamento.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnPagamento.ForeColor = Color.White;
        btnPagamento.Location = new Point(365, 535);
        btnPagamento.Name = "btnPagamento";
        btnPagamento.Size = new Size(190, 48);
        btnPagamento.TabIndex = 1;
        btnPagamento.Text = "Pagamento";
        btnPagamento.UseVisualStyleBackColor = false;
        btnPagamento.Click += btnPagamento_Click;
        // 
        // btnSair
        // 
        btnSair.BackColor = Color.FromArgb(90, 90, 90);
        btnSair.FlatAppearance.BorderSize = 0;
        btnSair.FlatStyle = FlatStyle.Flat;
        btnSair.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnSair.ForeColor = Color.White;
        btnSair.Location = new Point(705, 535);
        btnSair.Name = "btnSair";
        btnSair.Size = new Size(190, 48);
        btnSair.TabIndex = 0;
        btnSair.Text = "Sair";
        btnSair.UseVisualStyleBackColor = false;
        btnSair.Click += btnSair_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(9F, 23F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 247, 249);
        ClientSize = new Size(920, 650);
        Controls.Add(btnSair);
        Controls.Add(btnPagamento);
        Controls.Add(btnCalcular);
        Controls.Add(panelPrincipal);
        Controls.Add(panelHeader);
        Font = new Font("Segoe UI", 10F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimumSize = new Size(920, 650);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Restaurante Bom Prato";
        panelHeader.ResumeLayout(false);
        panelHeader.PerformLayout();
        panelPrincipal.ResumeLayout(false);
        panelPrincipal.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudRefeicao).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudPetiscos).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudChopp).EndInit();
        ResumeLayout(false);
    }

    private static void ConfigureNumeric(NumericUpDown control, int x, int y, string name)
    {
        control.Location = new Point(x, y);
        control.Maximum = 99;
        control.Name = name;
        control.Size = new Size(100, 27);
        control.TextAlign = HorizontalAlignment.Center;
        control.ValueChanged += static (s, e) => { };
    }

    private static void ConfigureValueTextBox(TextBox control, int x, int y, string name)
    {
        control.Location = new Point(x, y);
        control.Name = name;
        control.ReadOnly = true;
        control.Size = new Size(150, 27);
        control.TextAlign = HorizontalAlignment.Right;
        control.BackColor = Color.FromArgb(248, 248, 248);
    }

    private static void ConfigureButton(Button control, string text, int x, int y, string name)
    {
        control.BackColor = Color.FromArgb(173, 91, 19);
        control.FlatStyle = FlatStyle.Flat;
        control.FlatAppearance.BorderSize = 0;
        control.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        control.ForeColor = Color.White;
        control.Location = new Point(x, y);
        control.Name = name;
        control.Size = new Size(190, 55);
        control.Text = text;
        control.UseVisualStyleBackColor = false;
    }
}
