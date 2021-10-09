
namespace Pizzaria
{
    partial class Tela_ClientesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnderecoCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeCompletoCliente = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnAdicionarCliente = new System.Windows.Forms.Button();
            this.btnLimparCliente = new System.Windows.Forms.Button();
            this.mskCpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroCasaCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBairroCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskDataNascCliente = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mskTelefoneFixoCliente = new System.Windows.Forms.MaskedTextBox();
            this.mskWhatsAppCliente = new System.Windows.Forms.MaskedTextBox();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adventure", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(443, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "tela clientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEnderecoCliente
            // 
            this.txtEnderecoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnderecoCliente.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEnderecoCliente.Location = new System.Drawing.Point(159, 188);
            this.txtEnderecoCliente.Name = "txtEnderecoCliente";
            this.txtEnderecoCliente.Size = new System.Drawing.Size(315, 31);
            this.txtEnderecoCliente.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Adventure", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(24, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 40);
            this.label7.TabIndex = 32;
            this.label7.Text = "endereço";
            // 
            // txtNomeCompletoCliente
            // 
            this.txtNomeCompletoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeCompletoCliente.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCompletoCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomeCompletoCliente.Location = new System.Drawing.Point(362, 76);
            this.txtNomeCompletoCliente.Name = "txtNomeCompletoCliente";
            this.txtNomeCompletoCliente.Size = new System.Drawing.Size(543, 31);
            this.txtNomeCompletoCliente.TabIndex = 2;
            this.txtNomeCompletoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeCompletoCliente_KeyPress);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCliente.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIdCliente.Location = new System.Drawing.Point(72, 76);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(64, 31);
            this.txtIdCliente.TabIndex = 1;
            this.txtIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCliente_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Adventure", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(911, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 40);
            this.label4.TabIndex = 29;
            this.label4.Text = "cpf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Adventure", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(138, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 40);
            this.label3.TabIndex = 27;
            this.label3.Text = "nome completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Adventure", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 40);
            this.label2.TabIndex = 23;
            this.label2.Text = "id";
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.BackColor = System.Drawing.Color.DarkRed;
            this.btnExcluirCliente.FlatAppearance.BorderSize = 0;
            this.btnExcluirCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExcluirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCliente.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluirCliente.Location = new System.Drawing.Point(737, 677);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(132, 49);
            this.btnExcluirCliente.TabIndex = 12;
            this.btnExcluirCliente.Text = "Excluir";
            this.btnExcluirCliente.UseVisualStyleBackColor = false;
            this.btnExcluirCliente.Click += new System.EventHandler(this.btnExcluirCliente_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(206)))), ((int)(((byte)(7)))));
            this.btnEditarCliente.FlatAppearance.BorderSize = 0;
            this.btnEditarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCliente.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(94)))), ((int)(((byte)(12)))));
            this.btnEditarCliente.Location = new System.Drawing.Point(875, 677);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(132, 49);
            this.btnEditarCliente.TabIndex = 11;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.UseVisualStyleBackColor = false;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnAdicionarCliente
            // 
            this.btnAdicionarCliente.BackColor = System.Drawing.Color.Green;
            this.btnAdicionarCliente.FlatAppearance.BorderSize = 0;
            this.btnAdicionarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnAdicionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarCliente.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdicionarCliente.Location = new System.Drawing.Point(1013, 677);
            this.btnAdicionarCliente.Name = "btnAdicionarCliente";
            this.btnAdicionarCliente.Size = new System.Drawing.Size(132, 49);
            this.btnAdicionarCliente.TabIndex = 10;
            this.btnAdicionarCliente.Text = "Adicionar";
            this.btnAdicionarCliente.UseVisualStyleBackColor = false;
            this.btnAdicionarCliente.Click += new System.EventHandler(this.btnAdicionarCliente_Click);
            // 
            // btnLimparCliente
            // 
            this.btnLimparCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLimparCliente.FlatAppearance.BorderSize = 0;
            this.btnLimparCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimparCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparCliente.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLimparCliente.Location = new System.Drawing.Point(31, 677);
            this.btnLimparCliente.Name = "btnLimparCliente";
            this.btnLimparCliente.Size = new System.Drawing.Size(132, 49);
            this.btnLimparCliente.TabIndex = 13;
            this.btnLimparCliente.Text = "Limpar";
            this.btnLimparCliente.UseVisualStyleBackColor = false;
            this.btnLimparCliente.Click += new System.EventHandler(this.btnLimparCliente_Click);
            // 
            // mskCpfCliente
            // 
            this.mskCpfCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskCpfCliente.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.mskCpfCliente.Location = new System.Drawing.Point(976, 76);
            this.mskCpfCliente.Mask = "000,000,000-00";
            this.mskCpfCliente.Name = "mskCpfCliente";
            this.mskCpfCliente.Size = new System.Drawing.Size(169, 31);
            this.mskCpfCliente.TabIndex = 3;
            this.mskCpfCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskCpfCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskCpfCliente_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Adventure", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(480, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 40);
            this.label5.TabIndex = 40;
            this.label5.Text = "número";
            // 
            // txtNumeroCasaCliente
            // 
            this.txtNumeroCasaCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroCasaCliente.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCasaCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNumeroCasaCliente.Location = new System.Drawing.Point(599, 191);
            this.txtNumeroCasaCliente.Name = "txtNumeroCasaCliente";
            this.txtNumeroCasaCliente.Size = new System.Drawing.Size(48, 31);
            this.txtNumeroCasaCliente.TabIndex = 8;
            this.txtNumeroCasaCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Adventure", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(653, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 40);
            this.label6.TabIndex = 42;
            this.label6.Text = "bairro";
            // 
            // txtBairroCliente
            // 
            this.txtBairroCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairroCliente.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBairroCliente.Location = new System.Drawing.Point(763, 188);
            this.txtBairroCliente.Name = "txtBairroCliente";
            this.txtBairroCliente.Size = new System.Drawing.Size(382, 31);
            this.txtBairroCliente.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Adventure", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(24, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(266, 40);
            this.label8.TabIndex = 44;
            this.label8.Text = "data de nascimento";
            // 
            // mskDataNascCliente
            // 
            this.mskDataNascCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskDataNascCliente.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.mskDataNascCliente.Location = new System.Drawing.Point(296, 131);
            this.mskDataNascCliente.Mask = "00/00/0000";
            this.mskDataNascCliente.Name = "mskDataNascCliente";
            this.mskDataNascCliente.Size = new System.Drawing.Size(155, 31);
            this.mskDataNascCliente.TabIndex = 4;
            this.mskDataNascCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Adventure", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(457, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 40);
            this.label9.TabIndex = 46;
            this.label9.Text = "telefone fixo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Adventure", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(826, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 40);
            this.label10.TabIndex = 47;
            this.label10.Text = "whatsapp";
            // 
            // mskTelefoneFixoCliente
            // 
            this.mskTelefoneFixoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTelefoneFixoCliente.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.mskTelefoneFixoCliente.Location = new System.Drawing.Point(645, 131);
            this.mskTelefoneFixoCliente.Mask = "(99) 0000-0000";
            this.mskTelefoneFixoCliente.Name = "mskTelefoneFixoCliente";
            this.mskTelefoneFixoCliente.Size = new System.Drawing.Size(175, 31);
            this.mskTelefoneFixoCliente.TabIndex = 5;
            this.mskTelefoneFixoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mskWhatsAppCliente
            // 
            this.mskWhatsAppCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskWhatsAppCliente.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.mskWhatsAppCliente.Location = new System.Drawing.Point(967, 131);
            this.mskWhatsAppCliente.Mask = "(99) 00000-0000";
            this.mskWhatsAppCliente.Name = "mskWhatsAppCliente";
            this.mskWhatsAppCliente.Size = new System.Drawing.Size(178, 31);
            this.mskWhatsAppCliente.TabIndex = 6;
            this.mskWhatsAppCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskWhatsAppCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskWhatsAppCliente_KeyPress);
            // 
            // dtgClientes
            // 
            this.dtgClientes.AllowUserToAddRows = false;
            this.dtgClientes.AllowUserToDeleteRows = false;
            this.dtgClientes.AllowUserToResizeColumns = false;
            this.dtgClientes.AllowUserToResizeRows = false;
            this.dtgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgClientes.BackgroundColor = System.Drawing.Color.White;
            this.dtgClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgClientes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgClientes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgClientes.Location = new System.Drawing.Point(31, 233);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.RowHeadersVisible = false;
            this.dtgClientes.Size = new System.Drawing.Size(1114, 428);
            this.dtgClientes.TabIndex = 34;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataSource = typeof(Pizzaria.Classes_Clientes.Clientes);
            // 
            // Tela_ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1167, 738);
            this.Controls.Add(this.mskWhatsAppCliente);
            this.Controls.Add(this.mskTelefoneFixoCliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mskDataNascCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBairroCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumeroCasaCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskCpfCliente);
            this.Controls.Add(this.btnLimparCliente);
            this.Controls.Add(this.btnExcluirCliente);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnAdicionarCliente);
            this.Controls.Add(this.dtgClientes);
            this.Controls.Add(this.txtEnderecoCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNomeCompletoCliente);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_ClientesForm";
            this.Text = "TelaClientesForm";
            this.Load += new System.EventHandler(this.Tela_ClientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnderecoCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomeCompletoCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExcluirCliente;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnAdicionarCliente;
        private System.Windows.Forms.Button btnLimparCliente;
        private System.Windows.Forms.MaskedTextBox mskCpfCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumeroCasaCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBairroCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskDataNascCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskTelefoneFixoCliente;
        private System.Windows.Forms.MaskedTextBox mskWhatsAppCliente;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.BindingSource clientesBindingSource;
    }
}