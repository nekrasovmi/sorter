using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
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
        Ascending,
        Descending
    }
    public partial class SorterForm : Form
    {
        
        //public int[] myarray;
        static public minmaxcount test;
        private static Random rand = new Random();
        private int[] originArr;
        Form2 pForm = new Form2();
        Form3 hIForm = new Form3();
        //int[] myArray;
        private BufferedGraphics buff;
        SortDirection dir = SortDirection.Ascending;
        //BufferedGraphics buff = BufferedGraphicsManager.Current.Allocate(pictureBox1.CreateGraphics(), pictureBox1.DisplayRectangle);
        

        sortedMethods sm = new sortedMethods();
        
        public SorterForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            buff = BufferedGraphicsManager.Current.Allocate(pictureBox1.CreateGraphics(), pictureBox1.DisplayRectangle);
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
            pForm.Owner = this;
            pForm.ShowDialog();
            //Console.WriteLine(md.min + " " + md.max + " " + md.count);
            //frm2. 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //drawArray(originArr);
            /*//myArray = generateArrayRandom(test.count, test.min, test.max);
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

        private void drawArray(int[] array)
        {
            Pen pen = new Pen(Color.OrangeRed);
            SolidBrush sb = new SolidBrush(pen.Color);
            //Graphics graphics = pictureBox1.CreateGraphics();
            //graphics.Clear(Color.Black);
            buff.Graphics.Clear(Color.Black);
            int deltaW = pictureBox1.Width / array.Length;
            int deltaH = pictureBox1.Height / array.Max();

            for (int i = 0; i < array.Length; i++)
            {
                //graphics.FillRectangle(sb, i * deltaW, pictureBox1.Height - (array[i] * deltaH), deltaW, array[i] * deltaH);
                buff.Graphics.FillRectangle(sb, i * deltaW, pictureBox1.Height - (array[i] * deltaH), deltaW, array[i] * deltaH);
                //buff.Render();
            }
            
            /*pen = new Pen(Color.DarkGreen);
            for (int i = 0; i < pictureBox1.Width; i += deltaW)
            {
                graphics.DrawLine(pen, i, 0, i, pictureBox1.Width);
            }
            for (int i = 0; i < pictureBox1.Width; i += deltaH)
            {
                //graphics.DrawLine(pen, 0, pictureBox1.Height - i, pictureBox1.Width, pictureBox1.Height - i);
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton12.Checked)
            {
                dir = SortDirection.Ascending;
                //SortDirection dir = SortDirection.Ascending;
            }
            if (radioButton11.Checked)
            {
                dir = SortDirection.Descending;
            }
            
                /////Сортировка пузырем
                //SortDirection dir = SortDirection.Ascending;
                //Console.WriteLine(dir);
            buff.Graphics.Clear(Color.Black);
            int n = originArr.Length;
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n-i-1; j++)
                {
                    bool needSwap = dir == SortDirection.Ascending
                        ? originArr[j] > originArr[j + 1]
                        : originArr[j] < originArr[j + 1];

                    //if (originArr[j] > originArr[j+1])

                    if (needSwap)
                    {
                        int temp = originArr[j];
                        originArr[j] = originArr[j + 1];
                        originArr[j+1] = temp;
                        drawArray(originArr);
                        buff.Render();
                        Thread.Sleep(1);                        
                    }                    
                }                
            }            
            richTextBox1.AppendText("\nОтсортированный массив:\n" + string.Join(" ", originArr));
            

            //////Сортировка шейкером
            /*
            buff.Graphics.Clear(Color.Black);
            //int[] test = { 27, 3, 30, 8 };
            //int n = test.Length;
            int n = originArr.Length;
            int start = 0;
            int end = n -1 ;
            bool swapped;

            do
            {
                swapped = false;
                for (int i = start; i < end; i++)
                {
                    if (originArr[i] > originArr[i + 1])
                    {
                        SwapElements(originArr, i, i+1);
                        //int temp = originArr[i];
                        //originArr[i] = originArr[i + 1];
                        //originArr[i + 1] = temp;
                        swapped = true;

                        //richTextBox1.AppendText("\nswap++\n");
                        drawArray(originArr);
                        buff.Render();
                        Thread.Sleep(1);

                    }
                }
                end--;

                swapped = false;
                for (int i = end; i >= start; i--)
                    {
                        if (originArr[i] > originArr[i + 1])
                        {
                            SwapElements(originArr, i, i+1);
                            //int temp = originArr[i];
                            //originArr[i] = originArr[i + 1];
                            //originArr[i + 1] = temp;
                            swapped = true;
                            //richTextBox1.AppendText("\nswap--\n");
                            drawArray(originArr);
                            buff.Render();
                            Thread.Sleep(1);
                            
                        }
                    }
                start++;

            } while (swapped && start <= end);
            richTextBox1.AppendText("\nОтсортированный массив:\n" + string.Join(" ", originArr));
            */

            /*
            /////////Сортировка вставками
            buff.Graphics.Clear(Color.Black);
            //int[] test = { 27, 3, 30, 8 };
            int n = originArr.Length;
            //int start = 0;
            //int end = n;
            //bool swapped;

            for (int i = 1; i < n; i++)
            {
                int current = originArr[i];
                int j = i - 1;
                while (j >= 0 && originArr[j] > current)
                {
                    originArr[j + 1] = originArr[j];
                    j--;
                    drawArray(originArr);
                    buff.Render();
                    Thread.Sleep(1);
                }
                originArr[j + 1] = current;
                drawArray(originArr);
                buff.Render();
                Thread.Sleep(1);
            }
            //richTextBox1.AppendText("\nОтсортированный массив:\n" + string.Join(" ", originArr));
            

            /////////Сортировка Бого
            buff.Graphics.Clear(Color.Black);
            int attemps = 0;

            while (!ArrayIsSorted(originArr))
            {

                Shuffle(originArr);
                attemps++;
                drawArray(originArr);
                buff.Render();
                Thread.Sleep(1);                
            }
            richTextBox1.AppendText("\nОтсортированный массив:\n" + string.Join(" ", originArr));
            */
        }

        private bool ArrayIsSorted(int[] array)
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                if(array[i] > array[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        private void Shuffle(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                int randomIndex = rand.Next(i, array.Length);
                SwapElements(array, i, randomIndex);
            }
        }

        private void SwapElements(int[] array, int currentIndex, int nextIndex)
        {
            int temp = array[currentIndex];
            array[currentIndex] = array[nextIndex];
            array[nextIndex] = temp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton8.Checked){
                hIForm.Owner = this;
                hIForm.ShowDialog();
                originArr = hIForm.GetArray();
                richTextBox1.Text = "Массив:\n" + string.Join(" ", originArr);
                drawArray(originArr);
                buff.Render();
            }
            if (radioButton7.Checked)
            {
                pForm.Owner = this;
                pForm.ShowDialog();
                originArr = pForm.GetArray();
                richTextBox1.Text = "Массив:\n" + string.Join(" ", originArr);
                drawArray(originArr);
                buff.Render();
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
                    drawArray(originArr);
                    buff.Render();
                }
            }           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            //buff = BufferedGraphicsManager.Current.Allocate(pictureBox1.CreateGraphics(), pictureBox1.DisplayRectangle);
            //pictureBox1
            originArr = generateArrayRandom(rand.Next(20, 70), 1, 70);
            richTextBox1.Text = "Массив:\n" + string.Join(" ", originArr);
            
            drawArray(originArr);
            buff.Render();
            //rand.Next(2, 20);
            //Console.WriteLine(radioButton6.Checked)
            //Console.WriteLine(radioButton6.Checked);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //buff.Render();
            /*
            buff = e.Graphics;
            buff.Graphics.FillRectangle(sb, i * deltaW, pictureBox1.Height - (array[i] * deltaH), deltaW, array[i] * deltaH);
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {            
            pictureBox2.Image = Properties.Resources.Ascending;            
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Descending;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.bubbles;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.shaker;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.insert;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.bogo;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
