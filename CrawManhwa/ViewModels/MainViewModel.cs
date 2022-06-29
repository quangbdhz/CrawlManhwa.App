using CrawManhwa.Models;
using CrawManhwa.Views;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Windows;
using System.Windows.Controls;

namespace CrawManhwa.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _urlWebsite;
        public string UrlWebsite
        {
            get { return _urlWebsite; }
            set { SetProperty(ref _urlWebsite, value); }
        }

        private int _startChapterCraw;
        public int StartChapterCraw
        {
            get { return _startChapterCraw; }
            set { SetProperty(ref _startChapterCraw, value); }
        }

        private int _endChapterCraw;
        public int EndChapterCraw
        {
            get { return _endChapterCraw; }
            set { SetProperty(ref _endChapterCraw, value); }
        }

        private string _startUrlWebsite;
        public string StartUrlWebsite
        {
            get { return _startUrlWebsite; }
            set { SetProperty(ref _startUrlWebsite, value); }
        }

        private string _endUrlWebsite;
        public string EndUrlWebsite
        {
            get { return _endUrlWebsite; }
            set { SetProperty(ref _endUrlWebsite, value); }
        }

        private string _fullUrlChapterCrawl;
        public string FullUrlChapterCrawl
        {
            get { return _fullUrlChapterCrawl; }
            set { SetProperty(ref _fullUrlChapterCrawl, value); }
        }

        private string _attributeTag;
        public string AttributeTag
        {
            get { return _attributeTag; }
            set { SetProperty(ref _attributeTag, value); }
        }

        private string _endCharAttribute;
        public string EndCharAttribute
        {
            get { return _endCharAttribute; }
            set { SetProperty(ref _endCharAttribute, value); }
        }


        private bool _checkedCrawlUrlChapter;
        public bool CheckedCrawlUrlChapter
        {
            get { return _checkedCrawlUrlChapter; }
            set { SetProperty(ref _checkedCrawlUrlChapter, value); }
        }

        private bool _checkedCrawlChapter;
        public bool CheckedCrawlChapter
        {
            get { return _checkedCrawlChapter; }
            set { SetProperty(ref _checkedCrawlChapter, value); }
        }

        private Visibility _visibilityControlCrawlUrlChapterManhwa;
        public Visibility VisibilityControlCrawlUrlChapterManhwa
        {
            get { return _visibilityControlCrawlUrlChapterManhwa; }
            set { SetProperty(ref _visibilityControlCrawlUrlChapterManhwa, value); }
        }

        private Visibility _visibilityControlCrawlChapterManhwa;
        public Visibility VisibilityControlCrawlChapterManhwa
        {
            get { return _visibilityControlCrawlChapterManhwa; }
            set { SetProperty(ref _visibilityControlCrawlChapterManhwa, value); }
        }


        private string _urlCrawlFullManhwa;
        public string UrlCrawlFullManhwa
        {
            get { return _urlCrawlFullManhwa; }
            set { SetProperty(ref _urlCrawlFullManhwa, value); }
        }

        private string _nameUrlManhwa;
        public string NameUrlManhwa
        {
            get { return _nameUrlManhwa; }
            set { SetProperty(ref _nameUrlManhwa, value); }
        }

        private string _urlWebUploadImage;
        public string UrlWebUploadImage
        {
            get { return _urlWebUploadImage; }
            set { SetProperty(ref _urlWebUploadImage, value); }
        }

        private Models.Comic _selectedItemManhwa;
        public Models.Comic SelectedItemManhwa
        {
            get { return _selectedItemManhwa; }
            set { SetProperty(ref _selectedItemManhwa, value); SaveDataToDatabaseCommand.RaiseCanExecuteChanged(); }
        }

        private int _getIdManhwaAddChapter;
        public int GetIdManhwaAddChapter
        {
            get { return _getIdManhwaAddChapter; }
            set { SetProperty(ref _getIdManhwaAddChapter, value); SaveDataToDatabaseCommand.RaiseCanExecuteChanged(); }
        }


        private int _copyStartChapterCrawl;
        public int CopyStartChapterCrawl
        {
            get { return _copyStartChapterCrawl; }
            set { SetProperty(ref _copyStartChapterCrawl, value); }
        }

        private string _optionSortCrawlFullChapter;
        public string OptionSortCrawlFullChapter
        {
            get { return _optionSortCrawlFullChapter; }
            set { SetProperty(ref _optionSortCrawlFullChapter, value); }
        }

        private int _idChapterDuplicate;
        public int IdChapterDuplicate
        {
            get { return _idChapterDuplicate; }
            set { SetProperty(ref _idChapterDuplicate, value); }
        }

        private string _addProtocolToUrl;
        public string AddProtocolToUrl
        {
            get { return _addProtocolToUrl; }
            set { SetProperty(ref _addProtocolToUrl, value); }
        }

        private string _urlDuplicate;
        public string UrlDuplicate
        {
            get { return _urlDuplicate; }
            set { SetProperty(ref _urlDuplicate, value); }
        }

        private string _addZeroStartChapterCrawl;
        public string AddZeroStartChapterCrawl
        {
            get { return _addZeroStartChapterCrawl; }
            set { SetProperty(ref _addZeroStartChapterCrawl, value); }
        }

        private int _urlInLine;
        public int UrlInLine
        {
            get { return _urlInLine; }
            set { SetProperty(ref _urlInLine, value); }
        }

        private string _replaceNameChapter;
        public string ReplaceNameChapter
        {
            get { return _replaceNameChapter; }
            set { SetProperty(ref _replaceNameChapter, value); }
        }

        private string _errorUrlMaxLength;
        public string ErrorUrlMaxLength
        {
            get { return _errorUrlMaxLength; }
            set { SetProperty(ref _errorUrlMaxLength, value); }
        }


        private ObservableCollection<UrlImageCrawl> _lvUrlImageCrawl;
        public ObservableCollection<UrlImageCrawl> LvUrlImageCrawl { get { return _lvUrlImageCrawl; } set { SetProperty(ref _lvUrlImageCrawl, value); } }

        private ObservableCollection<Comic> _lvNameManhwa;
        public ObservableCollection<Comic> LvNameManhwa { get { return _lvNameManhwa; } set { SetProperty(ref _lvNameManhwa, value); } }

        private ObservableCollection<ChapterComic> _lvChapterCrawl;
        public ObservableCollection<ChapterComic> LvChapterCrawl { get { return _lvChapterCrawl; } set { SetProperty(ref _lvChapterCrawl, value); } }

        private ObservableCollection<FullUrlImageOneChapter> _lvFullUrlImageOneChapter;
        public ObservableCollection<FullUrlImageOneChapter> LvFullUrlImageOneChapter { get { return _lvFullUrlImageOneChapter; } set { SetProperty(ref _lvFullUrlImageOneChapter, value); } }

        public DelegateCommand SubmitUrlWebsite { get; set; }

        public DelegateCommand<UrlImageCrawl> DoubleClickLvCrawlImage { get; set; }

        public DelegateCommand ReadManhwa { get; set; }

        public DelegateCommand<CheckBox> CheckedCrawlUrlChapterCommand { get; set; }

        public DelegateCommand<CheckBox> CheckedCrawlChapterCommand { get; set; }

        public DelegateCommand<Object> SaveDataToDatabaseCommand { get; set; }

        public DelegateCommand<ComboBox> ChooseManhwaAddChapterCommand { get; set; }

        public DelegateCommand<ComboBox> SelectedOptionSortListChapterCrawlCommand { get; set; }

        public DelegateCommand<Object> DeleteChapterDuplicateCommand { get; set; }

        public DelegateCommand<ComboBox> SelectedAddProtocolToUrlCommand { get; set; }

        public DelegateCommand<Object> DeleteUrlDuplicateCommand { get; set; }

        public DelegateCommand<UrlImageCrawl> MouseUpLvCrawlImage { get; set; }

        public DelegateCommand<Object> AddManhwaCommand { get; set; }

        public DelegateCommand<Object> ReplaceNameChapterCommand { get; set; }

        public DelegateCommand<Object> UserManagerCommand { get; set; }

        public DelegateCommand<Object> CategoriesAndAuthorsManagerCommand { get; set; }
        
        public MainViewModel()
        {
            LvUrlImageCrawl = new ObservableCollection<UrlImageCrawl>();
            LvChapterCrawl = new ObservableCollection<ChapterComic>();
            LvNameManhwa = new ObservableCollection<Comic>(DataProvider.Ins.DB.Comics);
            LvFullUrlImageOneChapter = new ObservableCollection<FullUrlImageOneChapter>();

            StartChapterCraw = 0;
            EndChapterCraw = 0;
            UrlCrawlFullManhwa = "";
            EndCharAttribute = "''";
            AttributeTag = "src";
            OptionSortCrawlFullChapter = "Decrease";
            AddProtocolToUrl = "Normal";
            UrlDuplicate = "";
            AddZeroStartChapterCrawl = "";
            UrlInLine = 30;
            ErrorUrlMaxLength = "";

            //UrlWebUploadImage = "https://truyenhaytv.com/wp-content";
            AttributeTag = "data-original";


            CheckedCrawlUrlChapter = true;
            VisibilityControlCrawlUrlChapterManhwa = Visibility.Visible;
            CheckedCrawlChapter = false;
            VisibilityControlCrawlChapterManhwa = Visibility.Collapsed;

            CheckedCrawlUrlChapterCommand = new DelegateCommand<CheckBox>(ExcuteCrawlUrlChapter);
            CheckedCrawlChapterCommand = new DelegateCommand<CheckBox>(ExcuteCrawlChapter);


            SubmitUrlWebsite = new DelegateCommand(Excute, CanExcute).ObservesProperty(() => StartChapterCraw).ObservesProperty(() => UrlCrawlFullManhwa).ObservesProperty(() => EndChapterCraw).ObservesProperty(() => CheckedCrawlUrlChapter);

            DoubleClickLvCrawlImage = new DelegateCommand<UrlImageCrawl>(ExcuteLvCrawlData, CanExcuteLvCrawData);

            ReadManhwa = new DelegateCommand(ExcuteReadManhwa);

            SaveDataToDatabaseCommand = new DelegateCommand<Object>((p) =>

            {
                DetailComic getComicSave = DataProvider.Ins.DB.DetailComics.Where(x => x.ComicId == GetIdManhwaAddChapter).SingleOrDefault();

                Random rnd = new Random();

                string seoAlias = "";

                if (getComicSave != null)
                {
                    seoAlias = getComicSave.SeoAlias;
                }

                if (LvUrlImageCrawl.Count() > 0 && GetIdManhwaAddChapter != 0)
                {
                    int IdManhwaStartAdd = 0;
                    int index = 0;
                    string name = "";
                    string fullSeoAlias = "";


                    foreach (ChapterComic item in LvChapterCrawl)
                    {
                        index++;
                        name = item.NameChapter;

                        if (name.IndexOf("Chapter") == -1)
                        {
                            name = "Chapter " + name;
                            fullSeoAlias = seoAlias + "/" + name.ToString().ToLower().Replace(" ", "-") + "-" + rnd.Next(100000, 999999).ToString();
                        }
                        else
                        {
                            fullSeoAlias = seoAlias + "/" + name.ToString().ToLower().Replace(" ", "-") + "-" + rnd.Next(100000, 999999).ToString();
                        }



                        Models.ChapterComic newChapterOfManhwa = new Models.ChapterComic() { ComicId = GetIdManhwaAddChapter, NameChapter = name, DateCreated = DateTime.Now, ViewCount = 0, IsActive = true, SeoAlias = fullSeoAlias };
                        DataProvider.Ins.DB.ChapterComics.Add(newChapterOfManhwa);
                        DataProvider.Ins.DB.SaveChanges();

                        if (item.NameChapter == CopyStartChapterCrawl.ToString())
                        {
                            IdManhwaStartAdd = newChapterOfManhwa.Id - 1;
                        }

                        if (StartChapterCraw == 0 && VisibilityControlCrawlUrlChapterManhwa == Visibility.Visible && index == 1)
                        {
                            IdManhwaStartAdd = newChapterOfManhwa.Id - 1;
                        }

                        fullSeoAlias = "";
                    }

                    foreach (FullUrlImageOneChapter item in LvFullUrlImageOneChapter)
                    {
                        //MessageBox.Show(item.Id.ToString());
                        Models.UrlImageComic urlImageManhwa = new Models.UrlImageComic() { ChapterComicId = (item.Id + IdManhwaStartAdd), UrlImageChapterComic = item.FullUrlImage, IsActive = true };
                        DataProvider.Ins.DB.UrlImageComics.Add(urlImageManhwa);
                        DataProvider.Ins.DB.SaveChanges();
                    }

                }

                MessageBox.Show("Successful");
            }, (p) =>
            {
                if (SelectedItemManhwa == null || GetIdManhwaAddChapter == 0)
                    return false;
                return true;
            });

            ChooseManhwaAddChapterCommand = new DelegateCommand<ComboBox>((p) =>
            {
                if (SelectedItemManhwa != null)
                {

                    GetIdManhwaAddChapter = SelectedItemManhwa.Id;
                }
            }, (p) => { return true; });

            SelectedOptionSortListChapterCrawlCommand = new DelegateCommand<ComboBox>((p) =>
            {
                OptionSortCrawlFullChapter = p.Text;
            }, (p) => { return true; });

            DeleteChapterDuplicateCommand = new DelegateCommand<object>((p) =>
            {
                ObservableCollection<UrlImageCrawl> list = new ObservableCollection<UrlImageCrawl>();
                list = LvUrlImageCrawl;

                foreach (UrlImageCrawl c in list.ToList())
                {
                    if (c.IdChapter == IdChapterDuplicate)
                        LvUrlImageCrawl.Remove(c);
                }

                ObservableCollection<ChapterComic> chapters = new ObservableCollection<ChapterComic>();
                chapters = LvChapterCrawl;

                foreach (ChapterComic item in chapters.ToList())
                {
                    if (item.ComicId == IdChapterDuplicate)
                    {
                        LvChapterCrawl.Remove(item);
                    }
                }

                ObservableCollection<FullUrlImageOneChapter> listFullUrlImageOneChapter = new ObservableCollection<FullUrlImageOneChapter>();
                listFullUrlImageOneChapter = LvFullUrlImageOneChapter;

                foreach (FullUrlImageOneChapter item in listFullUrlImageOneChapter.ToList())
                {
                    if (item.Id == IdChapterDuplicate)
                    {
                        LvFullUrlImageOneChapter.Remove(item);
                    }
                }

                IdChapterDuplicate = 0;
                //MessageBox.Show("Delete Duplicate Successful");

            }, (p) =>
            {
                if (IdChapterDuplicate == 0)
                    return false;
                return true;
            }).ObservesProperty(() => IdChapterDuplicate);

            SelectedAddProtocolToUrlCommand = new DelegateCommand<ComboBox>((p) =>
            {
                AddProtocolToUrl = p.Text;
            }, (p) => { return true; });

            DeleteUrlDuplicateCommand = new DelegateCommand<object>((p) =>
            {
                ObservableCollection<UrlImageCrawl> list = new ObservableCollection<UrlImageCrawl>();
                list = LvUrlImageCrawl;

                foreach (UrlImageCrawl c in list.ToList())
                {
                    if (c.UrlImage == UrlDuplicate)
                        LvUrlImageCrawl.Remove(c);
                }

                int size = LvFullUrlImageOneChapter.Count;
                for (int i = 0; i < size; i++)
                {
                    LvFullUrlImageOneChapter[i].FullUrlImage = LvFullUrlImageOneChapter[i].FullUrlImage.Replace((UrlDuplicate + "|"), "");
                }

                UrlDuplicate = "";
            }, (p) =>
            {
                if (UrlDuplicate == "")
                    return false;
                return true;
            }).ObservesProperty(() => UrlDuplicate);

            MouseUpLvCrawlImage = new DelegateCommand<UrlImageCrawl>((p) => { UrlDuplicate = p.UrlImage; }, (p) => { if (p == null) return false; return true; });

            AddManhwaCommand = new DelegateCommand<object>((p) =>
            {
                AddManhwaViews addManhwaViews = new AddManhwaViews();
                addManhwaViews.ShowDialog();

                LvNameManhwa = new ObservableCollection<Comic>(DataProvider.Ins.DB.Comics);
            }, (p) => { return true; });

            ReplaceNameChapterCommand = new DelegateCommand<object>((p) =>
            {
                foreach (ChapterComic item in LvChapterCrawl)
                {
                    item.NameChapter = item.NameChapter.Replace(ReplaceNameChapter, "");
                }
            }, (p) => { if (LvChapterCrawl.Count() > 0) return true; return false; }).ObservesProperty(() => LvChapterCrawl);

            UserManagerCommand = new DelegateCommand<object>((p) => { UserManagerView userManagerView = new UserManagerView(); userManagerView.ShowDialog(); });

            CategoriesAndAuthorsManagerCommand = new DelegateCommand<object>((p) => { CategoriAndAuthorManagerView categoriAndAuthorManagerView = new CategoriAndAuthorManagerView(); categoriAndAuthorManagerView.ShowDialog(); });
        }


        private void ExcuteCrawlChapter(CheckBox obj)
        {
            CheckedCrawlChapter = (bool)obj.IsChecked;
            if (CheckedCrawlChapter == true)
            {
                VisibilityControlCrawlUrlChapterManhwa = Visibility.Collapsed;
                VisibilityControlCrawlChapterManhwa = Visibility.Visible;

                CheckedCrawlUrlChapter = !CheckedCrawlChapter;

                StartChapterCraw = 0;
                EndChapterCraw = 0;

                UrlCrawlFullManhwa = "";
            }
        }

        private void ExcuteCrawlUrlChapter(CheckBox obj)
        {
            CheckedCrawlUrlChapter = (bool)obj.IsChecked;
            if (CheckedCrawlUrlChapter == true)
            {
                VisibilityControlCrawlUrlChapterManhwa = Visibility.Visible;
                VisibilityControlCrawlChapterManhwa = Visibility.Collapsed;

                CheckedCrawlChapter = !CheckedCrawlUrlChapter;

                StartChapterCraw = 0;
                EndChapterCraw = 0;

                UrlCrawlFullManhwa = "";
            }
        }

        private void ExcuteReadManhwa()
        {
            ReadManhwaView readManhwaView = new ReadManhwaView();
            readManhwaView.ShowDialog();
        }

        private bool CanExcuteLvCrawData(UrlImageCrawl arg)
        {
            return true;
        }

        private void ExcuteLvCrawlData(UrlImageCrawl obj)
        {
            if (obj != null)
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = obj.UrlImage,
                    UseShellExecute = true
                });
            }
        }

        public void GetAllImagesOptionCustomChapter(string urlWebsite, int chapter, int idChapterManhwa)
        {
            //WebProxy wp = new WebProxy(WebProxy.GetDefaultProxy().Address);
            WebClient x = new WebClient();
            // x.Proxy = wp;
            x.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/97.0.4692.99 Safari/537.36 Edg/97.0.1072.76");
            //x.Headers.Add("method", "GET");
            //x.Headers.Add("Cookie", "cookies");
            //x.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");

            x.UseDefaultCredentials = true;

            string source = x.DownloadString(urlWebsite);

            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(source);

            int serial = 0;
            int quantityUrlImageChapter = 0;

            string fullUrl = "|";
            int lengthUrl = 0;
            foreach (var link in document.DocumentNode.Descendants("img"))
            {
                string getUrlImage = GetAttributesHTML(AttributeTag, link.OuterHtml.ToString());

                if (Uri.IsWellFormedUriString(getUrlImage, UriKind.Absolute) == true)
                {
                    serial++;
                    quantityUrlImageChapter++;
                    LvUrlImageCrawl.Add(new UrlImageCrawl() { Id = serial, UrlImage = getUrlImage, IdChapter = idChapterManhwa, ChapterManhwa = chapter.ToString() });

                    fullUrl += (getUrlImage + "|");

                    if (quantityUrlImageChapter > UrlInLine)
                    {
                        lengthUrl = fullUrl.Length;
                        if (lengthUrl > 7550)
                            ErrorUrlMaxLength = "Appear url larger than allowed";

                        LvFullUrlImageOneChapter.Add(new FullUrlImageOneChapter() { Id = chapter, Length = lengthUrl, FullUrlImage = fullUrl });
                        fullUrl = "|";
                        quantityUrlImageChapter = 0;
                    }
                }
            }



            if (fullUrl != "|")
            {
                lengthUrl = fullUrl.Length;
                if (lengthUrl > 7550)
                    ErrorUrlMaxLength = "Appear url larger than allowed";

                LvFullUrlImageOneChapter.Add(new FullUrlImageOneChapter() { Id = chapter, Length = lengthUrl, FullUrlImage = fullUrl });
            }
        }

        public void GetAllImages(string urlWebsite, int chapter)
        {
            //var request = (HttpWebRequest)WebRequest.Create(urlWebsite);
            //request.UserAgent = @"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/98.0.4758.80 Safari/537.36 Edg/98.0.1108.43";
            //var result = (HttpWebResponse)request.GetResponse();

            //HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(urlWebsite);
            //myRequest.Method = "GET";
            //WebResponse myResponse = myRequest.GetResponse();
            //StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
            //string va = sr.ReadToEnd();
            //sr.Close();
            //myResponse.Close();

            //int i = 0;

            WebClient x = new WebClient();
            x.UseDefaultCredentials = true;
            string source = x.DownloadString(urlWebsite);
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(source);
            int serial = 0;
            int quantityUrlImageChapter = 0;
            int lengthUrl = 0;
            string fullUrl = "|";
            foreach (var link in document.DocumentNode.Descendants("img")) //.Select(i => i.Attributes["src"])
            {
                string getUrlImage = GetAttributesHTML(AttributeTag, link.OuterHtml.ToString());

                if (getUrlImage != null)
                {
                    if (getUrlImage.IndexOf(UrlWebUploadImage) != -1)
                    {
                        if (AddProtocolToUrl != "Normal")
                        {
                            getUrlImage = AddProtocolToUrl + getUrlImage;
                        }

                        if (Uri.IsWellFormedUriString(getUrlImage, UriKind.Absolute) == true)
                        {
                            serial++;
                            quantityUrlImageChapter++;

                            LvUrlImageCrawl.Add(new UrlImageCrawl() { Id = serial, UrlImage = getUrlImage, IdChapter = chapter, ChapterManhwa = chapter.ToString() });
                            fullUrl += (getUrlImage + "|");

                            if (quantityUrlImageChapter > UrlInLine)
                            {
                                lengthUrl = fullUrl.Length;
                                if (lengthUrl > 7550)
                                    ErrorUrlMaxLength = "Appear url larger than allowed";

                                LvFullUrlImageOneChapter.Add(new FullUrlImageOneChapter() { Id = chapter, Length = lengthUrl, FullUrlImage = fullUrl });
                                fullUrl = "|";
                                quantityUrlImageChapter = 0;
                            }
                        }
                    }
                }
            }

            if (fullUrl != "|")
            {
                lengthUrl = fullUrl.Length;
                if (lengthUrl > 7550)
                    ErrorUrlMaxLength = "Appear url larger than allowed";

                LvFullUrlImageOneChapter.Add(new FullUrlImageOneChapter() { Id = chapter, Length = lengthUrl, FullUrlImage = fullUrl });
            }
        }

        public string GetAttributesHTML(string attributes, string link)
        {
            int index = link.IndexOf(attributes) + attributes.Length + 2;

            int lengthLink = link.Length;
            string newLink = "";

            int ASCIIEndCharAttribute = 0;

            if (EndCharAttribute == "'")
            {
                ASCIIEndCharAttribute = 39;
            }
            if (EndCharAttribute == "''")
            {
                ASCIIEndCharAttribute = 34;
            }


            for (int i = index; i < lengthLink; i++)
            {
                if ((int)link[i] == ASCIIEndCharAttribute)
                {
                    break;
                }
                if ((int)link[i] > 33)
                {
                    newLink += link[i];
                }

            }


            return newLink;
        }

        private bool CanExcute()
        {
            if (StartChapterCraw != 0 && EndChapterCraw != 0 && UrlCrawlFullManhwa == "" && CheckedCrawlUrlChapter == false)
                return true;

            if (StartChapterCraw == 0 && EndChapterCraw == 0 && UrlCrawlFullManhwa != "" && CheckedCrawlUrlChapter == true)
                return true;

            return false;
        }

        private void Excute()
        {
            LvUrlImageCrawl.Clear();
            LvChapterCrawl.Clear();
            LvFullUrlImageOneChapter.Clear();
            ErrorUrlMaxLength = "";

            if (StartChapterCraw != 0 && EndChapterCraw != 0 && UrlCrawlFullManhwa == "")
            {
                string url = "";
                CopyStartChapterCrawl = StartChapterCraw;
                int idChapterManhwa = 0;
                for (int i = StartChapterCraw; i <= EndChapterCraw; i++)
                {
                    if (AddZeroStartChapterCrawl == "0")
                    {
                        if (i > 0 && i < 10)
                        {
                            url = StartUrlWebsite + "0" + i.ToString() + EndUrlWebsite;
                        }
                        else
                        {
                            url = StartUrlWebsite + i.ToString() + EndUrlWebsite;
                        }
                    }
                    else
                    {
                        url = StartUrlWebsite + i.ToString() + EndUrlWebsite;
                    }
                    FullUrlChapterCrawl = url;


                    LvChapterCrawl.Add(new ChapterComic() { ComicId = i - StartChapterCraw + 1, NameChapter = i.ToString() });
                    GetAllImagesOptionCustomChapter(url, i - StartChapterCraw + 1, idChapterManhwa);
                    idChapterManhwa++;
                }
            }

            if (StartChapterCraw == 0 && EndChapterCraw == 0 && UrlCrawlFullManhwa != "")
            {
                FirefoxOptions options = new FirefoxOptions();
                options.BrowserExecutableLocation = ("C:\\Program Files\\Mozilla Firefox\\firefox.exe");

                var profile = new FirefoxProfile();

                FirefoxDriver driver = new FirefoxDriver("E:\\Manhwa\\CrawManhwa\\CrawManhwa\\bin\\Debug", options, TimeSpan.FromSeconds(1000));
                //FirefoxDriver driver = new FirefoxDriver(options);
                driver.Navigate().GoToUrl(UrlCrawlFullManhwa);

                int index = 0;
                IList<IWebElement> lis = driver.FindElements(By.TagName("a"));
                string hrefTag = "";

                ObservableCollection<string> urlChapter = new ObservableCollection<string>();

                string nameReplace = "";

                foreach (IWebElement li in lis)
                {
                    hrefTag = li.GetAttribute("href");
                    if (hrefTag != null && hrefTag != "")
                    {
                        if (hrefTag.IndexOf(NameUrlManhwa) != -1)
                        {
                            index++;
                            //nameReplace = li.Text.Replace("Chương ", "");
                            nameReplace = li.Text;
                            LvChapterCrawl.Add(new ChapterComic() { ComicId = index, NameChapter = nameReplace });
                            urlChapter.Add(hrefTag);

                        }
                    }

                }

                LvChapterCrawl = new ObservableCollection<ChapterComic>(LvChapterCrawl.Reverse());

                ObservableCollection<ChapterComic> LvChapterCrawlReserve = new ObservableCollection<ChapterComic>();

                //int chapter = 0;
                //foreach (var item in LvChapterCrawl)
                //{
                //    chapter++;
                //    LvChapterCrawlReserve.Add(item);

                //    if (chapter > 20)
                //    {
                //        chapter = 0;
                //        break;
                //    }
                //}

                LvChapterCrawl = new ObservableCollection<ChapterComic>(LvChapterCrawl);

                int sizeListUrlChapter = urlChapter.Count();
                if (OptionSortCrawlFullChapter == "Decrease")
                {
                    int serial = 0;
                    for (int i = sizeListUrlChapter - 1; i >= 0; i--)
                    {
                        //chapter++;
                        LvChapterCrawl[serial].ComicId = serial + 1;
                        serial++;
                        GetAllImages(urlChapter[i], serial);
                        //if (chapter > 20)
                        //{
                        //    chapter = 0;
                        //    break;
                        //}
                    }

                }
                driver.Quit();
            }

            StartChapterCraw = 0;
            EndChapterCraw = 0;
            UrlCrawlFullManhwa = "";
            MessageBox.Show("Crawl Url Image Chapter Susscecfull");
        }

        public bool IsImageUrl(string URL)
        {
            try
            {
                var req = (HttpWebRequest)HttpWebRequest.Create(URL);
                req.Method = "HEAD";
                using (var resp = req.GetResponse())
                {
                    return resp.ContentType.ToLower(CultureInfo.InvariantCulture).StartsWith("image/");
                    /*bool value = 

                    if(value == true)
                    {
                        byte[] imageData = new WebClient().DownloadData(URL);
                        MemoryStream imgStream = new MemoryStream(imageData);
                        System.Drawing.Image img = System.Drawing.Image.FromStream(imgStream);

                        if (img.Width > 200)
                            return true;
                        return false;
                    }
                    else return false;*/
                }
            }
            catch
            {
                return false;
            }
        }

        public async void CheckImageUsing(string url, int serial)
        {
            HttpClient client = new HttpClient();
            bool IsTypeImage = false;
            try
            {
                HttpResponseMessage res = await client.GetAsync(url);

                IsTypeImage = res.ToString().Contains("Content-Type: image");
            }
            catch
            {

            }

            if (IsTypeImage == true)
            {

            }
        }
    }

    public class FullUrlImageOneChapter : BindableBase
    {
        private int _id;
        public int Id { get { return _id; } set { SetProperty(ref _id, value); } }

        private int _length;
        public int Length { get { return _length; } set { SetProperty(ref _length, value); } }

        private string _fullUrlImage;
        public string FullUrlImage { get { return _fullUrlImage; } set { SetProperty(ref _fullUrlImage, value); } }
    }

    public class UrlImageCrawl : BindableBase
    {
        private int _id;
        public int Id { get { return _id; } set { SetProperty(ref _id, value); } }

        private string _urlImage;
        public string UrlImage { get { return _urlImage; } set { SetProperty(ref _urlImage, value); } }

        private int _idChapter;
        public int IdChapter { get { return _idChapter; } set { SetProperty(ref _idChapter, value); } }

        private string _chapterManhwa;
        public string ChapterManhwa { get { return _chapterManhwa; } set { SetProperty(ref _chapterManhwa, value); } }
    }
}
