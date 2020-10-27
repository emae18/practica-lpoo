using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class UserModel
    {
        public void AltaUsuario(
            string loginName, string password, string firstname,
            string lastname, int age,string role
            )
        {
            User oUser = new User();
            oUser.loginName = loginName;
            oUser.password = password;
            oUser.lastName = lastname;
            oUser.firstName = firstname;
            oUser.age = age;
            oUser.role = role;
            UserController userController = new UserController();
            userController.InsertUser(oUser);
        }

        public void ModificarUsuario(int id,string loginName, string password, string firstname,
            string lastname, int age, string role)
        {
            User oUser = new User();
            oUser.idUser = id;
            oUser.loginName = loginName;
            oUser.password = password;
            oUser.lastName = lastname;
            oUser.firstName = firstname;
            oUser.age = age;
            oUser.role = role;
            UserController userController = new UserController();
            userController.UpdateUser(oUser);
        }

        public void EliminarUsuario(int id)
        {
            UserController userController = new UserController();
            userController.RemoveUser(id);
        }

        public List<User> ListarUsuarios()
        {
            UserController userController = new UserController();
            return userController.GetUsers();
        }

    }
}
