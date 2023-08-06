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
    public class Department
    {
        private int idDepartment;
        private string nameDepartment;
        ConnectionDAtaBase objConection = new ConnectionDAtaBase();
        public Department()
        {
        }

        public Department(string nameDepartment)
        {
            this.nameDepartment = nameDepartment;
        }

        public Department(int idDepartment, string nameDepartment)
        {
            this.idDepartment = idDepartment;
            this.nameDepartment = nameDepartment;
        }

        public int IdDepartment { get => idDepartment; set => idDepartment = value; }
        public string NameDepartment { get => nameDepartment; set => nameDepartment = value; }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        public bool SendDepartment(string sql)
        {
            bool t = false;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, objConection.DataSource());
                objConection.ConnectOpened();
                int i = cmd.ExecuteNonQuery();
                Console.WriteLine("Si se realizó la conexión ");
                objConection.ConnectClosed();
                if (i > -1)
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
                Console.WriteLine("ERROOOOOOR " + w.Message);
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
