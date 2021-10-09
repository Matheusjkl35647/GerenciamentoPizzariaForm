using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    class AddPizzaCardapio
    {
        private string numeroPizza;
        private string nomePizza;
        private string recheioPizza;
        private double precoIntPizza;
        private double precoBrotoPizza;

        public AddPizzaCardapio()
        {
            NumeroPizza = "";
            NomePizza = "";
            RecheioPizza = "";
            PrecoIntPizza = 0.0;
            PrecoBrotoPizza = 0.0;
        }

        public AddPizzaCardapio(string nump, string nomp, string rp, double pip, double pbp)
        {
            NumeroPizza = nump;
            NomePizza = nomp;
            RecheioPizza = rp;
            PrecoIntPizza = pip;
            PrecoBrotoPizza = pbp;
        }

        public string NumeroPizza { get => numeroPizza; set => numeroPizza = value; }
        public string NomePizza { get => nomePizza; set => nomePizza = value; }
        public string RecheioPizza { get => recheioPizza; set => recheioPizza = value; }
        public double PrecoIntPizza { get => precoIntPizza; set => precoIntPizza = value; }
        public double PrecoBrotoPizza { get => precoBrotoPizza; set => precoBrotoPizza = value; }

        // Cirar caminho para arquivo
        public string CaminhoPizza()
        {
            return "C:/Users/Mathe/Desktop/Pizzas.txt";
        }
        // Comando adicionar Pizza
        public void AdicionarPizza()
        {
            // Usa a classe StreamWriter para grava em txt baseado no caminho que foi lhe passado e cria o arquivo, caso não exista.
            StreamWriter swriter = File.AppendText(CaminhoPizza());
            // Aqui informamos como os dados serão armazenados dentro do arquivo txt
            swriter.WriteLine(this.NumeroPizza + ";" + this.NomePizza + ";" +
                         this.RecheioPizza + ";" + this.PrecoIntPizza + ";" + this.PrecoBrotoPizza);
            //Agora fechamos o programa
            swriter.Close();
        }
        // Comando criar lista de pizza
        public List<AddPizzaCardapio> Ler()
        {
            var list = new List<AddPizzaCardapio>();
            // Verifica se o arquivo existe {Exists}
            if (File.Exists(CaminhoPizza()))
            {
                //Usa o StreamReader para fazer a leitura do arquivo baseado no caminho
                StreamReader sreader = File.OpenText(CaminhoPizza());
                string linha;
                while ((linha = sreader.ReadLine()) != null)
                {
                    var arquivo = linha.Split(';');
                    AddPizzaCardapio addPizza = new AddPizzaCardapio(arquivo[0], arquivo[1], arquivo[2], double.Parse(arquivo[3]), double.Parse(arquivo[4]));
                    list.Add(addPizza);
                }
                sreader.Close();
            }
            return list;
        }

        // Comando para editar itens da lista
        public void EditarPizza()
        {
            string text = null;
            if (File.Exists(CaminhoPizza()))
            {
                using (StreamReader sreader = new StreamReader(CaminhoPizza()))
                {
                    string linha;
                    while ((linha = sreader.ReadLine()) != null)
                    {
                        var arquivo = linha.Split(';');
                        if (arquivo[0].Equals(this.NumeroPizza) || arquivo[1].Equals(this.NomePizza) || 
                            (arquivo[2].Equals(this.RecheioPizza)) || (arquivo[3].Equals(this.PrecoIntPizza)) || (arquivo[4].Equals(this.PrecoBrotoPizza)))
                        {
                            string novoTexto = this.NumeroPizza + ";" + this.NomePizza + ";" + this.RecheioPizza +
                                                ";" + this.PrecoIntPizza + ";" + this.PrecoBrotoPizza + "\n";
                            text += novoTexto;
                        }
                        else
                        {
                            text = text + linha + "\n";
                        }
                    }
                    sreader.Close();
                    File.Delete(CaminhoPizza());
                    StreamWriter swriter = new StreamWriter(CaminhoPizza());
                    swriter.Write(text);
                    swriter.Close();
                }
            }
        }
        // Excluir pizza do Cardápio
        public void ExcluirPizza()
        {
            string texto = null;
            if (File.Exists(CaminhoPizza()))
            {
                using (StreamReader sr = new StreamReader(CaminhoPizza()))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        var arquivo = linha.Split(';');
                        if (!arquivo[0].Equals(this.NumeroPizza))
                        {
                            texto = texto + linha + "\n";
                        }
                    }
                    sr.Close();
                    File.Delete(CaminhoPizza());
                    StreamWriter sw = new StreamWriter(CaminhoPizza());
                    sw.Write(texto);
                    sw.Close();
                }
            }
        }

        // Comando Buscar em lista
        public void BuscarPizza()
        {
            if (File.Exists(CaminhoPizza()))
            {
                StreamReader sreader = File.OpenText(CaminhoPizza());
                string linha;
                while ((linha = sreader.ReadLine()) != null)
                {
                    var arquivo = linha.Split(';');
                    if (arquivo[0].Equals(this.NumeroPizza.ToString()))
                    {
                        NomePizza = arquivo[1];
                        RecheioPizza = arquivo[2];
                        PrecoIntPizza = double.Parse(arquivo[3]);
                        PrecoBrotoPizza = double.Parse(arquivo[4]);
                    }
                }
                sreader.Close();
            }
        }

    }
}
