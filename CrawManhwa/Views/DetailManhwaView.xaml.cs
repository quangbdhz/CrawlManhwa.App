using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CrawManhwa.Views
{
    /// <summary>
    /// Interaction logic for DetailManhwaView.xaml
    /// </summary>
    public partial class DetailManhwaView : Window
    {
        public DetailManhwaView()
        {
            InitializeComponent();
        }

        private void LvOneChapterManhwaScrollViewer_PreviewMouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            ScrollViewer scv = (ScrollViewer)sender;
            scv.ScrollToVerticalOffset(scv.VerticalOffset - e.Delta);
            e.Handled = true;
        }

        private void cbx_ChooseChapterManhwa_DropDownClosed(object sender, EventArgs e)
        {
            ScrollLvReadManhwa.ScrollToVerticalOffset(0);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ScrollLvReadManhwa.ScrollToVerticalOffset(0);
        }
    }
}
