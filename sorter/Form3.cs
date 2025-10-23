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
    public partial class Form3 : Form
    {
        public static int count = 0;
        public int[] arr;
        public int len;
        public int item = 0;
        public bool endMassive = false;
        DataTable dt = new DataTable();
        //public Array myarr = new Array;
        public Form3()
        {
            InitializeComponent();
            button3.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            len = Convert.ToInt32(numericUpDown1.Value);
            label1.Text = "Введите " + item + " элемент массива";
            //textBox1.Text = null;
            button1.Visible = false;
            button3.Visible = true;
            //arr = new int[len];
            //arr = Array[len];
            //int item = 1;
            //for(int i=0; i < len; i++)
            //{
            //    label1.Text = "Введите " + item + " элемент массива";
            //    item++;
            //}
            Form1.test.myarray = new int[len];

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            /*
            while ()
            {
                label1.Text = "Введите " + item + " элемент массива";

                item++;
                if (item == len)
                {
                    
                    endMassive = true;
                }

            }
            /*for (int i = 0; i < len; i++)
            {
                label1.Text = "Введите " + item + " элемент массива";
                arr[i] = Convert.ToInt32(textBox1.Text);
                //textBox1.Text = null;
                item++;
                //textBox1.Text = null;
            }
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine();
            } */
            
            
            /*public int[] GetArray()
            {

            }*/
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].ReadOnly = true;
            
        }
    }
}
