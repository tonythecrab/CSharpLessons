using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Validator : IValidator   ////Ошибка?????
    {
        public void ValidateUser(IUser user) { }
        public void ValidateUser(User user, UserArray users)
        {
            
            for (int i = 0; i < users.Array.Length; i++)
            {
                    if (
                           (users.Array[i].Name == user.Name && users.Array[i].Password == user.Password)
                           || (users.Array[i].Email == user.Email && users.Array[i].Password == user.Password))
                    {
                    user.GetFullInfo(user);
                    //Обновлени времени входа пользователя   
                    users.Array[i].LastLogin = DateTime.Now;
                    }
                    

            }
        }
    }

}
