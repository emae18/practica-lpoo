using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UserController
    {
        public void InsertUser(User oUser)
        {
            using (db_agencyEntities db = new db_agencyEntities() )
            {
                db.Users.Add(oUser);
                db.SaveChanges();
            }
        }

        public void UpdateUser(User oUser)
        {
            using(db_agencyEntities db = new db_agencyEntities())
            {
                User res = db.Users.Find(oUser.idUser);

                res.loginName = oUser.loginName;
                res.password = oUser.password;
                res.firstName = oUser.firstName;
                res.lastName = oUser.lastName;
                res.age = oUser.age;
                res.role = oUser.role;
                db.SaveChanges();
            }
        }

        public void RemoveUser(int id)
        {
            using (  db_agencyEntities db = new db_agencyEntities())
            {
                User res = db.Users.Find(id);
                db.Users.Remove(res);
                db.SaveChanges();
            }
        }

        public List<User> GetUsers()
        {
            using(db_agencyEntities db=new db_agencyEntities())
            {
                return db.Users.ToList();
            }
        }
    }
}
