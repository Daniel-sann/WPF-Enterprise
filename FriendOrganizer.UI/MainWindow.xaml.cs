﻿using System.Windows;
using FriendOrganizer.UI.ViewModel;

namespace FriendOrganizer.UI
{
    
    public partial class MainWindow : Window
    {
        private readonly MainViewModel _viewModel;

        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = viewModel;
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _viewModel.Load();
        }
    }
}
