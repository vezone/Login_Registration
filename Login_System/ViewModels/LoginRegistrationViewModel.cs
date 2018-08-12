using Login_System.Models;
using System;
using System.Windows.Controls;

namespace Login_System.ViewModels
{
    public class LoginRegistrationViewModel : ViewModelBase
    {
        private ContentControl m_ContentField;

        bool IsRegistrationInfoCorrect = true;

        public LoginRegistrationViewModel()
        {
            ContentField = new Views.LoginView();
            App.Current.MainWindow.Height = 650;

        }

        public ContentControl ContentField
        {
            get { return m_ContentField; }
            set
            {
                m_ContentField = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand btnCreate_Click
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    App.Current.MainWindow.Height = 1050;
                    ContentField = new Views.RegistrationBasicView();
                    
                });
            }
        }

        public RelayCommand btnSubmit_Click
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    if (IsRegistrationInfoCorrect)
                    {
                        App.Current.MainWindow.Height = 450;
                        App.Current.MainWindow.Width = 800;
                        ContentField = new Views.RegistrationEmailView();
                    }
                });
            }
        }

    }
}