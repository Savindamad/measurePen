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
    public sealed partial class Menu : Page
    {
        public Menu()
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

        private void btnShapes_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Shapes), null);
        }

        private void btnObjects_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Objects), null);

        }

        private void btnMotionGraphs_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MotionGraph), null);
        }

        private void btnWeakEye_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(WeakEye), null);
        }

        private void btnFashion_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FashionMen), null);
        }

        private void txt1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
