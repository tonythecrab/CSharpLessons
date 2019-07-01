using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class UserArray
    {
        public User[] Array { get; set; }

        public void ArrayExtention(User[] users, User _user)
        {
            if (users == null)
            {
                User[] tempArray = new User[1] { _user };
                Array = tempArray;
            }
            else { 
                User[] tempArray = new User[users.Length + 1];
                for (int i = 0; i < users.Length; i++)
                {   //копирование существующих пользователей
                    tempArray[i].Name = users[i].Name;
                    tempArray[i].Password = users[i].Password;
                    tempArray[i].Email = users[i].Email;
                    tempArray[i].LastLogin = users[i].LastLogin;
                }   //Добавление нового пользователя
                tempArray[tempArray.Length].Name = _user.Name;
                tempArray[tempArray.Length].Password = _user.Password;
                tempArray[tempArray.Length].Email = _user.Email;
                tempArray[tempArray.Length].LastLogin = _user.LastLogin;

                Array = tempArray;
            }
        }

    }
}
