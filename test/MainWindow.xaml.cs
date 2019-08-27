using System;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Windows;

namespace test
{

    public partial class MainWindow : Window
    {
        ObservableCollection<Student> students;
        ApplicationContext db = new ApplicationContext();

        public MainWindow()
        {
            db.Students.Load();
            db.Students.Local.ToBindingList();
            Students = db.Students.Local;
            InitializeComponent();

        }

        public ObservableCollection<Student> Students
        {
            get { return students; }
            set
            {
                students = value;
            }
        }

        private void ex_Click(object sender, RoutedEventArgs e)
        {
            enter enter = new enter();
            Close();
            enter.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tit.Visibility = Visibility.Hidden;
            qw.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lab.Visibility = Visibility.Visible;
            tit.Visibility = Visibility.Hidden;
            qq.Visibility = Visibility.Visible;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            lab.Visibility = Visibility.Hidden;
            tit.Visibility = Visibility.Visible;
            qw.Visibility = Visibility.Hidden;
            qq.Visibility = Visibility.Hidden;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Student std = new Student();
            std.Name = pibstudent.Text;
            std.Specials = speccombo.Text;
            std.Absent = Convert.ToInt32(absent.Text);
            std.Avgmark = Convert.ToDouble(avgmark.Text);
            std.Year = Convert.ToInt32(year.Text);
            Students.Add(std);
            db.SaveChanges();
        }

        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {
            if (pibstudent2.Text == null)
            {
                return;
            }
            else
            {
                foreach (var s in Students)
                {
                    if (s.Name == pibstudent2.Text)
                    {
                        tsearch.Visibility = Visibility.Visible;
                        lsearch.Visibility = Visibility.Visible;
                        speccombo2.Text = s.Specials;
                        absent2.Text = s.Absent.ToString();
                        avgmark2.Text = s.Avgmark.ToString();
                        year2.Text = s.Year.ToString();
                        tsearch.Height = lsearch.Height;
                    }
                }
            }
        }
    }
}