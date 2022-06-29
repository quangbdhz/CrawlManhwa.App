using CrawManhwa.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace CrawManhwa.Views
{
    /// <summary>
    /// Interaction logic for UserManagerView.xaml
    /// </summary>
    public partial class UserManagerView : Window
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ObservableCollection<AppUser> _lvAppUsers;
        public ObservableCollection<AppUser> LvAppUsers { get => _lvAppUsers; set { _lvAppUsers = value; } }

        private string _StringSearchUser;
        public string StringSearchUser { get => _StringSearchUser; set { _StringSearchUser = value; OnPropertyChanged(); } }

        public UserManagerView()
        {
            InitializeComponent();

            StringSearchUser = "User Name";

            LvAppUsers = new ObservableCollection<AppUser>(DataProvider.Ins.DB.AppUsers);
            Lv_AppUsers.ItemsSource = LvAppUsers;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(Lv_AppUsers.ItemsSource);
            view.Filter = UserFilter;
        }

        private bool UserFilter(object item)
        {
            if (String.IsNullOrEmpty(tb_user.Text))
                return true;
            else
            {
                if(StringSearchUser == "User Name")
                {
                    return ((item as AppUser).UserName.IndexOf(tb_user.Text, StringComparison.OrdinalIgnoreCase) >= 0);
                }
                else if(StringSearchUser == "Email")
                {
                    return ((item as AppUser).Email.IndexOf(tb_user.Text, StringComparison.OrdinalIgnoreCase) >= 0);
                }
                else if(StringSearchUser == "Active User")
                {
                    return ((item as AppUser).IsActive.ToString().IndexOf(tb_user.Text, StringComparison.OrdinalIgnoreCase) >= 0);
                }
                else
                {
                    return ((item as AppUser).EmailConfirmed.ToString().IndexOf(tb_user.Text, StringComparison.OrdinalIgnoreCase) >= 0);
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(Lv_AppUsers.ItemsSource).Refresh();
        }

        private void OptionSearch_DropDownClosed(object sender, EventArgs e)
        {
            StringSearchUser = this.OptionSearch.Text;
        }


        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scv = (ScrollViewer)sender;
            scv.ScrollToVerticalOffset(scv.VerticalOffset - e.Delta);
            e.Handled = true;
        }
    }
}
