using System.Data;

namespace Test3_24S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            double sum = Convert.ToInt32(textBox1.Text);
            sum=sum+ Convert.ToInt32(textBox2.Text);
            textBox2.Text= sum.ToString();
            
          
            double count=1;
          
            count =count+Convert.ToInt32(textBox3.Text);
            textBox3.Text= count.ToString();

            Double avg=sum/count;
             textBox4.Text =Convert.ToString(avg);

            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text=string.Empty;
            textBox2.Text=string.Empty; 
            textBox3.Text = string.Empty;
            textBox4.Text=string.Empty;
        }
    }
}
