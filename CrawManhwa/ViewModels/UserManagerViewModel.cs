using CrawManhwa.Models;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Data.Entity;

namespace CrawManhwa.ViewModels
{
    public class UserManagerViewModel : BindableBase
    {

        private ObservableCollection<AppUser> _lvAppUsers;
        public ObservableCollection<AppUser> LvAppUsers { get { return _lvAppUsers; } set { SetProperty(ref _lvAppUsers, value); } }

        public DelegateCommand<AppUser> LockOrUnlockUserComamnd { get; set; }

        public UserManagerViewModel()
        {
            LvAppUsers = new ObservableCollection<AppUser>(DataProvider.Ins.DB.AppUsers);

            LockOrUnlockUserComamnd = new DelegateCommand<AppUser>(async (p) =>
            {
                AppUser appUser = await DataProvider.Ins.DB.AppUsers.SingleOrDefaultAsync(x => x.Id == p.Id);
                appUser.IsActive = !appUser.IsActive;
                await DataProvider.Ins.DB.SaveChangesAsync();
            });
        }
    }
}
