using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CrawManhwa.Models;
using Prism.Commands;
using Prism.Mvvm;

namespace CrawManhwa.ViewModels
{
    public class AddManhwaViewModel : BindableBase
    {

        private string _nameManhwa;
        public string NameManhwa
        {
            get { return _nameManhwa; }
            set { SetProperty(ref _nameManhwa, value); }
        }

        private string _differentNameComic;
        public string DifferentNameComic
        {
            get { return _differentNameComic; }
            set { SetProperty(ref _differentNameComic, value); }
        }

        private string _urlImageManhwa;
        public string UrlImageManhwa
        {
            get { return _urlImageManhwa; }
            set { SetProperty(ref _urlImageManhwa, value); }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }

        private string _seoDescription;
        public string SeoDescription
        {
            get { return _seoDescription; }
            set { SetProperty(ref _seoDescription, value); }
        }

        private string _seoTitle;
        public string SeoTitle
        {
            get { return _seoTitle; }
            set { SetProperty(ref _seoTitle, value); }
        }

        private string _seoAlias;
        public string SeoAlias
        {
            get { return _seoAlias; }
            set { SetProperty(ref _seoAlias, value); }
        }

        private int _authorId;
        public int AuthorId
        {
            get { return _authorId; }
            set { SetProperty(ref _authorId, value); }
        }

        private int _categoryId;
        public int CategoryId
        {
            get { return _categoryId; }
            set { SetProperty(ref _categoryId, value); }
        }

        private Author _selectedAuthor;
        public Author SelectedAuthor
        {
            get { return _selectedAuthor; }
            set { SetProperty(ref _selectedAuthor, value); }
        }

        private DetailCategory _selectedCategory;
        public DetailCategory SelectedCategory
        {
            get { return _selectedCategory; }
            set { SetProperty(ref _selectedCategory, value); }
        }

        private ObservableCollection<Author> _lvAuthors;
        public ObservableCollection<Author> LvAuthors { get { return _lvAuthors; } set { SetProperty(ref _lvAuthors, value); } }

        private ObservableCollection<DetailCategory> _lvCategories;
        public ObservableCollection<DetailCategory> LvCategories { get { return _lvCategories; } set { SetProperty(ref _lvCategories, value); } }

        public DelegateCommand<Window> SubmitAddManhwaCommand { get; set; }

        public AddManhwaViewModel()
        {
            LvAuthors = new ObservableCollection<Author>(DataProvider.Ins.DB.Authors.Where(x => x.IsActive == true));

            LvCategories = new ObservableCollection<DetailCategory>(DataProvider.Ins.DB.DetailCategories.Where(x => x.Category.IsActive == true));

            SubmitAddManhwaCommand = new DelegateCommand<Window>((p) => 
            {
                int Author = SelectedAuthor.Id;
                int Categori = SelectedCategory.CategoryId;
                Comic comic = new Models.Comic() { NameComic = NameManhwa, DifferentNameComic = DifferentNameComic, ViewCount = 0, UrlCoverImageComic = UrlImageManhwa, DateCreated = DateTime.Now, IsActive = true, IdNewChapter = null};
                DataProvider.Ins.DB.Comics.Add(comic);
                DataProvider.Ins.DB.SaveChanges();

                Random rd = new Random();
                int idComic = rd.Next(100000, 999999);
                SeoAlias = "/" + SeoAlias + "-" + idComic.ToString();

                DetailComic detailComic = new Models.DetailComic() { ComicId = comic.Id, CountFollow = 0, CountRating = 0, StatusId = 1, Rating = 0, Description = Description, SeoDescription = SeoDescription, SeoTitle = SeoTitle, SeoAlias = SeoAlias };
                DataProvider.Ins.DB.DetailComics.Add(detailComic);
                DataProvider.Ins.DB.SaveChanges();

                p.Close();
            }, (p) => 
            {
                if (NameManhwa == null || NameManhwa == "" || UrlImageManhwa == null || UrlImageManhwa == "")
                    return false;
                return true;
            }).ObservesProperty(() => NameManhwa).ObservesProperty(() => UrlImageManhwa).ObservesProperty(() => SeoAlias).ObservesProperty(() => DifferentNameComic).ObservesProperty(() => SeoDescription).ObservesProperty(() => SeoTitle).ObservesProperty(() => AuthorId).ObservesProperty(() => CategoryId).ObservesProperty(() => Description);
        }
    }
}
