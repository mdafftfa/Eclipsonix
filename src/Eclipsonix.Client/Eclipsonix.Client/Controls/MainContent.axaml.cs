using Avalonia.Controls;
using Avalonia.Threading;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Eclipsonix.Client.Models;

namespace Eclipsonix.Client.Controls;

public partial class MainContent : UserControl, INotifyPropertyChanged
{
    private int _seconds = 0;
    
    private LineModel.Type firstLine;
    private LineModel.Type secondLine;
    private LineModel.Type largeIconPath;
    private LineModel.Type smallIconPath;
    private bool isRichPresenceEnabled;
    
    private string _elapsedTimeFormatted = "00:00"; 
    private DispatcherTimer _timer;

    public string ElapsedTimeFormatted
    {
        get => _elapsedTimeFormatted;
        set
        {
            if (_elapsedTimeFormatted != value)
            {
                _elapsedTimeFormatted = value;
                OnPropertyChanged();
            }
        }
    }

    public MainContent()
    {
        InitializeComponent();
        
        DataContext = this; 
        _timer = new DispatcherTimer
        {
            Interval = TimeSpan.FromSeconds(1)
        };
        _timer.Tick += (sender, args) => 
        {
            UpdateSeconds(_seconds + 1); 
        };
        _timer.Start();
    }

    public void UpdateSeconds(int newSeconds)
    {
        _seconds = newSeconds;
        
        TimeSpan time = TimeSpan.FromSeconds(_seconds);
        
        if (time.TotalHours >= 1)
            ElapsedTimeFormatted = time.ToString(@"hh\:mm\:ss");
        else
            ElapsedTimeFormatted = time.ToString(@"mm\:ss");
    }

    public new event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}