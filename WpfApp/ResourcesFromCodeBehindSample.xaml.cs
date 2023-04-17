using System;
using System.Windows;

namespace WpfApp
{
    /// <summary>
    /// Logica di interazione per ResourcesFromCodeBehindSample.xaml
    /// </summary>
    public partial class ResourcesFromCodeBehindSample : Window
    {
        public ResourcesFromCodeBehindSample()
        {
            InitializeComponent();
        }

        private void btnClickbMe_Click(object sender, RoutedEventArgs e)
        {
            lbResult.Items.Add(pnlMain.FindResource("strPanel").ToString());
            lbResult.Items.Add(this.FindResource("strWindow").ToString());
            try
            {
                lbResult.Items.Add(Application.Current.FindResource("strPanel").ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("è successo il finimondo:" + ex.Message);
            }
            lbResult.Items.Add(Application.Current.FindResource("strPanel").ToString());

        }
    }
}
