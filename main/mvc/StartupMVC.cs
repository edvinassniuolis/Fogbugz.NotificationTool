using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutePY
{
    public class StartupMVC
    {
        public static void RunStartup(User user, StartupView startupView)
        {
            UserController userController = new UserController(user, startupView);

            userController.SetUsername(user.Username);
            userController.SetEmail(user.Email);
            userController.SetPassword(user.Password);
            userController.SetViewTxtFields();
            userController.CheckLoginDetails();
        }
    }
}
