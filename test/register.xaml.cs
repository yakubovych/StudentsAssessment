using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace test
{

    public partial class register : Window
    {
        
        public User reguser;
        public register()
        {
            InitializeComponent();
        }

        private void ent(object sender, RoutedEventArgs e)
        {
            error.Text = "";
            bool errors = false;
            if (login.Text.Length < 5)
            {
                error.Visibility = Visibility.Visible;
                error.Text += "Логін має мати не менше 5 символів!\n";
                errors = true;
            }
            if (password.Password.Length < 6 || password.Password.Length > 50)
            {
                error.Text += "Пароль має мати не менше 6 символів!\n";
                errors = true;
            }
            if (password.Password != repass.Password)
            {
                error.Text += "Неправильний повтор пороля!\n";
                errors = true;          
            }
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                             @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";

            if (!Regex.IsMatch(email.Text, pattern))
            {
                error.Text += "Ви ввели не правильно пошту!\n";
                errors = true;
            }
         
            if(tel.Text.Length != 10)
            {
                error.Text += "Телефон має мати рівно 10 символів!\n";
                errors = true;
            }
            if (errors)
            {
                return;
            }
            reguser = new User();
            reguser.Login = login.Text;
            reguser.Password = password.Password;
            reguser.Email = email.Text;
            reguser.Tel = Convert.ToInt32(tel.Text);
            Close();        
        }
        private void tel_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            string inputSymbol = e.Text.ToString();

            if (!Regex.Match(inputSymbol, @"^([\d.,-]+)$").Success)
            {
                    e.Handled = true;                
            }
            
        }
    }
}
