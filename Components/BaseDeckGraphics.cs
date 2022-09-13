namespace SvgRectangleBug.Components;
public abstract class BaseDeckGraphics : GraphicsCommand
{
    [Parameter]
    public PointF Location { get; set; }
    [Parameter]
    public string TargetWidth { get; set; } = ""; //this focus on width alone.
    [Parameter]
    public string TargetHeight { get; set; } = ""; //this focus on height alone.
    [Parameter]
    public string TargetSize { get; set; } = ""; //this focus on the largest of them.
    [Parameter]
    public bool IsSelected { get; set; }
    protected abstract SizeF DefaultSize { get; } //i think this makes the most sense now.
    [Parameter]
    public float LongestSize { get; set; } //needs to have many options on setting the sizes needed.
    protected float BorderWidth { get; set; } = 2; //defaults at 4 but anybody can override that part.
    protected G? MainGroup { get; set; }
    private void PopulateCustomViewBox(ISvg svg)
    {
        var value = BorderWidth / 2 * -1;
        svg.ViewBox = $"{value} {value} {DefaultSize.Height + BorderWidth} {DefaultSize.Width + BorderWidth}";
    }
    protected float Scale()
    {
        if (LongestSize == 0)
        {
            return 1;
        }
        if (DefaultSize.Width <= DefaultSize.Height)
        {
            return LongestSize / DefaultSize.Height;
        }
        return LongestSize / DefaultSize.Width;
    }
    protected double GetDarkHighlighter() => .25;
    protected double GetLightHighlighter() => .1;
    protected string FillColor { set; get; } = "white";
    protected float RoundedRadius = 6;
    protected virtual bool ShowDisabledColors { get; } = false;
    protected virtual void DrawHighlighters()
    {
        if (IsSelected == false)
        {
            return;
        }
        Rect rect = StartRectangle();
        rect.Fill_Opacity = GetOpacity;
        rect.Fill = SelectFillColor;
        MainGroup!.Children.Add(rect);
    }
    protected virtual string GetOpacity => GetLightHighlighter().ToString();
    protected virtual string SelectFillColor => "red";
    protected Rect StartRectangle()
    {
        Rect output = new();
        output.Width = (DefaultSize.Width - BorderWidth).ToString();
        output.AutoIncrementElement(MainGroup!);
        output.Height = (DefaultSize.Height - BorderWidth).ToString();
        output.RX = RoundedRadius.ToString();
        output.RY = RoundedRadius.ToString();
        return output;
    }
    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {

        ISvg svg = new SVG();
        SvgRenderClass render = new();
        if (TargetSize != "")
        {
            if (DefaultSize.Width >= DefaultSize.Height)
            {
                svg.Width = TargetSize;
            }
            else
            {
                svg.Height = TargetSize;
            }
            svg.X = Location.X.ToString();
            svg.Y = Location.Y.ToString();
            PopulateCustomViewBox(svg);
        }
        else if (TargetHeight != "")
        {
            svg.Height = TargetHeight;
            PopulateCustomViewBox(svg);
        }
        else if (TargetWidth != "")
        {
            svg.Width = TargetWidth;
            PopulateCustomViewBox(svg);
        }
        else
        {
            svg.X = Location.X.ToString();
            svg.Y = Location.Y.ToString();
            var value = Scale() * DefaultSize.Width;
            svg.Width = value.ToString();
            value = Scale() * DefaultSize.Height;
            svg.Height = value.ToString();
            value = BorderWidth / 2 * -1;
            svg.ViewBox = $"{value} {value} {DefaultSize.Width + BorderWidth} {DefaultSize.Height + BorderWidth}";
        }

        MainGroup = new G();
        svg.Children.Add(MainGroup);
        Rect rect = StartRectangle();
        rect.PopulateStrokesToStyles(strokeWidth: (int)BorderWidth);
        BeforeFilling();
        rect.Fill = FillColor;
        MainGroup.Children.Add(rect);
        DrawHighlighters();
        DrawImage();
        CreateClick(svg);
        render.RenderSvgTree(svg, 0, builder);
        base.BuildRenderTree(builder);
    }
    protected virtual void BeforeFilling() { }
    protected abstract void DrawImage();
}