using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNameSpace
{
    public class User
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        private string Password {get; set; }
        public bool IsLoggedIn { get; set; }

        public bool PasswordCreated;
        public User(string name, string email)
        {
            Name = name;
            Email = email;
            IsLoggedIn = false;
        }

        public bool IsSetupComplete()
        {
            if (Name != null && Email != null && Password != null)
            {
               return true;
            }
            else
            {
                return false;
            }
        }

        public void CreatePassword(string email, string password)
        {
            if (email == Email)
            {
                Password = password;
            }

            if (Password != null)
            {
                PasswordCreated = true;
                //I had no idea how to access the confirmation variable or Password property due to it being private so my last minute work around was to create a new bool value to confirm if a password was created.
            }
        }

        public string LogIn(string password)
        {
            if (password == Password)
            {
                IsLoggedIn = true;
                return "Logged In";
            }
            return "Not Logged In";
        }

        public void LogOut()
        {
            IsLoggedIn = false;
        }
    }
}
