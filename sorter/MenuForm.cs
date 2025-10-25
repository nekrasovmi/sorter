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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();            
        }

        SorterForm frm1 = new SorterForm();

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Click");
            //var frm2 = new Form2();
            //frm2.Show();
            //Form2.
            //this.Hide();
        }
        
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Text = "<<Дихотомия>>";            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = System.Drawing.Color.NavajoWhite;
            this.button1.Text = "Дихотомия";            
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.Text = "<<Золотое сечение>>";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.BackColor = System.Drawing.Color.NavajoWhite;
            this.button2.Text = "Золотое сечение";
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            this.button3.BackColor = System.Drawing.Color.LightGreen;
            this.button3.Text = "<<Интеграл>>";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.BackColor = System.Drawing.Color.NavajoWhite;
            this.button3.Text = "Интеграл";
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            this.button4.BackColor = System.Drawing.Color.LightGreen;
            this.button4.Text = "<<Сортировка>>";
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            this.button4.BackColor = System.Drawing.Color.NavajoWhite;
            this.button4.Text = "Сортировка";
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            this.button5.BackColor = System.Drawing.Color.Salmon;
            this.button5.Text = "<<Выход>>";
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            this.button5.BackColor = System.Drawing.Color.Pink;
            this.button5.Text = "Выход";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm1.Show();
            this.Hide();
        }
    }
}
