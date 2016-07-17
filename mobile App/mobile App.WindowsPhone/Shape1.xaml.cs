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
    public sealed partial class Shape1 : Page
    {

        public float perimeter;
        public float radius;
        public float area;
        public float diameter;
        public string radiusDisplay;
        public String areaDisplay;
        public String diameterDisplay;
        public String input1;
        public Shape1()
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

        private void btna_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Menu), null);
        }

        private void tstParimeter_TextChanged(object sender, TextChangedEventArgs e)
        {
            input1 = tstParimeter.Text;
            perimeter = Convert.ToSingle(input1);
        }        
        private void PerimeterBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RadiusBtn_Click(object sender, RoutedEventArgs e)
        {
            radius = perimeter / (2 * 22 / 7);
            radiusDisplay = Convert.ToString(radius);
            tstRadius.Text = radiusDisplay + "cm";
        }

        private void DiameterBtn_Click(object sender, RoutedEventArgs e)
        {
            diameter = perimeter / (22 / 7);
            diameterDisplay = Convert.ToString(diameter);
            tstDiameter.Text = diameterDisplay + "cm";
        }
    }
}
