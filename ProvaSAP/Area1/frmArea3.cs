using TelaVendaAutomovel;

namespace Area1
{
    public partial class frmArea3 : Form
    {
        public frmArea3()
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