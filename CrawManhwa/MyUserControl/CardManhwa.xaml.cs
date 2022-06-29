using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CrawManhwa.MyUserControl
{
    /// <summary>
    /// Interaction logic for CardManhwa.xaml
    /// </summary>
    public partial class CardManhwa : UserControl
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public CardManhwa()
        {
            InitializeComponent();
        }

        public string NameManhwa
        {
            get { return (string)GetValue(NameManhwaProperty); }
            set { SetValue(NameManhwaProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NameManhwaProperty =
            DependencyProperty.Register("NameManhwa", typeof(string), typeof(CardManhwa));

        public string NewChapterManhwa
        {
            get { return (string)GetValue(NewChapterManhwaProperty); }
            set { SetValue(NewChapterManhwaProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NewChapterManhwaProperty =
            DependencyProperty.Register("NewChapterManhwa", typeof(string), typeof(CardManhwa));


        public string BackgroundManhwa
        {
            get { return (string)GetValue(BackgroundManhwaProperty); }
            set { SetValue(BackgroundManhwaProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BackgroundManhwaProperty =
            DependencyProperty.Register("BackgroundManhwa", typeof(string), typeof(CardManhwa));

    }
}
