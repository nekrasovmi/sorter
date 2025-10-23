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
            myArray = generateArrayRandom(test.count, test.min, test.max);
            richTextBox1.Text = "Массив:\n" + string.Join(" ", myArray);

            Pen pen = new Pen(Color.OrangeRed);
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(Color.Black);
            //for(int i = (int)minLim)





            //for(int i = 0; i < myArray.Length; i++)
            //{
            //    richTextBox1.Text = ToString(myArray[i]);
            //    Console.WriteLine("Элумент " + i + " : " + myArray[i]);
            //}
            //min = frm2.getMin();
            //max = frm2.getMax();
            //count = frm2.getCount();
            //Console.WriteLine(test.min + " " + test.max + " " + test.count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            sm.bubbleSort(myArray);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton8.Checked){
                //DialogResult res = MessageBox.Show()
                frm3.Owner = this;
                frm3.ShowDialog();
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
                //openFileDialog1.ShowDialog();
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    char sep = '\n';
                    string filename = openFileDialog1.FileName;
                    string[] filetext = System.IO.File.ReadAllText(filename).Split(sep);

                    //for(int i=0;i< filetext.Split(sep).Length; i++)
                    //{
                    //    richTextBox1.Text = filetext[i];
                    //}
                    //richTextBox1.Text = filetext.Split(sep).ToString;
                    //richTextBox1.Text = Convert.ToInt32(filetext.Split(sep).ToArray());
                    //originArr = filetext.Select(n => int.Parse(n.Trim))
                    //originArr = Convert.ToInt32(filetext);
                    originArr = new int[filetext.Length];
                    for (int i = 0; i< filetext.Length; i++)
                    {
                        originArr[i] = Convert.ToInt32(filetext[i]);
                    }
                    richTextBox1.Text = "Массив:\n" + string.Join(" ", originArr);
                }
            }
            //openFileDialog1.Filter = "CSV файлы (*.csv)|*.csv";
            //openFileDialog1.FileName = "";
            //openFileDialog1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(radioButton6.Checked)
            Console.WriteLine(radioButton6.Checked);
        }
    }
}
