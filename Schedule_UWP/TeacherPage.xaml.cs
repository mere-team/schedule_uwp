using System;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Models;
using ScheduleApi;
using Schedule_UWP;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Schedule_UWP
{
    /// <summary>
    ///     An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TeacherPage : Page
    {
        private readonly TeacherScheduleApi _scheduleApi;

        public TeacherPage()
        {
            InitializeComponent();

            _scheduleApi = new TeacherScheduleApi();

            ToolBar.ButtonToolBar += OpenCloseSideBar;
            SideBar.TeacherListTapped += OpenTeacherList;
        }

        private void OpenTeacherList(object sender, EventArgs e)
        {
            //List<Teacher> teachers = await _scheduleApi.GetListObjectsAsync<Teacher>();

            UserControl = new TeacherListControl();

            UpdateLayout();
        }

        private void OpenCloseSideBar(object sender, EventArgs e)
        {
            if (SideBar.Visibility == Visibility.Collapsed)
                SideBar.Visibility = Visibility.Visible;
            else
                SideBar.Visibility = Visibility.Collapsed;
        }

        private void UserControl_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            if (SideBar.Visibility == Visibility.Visible)
                SideBar.Visibility = Visibility.Collapsed;
        }
    }
}