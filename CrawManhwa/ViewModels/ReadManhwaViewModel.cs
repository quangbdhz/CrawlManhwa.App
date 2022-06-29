using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using CrawManhwa.Models;
using CrawManhwa.Views;
using Prism.Commands;
using Prism.Mvvm;
namespace CrawManhwa.ViewModels
{
    public class ReadManhwaViewModel : BindableBase
    {
        private string _nameManhwa;
        public string NameManhwa
        {
            get { return _nameManhwa; }
            set { SetProperty(ref _nameManhwa, value); }
        }

        private int _idChapterRead;
        public int IdChapterRead
        {
            get { return _idChapterRead; }
            set { SetProperty(ref _idChapterRead, value); }
        }


        private static Models.Comic _selectedManhwaRead;
        public static Models.Comic SelectedManhwaRead
        {
            get { return _selectedManhwaRead; }
            set { _selectedManhwaRead = value; }
        }


        private ObservableCollection<Models.Comic> _lvNameManhwa;
        public ObservableCollection<Models.Comic> LvNameManhwa { get { return _lvNameManhwa; } set { SetProperty(ref _lvNameManhwa, value); } }

        

        public DelegateCommand<ComboBox> ChooseManhwaRead { get; set; }

        

        public DelegateCommand<Models.Comic> SelectedManhwaReadCommand { get; set; }

        

        public ReadManhwaViewModel()
        {
            LvNameManhwa = new ObservableCollection<Models.Comic>(DataProvider.Ins.DB.Comics);

            
            SelectedManhwaReadCommand = new DelegateCommand<Comic>((p) => 
            {
                SelectedManhwaRead = p;
                
                DetailManhwaView detailManhwaView = new DetailManhwaView();
                detailManhwaView.ShowDialog();

            }, (p) => { return true; });
        }
    }
}
