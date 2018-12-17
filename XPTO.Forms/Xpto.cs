using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xpto.Persistencia;
using Xpto.Modelo;
using Xpto.Persistencia.Context;
using System.IO;

namespace XPTO.Forms
{
    public partial class XptoForm : Form
    {
        public EFContext db = new EFContext();

        public XptoForm()
        {
            InitializeComponent();

            CarregarGrids();
        }

        private void AtualizarButton_Click(object sender, EventArgs e)
        {
            CarregarGrids();
        }

        private void CarregarGrids()
        {
            ClienteDataGridView.DataSource = db.Clientes.ToList();
            ProdutoDataGridView.DataSource = db.Produtos.ToList();
            ClienteProdutoDataGridView.DataSource = db.ClientesProdutos.ToList();
        }

        private void ExtrairDadosArquivosButton_Click(object sender, EventArgs e)
        {
            var extrairDados = new ExtrairDados();

            var caminho1 = @"C:\Users\eduardo\source\repos\Stefanini\XPTO.Forms\XPTO.Forms\Arquivos\ARQUIVO1-PLENO.txt";
            var caminho2 = @"C:\Users\eduardo\source\repos\Stefanini\XPTO.Forms\XPTO.Forms\Arquivos\ARQUIVO2-PLENO.txt";

            extrairDados.ExtrairDadosArquivo_1(caminho1);
            extrairDados.ExtrairDadosArquivo_2(caminho2);

            CarregarGrids();
        }
    }
}
