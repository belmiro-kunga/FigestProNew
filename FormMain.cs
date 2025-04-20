using System.Windows.Forms;
using POSDesktop.Views;

namespace POSDesktop
{
    public class FormMain : Form
    {
        public FormMain()
        {
            this.Text = "POS Angola";
            this.Width = 800;
            this.Height = 600;

            var menu = new MenuStrip();
            var cadastroMenu = new ToolStripMenuItem("Cadastro de Produtos");
            var vendaMenu = new ToolStripMenuItem("Processo de Venda");
            var relatorioMenu = new ToolStripMenuItem("Relatórios");

            cadastroMenu.Click += (s, e) => new FormCadastroProduto().ShowDialog();
            vendaMenu.Click += (s, e) => new FormVenda().ShowDialog();
            relatorioMenu.Click += (s, e) => new FormRelatorios().ShowDialog();

            menu.Items.Add(cadastroMenu);
            menu.Items.Add(vendaMenu);
            menu.Items.Add(relatorioMenu);

            this.MainMenuStrip = menu;
            this.Controls.Add(menu);
        }
    }
}
