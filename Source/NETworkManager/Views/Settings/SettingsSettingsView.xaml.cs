﻿using MahApps.Metro.Controls.Dialogs;
using NETworkManager.ViewModels.Settings;
using System.Windows;
using System.Windows.Controls;

namespace NETworkManager.Views.Settings
{
    public partial class SettingsSettingsView : UserControl
    {
        SettingsSettingsViewModel viewModel = new SettingsSettingsViewModel(DialogCoordinator.Instance);

        public SettingsSettingsView()
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (viewModel.CloseAction == null)
                viewModel.CloseAction = new System.Action(Window.GetWindow(this).Close);
        }
    }
}
