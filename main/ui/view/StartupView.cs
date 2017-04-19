using System;
using System.Windows.Forms;

namespace ExecutePY
{
    /// <summary>
    /// Project startup form
    /// </summary>
    public partial class StartupView : Form
    {
        #region Constructors
        public StartupView()
        {
            InitializeComponent();
        }

        //what is this?
        public StartupView(string password)
        {
            InitializeComponent();
            SaveChanges();
        }
        #endregion

        #region Events
        private void loginButton_Click(object sender, EventArgs e)
        {
            User user = new User(usernameTxtField.Text, emailTxtField.Text, psswTxtField.Text);
            StartupMVC.RunStartup(user, this);
        }

        private void StartupForm_Load(object sender, EventArgs e)
        {
            usernameTxtField.Text = Properties.Settings.Default.username;
            emailTxtField.Text = Properties.Settings.Default.email;
            psswTxtField.Text = Properties.Settings.Default.password;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            SaveChanges();
            Environment.Exit(0);
        }
        #endregion

        #region Methods
        public void RunMainView(User user)
        {
            MainView mainBox = new MainView(user);
            SplashScreenView splashScreen = new SplashScreenView(mainBox);

            SaveChanges();

            this.Hide();
            splashScreen.Show();
        }
        private void SaveChanges()
        {
            Properties.Settings.Default.username = usernameTxtField.Text;
            Properties.Settings.Default.email = emailTxtField.Text;
            Properties.Settings.Default.password = psswTxtField.Text;
            Properties.Settings.Default.Save();
        }
        public void PrintMessage(string message)
        {
            MessageBox.Show(message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void SetUsernameTxtField(string text)
        {
            usernameTxtField.Text = text;
        }
        public void SetEmailtxtField(string text)
        {
            emailTxtField.Text = text;
        }
        public void SetPsswTxtField(string text)
        {
            psswTxtField.Text = text;
        }
        #endregion
    }
}
