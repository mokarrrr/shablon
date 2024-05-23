using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using mya.Models;

namespace mya
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainContext db = new MainContext();
            List<Event> Events = db.Events.ToList();
            name.ItemsSource = Events;
        }

        private void DeleteButtonClick(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn.Tag is int id)
            {
                using (var dbContext = new MainContext())
                {
                    // Поиск записи по идентификатору id
                    var recordToDelete = dbContext.Events.FirstOrDefault(r => r.Id == id);

                    if (recordToDelete != null)
                    {
                        // Удаление записи из базы данных
                        dbContext.Events.Remove(recordToDelete);
                        dbContext.SaveChanges();

                        // Обновление отображения (примерно, перезагрузка данных)
                         // Предполагается, что это обновляет отображаемые элементы
                    }
                    else
                    {
                        MessageBox.Show($"Запись с идентификатором {id} не найдена.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }


        private void NewService_click (object sender, RoutedEventArgs e)
        {
            NewUsluga usluga = new NewUsluga();
            usluga.Show();
        }

        private void aut_Click(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
        }
    }
}
