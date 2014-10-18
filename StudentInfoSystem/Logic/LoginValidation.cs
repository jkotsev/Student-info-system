using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInfoSystem.Data;

namespace StudentInfoSystem.Logic

{
    class LoginValidation
    {
        private string _username;
        private string _password;
        public string errText { get; private set; }
        public LoginValidation(string username, string pass)
       
        {
            _username = username;
            _password = pass;
            errText = string.Empty;
        }

        //public string errText { get; private set; }

        private bool isEmpty (String s)
        {
            return s.Equals(String.Empty);
        }
        private bool isShorterThan(String s, int minLen)
        {
            if (s.Length < minLen)
                return true;
            else
                return false;
        }
        public bool ValidateUserInput(out User user)
        {


            User queryResult = UserData.IsUserPassCorrect(_username, _password);
            // returns the user role
            if (queryResult == null)
            {
                errText += "Въвели сте грешно потребителско име или парола!";
                user = null;
                return false;
            }
            if (isEmpty(_username) || isEmpty(_password))
            {
                errText = "Полетата не могат да са празни.";
                user = null;
                return false;
            }
            else if (isShorterThan(_username, 4) || isShorterThan(_password, 4))
            {
                errText = "Полетата не могат да са по кратки от 4 символа.";
                user = null;
                return false;
            }
            else
                user = queryResult;
            return true;
        }
    }
}







//        private bool IsShorterThen (string S, int Z)
//        {
//            if (S.Length < Z)
//            {
//                return true;
//            }
//            else 
//            {
//                return false;
//            } 
//        }
//            private bool IsEmpty (string B)
//            {
//                if (B.Length < 0)
//            {
//                 return true;
//            }
//                else
//                {
//                    return false;
//                }
//            }
//            public bool ValidateUserInput(out UserStatus user) 
//            {
//                if (IsEmpty(_username))
//                {
//                    return false;
//                }
//                {
//                    if (IsEmpty(_password))
//                    {
//                        return false;
//                    }

//                    {
//                        if (IsShorterThen(_username, 6))
//                        {
//                            return false;
//                        }

//                        {
//                            if (IsShorterThen(_password, 6))
//                            {
//                                return false;
//                            }
//                        }


//                    }
//                }
//                return true;
//            }
//    }
//}
