using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Windows;


namespace test
{
    public partial class enter : Window
    {
        ObservableCollection<User> users;
        ApplicationContext db = new ApplicationContext();
        public enter()
        {
            db.Users.Load();
            db.Users.Local.ToBindingList();
            Users = db.Users.Local;
            InitializeComponent();
        }
        public ObservableCollection<User> Users
        {
            get { return users; }
            set
            {
                users = value;
            }
        }
        private void regist(object sender, RoutedEventArgs e)
        {
            this.Hide();
            register register = new register();
            if (register.ShowDialog() == false)
            {             
                if(register.reguser == null)
                {

                }
                else
                {
                    db.Users.Local.Add(register.reguser);
                    db.SaveChanges();
                }
            }
            this.Show();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool isConnected = false;
            foreach (var u in users)
            {
                if (u.Login == login.Text && u.Password == password.Password)
                {
                    isConnected = true;
                }

            }
            if (isConnected)
            {
                MainWindow MainWindow = new MainWindow();
                Close();
                MainWindow.ShowDialog();
            }
            else
            { MessageBox.Show("Логін або пароль введений неправильно!");
            }
        }
    }
}
