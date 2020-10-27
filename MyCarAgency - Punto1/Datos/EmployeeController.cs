using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class EmployeeController
    {
        public void InsertEmployee(Employee oEmployee)
        {
        }

        public void UpdateUser(Employee oEmployee)
        {            
        }

        public void RemoveUser(int id)
        {           
        }

        public List<Employee> GetUsers()
        {
            using (db_agencyEntities db = new db_agencyEntities())
            {
                return db.Employees.ToList();
            }
        }
    }
}
