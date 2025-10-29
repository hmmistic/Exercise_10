using System.Security.Cryptography;

namespace Random_number
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private int randomNumber;
        private int count = 0;
        private bool canGenerate = true;
        public Form1()
        {
            InitializeComponent();
            randomNumber = random.Next(1, 101);
            richTextBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int guessNumber);

            if (canGenerate == false)
            {
                MessageBox.Show("Ədədi yenidən təxmin etmək üçün zəhmət olmasa yeni oyun başladın");
                return;
            }

            count++;
            richTextBox1.Text = count.ToString();

            if (guessNumber == randomNumber)
            {
                MessageBox.Show("Siz ədədi düzgün təxmin etdiniz!");
                canGenerate = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            canGenerate = true;
            count = 0;
            richTextBox1.Text = "0";
            textBox1.Clear();
            randomNumber = random.Next(1, 101);
        }
    }
}
