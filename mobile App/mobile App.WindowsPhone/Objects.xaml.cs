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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace mobile_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Objects : Page
    {
        public Objects()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Object3), null);
        }

        private void btna_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Menu), null);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Object4), null);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Object2), null);
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Object5), null);
        }
    }
}
