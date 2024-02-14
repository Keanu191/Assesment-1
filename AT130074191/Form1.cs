/*
 * 
 * 30074191 / Keanu Farro
 * AT1 Question 9 WikiApp
 * 12/02/2024
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT130074191
{
    public partial class Form1 : Form
    {
        public static string[,] Wiki = new string[row, column]; // Global 2D String Array 9.1 

        // Define static variables for dimensions 9.1
        public static int row = 12;
        public static int column = 4;
        int arrayLength = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Store the values from the text boxes into the dataArray 9.2 data structure
            Wiki[arrayLength, 0] = name.Text.Trim();
            Wiki[arrayLength, 1] = category.Text.Trim();
            Wiki[arrayLength, 2] = structure.Text.Trim();
            Wiki[arrayLength, 3] = definition.Text.Trim();
            arrayLength++;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
