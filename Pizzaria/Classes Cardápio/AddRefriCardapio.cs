using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    class AddRefriCardapio
    {
        private string numeroRefri;
        private string nomeRefri;
        private string litrosRefri;
        private double precoRefri;

        public AddRefriCardapio()
        {
            NumeroRefri = "";
            NomeRefri = "";
            LitrosRefri = "";
            precoRefri = 0.0;
        }

        public AddRefriCardapio(string numr, string nomr, string lr, double pr)
        {
            NumeroRefri = numr;
            NomeRefri = nomr;
            LitrosRefri = lr;
            precoRefri = pr;
        }

        public string NumeroRefri { get => numeroRefri; set => numeroRefri = value; }
        public string NomeRefri { get => nomeRefri; set => nomeRefri = value; }
        public string LitrosRefri { get => litrosRefri; set => litrosRefri = value; }
        public double PrecoRefri { get => precoRefri; set => precoRefri = value; }
        //Definindo caminho para arquivo
        public string CaminhoRefri()
        {
            return "C:/Users/Mathe/Desktop/Refrigerante.txt";
        }
        // Comando adicionar Refrigerante
        public void AdicionarRefri()
        {
            // Usa a classe StreamWriter para grava em txt baseado no caminho que foi lhe passado e cria o arquivo, caso não exista.
            StreamWriter swriter = File.AppendText(CaminhoRefri());
            // Aqui informamos como os dados serão armazenados dentro do arquivo txt
            swriter.WriteLine(this.NumeroRefri + ";" + this.NomeRefri + ";" +
                         this.LitrosRefri + ";" + this.PrecoRefri);
            //Agora fechamos o programa
            swriter.Close();
        }
        // Comando criar lista
        public List<AddRefriCardapio> Ler()
        {
            var list = new List<AddRefriCardapio>();
            // Verifica se o arquivo existe {Exists}
            if (File.Exists(CaminhoRefri()))
            {
                //Usa o StreamReader para fazer a leitura do arquivo baseado no caminho
                StreamReader sreader = File.OpenText(CaminhoRefri());
                string linha;
                while ((linha = sreader.ReadLine()) != null)
                {
                    var arquivo = linha.Split(';');
                    AddRefriCardapio addRefri = new AddRefriCardapio(arquivo[0], arquivo[1], arquivo[2], double.Parse(arquivo[3]));
                    list.Add(addRefri);
                }
                sreader.Close();
            }
            return list;
        }

        //Comando editar refrigerante
        public void EditarRefri()
        {
            string text = null;
            if (File.Exists(CaminhoRefri()))
            {
                using (StreamReader sreader = new StreamReader(CaminhoRefri()))
                {
                    string linha;
                    while ((linha = sreader.ReadLine()) != null)
                    {
                        var arquivo = linha.Split(';');
                        if (arquivo[0].Equals(this.NumeroRefri) || arquivo[1].Equals(this.NomeRefri) ||
                            (arquivo[2].Equals(this.LitrosRefri)) || (arquivo[3].Equals(this.PrecoRefri)))
                        {
                            string novoTexto = this.NumeroRefri + ";" + this.NomeRefri + ";" + this.LitrosRefri +
                                                ";" + this.PrecoRefri + "\n";
                            text += novoTexto;
                        }
                        else
                        {
                            text = text + linha + "\n";
                        }
                    }
                    sreader.Close();
                    File.Delete(CaminhoRefri());
                    StreamWriter swriter = new StreamWriter(CaminhoRefri());
                    swriter.Write(text);
                    swriter.Close();
                }
            }
        }

        // Comando excluir Refrigerante
        public void ExcluirRefri()
        {
            string texto = null;
            if (File.Exists(CaminhoRefri()))
            {
                using (StreamReader sr = new StreamReader(CaminhoRefri()))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        var arquivo = linha.Split(';');
                        if (!arquivo[0].Equals(this.NumeroRefri))
                        {
                            texto = texto + linha + "\n";
                        }
                    }
                    sr.Close();
                    File.Delete(CaminhoRefri());
                    StreamWriter sw = new StreamWriter(CaminhoRefri());
                    sw.Write(texto);
                    sw.Close();
                }
            }
        }
        // Comando buscar refrigerante
        public void BuscarRefri()
        {
            if (File.Exists(CaminhoRefri()))
            {
                StreamReader sreader = File.OpenText(CaminhoRefri());
                string linha;
                while ((linha = sreader.ReadLine()) != null)
                {
                    var arquivo = linha.Split(';');
                    if (arquivo[0].Equals(this.NumeroRefri.ToString()))
                    {
                        NomeRefri = arquivo[1];
                        LitrosRefri = arquivo[2];
                        PrecoRefri = double.Parse(arquivo[3]);
                    }
                }
                sreader.Close();
            }
        }

    }
}
