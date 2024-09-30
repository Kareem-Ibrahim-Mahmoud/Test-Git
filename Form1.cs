using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_app_project_super
{
    public partial class Form1 : Form
    {
        public string massagee = @"The Null Mali , Plase Enter Email and @gmail And The Password...";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form form = new Form();
            //form.ShowDialog();  
            if(!textBox1.Text.Contains('@'))
            {
                //Form form = new Form();
                //form.ShowDialog();
                throw new Exception(massagee);

            }


            Form2 form2 = new Form2(); 
            form2.ShowDialog();
            Form1 form1 = new Form1();  

             




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
          

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
