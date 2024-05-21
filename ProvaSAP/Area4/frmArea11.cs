using TelaVendaAutomovel;

namespace Area4
{
    public partial class frmArea11 : Form
    {
        public frmArea11()
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