using Microsoft.Web.WebView2.Core;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace InteropBetweenWebView2AndCSharp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void MainPageLoaded(object sender, RoutedEventArgs e)
        {
            await WebView2.EnsureCoreWebView2Async();

            WebView2.CoreWebView2.SetVirtualHostNameToFolderMapping(
                "webview2.uwp.example",
                "Assets/html",
                CoreWebView2HostResourceAccessKind.Allow);
            WebView2.Source = new Uri("http://webview2.uwp.example/index.html");
        }

        private void LoadImageButtonClicked(object sender, RoutedEventArgs e)
        {

        }
    }
}
