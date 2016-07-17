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
    public sealed partial class Object3 : Page
    {

        public float length;
        public float breadth;
        public float height;
        public float area;
        public float volume;
        public String areaDisplay;
        public String volumeDisplay;
        public String input1;
        public String input2;
        public String input3;

        public Object3()
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
            length = Convert.ToSingle(input1);
        }

        private void tstHeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            input3 = tstParimeter.Text;
            height = Convert.ToSingle(input2);
        }

        private void AreaBtn_Click(object sender, RoutedEventArgs e)
        {
            area = (length*breadth+length*height+breadth*height)*2;
            areaDisplay = Convert.ToString(area);
            tstArea.Text = areaDisplay+ "cm\xB2";
        }

        private void VolumeBtn_Click(object sender, RoutedEventArgs e)
        {
            volume = length*height*breadth;
            volumeDisplay = Convert.ToString(volume);
            tstVolume.Text = volumeDisplay+ "cm\xB3";
        }

        private void PerimeterBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tstBreadth_TextChanged(object sender, TextChangedEventArgs e)
        {
            input2 = tstParimeter.Text;
            breadth = Convert.ToSingle(input2);
        }
    }
}
