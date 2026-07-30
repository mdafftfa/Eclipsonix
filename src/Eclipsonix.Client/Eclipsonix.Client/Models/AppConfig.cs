namespace Eclipsonix.Client.Models;

public class AppConfig
{
    public int FirstLineIndex { get; set; } = 1;
    public int SecondLineIndex { get; set; } = 2;
    public int LargeIconIndex { get; set; } = 2;
    public int SmallIconIndex { get; set; } = 3;
    public int LargeIconTextIndex { get; set; } = 2;
    public int SmallIconTextIndex { get; set; } = 3;
    public bool EnableRpc { get; set; } = true;
}