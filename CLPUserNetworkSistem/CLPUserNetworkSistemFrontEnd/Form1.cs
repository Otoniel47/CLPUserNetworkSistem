using CLPUserNetworkSistemFrontEnd.Telas;

namespace CLPUserNetworkSistemFrontEnd
{
    public partial class Form1 : Form
    {
        TelaLogin telaLogin = new();

        public Form1()
        {
            InitializeComponent();
            telaLogin.Parent = this.panelPrincipal;
            telaLogin.BringToFront();
            telaLogin.Show();
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}