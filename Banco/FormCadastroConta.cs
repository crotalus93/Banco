using Banco.Busca;
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
        private ICollection<string> devedores;
        private Form1 formPrincipal;

        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();

            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.GeraList();
        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {

            string titular = this.textoTitular.Text;
            bool ehDevedor = false;
            for (int i = 0; i < 30000; i++)
            {
                ehDevedor = this.devedores.Contains(titular);
            }
            if (!ehDevedor)
            {
                if (radioCC.Checked)
                {
                    Conta novaConta = new ContaCorrente();
                    novaConta.Titular = new Cliente(textoTitular.Text);
                    this.formPrincipal.adicionaConta(novaConta);
                    this.Close();
                }
                else
                if (radioCI.Checked)
                {
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
            else{
                MessageBox.Show("devedor");
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
