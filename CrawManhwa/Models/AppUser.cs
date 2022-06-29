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
    using System;
    using System.Collections.Generic;
    
    public partial class AppUser : BindableBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AppUser()
        {
            this.HistoryReadComicOfUsers = new HashSet<HistoryReadComicOfUser>();
            this.ListOfComicsUsersFollows = new HashSet<ListOfComicsUsersFollow>();
        }
    
        public System.Guid Id { get; set; }

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }

        public System.DateTime Dob { get; set; }

        private string _urlImageUser;
        public string UrlImageUser
        {
            get { return _urlImageUser; }
            set { SetProperty(ref _urlImageUser, value); }
        }

        public string MoreInfo { get; set; }

        private bool _isActive;
        public bool IsActive
        {
            get { return _isActive; }
            set { SetProperty(ref _isActive, value); }
        }

        public int GenderId { get; set; }
        public string RefreshToken { get; set; }
        public Nullable<System.DateTime> TokenCreated { get; set; }
        public Nullable<System.DateTime> TokenExpires { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }

        private string _phoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { SetProperty(ref _phoneNumber, value); }
        }

        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public Nullable<System.DateTimeOffset> LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
    
        public virtual Gender Gender { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoryReadComicOfUser> HistoryReadComicOfUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListOfComicsUsersFollow> ListOfComicsUsersFollows { get; set; }
    }
}
