using CrawManhwa.Models;
using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace CrawManhwa.ViewModels
{
    public class CategoriAndAuthorManagerViewModel : BindableBase
    {
        private ObservableCollection<DetailCategory> _lvCategories;
        public ObservableCollection<DetailCategory> LvCategories { get { return _lvCategories; } set { SetProperty(ref _lvCategories, value); } }

        private ObservableCollection<Author> _lvAuthors;
        public ObservableCollection<Author> LvAuthors { get { return _lvAuthors; } set { SetProperty(ref _lvAuthors, value); } }


        public CategoriAndAuthorManagerViewModel()
        {
            LvCategories = new ObservableCollection<DetailCategory>(DataProvider.Ins.DB.DetailCategories);
            LvAuthors = new ObservableCollection<Author>(DataProvider.Ins.DB.Authors);
        }
    }
}
