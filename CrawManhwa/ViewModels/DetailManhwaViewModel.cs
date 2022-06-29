using CrawManhwa.Models;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CrawManhwa.ViewModels
{
    public class DetailManhwaViewModel : ReadManhwaViewModel
    {
        private ObservableCollection<Models.ChapterComic> _lvChapterManhwa;
        public ObservableCollection<Models.ChapterComic> LvChapterManhwa { get { return _lvChapterManhwa; } set { SetProperty(ref _lvChapterManhwa, value); } }

        private ObservableCollection<Models.UrlImageComic> _lvFullUrlImageChapter;
        public ObservableCollection<Models.UrlImageComic> LvFullUrlImageChapter { get { return _lvFullUrlImageChapter; } set { SetProperty(ref _lvFullUrlImageChapter, value); } }

        private ObservableCollection<Models.UrlImageComic> _lvUrlImageOfOneChapter;
        public ObservableCollection<Models.UrlImageComic> LvUrlImageOfOneChapter { get { return _lvUrlImageOfOneChapter; } set { SetProperty(ref _lvUrlImageOfOneChapter, value); } }

        private Models.ChapterComic _selectedItemChapter;
        public Models.ChapterComic SelectedItemChapter
        {
            get { return _selectedItemChapter; }
            set { SetProperty(ref _selectedItemChapter, value); ChooseChapterManhwaRead.RaiseCanExecuteChanged(); }
        }

        private ChapterComic _currentChapter;
        public ChapterComic CurrentChapter
        {
            get { return _currentChapter; }
            set { SetProperty(ref _currentChapter, value); }
        }

        private ChapterComic _previousChapter;
        public ChapterComic PreviousChapter
        {
            get { return _previousChapter; }
            set { SetProperty(ref _previousChapter, value); }
        }

        private ChapterComic _nextChapter;
        public ChapterComic NextChapter
        {
            get { return _nextChapter; }
            set { SetProperty(ref _nextChapter, value); }
        }

        private int _indexCurrentChapterInLvChapter;
        public int IndexCurrentChapterInLvChapter
        {
            get { return _indexCurrentChapterInLvChapter; }
            set { SetProperty(ref _indexCurrentChapterInLvChapter, value); }
        }

        public DelegateCommand<ChapterComic> ChooseChapterManhwaRead { get; set; }

        public DelegateCommand<Object> PreviousChapterManhwa { get; set; }

        public DelegateCommand<Object> NextChapterManhwa { get; set; }

        public DetailManhwaViewModel()
        {
            LvChapterManhwa = new ObservableCollection<ChapterComic>(DataProvider.Ins.DB.ChapterComics.Where(x => x.ComicId == SelectedManhwaRead.Id));
            LvUrlImageOfOneChapter = new ObservableCollection<UrlImageComic>();


            if (LvChapterManhwa.Count > 0)
            {
                int idChapterFirst = LvChapterManhwa[0].Id;
                IndexCurrentChapterInLvChapter = 0;

                LvFullUrlImageChapter = new ObservableCollection<UrlImageComic>(DataProvider.Ins.DB.UrlImageComics.Where(x => x.ChapterComicId == idChapterFirst));

                LvUrlImageOfOneChapter = CutUrlToListUrl(LvFullUrlImageChapter);


            }


            ChooseChapterManhwaRead = new DelegateCommand<ChapterComic>((p) =>
            {
                LvUrlImageOfOneChapter.Clear();
                CurrentChapter = p;

                int sizeOfLvChapterManhwa = LvChapterManhwa.Count;
                for (int i = 0; i < sizeOfLvChapterManhwa; i++)
                {
                    if (LvChapterManhwa[i].Id == LvChapterManhwa[IndexCurrentChapterInLvChapter].Id)
                    {
                        IndexCurrentChapterInLvChapter = i;
                        break;
                    }
                }

                LvFullUrlImageChapter = new ObservableCollection<UrlImageComic>(DataProvider.Ins.DB.UrlImageComics.Where(x => x.ChapterComicId == CurrentChapter.Id));

                LvUrlImageOfOneChapter = CutUrlToListUrl(LvFullUrlImageChapter);

            }, (p) => { return true; }).ObservesProperty(() => IndexCurrentChapterInLvChapter);

            PreviousChapterManhwa = new DelegateCommand<Object>((p) => 
            {
                LvUrlImageOfOneChapter.Clear();
                IndexCurrentChapterInLvChapter--;

                int index = LvChapterManhwa[IndexCurrentChapterInLvChapter].Id;
                LvFullUrlImageChapter = new ObservableCollection<UrlImageComic>(DataProvider.Ins.DB.UrlImageComics.Where(x => x.ChapterComicId == index));
                LvUrlImageOfOneChapter = CutUrlToListUrl(LvFullUrlImageChapter);

            }, (p) => 
            {
                if (IndexCurrentChapterInLvChapter == 0)
                    return false;

                return true; 
            }).ObservesProperty(() => IndexCurrentChapterInLvChapter);

            NextChapterManhwa = new DelegateCommand<Object>((p) => 
            {
                LvUrlImageOfOneChapter.Clear();
                IndexCurrentChapterInLvChapter++;

                int index = LvChapterManhwa[IndexCurrentChapterInLvChapter].Id;
                LvFullUrlImageChapter = new ObservableCollection<UrlImageComic>(DataProvider.Ins.DB.UrlImageComics.Where(x => x.ChapterComicId == index));
                LvUrlImageOfOneChapter = CutUrlToListUrl(LvFullUrlImageChapter);
            }, (p) => 
            {
                if (IndexCurrentChapterInLvChapter == LvChapterManhwa.Count - 1)
                    return false;

                return true; 
            }).ObservesProperty(() => IndexCurrentChapterInLvChapter);
        }

        public void GetLvUrlImageOfOneChapter(int id)
        {
            LvUrlImageOfOneChapter.Clear();

            foreach (UrlImageComic item in LvFullUrlImageChapter)
            {
                if (item.ChapterComicId == id)
                {
                    LvUrlImageOfOneChapter.Add(item);
                }
            }
        }

        public ObservableCollection<UrlImageComic> CutUrlToListUrl(ObservableCollection<UrlImageComic> lvUrlEncode)
        {
            ObservableCollection<UrlImageComic> lvUrlDecode = new ObservableCollection<UrlImageComic>();

            foreach(UrlImageComic item in lvUrlEncode)
            {
                int lenghtUrl = item.UrlImageChapterComic.Length;

                string url = item.UrlImageChapterComic;
                string subString = "";
                for (int i = 1; i < lenghtUrl; i++)
                {
                    if (url[i] == '|' && i != 0)
                    {
                        lvUrlDecode.Add(new UrlImageComic() { UrlImageChapterComic = subString });
                        subString = "";
                    }
                    else
                    {
                        subString += url[i];
                    }
                }
            }
           

            return lvUrlDecode;
        }

        private void ExcuteNextChapterManhwa()
        {
           
        }

        private bool CanExcutedReadChapter(ComboBox arg)
        {
            if (NameManhwa == "") return false;
            return true;
        }

        private void ExcutePreviousChapterManhwa()
        {
            
        }

        private void ExcuteReadChapter(ComboBox obj)
        {
            
        }
    }
}
