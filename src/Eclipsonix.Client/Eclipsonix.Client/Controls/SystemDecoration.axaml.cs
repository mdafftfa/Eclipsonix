using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.VisualTree;

namespace Eclipsonix.Client.Controls;

public partial class SystemDecoration : UserControl
{
    public SystemDecoration()
    {
        InitializeComponent();
    }
    
    private void TitleBar_PointerPressed(object? sender, PointerPressedEventArgs e)
    {
        if (e.GetCurrentPoint(this).Properties.IsLeftButtonPressed)
        {
            var window = this.FindAncestorOfType<Window>();
            window?.BeginMoveDrag(e);
        }
    }

    private void MinimizeButton_Click(object? sender, RoutedEventArgs e)
    {
        var window = this.FindAncestorOfType<Window>();
        if (window != null)
        {
            window.WindowState = WindowState.Minimized;
        }
    }

    private void CloseButton_Click(object? sender, RoutedEventArgs e)
    {
        var window = this.FindAncestorOfType<Window>();
        window?.Close();
    }
}