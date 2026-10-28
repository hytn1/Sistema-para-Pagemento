using System.Globalization;

namespace ProjetoAula;

public partial class Form1 : Form
{
    private const decimal PrecoChopp = 4.50m;
    private const decimal PrecoPetiscos = 7.90m;
    private const decimal PrecoRefeicao = 15.90m;
    private readonly CultureInfo br = CultureInfo.GetCultureInfo("pt-BR");

    public Form1()
    {
        InitializeComponent();
        AtualizarTotais();
    }

    private decimal CalcularSubtotal()
    {
        decimal total = 0;

        if (chkChopp.Checked)
            total += nudChopp.Value * PrecoChopp;

        if (chkPetiscos.Checked)
            total += nudPetiscos.Value * PrecoPetiscos;

        if (chkRefeicao.Checked)
            total += nudRefeicao.Value * PrecoRefeicao;

        return total;
    }

    private void AtualizarTotais()
    {
        decimal chopp = chkChopp.Checked ? nudChopp.Value * PrecoChopp : 0;
        decimal petiscos = chkPetiscos.Checked ? nudPetiscos.Value * PrecoPetiscos : 0;
        decimal refeicao = chkRefeicao.Checked ? nudRefeicao.Value * PrecoRefeicao : 0;
        decimal subtotal = chopp + petiscos + refeicao;
        decimal taxa = subtotal * 0.10m;
        decimal total = subtotal + taxa;

        txtTotalChopp.Text = chopp.ToString("C2", br);
        txtTotalPetiscos.Text = petiscos.ToString("C2", br);
        txtTotalRefeicao.Text = refeicao.ToString("C2", br);
        txtTaxa.Text = taxa.ToString("C2", br);
        txtTotalPagar.Text = total.ToString("C2", br);
    }

    private void chkPedido_CheckedChanged(object sender, EventArgs e)
    {
        AtualizarTotais();
    }

    private void Quantidade_ValueChanged(object sender, EventArgs e)
    {
        AtualizarTotais();
    }

    private void btnCalcular_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMesa.Text))
        {
            MessageBox.Show("Informe o número da mesa.", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMesa.Focus();
            return;
        }

        if (CalcularSubtotal() <= 0)
        {
            MessageBox.Show("Selecione pelo menos um pedido e informe a quantidade.",
                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        AtualizarTotais();

        MessageBox.Show(
            $"Total da conta: {txtTotalPagar.Text}",
            "Conta calculada",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    private void btnPagamento_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMesa.Text))
        {
            MessageBox.Show("Informe o número da mesa.", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        decimal total = CalcularSubtotal() * 1.10m;

        if (total <= 0)
        {
            MessageBox.Show("Selecione pelo menos um pedido.", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        using var tela = new Fechamento(total, txtMesa.Text);
        tela.ShowDialog(this);
    }

    private void btnSair_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void lblTitulo_Click(object sender, EventArgs e)
    {

    }
}
