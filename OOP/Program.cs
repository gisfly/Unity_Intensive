using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Users anonymous = new Users();
            Console.WriteLine($"name = {anonymous.name}\nemail = {anonymous.email}\nage = {anonymous.age}\npassword = {anonymous.password}\n");
            
            Users Ilya = new Users("admin@mail.ru", "test123");
            anonymous.SetAll("anon", "admin@mail.ru", 25, "test");

            Ilya.PrintAll();
            anonymous.PrintAll();

            Users alex = new Users();
            alex.name = "Алексей";
            alex.email = "alex@mail.ru";
            alex.age = 45;
            alex.SetRole("Модератор");

            Users bob = new Users();
            bob.name = "Боб";
            bob.email = "bob@mail.ru";
            bob.age = 20;
            bob.SetRole("Редактор");

            Users admin = new Users();
            admin.name = "Боб";
            admin.email = "admin@mail.ru";
            admin.age = 30;
            admin.administrator.role = "Админ";
            admin.PrintAll();
            bob.PrintAll();
            Console.WriteLine(alex.administrator.role);
            Console.ReadKey();
            
        }
    }
}
