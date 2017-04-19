using System;
using System.Net.Mail;

namespace ExecutePY
{
    public class UserController
    {
        private User user;
        private StartupView startupView;

        public UserController(User user, StartupView startupView)
        {
            this.user = user;
            this.startupView = startupView;
        }

        #region User Properties
        public void SetUsername(string username)
        {
            user.Username = @"""" + username + @"""";
        }
        public string GetUsername()
        {
            return user.Username.Replace(@"""", "");
        }
        public void SetEmail(string email)
        {
            try
            {
                MailAddress m;

                if (email != "")
                    m = new MailAddress(email);
                user.Email = email;
            }
            catch (FormatException ex)
            {
                startupView.PrintMessage(ex.ToString());
            }
        }
        public string GetEmail()
        {
            return user.Email;
        }
        public void SetPassword(string password)
        {
            user.Password = password;
        }
        public string GetPassword()
        {
            return user.Password;
        }
        #endregion

        #region User methods
        public void SetViewTxtFields()
        {
            startupView.SetUsernameTxtField(GetUsername());
            startupView.SetEmailtxtField(GetEmail());
            startupView.SetPsswTxtField(GetPassword());
        }

        #region Check Login
        private bool CheckUsernameDetails()
        {
            if (GetUsername() == "")
            {
                startupView.PrintMessage("Please enter username details");
                return false;
            }
            else
                return true;
        }
        private bool CheckEmailDetails()
        {
            if (GetEmail() == "")
            {
                startupView.PrintMessage("Please enter email details");
                return false;
            }
            else
                return true;
        }
        private bool CheckPasswordDetails()
        {
            if (GetPassword() == "")
            {
                startupView.PrintMessage("Please enter password details");
                return false;
            }
            else
                return true;
        }

        public void CheckLoginDetails()
        {
            if (CheckUsernameDetails() != false &&
                CheckEmailDetails() != false &&
                CheckPasswordDetails() != false)
            {
                startupView.RunMainView(user);
            }
        }
        #endregion

        #endregion
    }
}
