using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_banco01
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultado = cbListagem.SelectedIndex;

            switch (resultado) 
            {
                case 0:
                    Form1 TelaCliente = new Form1();
                    this.Hide();
                    TelaCliente.ShowDialog();
                    break;

                case 1:
                    Funcionarios TelaFuncionarios = new Funcionarios();
                    this.Hide();
                    TelaFuncionarios.ShowDialog();
                    break;

                case 2:
                    Fornecedores TelaFornecedores = new Fornecedores();
                    this.Hide();
                    TelaFornecedores.ShowDialog();
                    break;

                case 3:
                    FrmCAcesso TelaAcesso = new FrmCAcesso();
                    this.Hide();
                    TelaAcesso.ShowDialog();
                    break;

            }


        }
    }
}
