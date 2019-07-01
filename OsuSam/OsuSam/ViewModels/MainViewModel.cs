using System;
using System.Collections.Generic;
using System.Text;

namespace OsuSam.ViewModels
{
    public class MainViewModel : BaseViewModel
    {

        public UserViewModel User { get; set; }

        public MainViewModel()
        {
            instance = this;
        }

        private static MainViewModel instance;
        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }

            return instance;
        }
    }
}
