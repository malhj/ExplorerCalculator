﻿
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace ExplorerCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        /* 
         * Initialization: the functions below handle initialization and autofill, etc
         * */

        public MainWindow()
        {
            InitializeComponent();
            CalculatePlotRange();
            this.Icon = Properties.Resources.explorer_AXa_icon.ToImageSource();

        }


        private void ImageInit(object sender, EventArgs e)
        {
            Bitmap bitmap = Properties.Resources.explorer;
            CentralImg.Source = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(bitmap.GetHbitmap(), IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions()); // Image is an image source
        }
        


        private void FillBoxes(object sender, EventArgs e) // Fill in on init, not MainWindow init, otherwise text box may be nil
        {

            JumpRangeBox.Text = Properties.Settings.Default.JumpRange.ToString(); // Automatically fill in the last saved jump range on app start
            // Note: it's stored as double so that this can also serve as a global variable when calculating

            
        }

        private void FillBoxes_d(object sender, EventArgs e)
        {
            DistanceBox.Text = Properties.Settings.Default.Distance.ToString();
        }


        /*
         * Input events: two functions below handle text box input
         * */

        private void JumpRange_TextChanged(object sender, TextChangedEventArgs e)
        {
            double d;
            bool isValid = double.TryParse(JumpRangeBox.Text, out d);
            if (isValid == true)
            {
                Properties.Settings.Default.JumpRange = d; // Set the setting as d, our attempted-to-parse variable (if we're in this if, it will have parsed properly)
                Properties.Settings.Default.Save(); // Save the user's jump range in Settings (AppData)
                Properties.Settings.Default.Reload();

                CalculatePlotRange(); // Recalculate


            }

        }

        private void Distance_TextChanged(object sender, TextChangedEventArgs e)
        {
            double d;
            bool isValid = double.TryParse(DistanceBox.Text, out d);
            if (isValid == true)
            {
                Properties.Settings.Default.Distance = d;
                Properties.Settings.Default.Save(); // Save the user's distance in Settings (AppData)
                Properties.Settings.Default.Reload();

                CalculatePlotRange(); // Recalculate


            }
        }

        /*
         * Calculation: The function below performs the ultimate calculation.
         * */


        public void CalculatePlotRange()
        {
            /*  N is the maximum number of full range jumps you can do within 1000Ly - e.g. 1000 / 35 = 28.57..., so N = 28
                M is the distance travelled by that number of jumps - e.g. 35 * 28 = 980
                D is the distance you are from Sgr A*, in 1000Ly - so if you're at about 15k from A*, D = 15

                Plot = M - ((N / 4) + (D * 2)) */

            int N; // You can't do half a jump so int is appropriate
            double M; // However jump ranges can be decimals, so range*n will not always be int
            double D = Properties.Settings.Default.Distance; // Retrieve distance
            double J = Properties.Settings.Default.JumpRange;

            // Establish variables fully
            

            N = (int)Math.Floor(1000 / J); // Cast to int the floored number of jumps 
            // (again you can't do half a jump, and the specification above shows rounding down, even when above upper bound)

            M = J * N; // Get distance travelled in those jumps

            // Final calculation:

            double PlotRange =
                M - ((N / 4) + (D * 2)); // I made it easy for myself :)

            string NewText = PlotRange.ToString() + " ly"; // Set label content


            if (PlotRangeLabel != null) // It bitches if I don't have this
            {
                PlotRangeLabel.Content = NewText;
            }

            
        }

        private void Save(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            Properties.Settings.Default.Upgrade();
        }



       

    }

    internal static class IconUtilities
    {
        /* Credit to Stackoverflow - Kenan E. K */
        [DllImport("gdi32.dll", SetLastError = true)]
        private static extern bool DeleteObject(IntPtr hObject);

        public static ImageSource ToImageSource(this Icon icon)
        {
            Bitmap bitmap = icon.ToBitmap();
            IntPtr hBitmap = bitmap.GetHbitmap();

            ImageSource wpfBitmap = Imaging.CreateBitmapSourceFromHBitmap(
                hBitmap,
                IntPtr.Zero,
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());

            if (!DeleteObject(hBitmap))
            {
                throw new Win32Exception();
            }

            return wpfBitmap;
        }
    }
}
