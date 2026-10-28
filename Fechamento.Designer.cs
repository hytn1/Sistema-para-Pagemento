namespace ProjetoAula;

partial class Fechamento
{
    private System.ComponentModel.IContainer components = null!;
    private Panel panelHeader = null!;
    private Label lblTitulo = null!;
    private Label lblMesa = null!;
    private GroupBox grpFormaPagamento = null!;
    private RadioButton rbDinheiro = null!;
    private RadioButton rbDebito = null!;
    private RadioButton rbCredito = null!;
    private GroupBox grpCartaoCredito = null!;
    private RadioButton rbVisa = null!;
    private RadioButton rbMastercard = null!;
    private RadioButton rbAmex = null!;
    private GroupBox grpDados = null!;
    private Label lblPagar = null!;
    private TextBox txtValorPagar = null!;
    private Label lblRecebido = null!;
    private TextBox txtValorRecebido = null!;
    private Label lblTrocoTitulo = null!;
    private TextBox txtTroco = null!;
    private Button btnEncerrar = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        panelHeader = new Panel();
        lblMesa = new Label();
        lblTitulo = new Label();
        grpFormaPagamento = new GroupBox();
        rbCredito = new RadioButton();
        rbDebito = new RadioButton();
        rbDinheiro = new RadioButton();
        grpCartaoCredito = new GroupBox();
        rbAmex = new RadioButton();
        rbMastercard = new RadioButton();
        rbVisa = new RadioButton();
        grpDados = new GroupBox();
        txtTroco = new TextBox();
        lblTrocoTitulo = new Label();
        txtValorRecebido = new TextBox();
        lblRecebido = new Label();
        txtValorPagar = new TextBox();
        lblPagar = new Label();
        btnEncerrar = new Button();
        panelHeader.SuspendLayout();
        grpFormaPagamento.SuspendLayout();
        grpCartaoCredito.SuspendLayout();
        grpDados.SuspendLayout();
        SuspendLayout();
        // 
        // panelHeader
        // 
        panelHeader.BackColor = Color.Teal;
        panelHeader.Controls.Add(lblMesa);
        panelHeader.Controls.Add(lblTitulo);
        panelHeader.Dock = DockStyle.Top;
        panelHeader.Location = new Point(0, 0);
        panelHeader.Name = "panelHeader";
        panelHeader.Size = new Size(903, 86);
        panelHeader.TabIndex = 0;
        // 
        // lblMesa
        // 
        lblMesa.AutoSize = true;
        lblMesa.Font = new Font("Segoe UI", 10.5F);
        lblMesa.ForeColor = Color.White;
        lblMesa.Location = new Point(28, 52);
        lblMesa.Name = "lblMesa";
        lblMesa.Size = new Size(54, 25);
        lblMesa.TabIndex = 0;
        lblMesa.Text = "Mesa";
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.White;
        lblTitulo.Location = new Point(25, 10);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(411, 45);
        lblTitulo.TabIndex = 1;
        lblTitulo.Text = "FECHAMENTO DA CONTA";
        // 
        // grpFormaPagamento
        // 
        grpFormaPagamento.Controls.Add(rbCredito);
        grpFormaPagamento.Controls.Add(rbDebito);
        grpFormaPagamento.Controls.Add(rbDinheiro);
        grpFormaPagamento.Location = new Point(25, 108);
        grpFormaPagamento.Name = "grpFormaPagamento";
        grpFormaPagamento.Size = new Size(847, 112);
        grpFormaPagamento.TabIndex = 1;
        grpFormaPagamento.TabStop = false;
        grpFormaPagamento.Text = "Forma de pagamento";
        // 
        // rbCredito
        // 
        rbCredito.AutoSize = true;
        rbCredito.Location = new Point(495, 52);
        rbCredito.Name = "rbCredito";
        rbCredito.Size = new Size(167, 27);
        rbCredito.TabIndex = 2;
        rbCredito.Text = "Cartão de Crédito";
        rbCredito.UseVisualStyleBackColor = true;
        rbCredito.CheckedChanged += FormaPagamento_CheckedChanged;
        // 
        // rbDebito
        // 
        rbDebito.AutoSize = true;
        rbDebito.Location = new Point(260, 52);
        rbDebito.Name = "rbDebito";
        rbDebito.Size = new Size(162, 27);
        rbDebito.TabIndex = 1;
        rbDebito.Text = "Cartão de Débito";
        rbDebito.UseVisualStyleBackColor = true;
        rbDebito.CheckedChanged += FormaPagamento_CheckedChanged;
        // 
        // rbDinheiro
        // 
        rbDinheiro.AutoSize = true;
        rbDinheiro.Location = new Point(22, 52);
        rbDinheiro.Name = "rbDinheiro";
        rbDinheiro.Size = new Size(96, 27);
        rbDinheiro.TabIndex = 0;
        rbDinheiro.Text = "Dinheiro";
        rbDinheiro.UseVisualStyleBackColor = true;
        rbDinheiro.CheckedChanged += FormaPagamento_CheckedChanged;
        // 
        // grpCartaoCredito
        // 
        grpCartaoCredito.Controls.Add(rbAmex);
        grpCartaoCredito.Controls.Add(rbMastercard);
        grpCartaoCredito.Controls.Add(rbVisa);
        grpCartaoCredito.Location = new Point(25, 242);
        grpCartaoCredito.Name = "grpCartaoCredito";
        grpCartaoCredito.Size = new Size(449, 146);
        grpCartaoCredito.TabIndex = 2;
        grpCartaoCredito.TabStop = false;
        grpCartaoCredito.Text = "Bandeira do cartão de crédito";
        // 
        // rbAmex
        // 
        rbAmex.AutoSize = true;
        rbAmex.Location = new Point(278, 62);
        rbAmex.Name = "rbAmex";
        rbAmex.Size = new Size(164, 27);
        rbAmex.TabIndex = 2;
        rbAmex.Text = "American Express";
        rbAmex.UseVisualStyleBackColor = true;
        // 
        // rbMastercard
        // 
        rbMastercard.AutoSize = true;
        rbMastercard.Location = new Point(138, 62);
        rbMastercard.Name = "rbMastercard";
        rbMastercard.Size = new Size(116, 27);
        rbMastercard.TabIndex = 1;
        rbMastercard.Text = "Mastercard";
        rbMastercard.UseVisualStyleBackColor = true;
        // 
        // rbVisa
        // 
        rbVisa.AutoSize = true;
        rbVisa.Location = new Point(22, 62);
        rbVisa.Name = "rbVisa";
        rbVisa.Size = new Size(62, 27);
        rbVisa.TabIndex = 0;
        rbVisa.Text = "Visa";
        rbVisa.UseVisualStyleBackColor = true;
        // 
        // grpDados
        // 
        grpDados.Controls.Add(txtTroco);
        grpDados.Controls.Add(lblTrocoTitulo);
        grpDados.Controls.Add(txtValorRecebido);
        grpDados.Controls.Add(lblRecebido);
        grpDados.Controls.Add(txtValorPagar);
        grpDados.Controls.Add(lblPagar);
        grpDados.Location = new Point(480, 242);
        grpDados.Name = "grpDados";
        grpDados.Size = new Size(392, 217);
        grpDados.TabIndex = 3;
        grpDados.TabStop = false;
        grpDados.Text = "Dados do pagamento";
        // 
        // txtTroco
        // 
        txtTroco.BackColor = SystemColors.ControlLight;
        txtTroco.Location = new Point(150, 151);
        txtTroco.Name = "txtTroco";
        txtTroco.ReadOnly = true;
        txtTroco.Size = new Size(145, 30);
        txtTroco.TabIndex = 5;
        txtTroco.Text = "R$ 0,00";
        txtTroco.TextAlign = HorizontalAlignment.Right;
        // 
        // lblTrocoTitulo
        // 
        lblTrocoTitulo.AutoSize = true;
        lblTrocoTitulo.Location = new Point(18, 154);
        lblTrocoTitulo.Name = "lblTrocoTitulo";
        lblTrocoTitulo.Size = new Size(52, 23);
        lblTrocoTitulo.TabIndex = 4;
        lblTrocoTitulo.Text = "Troco";
        // 
        // txtValorRecebido
        // 
        txtValorRecebido.Location = new Point(150, 99);
        txtValorRecebido.Name = "txtValorRecebido";
        txtValorRecebido.Size = new Size(145, 30);
        txtValorRecebido.TabIndex = 3;
        txtValorRecebido.TextChanged += txtValorRecebido_TextChanged;
        // 
        // lblRecebido
        // 
        lblRecebido.AutoSize = true;
        lblRecebido.Location = new Point(18, 102);
        lblRecebido.Name = "lblRecebido";
        lblRecebido.Size = new Size(120, 23);
        lblRecebido.TabIndex = 2;
        lblRecebido.Text = "Valor recebido";
        // 
        // txtValorPagar
        // 
        txtValorPagar.BackColor = Color.FromArgb(255, 244, 232);
        txtValorPagar.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
        txtValorPagar.ForeColor = Color.Teal;
        txtValorPagar.Location = new Point(150, 48);
        txtValorPagar.Name = "txtValorPagar";
        txtValorPagar.ReadOnly = true;
        txtValorPagar.Size = new Size(145, 31);
        txtValorPagar.TabIndex = 1;
        txtValorPagar.TextAlign = HorizontalAlignment.Right;
        // 
        // lblPagar
        // 
        lblPagar.AutoSize = true;
        lblPagar.Location = new Point(18, 51);
        lblPagar.Name = "lblPagar";
        lblPagar.Size = new Size(112, 23);
        lblPagar.TabIndex = 0;
        lblPagar.Text = "Valor a pagar";
        // 
        // btnEncerrar
        // 
        btnEncerrar.BackColor = Color.Teal;
        btnEncerrar.FlatAppearance.BorderSize = 0;
        btnEncerrar.FlatStyle = FlatStyle.Flat;
        btnEncerrar.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
        btnEncerrar.ForeColor = Color.White;
        btnEncerrar.Location = new Point(520, 465);
        btnEncerrar.Name = "btnEncerrar";
        btnEncerrar.Size = new Size(295, 48);
        btnEncerrar.TabIndex = 4;
        btnEncerrar.Text = "ENCERRAR";
        btnEncerrar.UseVisualStyleBackColor = false;
        btnEncerrar.Click += btnEncerrar_Click;
        // 
        // Fechamento
        // 
        AutoScaleDimensions = new SizeF(9F, 23F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 247, 249);
        ClientSize = new Size(903, 608);
        Controls.Add(btnEncerrar);
        Controls.Add(grpDados);
        Controls.Add(grpCartaoCredito);
        Controls.Add(grpFormaPagamento);
        Controls.Add(panelHeader);
        Font = new Font("Segoe UI", 10F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Fechamento";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Fechamento da Conta";
        panelHeader.ResumeLayout(false);
        panelHeader.PerformLayout();
        grpFormaPagamento.ResumeLayout(false);
        grpFormaPagamento.PerformLayout();
        grpCartaoCredito.ResumeLayout(false);
        grpCartaoCredito.PerformLayout();
        grpDados.ResumeLayout(false);
        grpDados.PerformLayout();
        ResumeLayout(false);
    }
}
