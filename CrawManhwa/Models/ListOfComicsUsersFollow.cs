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
    
    public partial class ListOfComicsUsersFollow
    {
        public int Id { get; set; }
        public System.Guid AppUserId { get; set; }
        public int ComicId { get; set; }
        public System.DateTime DateFollow { get; set; }
    
        public virtual AppUser AppUser { get; set; }
        public virtual Comic Comic { get; set; }
    }
}
