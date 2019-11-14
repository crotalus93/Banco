using Banco.contas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal;

        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            if (radioCC.Checked)
            {
                Conta novaConta = new ContaCorrente();
                novaConta.Titular = new Cliente(textoTitular.Text);
                this.formPrincipal.adicionaConta(novaConta);
                this.Close();
            }
            else
            if (radioCI.Checked){
                Conta novaConta = new ContaInvestimento();
                novaConta.Titular = new Cliente(textoTitular.Text);
                this.formPrincipal.adicionaConta(novaConta);
                this.Close();
            }
            else
            if (radioCP.Checked)
            {
                Conta novaConta = new ContaPoupanca();
                novaConta.Titular = new Cliente(textoTitular.Text);
                this.formPrincipal.adicionaConta(novaConta);
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione um tipo de conta!");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            textoNumero.Text = Convert.ToString(Conta.TotalDeContas);
        }
    }
}
