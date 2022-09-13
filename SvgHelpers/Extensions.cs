namespace SvgRectangleBug.SvgHelpers;
public static class Extensions
{
    //internal static int StartAt { get; set; } = 1000;
    public static void AutoIncrementElement(this IStart start, IParentGraphic parent)
    {
        start.RenderUpTo = parent.ManuelUpTo;
        parent.ManuelUpTo++;
    }
    public static void PopulateStrokesToStyles(this BaseElement element, string color = "black", float strokeWidth = 1, string fontFamily = "default", double opacity = 1)
    {
        if (fontFamily == "default")
        {
            fontFamily = TextFontHelpers.BorderedTextFontFamily; //do here.  for now, only for doing strokes to styles.
        }
        element.Style = $"stroke: {color}; stroke-width: {strokeWidth}px; stroke-miterlimit:4; font-family:{fontFamily}; opacity: {opacity}";
    }
    public static void PopulateTextFont(this Text text, string fontFamily = "tahoma")
    {
        text.Style = $"font-family:{fontFamily};";
    }
    public static void CenterText(this Text text, IParentGraphic parent, RectangleF rect)
    {
        text.CenterText(parent, rect.X, rect.Y, rect.Width, rect.Height);
    }
    public static void CenterText(this Text text, IParentGraphic parent, Rect rect)
    {
        ISvg svg = new SVG();
        parent.Children.Add(svg);
        svg.X = rect.X;
        svg.Y = rect.Y;
        svg.Width = rect.Width;
        svg.Height = rect.Height;
        svg.Children.Add(text);
        text.CenterText();
    }
    public static void CenterText(this Text text, IParentGraphic parent, float x, float y, float width, float height)
    {
        ISvg svg = new SVG();
        parent.Children.Add(svg);
        svg.X = x.ToString();
        svg.Y = y.ToString();
        svg.Width = width.ToString();
        svg.Height = height.ToString();
        svg.Children.Add(text);
        text.CenterText();
    }
    public static void CenterText(this Text text)
    {
        text.Width = "100%";
        text.Height = "100%";
        text.X = "50%";
        text.Y = "55%";
        text.Dominant_Baseline = "middle";
        text.Text_Anchor = "middle";
    }
    public static void PopulateCircle(this Circle circle, float x, float y, float widthHeight, string customColor, double opacity = 1)
    {
        var value = (widthHeight / 2) + x;
        circle.CX = value.ToString();
        value = (widthHeight / 2) + y;
        circle.CY = value.ToString();
        circle.R = (widthHeight / 2).ToString();
        if (customColor != "")
        {
            circle.Fill = customColor;
        }
        circle.Fill_Opacity = opacity.ToString();
    }
    public static void PopulateCircle(this Circle circle, RectangleF rectangle, string customColor, double opacity = 1)
    {
        circle.PopulateCircle(rectangle.X, rectangle.Y, rectangle.Width, customColor, opacity);
    }
    public static void PopulateRectangle(this Rect rect, RectangleF rectangle)
    {
        rect.X = rectangle.X.ToString();
        rect.Y = rectangle.Y.ToString();
        rect.Width = rectangle.Width.ToString();
        rect.Height = rectangle.Height.ToString();
    }
    public static void PopulateRectangle(this Rect rect, float x, float y, float width, float height)
    {
        rect.PopulateRectangle(new RectangleF(x, y, width, height));
    }
    public static void PopulateSVGStartingPoint(this ISvg svg, RectangleF rectangle)
    {
        svg.X = rectangle.X.ToString();
        svg.Y = rectangle.Y.ToString();
        svg.Width = rectangle.Width.ToString();
        svg.Height = rectangle.Height.ToString();
    }
    public static void DrawCenteredText(this IParentGraphic parent, RectangleF rectangle, float fontSize, string text, string customColor)
    {
        Text tt = new();
        ISvg svg = new SVG();
        svg.PopulateSVGStartingPoint(rectangle);
        parent.Children.Add(svg);
        tt.CenterText();
        tt.Font_Size = fontSize;
        tt.Fill = customColor;
        svg.Children.Add(tt);
        tt.Content = text;
    }
}