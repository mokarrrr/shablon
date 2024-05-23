using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.EntityFrameworkCore;
using mya.Models;

namespace mya
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        MainContext db;
        public Authorization()
        {
            db = new MainContext();
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(PasswordText.Password) || String.IsNullOrEmpty(IdText.Text)
                || !int.TryParse(IdText.Text, out int x))
            {
                
                MessageBox.Show("Не все поля заполнены");
                return;
            }
            if (!db.Users.Any(u => u.Id == Convert.ToInt32(IdText.Text) && u.Password == PasswordText.Password))
            {
                MessageBox.Show("Пользователя с такими данными не существует");

                return;
            }
            User user = db.Users.Include(u => u.Role).Where(u => u.Id == Convert.ToInt32(IdText.Text) && u.Password == PasswordText.Password).FirstOrDefault();
            UserWindow win = new UserWindow(user);

            switch (user.Role.Id)
            {
                case 1:
                    UserWindow usrwin = new UserWindow(user);
                    usrwin.Show();
                    break;
                case 2:
                    win.Show();
                    break;
                case 3:
                    OrganizerWindow OrgWin = new OrganizerWindow(user);
                    OrgWin.Show();
                    break;
                case 4:
                    win.Show();
                    break;
            }
            
            this.Close();
        }
    }
}
