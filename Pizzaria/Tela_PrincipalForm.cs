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
    public partial class Tela_PrincipalForm : Form
    {
        public Tela_PrincipalForm()
        {
            InitializeComponent();
        }

        // Ao carregar a tela
        private void Tela_PrincipalForm_Load(object sender, EventArgs e)
        {
            timerHora.Start();
            DataLabel.Text = DateTime.Now.ToLongDateString();
            HoraLabel.Text = DateTime.Now.ToLongTimeString();            
        }
        //Inciando contagem do relógio
        private void timerHora_Tick(object sender, EventArgs e)
        {
            HoraLabel.Text = DateTime.Now.ToLongTimeString();
            timerHora.Start();
        }

        // Ao fechar a tela
        private void Tela_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar o programa?", "Fechar o Programa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) { }
            else { e.Cancel = true; }
        }
        private void Btn_encerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Minimizar
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // Botões

        // Comando para fazer forms aparecerem em cima de outro form
        private void AbrirForm(object abrirForm)
        {
            if (Painel_de_controle.Controls.Count > 0)
                this.Painel_de_controle.Controls.RemoveAt(0);
            Form aForm = abrirForm as Form;
            aForm.TopLevel = false;
            aForm.Dock = DockStyle.Fill;
            this.Painel_de_controle.Controls.Add(aForm);
            this.Painel_de_controle.Tag = aForm;
            aForm.Show();
        }

        // Logo Porta Maggiori
        private void logobutton_Click(object sender, EventArgs e)
        {
            AbrirForm(new TelaDeBoasVindas());
        }
        // Novo Pedido
        private void BtnNovoPedido_Click(object sender, EventArgs e)
        {
            AbrirForm(new Tela_NovoPedidoForm());
        }


        // Cardápio
        private void BtnCardápio_Click(object sender, EventArgs e)
        {
            AbrirForm(new Tela_CardapioForm());
        }

        //SubMenu
        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            GrupoFinanceiro.Visible = true;
        }
        private void BtnVendas_Click(object sender, EventArgs e)
        {
            GrupoFinanceiro.Visible = false;
        }
        private void BtnCompras_Click(object sender, EventArgs e)
        {
            GrupoFinanceiro.Visible = false;
        }
        private void BtnFuncionarios_Click(object sender, EventArgs e)
        {
            GrupoFinanceiro.Visible = false;
        }
        private void BtnFolhaPgto_Click(object sender, EventArgs e)
        {
            GrupoFinanceiro.Visible = false;
        }
        private void BtnExtrato_Click(object sender, EventArgs e)
        {
            GrupoFinanceiro.Visible = false;
        }
        private void BtnSuporte_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://dankalisolucoes.com.br");
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            AbrirForm(new Tela_ClientesForm());
        }
    }
}
