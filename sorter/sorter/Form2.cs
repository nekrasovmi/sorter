using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sorter
{
    public partial class Form2 : Form
    {
        private int[] randomArray;
        private Random rand = new Random();
        //public int min;
        //public mydataset md = new mydataset();
        //Form1 frm1 = new Form1();
        public Form2()
        {
            InitializeComponent();
        }

        //public int getMin()
        //{
            //return Convert.ToInt32(textBox1.Text);
        //}
        //public int getMax()
        //{
            //return Convert.ToInt32(textBox2.Text);
        //}
        //public int getCount()
        //{
            //return Convert.ToInt32(textBox3.Text);
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1.
            //frm1.min = Convert.ToInt32(textBox1.Text);
            //min = text
            /*Form1.test.min = Convert.ToInt32(textBox1.Text);
            Form1.test.max = Convert.ToInt32(textBox2.Text);
            Form1.test.count = Convert.ToInt32(textBox3.Text);*/

            this.Hide();
        }
        public int[] getArray()
        {
            int size = Convert.ToInt32(textBox3.Text);
            int minValue = Convert.ToInt32(textBox1.Text);
            int maxValue = Convert.ToInt32(textBox2.Text);
            int[] randomArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                randomArray[i] = rand.Next(minValue, maxValue);
            }
            //randomArray = generateArrayRandom(test.count, test.min, test.max);
            return randomArray;
        }

        /*private int[] generateArrayRandom(int size, int minValue, int maxValue)
        {
            int[] randomArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                randomArray[i] = rand.Next(minValue, maxValue);
            }
            return randomArray;
        }*/
    }
}
