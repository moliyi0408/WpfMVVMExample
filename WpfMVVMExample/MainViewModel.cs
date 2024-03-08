using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfMVVMExample
{
    class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            ExampleCommand = new RelayCommand<string>(ExampleFuc);
        }

       
        private string _txtExample;
        public string txtExample
        {
            get => _txtExample;
            set
            {
                _txtExample = value; //value 來自於資料綁定
                OnPropertyChanged("txtExample"); // 通知 View 更新
            }
        }

        private string _txtLabExample;
        public string txtLabExample
        {
            get => _txtLabExample;
            set
            {
                _txtLabExample = value; //value 來自於資料綁定
                OnPropertyChanged("txtLabExample"); // 通知 View 更新
            }
        }
        public ICommand ExampleCommand { get; set; }
        private  void ExampleFuc(object parameter)
        {
            txtLabExample = txtExample;
        }
    }
}
