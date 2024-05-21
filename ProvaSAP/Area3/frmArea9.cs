using TelaVendaAutomovel;

namespace Area3
{
    public partial class frmArea9 : Form
    {
        public frmArea9()
        {
            InitializeComponent();
        }

        private void Vender1_Click(object sender, EventArgs e)
        {
            frmVendas frmVendas = new frmVendas();
            frmVendas.ShowDialog();
        }

        private void Vender2_Click(object sender, EventArgs e)
        {
            frmVendas frmVendas = new frmVendas();
            frmVendas.ShowDialog();
        }

        private void Vender3_Click(object sender, EventArgs e)
        {
            frmVendas frmVendas = new frmVendas();
            frmVendas.ShowDialog();
        }
    }
}