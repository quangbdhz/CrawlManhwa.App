using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlIamge.Models
{
    public class UrlImageCrawl : BindableBase
    {
        private int _id;
        public int Id { get { return _id; } set { SetProperty(ref _id, value); } }

        private string _urlImage;
        public string UrlImage { get { return _urlImage; } set { SetProperty(ref _urlImage, value); } }
    }
}
