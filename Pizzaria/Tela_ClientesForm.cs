using Pizzaria.Classes_Clientes;
using Pizzaria.Verificar_CPF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class Tela_ClientesForm : Form
    {
        public Tela_ClientesForm()
        {
            InitializeComponent();
        }

        // Ao carregar a tela de Clientes 
        private void Tela_ClientesForm_Load(object sender, EventArgs e)
        {
            carrega_griClientes();
        }
        // Carregar dados no grid
        private void carrega_griClientes()
        {
            Clientes cli = new Clientes();
            dtgClientes.DataSource = cli.Ler();

            dtgClientes.Columns["IdCliente"].HeaderText = " ID";
            dtgClientes.Columns["NomeCompleto"].HeaderText = "Nome Completo";
            dtgClientes.Columns["Cpf"].HeaderText = "CPF";
            dtgClientes.Columns["DataNasc"].HeaderText = "Data Nascimento";
            dtgClientes.Columns["TelefoneFixo"].HeaderText = "Telefone Fixo";
            dtgClientes.Columns["WhatsApp"].HeaderText = "WhatsApp";
            dtgClientes.Columns["Endereco"].HeaderText = "Endereço";
            dtgClientes.Columns["NumeroCasa"].HeaderText = "Nº Casa";
            dtgClientes.Columns["Bairro"].HeaderText = "Bairro";
        }
        // Ao clicar no botão adicionar
        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            // Validação de CPF
            string valor = mskCpfCliente.Text;

            if (ValidaCPF.IsCpf(valor))
            {
                Clientes cliente = new Clientes(txtIdCliente.Text, txtNomeCompletoCliente.Text, mskCpfCliente.Text, mskDataNascCliente.Text,
                                            mskTelefoneFixoCliente.Text, mskWhatsAppCliente.Text,
                                            txtEnderecoCliente.Text, txtNumeroCasaCliente.Text, txtBairroCliente.Text);
                cliente.AdicionarCliente();
                limpar();
                carrega_griClientes();
            }
            else
            {
                MessageBox.Show("O número é um CPF Inválido ou há campos em branco!", "Erro");
            } 
            

            
        }
        // Limpar após integração de dados no grid
        private void limpar()
        {
            txtIdCliente.Text = null;
            txtNomeCompletoCliente.Text = null;
            mskCpfCliente.Text = null;
            mskDataNascCliente.Text = null;
            mskTelefoneFixoCliente.Text = null;
            mskWhatsAppCliente.Text = null;
            txtEnderecoCliente.Text = null;
            txtNumeroCasaCliente.Text = null;
            txtBairroCliente.Text = null;
        }

        // Botão editar cliente da lista
        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (mskDataNascCliente.Text != "  /  /")
            {
                Clientes cliente = new Clientes(txtIdCliente.Text, txtNomeCompletoCliente.Text, mskCpfCliente.Text, mskDataNascCliente.Text,
                                            mskTelefoneFixoCliente.Text, mskWhatsAppCliente.Text,
                                            txtEnderecoCliente.Text, txtNumeroCasaCliente.Text, txtBairroCliente.Text);
                cliente.EditarCliente();
                limpar();
                carrega_griClientes();

            } else
            {
                MessageBox.Show("Digite as informações para editar", "Editar");
            }
            
        }

        // Botão excluir cliente da lista
        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            if (mskDataNascCliente.Text != "  /  /")
            {
                if (MessageBox.Show("Deseja realmente excluir o cliente da lista?", "Excluir cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Clientes cliente = new Clientes();
                    cliente.IdCliente = txtIdCliente.Text;
                    cliente.ExcluirCliente();
                    limpar();
                    carrega_griClientes();
                }
            }
            else
            {
                MessageBox.Show("Digite as informações para excluir", "Excluir");
            }



        }

        // Limpar todos os dados digitados sem querer
        private void btnLimparCliente_Click(object sender, EventArgs e)
        {
            txtIdCliente.Text = null;
            txtNomeCompletoCliente.Text = null;
            mskCpfCliente.Text = null;
            mskDataNascCliente.Text = null;
            mskTelefoneFixoCliente.Text = null;
            mskWhatsAppCliente.Text = null;
            txtEnderecoCliente.Text = null;
            txtNumeroCasaCliente.Text = null;
            txtBairroCliente.Text = null;
        }

        // Ao pressionar enter no txtIdCliente
        private void txtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Clientes cliente = new Clientes();
                cliente.IdCliente = txtIdCliente.Text;
                cliente.BuscarCliente();

                if (cliente.NomeCompleto != "")
                {
                    txtNomeCompletoCliente.Text = cliente.NomeCompleto;
                }
                else
                {
                    txtIdCliente.Text = null;
                    mskCpfCliente.Text = null;
                    mskDataNascCliente.Text = null;
                    mskTelefoneFixoCliente.Text = null;
                    mskWhatsAppCliente.Text = null;
                    txtEnderecoCliente.Text = null; 
                    txtNumeroCasaCliente.Text = null;
                    txtBairroCliente.Text = null; 

                }
                txtIdCliente.Text = cliente.IdCliente;
                mskCpfCliente.Text = cliente.Cpf;
                mskDataNascCliente.Text = cliente.DataNasc;
                mskTelefoneFixoCliente.Text = cliente.TelefoneFixo;
                mskWhatsAppCliente.Text = cliente.WhatsApp;
                txtEnderecoCliente.Text = cliente.Endereco;
                txtNumeroCasaCliente.Text = cliente.NumeroCasa;
                txtBairroCliente.Text = cliente.Bairro;
            }
        }
        // Ao pressionar enter no txtNomeCompletoCliente
        private void txtNomeCompletoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Clientes cliente = new Clientes();
                cliente.NomeCompleto = txtNomeCompletoCliente.Text;
                cliente.BuscarCliente();

                if (cliente.IdCliente != "")
                {
                    txtIdCliente.Text = cliente.IdCliente;
                }
                else
                {
                    txtNomeCompletoCliente.Text = null;
                    mskCpfCliente.Text = null;
                    mskDataNascCliente.Text = null;
                    mskTelefoneFixoCliente.Text = null;
                    mskWhatsAppCliente.Text = null;
                    txtEnderecoCliente.Text = null;
                    txtNumeroCasaCliente.Text = null;
                    txtBairroCliente.Text = null;

                }
                txtNomeCompletoCliente.Text = cliente.NomeCompleto;
                mskCpfCliente.Text = cliente.Cpf;
                mskDataNascCliente.Text = cliente.DataNasc;
                mskTelefoneFixoCliente.Text = cliente.TelefoneFixo;
                mskWhatsAppCliente.Text = cliente.WhatsApp;
                txtEnderecoCliente.Text = cliente.Endereco;
                txtNumeroCasaCliente.Text = cliente.NumeroCasa;
                txtBairroCliente.Text = cliente.Bairro;
            }
        }
        // Ao pressionar enter no mskCpfCliente
        private void mskCpfCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Clientes cliente = new Clientes();
                cliente.Cpf = mskCpfCliente.Text;
                cliente.BuscarCliente();

                if (cliente.IdCliente != "")
                {
                    txtIdCliente.Text = cliente.IdCliente;
                }
                else
                {
                    txtNomeCompletoCliente.Text = null;
                    mskCpfCliente.Text = null;
                    mskDataNascCliente.Text = null;
                    mskTelefoneFixoCliente.Text = null;
                    mskWhatsAppCliente.Text = null;
                    txtEnderecoCliente.Text = null;
                    txtNumeroCasaCliente.Text = null;
                    txtBairroCliente.Text = null;

                }
                txtNomeCompletoCliente.Text = cliente.NomeCompleto;
                mskCpfCliente.Text = cliente.Cpf;
                mskDataNascCliente.Text = cliente.DataNasc;
                mskTelefoneFixoCliente.Text = cliente.TelefoneFixo;
                mskWhatsAppCliente.Text = cliente.WhatsApp;
                txtEnderecoCliente.Text = cliente.Endereco;
                txtNumeroCasaCliente.Text = cliente.NumeroCasa;
                txtBairroCliente.Text = cliente.Bairro;
            }
        }

        // Ao pressionar enter no mskWhatsAppCliente
        private void mskWhatsAppCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Clientes cliente = new Clientes();
                cliente.WhatsApp = mskWhatsAppCliente.Text;
                cliente.BuscarCliente();

                if (cliente.IdCliente != "")
                {
                    txtIdCliente.Text = cliente.IdCliente;
                }
                else
                {
                    txtNomeCompletoCliente.Text = null;
                    mskCpfCliente.Text = null;
                    mskDataNascCliente.Text = null;
                    mskTelefoneFixoCliente.Text = null;
                    mskWhatsAppCliente.Text = null;
                    txtEnderecoCliente.Text = null;
                    txtNumeroCasaCliente.Text = null;
                    txtBairroCliente.Text = null;

                }
                txtNomeCompletoCliente.Text = cliente.NomeCompleto;
                mskCpfCliente.Text = cliente.Cpf;
                mskDataNascCliente.Text = cliente.DataNasc;
                mskTelefoneFixoCliente.Text = cliente.TelefoneFixo;
                mskWhatsAppCliente.Text = cliente.WhatsApp;
                txtEnderecoCliente.Text = cliente.Endereco;
                txtNumeroCasaCliente.Text = cliente.NumeroCasa;
                txtBairroCliente.Text = cliente.Bairro;
            }
        }
    }
}
