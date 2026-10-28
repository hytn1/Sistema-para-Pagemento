using System.Globalization;

namespace ProjetoAula;

public partial class Fechamento : Form
{
    private readonly decimal valorTotal;
    private readonly string mesa;
    private readonly CultureInfo br = CultureInfo.GetCultureInfo("pt-BR");

    public Fechamento(decimal total, string numeroMesa)
    {
        valorTotal = total;
        mesa = numeroMesa;
        InitializeComponent();
        lblMesa.Text = $"Mesa {mesa}";
        txtValorPagar.Text = valorTotal.ToString("C2", br);
        grpCartaoCredito.Enabled = false;
        txtValorRecebido.Enabled = false;
    }

    private void FormaPagamento_CheckedChanged(object sender, EventArgs e)
    {
        grpCartaoCredito.Enabled = rbCredito.Checked;
        txtValorRecebido.Enabled = rbDinheiro.Checked;

        if (!rbDinheiro.Checked)
        {
            txtValorRecebido.Clear();
            txtTroco.Text = "R$ 0,00";
        }

        if (rbDinheiro.Checked)
            txtValorRecebido.Focus();
    }

    private void txtValorRecebido_TextChanged(object sender, EventArgs e)
    {
        if (decimal.TryParse(txtValorRecebido.Text.Trim(),
            NumberStyles.Number, br, out decimal recebido))
        {
            decimal troco = recebido - valorTotal;
            txtTroco.Text = Math.Max(0, troco).ToString("C2", br);
        }
        else
        {
            txtTroco.Text = "R$ 0,00";
        }
    }

    private void btnEncerrar_Click(object sender, EventArgs e)
    {
        if (!rbDinheiro.Checked && !rbDebito.Checked && !rbCredito.Checked)
        {
            MessageBox.Show("Selecione uma forma de pagamento.", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (rbDinheiro.Checked)
        {
            if (!decimal.TryParse(txtValorRecebido.Text.Trim(),
                NumberStyles.Number, br, out decimal recebido) || recebido < valorTotal)
            {
                MessageBox.Show("Informe um valor recebido suficiente.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        if (rbCredito.Checked && !rbVisa.Checked && !rbMastercard.Checked && !rbAmex.Checked)
        {
            MessageBox.Show("Selecione a bandeira do cartão de crédito.", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string forma = rbDinheiro.Checked ? "Dinheiro" :
            rbDebito.Checked ? "Cartão de Débito" : "Cartão de Crédito";

        MessageBox.Show(
            $"Pagamento concluído!\n\nMesa: {mesa}\nForma: {forma}\nTotal: {valorTotal.ToString("C2", br)}",
            "Conta encerrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

        DialogResult = DialogResult.OK;
        Close();
    }
}
