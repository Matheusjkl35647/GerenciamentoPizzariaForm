using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Classes_Clientes
{
    class Clientes
    {
        private string idCliente;
        private string nomeCompleto;
        private string cpf;
        private string dataNasc;
        private string telefoneFixo;
        private string whatsApp;
        private string endereco;
        private string numeroCasa;
        private string bairro;

        public Clientes()
        {
            IdCliente = "";
            NomeCompleto = "";
            Cpf = "";
            dataNasc = "";
            TelefoneFixo = "";
            WhatsApp = "";
            Endereco = "";
            NumeroCasa = "";
            Bairro = "";
        }

        public Clientes(string ic, string nomc, string c, string dtn, string tlf, string w, string e, string numc, string b)
        {
            IdCliente = ic;
            NomeCompleto = nomc;
            Cpf = c;
            dataNasc = dtn;
            TelefoneFixo = tlf;
            WhatsApp = w;
            Endereco = e;
            NumeroCasa = numc;
            Bairro = b;
        }

        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string NomeCompleto { get => nomeCompleto; set => nomeCompleto = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string DataNasc { get => dataNasc; set => dataNasc = value; }
        public string TelefoneFixo { get => telefoneFixo; set => telefoneFixo = value; }
        public string WhatsApp { get => whatsApp; set => whatsApp = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string NumeroCasa { get => numeroCasa; set => numeroCasa = value; }
        public string Bairro { get => bairro; set => bairro = value; }

        // Cirar caminho para arquivo
        public string CaminhoClientes()
        {
            return "C:/Users/Mathe/Desktop/Clientes.txt";
        }

        // Comando adicionar Cliente
        public void AdicionarCliente()
        {
            // Usa a classe StreamWriter para grava em txt baseado no caminho que foi lhe passado e cria o arquivo, caso não exista.
            StreamWriter swriter = File.AppendText(CaminhoClientes());
            // Aqui informamos como os dados serão armazenados dentro do arquivo txt
            swriter.WriteLine(this.IdCliente + ";" + this.NomeCompleto + ";" + this.Cpf + ";" +
                              this.DataNasc + ";" + this.TelefoneFixo + ";" + this.WhatsApp + 
                              ";" + this.Endereco + ";" + this.NumeroCasa + ";" + this.Bairro);
            //Agora fechamos o programa
            swriter.Close();
        }

        // Comando criar lista de Clientes
        public List<Clientes> Ler()
        {
            var list = new List<Clientes>();
            // Verifica se o arquivo existe {Exists}
            if (File.Exists(CaminhoClientes()))
            {
                //Usa o StreamReader para fazer a leitura do arquivo baseado no caminho
                StreamReader sreader = File.OpenText(CaminhoClientes());
                string linha;
                while ((linha = sreader.ReadLine()) != null)
                {
                    var arquivo = linha.Split(';');
                    Clientes addClientes = new Clientes(arquivo[0], arquivo[1], arquivo[2], arquivo[3], arquivo[4], 
                                                                     arquivo[5], arquivo[6], arquivo[7], arquivo[8]);
                    list.Add(addClientes);
                }
                sreader.Close();
            }
            return list;
        }

        // Comando para editar itens da lista
        public void EditarCliente()
        {
            string text = null;
            if (File.Exists(CaminhoClientes()))
            {
                using (StreamReader sreader = new StreamReader(CaminhoClientes()))
                {
                    string linha;
                    while ((linha = sreader.ReadLine()) != null)
                    {
                        var arquivo = linha.Split(';');
                        if (arquivo[0].Equals(this.IdCliente) || arquivo[1].Equals(this.NomeCompleto) ||
                            (arquivo[2].Equals(this.Cpf)) || (arquivo[3].Equals(this.DataNasc)) ||
                            (arquivo[4].Equals(this.TelefoneFixo)) || (arquivo[5].Equals(this.WhatsApp)) ||
                            (arquivo[6].Equals(this.Endereco)) || (arquivo[7].Equals(this.NumeroCasa)) ||
                            (arquivo[8].Equals(this.Bairro)))
                        {
                            string novoTexto = this.IdCliente + ";" + this.NomeCompleto + ";" + this.Cpf +
                                                ";" + this.DataNasc + ";" + this.TelefoneFixo + ";" + this.WhatsApp +
                                                ";" + this.Endereco + ";" + this.NumeroCasa + ";" + this.Bairro + "\n";
                            text += novoTexto;
                        }
                        else
                        {
                            text = text + linha + "\n";
                        }
                    }
                    sreader.Close();
                    File.Delete(CaminhoClientes());
                    StreamWriter swriter = new StreamWriter(CaminhoClientes());
                    swriter.Write(text);
                    swriter.Close();
                }
            }
        }

        // Excluir Cliente da lista
        public void ExcluirCliente()
        {
            string texto = null;
            if (File.Exists(CaminhoClientes()))
            {
                using (StreamReader sr = new StreamReader(CaminhoClientes()))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        var arquivo = linha.Split(';');
                        if (!arquivo[0].Equals(this.IdCliente))
                        {
                            texto = texto + linha + "\n";
                        }
                    }
                    sr.Close();
                    File.Delete(CaminhoClientes());
                    StreamWriter sw = new StreamWriter(CaminhoClientes());
                    sw.Write(texto);
                    sw.Close();
                }
            }
        }

        // Comando Buscar em lista
        public void BuscarCliente()
        {
            if (File.Exists(CaminhoClientes()))
            {
                StreamReader sreader = File.OpenText(CaminhoClientes());
                string linha;
                while ((linha = sreader.ReadLine()) != null)
                {
                    var arquivo = linha.Split(';');
                    if (arquivo[0].Equals(this.IdCliente.ToString()))
                    {
                        NomeCompleto = arquivo[1];
                        Cpf = arquivo[2];
                        DataNasc = arquivo[3];
                        TelefoneFixo = arquivo[4];
                        WhatsApp = arquivo[5];
                        Endereco = arquivo[6];
                        NumeroCasa = arquivo[7];
                        Bairro = arquivo[8];
                    } 
                    else if (arquivo[1].Equals(this.NomeCompleto.ToString()))
                    {
                        IdCliente = arquivo[0];
                        Cpf = arquivo[2];
                        DataNasc = arquivo[3];
                        TelefoneFixo = arquivo[4];
                        WhatsApp = arquivo[5];
                        Endereco = arquivo[6];
                        NumeroCasa = arquivo[7];
                        Bairro = arquivo[8];
                    } 
                    else if (arquivo[2].Equals(this.Cpf.ToString()))
                    {
                        IdCliente = arquivo[0];
                        NomeCompleto = arquivo[1];
                        DataNasc = arquivo[3];
                        TelefoneFixo = arquivo[4];
                        WhatsApp = arquivo[5];
                        Endereco = arquivo[6];
                        NumeroCasa = arquivo[7];
                        Bairro = arquivo[8];
                    } 
                    else if (arquivo[5].Equals(this.WhatsApp.ToString()))
                    {
                            IdCliente = arquivo[0];
                            NomeCompleto = arquivo[1];
                            Cpf = arquivo[2];
                            DataNasc = arquivo[3];
                            TelefoneFixo = arquivo[4];
                            Endereco = arquivo[6];
                            NumeroCasa = arquivo[7];
                            Bairro = arquivo[8];
                    }
                }
                sreader.Close();
            }
        }
    }
}
