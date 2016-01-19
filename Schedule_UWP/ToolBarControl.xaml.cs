using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Schedule_UWP
{
    public sealed partial class ToolBarControl : UserControl
    {
        public ToolBarControl()
        {
            this.InitializeComponent();
        }

        public event EventHandler ButtonToolBar = delegate { };

        private void OnButtonToolBar()
        {
            ButtonToolBar(this, EventArgs.Empty);
        }

        private void ToolBarButton_OnClick(object sender, RoutedEventArgs e)
        {
            OnButtonToolBar();
        }
    }
}
