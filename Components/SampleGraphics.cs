namespace SvgRectangleBug.Components;
public class SampleGraphics : BaseDeckGraphics
{
    [Parameter]
    public EnumShape Shape { get; set; }
    protected override SizeF DefaultSize => new(55, 72);
    protected override void DrawImage()
    {
        string color = cs.Red;
        var shapeRect = new RectangleF(13, 5, 30, 30);
        if (Shape == EnumShape.Square)
        {
            Rect rect = new();
            rect.PopulateRectangle(shapeRect);
            rect.Fill = color.ToWebColor();
            rect.PopulateStrokesToStyles(strokeWidth: 2);
            MainGroup!.Children.Add(rect);
        }
        else if (Shape == EnumShape.Circle)
        {
            Circle circle = new();
            circle.PopulateCircle(shapeRect, color);
            circle.PopulateStrokesToStyles(strokeWidth: 2);
            MainGroup!.Children.Add(circle);
        }
        else
        {
            Polygon poly = shapeRect.PopulateTrianglePolygon(color);
            poly.PopulateStrokesToStyles(strokeWidth: 2);
            MainGroup!.Children.Add(poly);
        }
        var textRect = new RectangleF(0, 35, 55, 25);
        var fontSize = textRect.Height;
        Text text = new();
        text.CenterText(MainGroup, textRect);
        text.Font_Size = fontSize;
        text.Fill = color.ToWebColor();
        text.PopulateStrokesToStyles();
        text.Content = "5";
    }
}