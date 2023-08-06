using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjemploBDMysql.model;
using EjemploBDMysql.Controller;

namespace EjemploBDMysql
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nombre1E = textBox1.Text;
            string nombre2E = textBox2.Text;
            string apellido1E = textBox3.Text;
            string apellido2E = textBox4.Text;
            string dirE = textBox5.Text;
            string mailE = textBox6.Text;
            string passWE = textBox7.Text;
            string TelE = textBox8.Text;
            Employee objE = new Employee(nombre1E, nombre2E, apellido1E, apellido2E, dirE, mailE, passWE, TelE);
            ControllerEmployee objCE = new ControllerEmployee();
            bool t = objCE.SendEmployee(objE);
            if (t)
            {
                MessageBox.Show("Si se registro el empleado");
            }
            else
            {
                MessageBox.Show("No se registro el empleado");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
