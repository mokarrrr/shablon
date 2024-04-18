using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

using mya.Models;
using Microsoft.Extensions.Logging;

namespace mya
{
    /// <summary>
    /// Логика взаимодействия для NewUsluga.xaml
    /// </summary>
    public partial class NewUsluga : Window
    {
        MainContext db;
        public NewUsluga()
        {
            InitializeComponent();
            db = new MainContext();
        }
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            //List<string> errors = new List<string>();

            //if (String.IsNullOrEmpty(Name.Text))
            //    errors.Add("Имя не указано");

            //if (String.IsNullOrEmpty(Surname.Text))
            //    errors.Add("Фамилия не указана");

            //if (String.IsNullOrEmpty(Email.Text))
            //    errors.Add("Email не указан");
            //else if (!Email.Text.Contains("@"))
            //    errors.Add("Некорректный формат Email");


            //if (String.IsNullOrEmpty(Phonenumber.Text))
            //    errors.Add("Номер телефона не указан");
            //else if (new Regex(@"\D").IsMatch(Phonenumber.Text))
            //    errors.Add("Номер телефона должен содержать только цифры");
            //else if (Phonenumber.Text.Length < 9)
            //    errors.Add("Номер телефона должен содержать не менее 9 символов");
            //else if (Phonenumber.Text.All(c => c == '0'))
            //    errors.Add("Номер телефона не может состоять только из нулей");

            //if (Gender.SelectedItem == null)
            //    errors.Add("Пол не выбран");


            //if (String.IsNullOrEmpty(Password.Password))
            //    errors.Add("Пароль не указан");
            //else if (Password.Password.Length < 6)
            //    errors.Add("Пароль должен содержать не менее 6 символов");
            //else if (!Password.Password.Any(char.IsUpper))
            //    errors.Add("Пароль должен содержать хотя бы одну заглавную букву");
            //else if (!Password.Password.Any(char.IsLower))
            //    errors.Add("Пароль должен содержать хотя бы одну строчную букву");
            //else if (!Password.Password.Any(ch => !char.IsLetterOrDigit(ch)))
            //    errors.Add("Пароль должен содержать хотя бы один специальный символ");

            //if (String.IsNullOrEmpty(PasswordCheck.Password))
            //    errors.Add("Подтверждение пароля не указано");

            //if (Password.Password != PasswordCheck.Password)
            //    errors.Add("Пароли не совпадают");

            //if (Country.SelectedItem == null)
            //    errors.Add("Страна не выбрана");


            //if (Birthday.SelectedDate == null)
            //    errors.Add("Дата рождения не выбрана");

            //if (!Regex.IsMatch(Email.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            //    errors.Add("Поле имейл должно содержать только английские буквы и соответствовать формату");


            //string[] allowedEndings = { ".com", ".ru", ".net", ".org", ".edu", ".gov", ".info", ".biz", ".us" }; // Добавлены дополнительные окончания
            //bool validEnding = false;
            //foreach (string ending in allowedEndings)
            //{
            //    if (Email.Text.EndsWith(ending))
            //    {
            //        validEnding = true;
            //        break;
            //    }
            //}
            //if (!validEnding)
            //{
            //    errors.Add("Поле имейл должно оканчиваться на одно из распространенных окончаний: .com, .ru, .net, .org, .edu, .gov, .info, .biz, .us");
            //}

            //if (errors.Count > 0)
            //{
            //    string errorMessage = "Обнаружены следующие ошибки:\n\n";
            //    errorMessage += string.Join("\n", errors);
            //    MessageBox.Show(errorMessage);
            //}
            //else
            //{               
            Event _event = new Event
            {
                    Name = Name.Text,
                    //Surname = Surname.Text,
                    //Email = Email.Text,
                    //Patronimic = Patronimic.Text,
                    //Birthday = (DateTime)Birthday.SelectedDate,
                    //Password = Password.Password,
                    //Photo = _photo,
                    //Role = userRole,
                    //Country = Country.SelectedValue as Country,
                    //Gender = (char)Gender.SelectedValue,
                    //Phone = Phonenumber.Text
                };

                db.Events.Add(_event);
                MessageBox.Show(" добален");
                this.Close();

                db.SaveChanges();
            //}
        }
    }
}
