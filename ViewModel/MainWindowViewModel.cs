using MVVMApp.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMApp.ViewModel
{
    class MainWindowViewModel : BindableBase
    {

        public MainWindowViewModel()
        {
            NavCommand = new MyICommand<string>(OnNav);
        }

        private  RegistrationViewModel registerViewModel = new RegistrationViewModel();

        private  LoginViewModel loginViewModel = new LoginViewModel();
        private HomeViewModel homeViewModel = new HomeViewModel();

        private Object _CurrentViewModel;

        public Object CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set { SetProperty(ref _CurrentViewModel, value); }
        }

        public MyICommand<string> NavCommand { get; private set; }

        private void OnNav(string destination)
        {

            switch (destination)
            {
                case "register":
                    CurrentViewModel = registerViewModel;
                    break;
                case "login":
                    CurrentViewModel = loginViewModel;
                    break;
                case "get":
                    CurrentViewModel = new UserViewModel();
                    break;
                case "addcontact":
                    CurrentViewModel = new AddContactViewModel();
                    break;
                case "profile":
                    CurrentViewModel = new ProfileViewModel();
                    break;
                
            }
        }

        
    }

}
