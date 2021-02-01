using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScoreManager.Modules.BasicInfo.ViewModels
{
    public class BasicInfoPageViewModel : BindableBase
    {
        private string _Title = "张三";
        public string Title
        {
            get { return _Title; }
            set { SetProperty(ref _Title, value); }
        }

        public BasicInfoPageViewModel()
        {

        }
    }
}
