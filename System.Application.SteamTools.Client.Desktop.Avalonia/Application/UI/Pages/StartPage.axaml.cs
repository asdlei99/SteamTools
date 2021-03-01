using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System.Application.UI.ViewModels;

namespace System.Application.UI.Views.Pages
{
    public class StartPage : UserControl
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}