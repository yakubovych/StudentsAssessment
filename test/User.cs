namespace test
{
    public class User
    {
        public int Id { get; set; }
        private string login;
        private string password;
        private string email;
        private int tel;
        public string Login
        {
            get { return login; }
            set
            {
                login = value;
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }
        public int Tel
        {
            get { return tel; }
            set
            {
                tel = value;
            }
        }
    }

}
