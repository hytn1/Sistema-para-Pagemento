using System.Globalization;

namespace ProjetoAula;

public partial class DinheiroRecebido : Form
{
    private readonly decimal valorTotal;
    private readonly CultureInfo br = CultureInfo.GetCultureInfo("pt-BR");

    public decimal ValorRecebido { get; private set; }

    public DinheiroRecebido(decimal total)
    {
        InitializeComponent();
        valorTotal = total;
        lblTotal.Text = $"Total da conta: {valorTotal.ToString("C2", br)}";
        btnOk.Click += btnOk_Click;
        AcceptButton = btnOk;
    }

    private void btnOk_Click(object? sender, EventArgs e)
    {
        if (!decimal.TryParse(txtValorRecebido.Text.Trim(),
            NumberStyles.Currency, br, out decimal recebido) || recebido < valorTotal)
        {
            MessageBox.Show("Digite um valor válido, igual ou maior que o total.",
                "Valor recebido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtValorRecebido.Focus();
            return;
        }

        ValorRecebido = recebido;
        DialogResult = DialogResult.OK;
        Close();
    }
}
