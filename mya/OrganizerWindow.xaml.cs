﻿using mya.Models;
using System;
using System.Collections.Generic;
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
using mya.Models;
using Microsoft.EntityFrameworkCore;

namespace mya
{
    /// <summary>
    /// Логика взаимодействия для OrganizerWindow.xaml
    /// </summary>
    public partial class OrganizerWindow : Window
    {
        MainContext db;
        User User { get; set; }
        public OrganizerWindow(User user)
        {
            User = user;
            db = new MainContext();
            InitializeComponent();
        }
    }
}
