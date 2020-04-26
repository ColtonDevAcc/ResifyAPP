using System;
namespace Resify.Models
{ 

    public class UserDetails
    {
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;

        public string FirstName { get { return _firstName; } set {_firstName = FirstName; } }
        public string LastName { get; set; }

        void UserInfo()
        {
            
        }
    }
}
