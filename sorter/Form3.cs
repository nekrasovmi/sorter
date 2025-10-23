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
            //button3.Visible = false;

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
            this.Hide();
            /*len = Convert.ToInt32(numericUpDown1.Value);
            label1.Text = "Введите " + item + " элемент массива";
            //textBox1.Text = null;
            button1.Visible = false;
            button3.Visible = true;
            */
            //arr = new int[len];
            //arr = Array[len];
            //int item = 1;
            //for(int i=0; i < len; i++)
            //{
            //    label1.Text = "Введите " + item + " элемент массива";
            //    item++;
            //}
            //Form1.test.myarray = new int[len];

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

        private void dataGridView1_CancelRowEdit(object sender, QuestionEventArgs e)
        {
            //Console.WriteLine("edit cell");
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("edit cell");
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine("edit cell cancel");
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            incrementIndex();
            /*for(int i =0; i< dataGridView1.RowCount-1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i+1;
            }*/
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string s = new string(e.KeyChar,1);
            //Console.WriteLine(s);
            if (e.KeyChar == 8 || e.KeyChar == 46) 
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                incrementIndex();
                //Console.WriteLine("backspace");
                //Console.WriteLine();
            }
            /*if (e.KeyChar == 46)
            {
                //Console.WriteLine("del");
                //Console.WriteLine();
            }*/
        }

        private void incrementIndex()
        {
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }

        public int[] GetArray()
        {
            int[] handleArray = new int[dataGridView1.RowCount - 1];

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                //dataGridView1.Rows[i].Cells[1].Value;
                handleArray[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }

            return handleArray;
        }
    }
}
