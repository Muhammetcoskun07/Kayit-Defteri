namespace Kayıt_Defteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
            label5.Text = textBox2.Text;
            label8.Text = comboBox1.Text;
            label11.Text = textBox3.Text;
        }
    }
}
