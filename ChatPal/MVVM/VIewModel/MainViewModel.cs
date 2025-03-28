﻿using ChatPal.Core;
using ChatPal.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChatPal.MVVM.VIewModel
{
    public class MainViewModel : ObservableObject
    {
        public RelayCommand LoginViewCommand { get; set; }
        public RelayCommand SigninViewCommand {  get; set; }
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand ConnectToServerCommand { get; set; }
        public LoginViewModel loginVM { get; set; }
        public SigninViewModel signinVM { get; set; }
        public HomeViewModel homeVM { get; set; }
        public string Msg { get; set; }
        private object _currentView;
        private Server _server;

        public object currentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            _server = new Server();
            loginVM = new LoginViewModel();
            signinVM = new SigninViewModel();
            homeVM = new HomeViewModel();
            currentView = loginVM;
            LoginViewCommand = new RelayCommand(obj =>
            {
                currentView = loginVM;
            });
            SigninViewCommand = new RelayCommand(obj =>
            {
                currentView = signinVM;
            });
            HomeViewCommand = new RelayCommand(obj =>
            {
                currentView = homeVM;
            });

            ConnectToServerCommand = new RelayCommand(obj => {
                _server.connect(Session.Session.username);
            });
        }

        public void openHome()
        {
            currentView = homeVM;
        }
    }
}