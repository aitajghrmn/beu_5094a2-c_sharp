namespace greeting_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalamla_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            lblSalam.Text = "Salam, " + ad;
        }
    }
}


