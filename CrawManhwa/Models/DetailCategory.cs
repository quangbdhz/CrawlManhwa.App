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
    using System;
    using System.Collections.Generic;
    
    public partial class DetailCategory
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string NameCategory { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }
        public string SeoAlias { get; set; }
    
        public virtual Category Category { get; set; }
    }
}
