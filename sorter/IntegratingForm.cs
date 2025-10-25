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
    public partial class IntegratingForm : Form
    {        
        public IntegratingForm()
        {
            InitializeComponent();
            Icon = Properties.Resources.integralico;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Close();
            //MenuForm.Instance.Show();            
        }
    }
}
