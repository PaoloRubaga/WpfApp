using System.Windows;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //creo la finistra di avvio
            //MainWindow wnd = new MainWindow();

            //if (e.Args.Length == 1)
            //    //wnd.OpenFile(e.Args[0]);

            //wnd.Title = "Finestra modificata da code behind";
            //wnd.Show();

            //ResourceSample res = new ResourceSample();
            //res.Show();

            //ExtendedResourceSample exRes = new ExtendedResourceSample();
            //exRes.Show();

            ResourcesFromCodeBehindSample resources = new ResourcesFromCodeBehindSample();
            resources.Show();
        }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("eccezione non gestita " + e.Exception.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Error);
            e.Handled = true;
        }
    }
}
