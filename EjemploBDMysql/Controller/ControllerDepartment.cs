using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjemploBDMysql.model;

namespace EjemploBDMysql.Controller
{
    class ControllerDepartment
    {
        public bool SendDepartment(Department objd)
        {
            bool t ;
            string sql = "insert into departments(nameDepartment) " +
                "values('" + objd.NameDepartment + "'); ";
            t = objd.SendDepartment(sql);

            return t;
        }
    }
}
