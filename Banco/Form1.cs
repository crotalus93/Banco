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
    public partial class Form1 : Form
    {
        //private Conta c;
        private List<Conta> contas;
        private int numeroDeContas;

        public Form1()
        {
            InitializeComponent();
        }

        public void adicionaConta(Conta conta)
        {
            this.contas.Add(conta);
            comboContas.Items.Add(conta);
            //comboContas.DisplayMember = "Titular.Nome";
            this.numeroDeContas++;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new List<Conta>();

            ContaCorrente cc1 = new ContaCorrente() { Titular = new Cliente("Bruno"), Numero = 1 };
            ContaPoupanca cp1 = new ContaPoupanca() { Titular = new Cliente("Maurício"), Numero = 2};
            ContaInvestimento ci1 = new ContaInvestimento() { Titular = new Cliente("Osni"), Numero = 3 };


            //this.contas[1] = new ContaPoupanca()
            //{
            //    Titular = new Cliente("Mauricio"),
            //    Numero = 2
            //};


            //this.contas[2] = new ContaInvestimento()
            //{
            //    Titular = new Cliente("Osni"),
            //    Numero = 3
            //};
            adicionaConta(cc1);
            adicionaConta(cp1);
            adicionaConta(ci1);

            //int num = 0;
            //object o = num.GetType();

            //if(o. == "Int32")
            //{
            //    MessageBox.Show("worked");

            //}

            //int indice = 0;
            //Conta selecionada = contas[indice];
            //selecionada.CTributo();

            //Conta c = new ContaCorrente();
            //c.CTributo();

            //foreach (Conta conta in contas)
            //{
            //    comboContas.Items.Add(conta.Titular.Nome);
            //}
            //c = new ContaCorrente();
            //c.Numero = 1;
            //Cliente cliente = new Cliente("Victor");
            //c.Titular = cliente;

            //textoNome.Text = c.Titular.Nome;
            //textoNumero.Text = Convert.ToString(c.Numero);
            //textoSaldo.Text = Convert.ToString(c.Saldo);
        }

        private void textoNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void botaoDeposita_Click(object sender, EventArgs e)
        {
            try {
                Conta selecionada = (Conta)comboContas.SelectedItem;//pegar o valor digitado no campo valor
                string valorDigitado = textoValor.Text;

                ////Converter para double
                double valorConvertido = Convert.ToDouble(valorDigitado);

                //chamar método deposita
                //contas[comboContas.SelectedIndex].Deposita(Convert.ToDouble(valorConvertido));
                selecionada.Deposita(valorConvertido);
                //atualiza os campos
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            }
            catch
            {
                MessageBox.Show("Argumento Inválido");
            }

        }
        private void botaoSaca_Click(object sender, EventArgs e)
        {
            try
            {
                //int contaSelecionada = Convert.ToInt32(textoIndice.Text);
                //pegar o valor digitado no campo valor
                string valorDigitado = textoValor.Text;

                //Converter para double
                double valorConvertido = Convert.ToDouble(valorDigitado);

                //chamar método deposita
                contas[comboContas.SelectedIndex].Saca(valorConvertido);

                //atualiza os campos
                textoSaldo.Text = Convert.ToString(contas[comboContas.SelectedIndex].Saldo);
            }
            catch
            {
                MessageBox.Show("Saldo Insuficiente");
            } 
        }

        //private void botaoBusca_Click(object sender, EventArgs e)
        //{
        //    int indice = Convert.ToInt32(textoIndice.Text);
        //    Conta selecionada = this.contas[indice];
        //    textoNome.Text = selecionada.Titular.Nome;
        //    textoNumero.Text = Convert.ToString(selecionada.Numero);
        //    textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        //}

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;

            Conta selecionada = contas[indice];

            textoNome.Text = selecionada.Titular.Nome;
            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);

        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta novaConta = new FormCadastroConta(this);
            novaConta.ShowDialog();
        }

        private void botaoImpostos_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];
            //selecionada.CTributo();
            if(selecionada is ContaCorrente)
            {
                ContaCorrente selecionada2 = (ContaCorrente)selecionada; 
                double valor = selecionada2.CTributo();
                MessageBox.Show("Imposto da Conta Corrente:" + valor);
            }
            else
            if(selecionada is ContaPoupanca)
            {
                ContaPoupanca selecionada2 = (ContaPoupanca)selecionada;
                double valor = selecionada2.CTributo();
                MessageBox.Show("Imposto da Conta Poupança:" + valor);
            }
            else
            if(selecionada is ContaInvestimento)
            {
                ContaInvestimento selecionada2 = (ContaInvestimento)selecionada;
                double valor = selecionada2.CTributo();
                MessageBox.Show("Imposto da Conta Investimento:" + valor);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Conta cc = new Conta();
            //cc.Nome = "caio";

            //Conta cc2 = new Conta();
            //cc2.Nome = "fernando";

            //if (cc2.GetType().Name.Equals("Conta"))
            //{
            //    MessageBox.Show("Tipo da Conta:" + cc2.GetType().FullName);
            //}

            //MessageBox.Show(cc.Nome);
            //MessageBox.Show(cc2.Nome);
            //MessageBox.Show(Convert.ToString(Conta.TotalDeContas));

            HashSet<String> devedores = new HashSet<string>();

            devedores.Add("Thiago");


        }
    }
}
