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
    public partial class Tela_CardapioForm : Form
    {
        public Tela_CardapioForm()
        {
            InitializeComponent();
        }

        // Ao carregar a tela
        private void AdicionarCardapioForm_Load(object sender, EventArgs e)
        {
            carrega_gridPizza();
            carrega_gridRefri();
        }

        // Ao clicar em Adicionar
        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            if (txtRecheioPizza.Text != "")
            {
                if (txtNumeroRefri.Text == "")
                {

                    AddPizzaCardapio pizza = new AddPizzaCardapio(txtNumeroPizza.Text, txtNomePizza.Text, txtRecheioPizza.Text, double.Parse(txtPrecoIntPizza.Text), double.Parse(txtPrecoBrotoPizza.Text));
                    pizza.AdicionarPizza();
                    limpar();
                    carrega_gridPizza();
                }
            }
            else if (cbxLitros.Text != "")
            {
                if (txtNumeroPizza.Text == "")
                {
                    AddRefriCardapio refri = new AddRefriCardapio(txtNumeroRefri.Text, txtNomeRefrigerante.Text, cbxLitros.Text, double.Parse(txtPrecoRefri.Text));
                    refri.AdicionarRefri();
                    limpar();
                    carrega_gridRefri();
                }
            } else
            {
                MessageBox.Show("Você precisa digitar os dados para adicionar", "Adicionar");
            }
        }
        // Carregar dados no grid
        private void carrega_gridPizza()
        {
            AddPizzaCardapio pizza = new AddPizzaCardapio();
            dtgPizza.DataSource = pizza.Ler();

            dtgPizza.Columns["NumeroPizza"].HeaderText = "Nº Pizza";
            dtgPizza.Columns["NomePizza"].HeaderText = "Sabor";
            dtgPizza.Columns["RecheioPizza"].HeaderText = "Recheio";
            dtgPizza.Columns["PrecoIntPizza"].HeaderText = "Preço Inteira";
            dtgPizza.Columns["PrecoBrotoPizza"].HeaderText = "Preço Broto";
        }
        private void carrega_gridRefri()
        {
            AddRefriCardapio refri = new AddRefriCardapio();
            dtgRefri.DataSource = refri.Ler();

            dtgRefri.Columns["NumeroRefri"].HeaderText = "Nº Refrigerante";
            dtgRefri.Columns["NomeRefri"].HeaderText = "Refrigerante";
            dtgRefri.Columns["LitrosRefri"].HeaderText = "Litro";
            dtgRefri.Columns["PrecoRefri"].HeaderText = "Preço";
        }
        // Limpar após integração de dados no grid
        private void limpar()
        {
            txtNomePizza.Text = null;
            txtNomeRefrigerante.Text = null;
            txtNumeroPizza.Text = null;
            txtNumeroRefri.Text = null;
            txtPrecoBrotoPizza.Text = null;
            txtPrecoIntPizza.Text = null;
            txtPrecoRefri.Text = null;
            txtRecheioPizza.Text = null;
            cbxLitros.Text = null;
        }

        // Editar itens da lista
        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (txtRecheioPizza.Text != "")
            {
                if (txtNumeroRefri.Text == "")
                {
                    AddPizzaCardapio pizza = new AddPizzaCardapio(txtNumeroPizza.Text, txtNomePizza.Text, txtRecheioPizza.Text, double.Parse(txtPrecoIntPizza.Text), double.Parse(txtPrecoBrotoPizza.Text));
                    pizza.EditarPizza();
                    limpar();
                    carrega_gridPizza();
                }
            }
            else if (cbxLitros.Text != "")
            {
                if (txtNumeroPizza.Text == "")
                {
                    AddRefriCardapio refri = new AddRefriCardapio(txtNumeroRefri.Text, txtNomeRefrigerante.Text, cbxLitros.Text, double.Parse(txtPrecoRefri.Text));
                    refri.EditarRefri();
                    limpar();
                    carrega_gridRefri();
                }
            } else
            {
                MessageBox.Show("Você precisa digitar os dados para Editar", "Editar");
            }
            
            
        }

        // Excluir itens da lista
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtRecheioPizza.Text != "")
            {
                if (MessageBox.Show("Deseja realmente excluir o item da lista?", "Excluir item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (txtNumeroRefri.Text == "")
                    {
                        AddPizzaCardapio pizza = new AddPizzaCardapio();
                        pizza.NumeroPizza = txtNumeroPizza.Text;
                        pizza.ExcluirPizza();
                        limpar();
                        carrega_gridPizza();

                    }
                }
            }
            else if (cbxLitros.Text != "")
            {
                if (txtNumeroPizza.Text == "")
                {
                    if (MessageBox.Show("Deseja realmente excluir o item da lista?", "Excluir item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        AddRefriCardapio refri = new AddRefriCardapio();
                        refri.NumeroRefri = txtNumeroRefri.Text;
                        refri.ExcluirRefri();
                        limpar();
                        carrega_gridRefri();
                    }
                }
            }
            else
            {
                MessageBox.Show("Você precisa digitar os dados para Excluir", "Excluir");
            }
        }
        // Ao pressionar enter no TxtNumeroPizza
        private void txtNumeroPizza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                AddPizzaCardapio pizza = new AddPizzaCardapio();
                pizza.NumeroPizza = txtNumeroPizza.Text;
                pizza.BuscarPizza();

                if (pizza.RecheioPizza != "")
                {
                    txtRecheioPizza.Text = pizza.RecheioPizza;
                }
                else
                {
                    txtNomePizza.Text = null;
                    txtPrecoIntPizza.Text = null;
                    txtPrecoBrotoPizza.Text = null;
                    txtNumeroPizza.Text = null;
                }
                txtNomePizza.Text = pizza.NomePizza;
                txtRecheioPizza.Text = pizza.RecheioPizza;
                txtPrecoIntPizza.Text = pizza.PrecoIntPizza.ToString();
                txtPrecoBrotoPizza.Text = pizza.PrecoBrotoPizza.ToString();
            }
        }
        //Ao Pressionar enter em TxtNumeroRefri
        private void txtNumeroRefri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                AddRefriCardapio refri = new AddRefriCardapio();
                refri.NumeroRefri = txtNumeroRefri.Text;
                refri.BuscarRefri();

                if (refri.NomeRefri != "")
                {
                    txtNomeRefrigerante.Text = refri.NomeRefri;
                }
                else
                {
                    txtNumeroRefri.Text = null;
                    cbxLitros.Text = null;
                    txtPrecoRefri.Text = null;
                }
                txtNomeRefrigerante.Text = refri.NomeRefri;
                cbxLitros.Text = refri.LitrosRefri;
                txtPrecoRefri.Text = refri.PrecoRefri.ToString();
            }

        }
        // Botão para limpar tudo de uma vez
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomePizza.Text = null;
            txtNomeRefrigerante.Text = null;
            txtNumeroPizza.Text = null;
            txtNumeroRefri.Text = null;
            txtPrecoBrotoPizza.Text = null;
            txtPrecoIntPizza.Text = null;
            txtPrecoRefri.Text = null;
            txtRecheioPizza.Text = null;
            cbxLitros.Text = null;
        }
    }
}
