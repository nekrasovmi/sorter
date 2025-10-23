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
    
    public struct minmaxcount
    {
        public int min;
        public int max;
        public int count;
        public int[] myarray;
    }

    public enum SortDirection
    {
        Ascending = 0,
        Descending = 1
    }
    public partial class Form1 : Form
    {
        //public int[] myarray;
        static public minmaxcount test;
        private static Random rand = new Random();
        private int[] originArr;
        Form2 frm2 = new Form2();
        Form3 frm3 = new Form3();
        int[] myArray;

        sortedMethods sm = new sortedMethods();
        
        public Form1()
        {
            InitializeComponent();
        }

        private static int[] generateArrayRandom(int size, int minValue, int maxValue)
        {
            int[] randomArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                randomArray[i] = rand.Next(minValue, maxValue);
            }
            return randomArray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Message", "ssss", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //frm2.Show();
            frm2.Owner = this;
            frm2.ShowDialog();
            //Console.WriteLine(md.min + " " + md.max + " " + md.count);
            //frm2. 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //myArray = generateArrayRandom(test.count, test.min, test.max);
            //richTextBox1.Text = "Массив:\n" + string.Join(" ", myArray);
            int[] arr = originArr;

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Pen pen = new Pen(Color.OrangeRed);
            SolidBrush sb = new SolidBrush(pen.Color);
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(Color.Black);

            int min = arr.Min();
            int max = arr.Max();
            
            
            //int[] test = { 10, 10, 2, 7, 13, 12, 12, 13, 14, 1, 4, 11, 12, 1, 14, 13, 4, 8, 6, 10};
            //int[] test = { 10, 10, 2, 7, 13 };
            //int element = 17;
            int deltaW = pictureBox1.Width / arr.Length;
            int deltaH = pictureBox1.Height / arr.Max();

            //graphics.FillRectangle(sb, 0, pictureBox1.Height - (element * 15), 15, element * 15);


            for (int i = 0; i < arr.Length; i++)
            {
                //graphics.FillRectangle(sb, i*15 , pictureBox1.Height-(test[i] * 15), 15, test[i] * 15);
                graphics.FillRectangle(sb, i * deltaW, pictureBox1.Height - (arr[i] * deltaH), deltaW, arr[i] * deltaH);
            }

            //graphics.FillRectangle(sb, 0 , pictureBox1.Height-(element * 15), 15, element * 15);

            for (int i = min; i <= max; i++)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] >= i)
                    {
                        //graphics.FillRectangle(sb, 15 * j, pictureBox1.Height - 15 * i, 15, 15);
                    }
                    
                }
            }

            pen = new Pen(Color.DarkGreen);
            for(int i = 0; i < pictureBox1.Width; i += deltaW)
            {
                graphics.DrawLine(pen, i, 0, i, pictureBox1.Width);
            }
            for (int i = 0; i < pictureBox1.Width; i += deltaH)
            {
                graphics.DrawLine(pen, 0, pictureBox1.Height-i, pictureBox1.Width, pictureBox1.Height-i);
            }
            /*
            for (int i = 0; i < arr.Length; i++)
            {
                graphics.FillRectangle(sb,15*i, pictureBox1.Height - 15*i,15,15);
            }

            drawArray(arr);
            */
        }

        private void drawArray(int[] arr)
        {
            for(int i =0; i < arr.Length; i++)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            sm.bubbleSort(myArray);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton8.Checked){                
                frm3.Owner = this;
                frm3.ShowDialog();
                originArr = frm3.GetArray();
                richTextBox1.Text = "Массив:\n" + string.Join(" ", originArr);
            }
            if (radioButton7.Checked)
            {
                frm2.Owner = this;
                frm2.ShowDialog();
                originArr = frm2.GetArray();
                richTextBox1.Text = "Массив:\n" + string.Join(" ", originArr);
            }
            if (radioButton6.Checked)
            {
                openFileDialog1.Filter = "TXT файлы (*.txt)|*.txt|CSV файлы (*.csv)|*.csv";
                openFileDialog1.FileName = "";
                
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    char sep = '\n';
                    string filename = openFileDialog1.FileName;
                    string[] filetext = System.IO.File.ReadAllText(filename).Split(sep);

                    originArr = new int[filetext.Length];
                    for (int i = 0; i< filetext.Length; i++)
                    {
                        originArr[i] = Convert.ToInt32(filetext[i]);
                    }
                    richTextBox1.Text = "Массив:\n" + string.Join(" ", originArr);
                }
            }           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(radioButton6.Checked)
            Console.WriteLine(radioButton6.Checked);
        }
    }
}
