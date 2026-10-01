namespace age_checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYoxla_Click(object sender, EventArgs e)
        {
            int yas = Convert.ToInt32(txtYas.Text);
            if (yas >= 18)
            {
                lblNetice.Text = "Siz yetkinsiniz!";

            }
            else
            {
                lblNetice.Text = "Siz hələ yetkin deyilsiniz!";
            }
        }
    }
}
