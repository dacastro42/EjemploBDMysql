using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EjemploBDMysql.model
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class Employee
    {
        private string nombre1E;
        private string nombre2E;
        private string apellido1E;

       

        private string apellido2E;
        private string DirE;
        private string MailE;
        private string passWE;
        private string telE;
        ConnectionDAtaBase objConection = new ConnectionDAtaBase();
        public Employee()
        {
        }
        public Employee(string nombre1E, string nombre2E, string apellido1E, string apellido2E, string dirE, string mailE, string passWE, string telE)
        {
            this.nombre1E = nombre1E;
            this.nombre2E = nombre2E;
            this.apellido1E = apellido1E;
            this.apellido2E = apellido2E;
            DirE = dirE;
            MailE = mailE;
            this.passWE = passWE;
            this.telE = telE;
        }

        public string Nombre1E { get => nombre1E; set => nombre1E = value; }
        public string Nombre2E { get => nombre2E; set => nombre2E = value; }
        public string Apellido1E { get => apellido1E; set => apellido1E = value; }
        public string Apellido2E { get => apellido2E; set => apellido2E = value; }
        public string DirE1 { get => DirE; set => DirE = value; }
        public string MailE1 { get => MailE; set => MailE = value; }
        public string PassWE { get => passWE; set => passWE = value; }
        public string TelE { get => telE; set => telE = value; }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
        public bool SendEmployee(string sql)
        {
            // throw new NotImplementedException();
            bool t = false;
            
            try
            {
                

                MySqlCommand cmd = new MySqlCommand(sql, objConection.DataSource());
                objConection.ConnectOpened();
                int i = cmd.ExecuteNonQuery();
                Console.WriteLine("Si se realizó la coneción ");
                objConection.ConnectClosed();
                if (i>-1)
                {
                    t = true;
                }
                else
                {
                    t = false;
                }
            }
            catch (Exception w)
            {
                Console.WriteLine("ERROOOOOOR "+ w.Message);
                objConection.ConnectClosed();
            }
            finally
            {
                objConection.ConnectClosed();
            }

            return t;
        }
    }
}
