using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace InYourFace
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            ExtendsContentIntoTitleBar = true;

            this.AppWindow.Resize(new Windows.Graphics.SizeInt32(1584, 396));
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            //myButton.Content = "Clicked";

            this.AppWindow.SetPresenter(Microsoft.UI.Windowing.AppWindowPresenterKind.FullScreen);
        }
    }
}
