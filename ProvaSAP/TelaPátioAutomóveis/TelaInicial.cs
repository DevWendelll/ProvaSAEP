using Area1;
using Area2;
using Area3;
using Area4;

namespace TelaPátioAutomóveis
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void Area3_Click(object sender, EventArgs e)
        {
            frmArea3 frmArea3 = new frmArea3();
            frmArea3.ShowDialog();
        }

        private void Area11_Click(object sender, EventArgs e)
        {
            frmArea11 frmArea11 = new frmArea11();
            frmArea11.ShowDialog();
        }

        private void Area9_Click(object sender, EventArgs e)
        {
            frmArea9 frmArea9 = new frmArea9();
            frmArea9.ShowDialog();
        }

        private void Area10_Click(object sender, EventArgs e)
        {
            frmArea10 frmArea10 = new frmArea10();
            frmArea10.ShowDialog();
        }
    }
}