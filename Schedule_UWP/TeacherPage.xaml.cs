using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Schedule_UWP
{
    /// <summary>
    ///     An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TeacherPage : Page
    {
        public TeacherPage()
        {
            InitializeComponent();

            toolBar.ButtonToolBar += OpenCloseSideBar;
        }

        private void OpenCloseSideBar(object sender, EventArgs e)
        {
            if (sideBar.Visibility == Visibility.Collapsed)
                sideBar.Visibility = Visibility.Visible;
            else
                sideBar.Visibility = Visibility.Collapsed;
        }
    }
}