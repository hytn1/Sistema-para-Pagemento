namespace ProjetoAula;

partial class DinheiroRecebido
{
    private System.ComponentModel.IContainer components = null!;
    private Label lblTitulo = null!;
    private Label lblTotal = null!;
    private Label lblValor = null!;
    private TextBox txtValorRecebido = null!;
    private Button btnOk = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitulo = new Label();
        lblTotal = new Label();
        lblValor = new Label();
        txtValorRecebido = new TextBox();
        btnOk = new Button();
        SuspendLayout();
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.Teal;
        lblTitulo.Location = new Point(25, 20);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(285, 37);
        lblTitulo.TabIndex = 4;
        lblTitulo.Text = "DINHEIRO RECEBIDO";
        // 
        // lblTotal
        // 
        lblTotal.AutoSize = true;
        lblTotal.Font = new Font("Segoe UI", 10F);
        lblTotal.Location = new Point(27, 58);
        lblTotal.Name = "lblTotal";
        lblTotal.Size = new Size(110, 23);
        lblTotal.TabIndex = 3;
        lblTotal.Text = "Total: R$ 0,00";
        // 
        // lblValor
        // 
        lblValor.AutoSize = true;
        lblValor.Location = new Point(27, 100);
        lblValor.Name = "lblValor";
        lblValor.Size = new Size(106, 20);
        lblValor.TabIndex = 2;
        lblValor.Text = "Valor recebido";
        // 
        // txtValorRecebido
        // 
        txtValorRecebido.Location = new Point(27, 125);
        txtValorRecebido.Name = "txtValorRecebido";
        txtValorRecebido.Size = new Size(235, 27);
        txtValorRecebido.TabIndex = 1;
        // 
        // btnOk
        // 
        btnOk.BackColor = Color.Teal;
        btnOk.FlatAppearance.BorderSize = 0;
        btnOk.FlatStyle = FlatStyle.Flat;
        btnOk.ForeColor = Color.White;
        btnOk.Location = new Point(280, 123);
        btnOk.Name = "btnOk";
        btnOk.Size = new Size(105, 34);
        btnOk.TabIndex = 0;
        btnOk.Text = "OK";
        btnOk.UseVisualStyleBackColor = false;
        // 
        // DinheiroRecebido
        // 
        BackColor = Color.FromArgb(246, 247, 249);
        ClientSize = new Size(430, 220);
        Controls.Add(btnOk);
        Controls.Add(txtValorRecebido);
        Controls.Add(lblValor);
        Controls.Add(lblTotal);
        Controls.Add(lblTitulo);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "DinheiroRecebido";
        StartPosition = FormStartPosition.CenterParent;
        Text = "DinheiroRecebido";
        ResumeLayout(false);
        PerformLayout();
    }
}
