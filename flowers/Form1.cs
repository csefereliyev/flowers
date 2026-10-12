namespace flowers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double finalResult = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(maskedTextBox1.Text))
            {
                MessageBox.Show("Bos xana olmamalidir!", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string ftype = textBox1.Text;
                int fnum = int.Parse(maskedTextBox1.Text);
                double fprice = double.Parse(textBox2.Text);
                double result = fnum * fprice;
                if (fnum < 0 || fprice < 0)
                {
                    MessageBox.Show("Menfi eded qeyd edile bilmez!", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dataGridView1.Rows.Add(ftype, fnum, fprice.ToString("F2"), result.ToString("F2"));

                finalResult += result;
                label5.Text = finalResult.ToString("F2");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Cixmaq isteyirsiz?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
