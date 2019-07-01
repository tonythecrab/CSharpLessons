using System;


namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string pass;
            string email;
            UserArray UsersDatabase = new UserArray();
            while (true)
            {

                name = Console.ReadLine();
                Console.WriteLine("Введите Имя");
                pass = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                email = Console.ReadLine();
                Console.WriteLine("Введите электронную почту");
                if ((name != "exit" && pass != "exit") && email != "exit")
                {
                    var user = new User(name, pass, email);
                    if (UsersDatabase.Array != null)
                    {
                        new Validator().ValidateUser(user, UsersDatabase);
                    }
                    UsersDatabase.ArrayExtention(UsersDatabase.Array, user);
                } else break;

            } 
        }
    }
}
