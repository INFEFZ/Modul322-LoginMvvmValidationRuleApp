﻿using LoginMvvmApp.Commands;
using LoginMvvmApp.Models;
using System.Windows;
using System.Windows.Input;

namespace LoginMvvmApp.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private User user;
        public ICommand LoginCommand { get; }
        public LoginViewModel()
        {
            user = new User();
            LoginCommand = new RelayCommand((param) => LoggedIn(param));
        }

        public string? UserName
        {
            get => user.UserName;
            set
            {
                user.UserName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        public string? Password
        {
            get => user.Password;
            set
            {
                user.Password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private void LoggedIn(object? parameter)
        {
            MessageBox.Show($"Logged in successfull as {parameter}");
        }
    }
}
