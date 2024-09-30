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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            long a;
            a = long.Parse(textBox2.Text);


            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            long a;
            a = long.Parse(textBox2.Text);

            
           
            
            if (textBox2.Text==""||textBox2.TextLength < 14 || textBox2.TextLength >14)
            {
                throw new Exception("sorry,The Maxlength 14 Number...!");
                
                
            }


            object [] data = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, dateTimePicker1.Text };
            
            dataGridView1.Rows.Add(data);

            







        }

        private void button3_Click(object sender, EventArgs e)
        {



            
            
           

           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditorAttribute ah= new EditorAttribute();
           dataGridView1 = new DataGridView();
           dataGridView1.Update();
            
        }
    }
}
