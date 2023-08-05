using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjemploBDMysql.model;

namespace EjemploBDMysql.Controller
{
    public class ControllerEmployee
    {
        public bool SendEmployee(Employee obje)
        {
            bool t = false;
            string sql = "insert into employees(name1E,name2E,lastName1E, lastName2E, addressE, mailE, passwordE, phoneE) " +
                "values('"+ obje.Nombre1E+"', '"+obje.Nombre2E+"', '"+obje.Apellido1E+"', '"+obje.Apellido2E+"', " +
                "'"+obje.DirE1+"', '"+obje.MailE1+"', '"+obje.PassWE+"', '"+obje.TelE+"'); ";
            t = obje.SendEmployee(sql);

            return t;
        }

    }
}
