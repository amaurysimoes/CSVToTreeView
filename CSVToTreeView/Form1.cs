using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Macoratti.CSVTreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            StreamReader leitorStream = new StreamReader("dadosPesquisa.txt");
            string strContato = "";

            TreeNode main = Pesquisa.Nodes.Add("Pesquisa");

            while ((strContato = leitorStream.ReadLine()) != null)
            {
                string[] Contato = strContato.Split(',');

                TreeNode name = main.Nodes.Add(Contato[0]);
                name.ForeColor = Color.Green;

                TreeNode email = name.Nodes.Add(Contato[1]);
                email.ForeColor = Color.Red;

                TreeNode numero_contato = name.Nodes.Add(Contato[2]);
                numero_contato.ForeColor = Color.Blue;
            }
        }

        private void contatos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 2)
            {
                txtSelecao.Text  = Pesquisa.SelectedNode.Text;
            }
        }
    }
}
