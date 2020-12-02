using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter archivo = new StreamWriter("productos.txt");
            for(int f=0;f<dataGridView1.Rows.Count-1;f++)
            {
                archivo.WriteLine(dataGridView1.Rows[f].Cells[0].Value.ToString());
                archivo.WriteLine(dataGridView1.Rows[f].Cells[1].Value.ToString());
                archivo.WriteLine(dataGridView1.Rows[f].Cells[2].Value.ToString());
            }
            archivo.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("productos.txt"))
            {
                StreamReader archivo = new StreamReader("productos.txt");
                while(!archivo.EndOfStream)
                {
                    string linea1 = archivo.ReadLine();
                    string linea2 = archivo.ReadLine();
                    string linea3 = archivo.ReadLine();
                    dataGridView1.Rows.Add(linea1, linea2, linea3);
                }
                archivo.Close();
            }
        }
    }
}
