using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Users
    {
        public string name;
        public string email;
        public int age;
        public string password;
        public Admin administrator = new Admin();

        public Users()
        {
            name = "none";
            email = "info@mail.ru";
            age = 0;
            password = "pass";
        }

        public Users(string _email, string _pass)
        {
            email = _email;
            password = _pass;
        }

        public void SetAll(string _name, string _email, int _age, string _pass)
        {
            name = _name;
            email = _email;
            age = _age;
            password = _pass;
        }

        public void PrintAll()
        {
            Console.WriteLine($"name = {name} email = {email} age = {age} password = {password} role = {administrator.role}");
        }

        public void SetRole(string _role)
        {
            administrator.role = _role;
        }
    }
}
