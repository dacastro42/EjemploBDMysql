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

namespace EjemploBDMysql.Vista
{
    public partial class UIDepartment : Form
    {
        public UIDepartment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameD = textBox1.Text;
            Department objD = new Department(nameD);
            ControllerDepartment objCD = new ControllerDepartment();
            bool t = objCD.SendDepartment(objD);

            if (t)
            {
                MessageBox.Show("Si se registro el Departamento");
            }
            else
            {
                MessageBox.Show("No se registro el Departemento");
            }
        }
    }
}
