using System;
using System.IO;
using System.Windows.Forms;

namespace CountCharacters
{
    public partial class Form1 : Form
    {
        public string FileName { get; set; }
        public string Input { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = string.Empty;
            radioButton1.Checked = true;
            radioButton2.Checked = false;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (File.Exists(textBox1.Text))
                {
                    Input = File.ReadAllText(textBox1.Text);
                }
                else
                {
                    this.label1.Text = "File does not exists!!";
                }
            }
            else if (radioButton2.Checked)
            {
                Input = textBox1.Text;
            }
            if (!string.IsNullOrWhiteSpace(Input))
            {
                CalculateOccurrence calculateOccurrence = new CalculateOccurrence(Input);
                calculateOccurrence.FindCharacterOccureceInString();
                label1.Text = calculateOccurrence.PrintData();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
        }
    }
}
