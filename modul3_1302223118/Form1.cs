namespace modul3_1302223118
{
    public partial class Form1 : Form
    {
        int jumlah;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            this.jumlah = this.jumlah + int.Parse(textBox.Text);
            textBox.Text = this.jumlah.ToString();
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            this.jumlah = this.jumlah + int.Parse(textBox.Text);
            textBox.Text = "";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "7";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "9";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
