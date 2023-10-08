using Avalonia.Controls;
using SkiaSharp;

namespace ExampleUI.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
        CanvasControl.Draw += (_, e) =>
        {
            e.Canvas.DrawRect(SKRect.Create(0f, 0f, 100f, 100f), new SKPaint { Color = SKColors.Aqua });
        };
    }
}
