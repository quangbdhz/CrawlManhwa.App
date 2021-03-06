//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrawManhwa.Models
{
    using Prism.Mvvm;
    using System.Collections.Generic;
    
    public partial class ChapterComic : BindableBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChapterComic()
        {
            this.HistoryReadComicOfUsers = new HashSet<HistoryReadComicOfUser>();
            this.UrlImageComics = new HashSet<UrlImageComic>();
        }

        private int _id;
        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        public int ComicId { get; set; }

        private string _nameChapter;
        public string NameChapter
        {
            get { return _nameChapter; }
            set { SetProperty(ref _nameChapter, value); }
        }

        public System.DateTime DateCreated { get; set; }
        public int ViewCount { get; set; }
        public bool IsActive { get; set; }
        public string SeoAlias { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoryReadComicOfUser> HistoryReadComicOfUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UrlImageComic> UrlImageComics { get; set; }
    }
}
