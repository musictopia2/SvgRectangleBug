namespace SvgRectangleBug.Components;
public class SimpleGraphics : ComponentBase
{
    [Parameter]
    public EnumShape Shape { get; set; }
    [Parameter]
    public bool IsSelected { get; set; }
    [Parameter]
    public EventCallback Click { get; set; }
    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        //start with svg.
        builder.OpenRegion(0); //focus on svg section.
        builder.OpenElement(1, "svg"); //this is the first svg.
        builder.AddAttribute(2, "onclick", EventCallback.Factory.Create(this, e => Click.InvokeAsync()));
        builder.AddAttribute(3, "viewbox", "-1 -1 57 74");
        builder.AddAttribute(4, "width", "55");
        builder.AddAttribute(5, "height", "72");
        builder.AddAttribute(6, "xmlns", "http://www.w3.org/2000/svg");
        builder.OpenRegion(0); //this is for the group
        builder.OpenElement(1, "g");
        builder.OpenRegion(0);
        builder.OpenElement(1, "rect"); //this is the first rectangle.
        builder.AddAttribute(2, "x", "0");
        builder.AddAttribute(3, "y", "0");
        builder.AddAttribute(4, "rx", "6");
        builder.AddAttribute(5, "ry", "6");
        builder.AddAttribute(6, "width", "53");
        builder.AddAttribute(7, "height", "70");
        builder.AddAttribute(8, "fill", "white");
        builder.AddAttribute(9, "style", "stroke: black; stroke-width: 2px; stroke-miterlimit:4; font-family:tahoma; opacity: 1");
        builder.CloseElement();//closing first rectangle
        builder.CloseRegion();
        if (IsSelected)
        {
            //this is for selecting something.
            builder.OpenRegion(0);
            builder.OpenElement(1, "rect");
            builder.AddAttribute(2, "x", "0");
            builder.AddAttribute(3, "y", "0");
            builder.AddAttribute(4, "rx", "6");
            builder.AddAttribute(5, "ry", "6");
            builder.AddAttribute(6, "width", "53");
            builder.AddAttribute(7, "height", "70");
            builder.AddAttribute(8, "fill", "red");
            builder.AddAttribute(9, "fill-opacity", ".1");
            builder.CloseElement(); //closing selected rectangle.
            builder.CloseRegion();
        }
        if (Shape == EnumShape.Square)
        {
            builder.OpenRegion(0); //opening second rectangle
            builder.OpenElement(1, "rect");
            builder.AddAttribute(2, "x", "13");
            builder.AddAttribute(3, "y", "5");
            builder.AddAttribute(4, "rx", "0");
            builder.AddAttribute(5, "ry", "0");
            builder.AddAttribute(6, "width", "30");
            builder.AddAttribute(7, "height", "30");
            builder.AddAttribute(8, "fill", "red");
            builder.AddAttribute(9, "style", "stroke: black; stroke-width: 2px; stroke-miterlimit:4; font-family:tahoma; opacity: 1");
            builder.CloseElement(); //closing second rectangle.
            builder.CloseRegion();
        }
        else
        {
            builder.OpenRegion(0);
            builder.OpenElement(1, "circle");
            builder.AddAttribute(2, "cx", "28");
            builder.AddAttribute(3, "cy", "20");
            builder.AddAttribute(4, "r", "15");
            builder.AddAttribute(5, "fill", "red");
            builder.AddAttribute(6, "fill-opacity", "1");
            builder.AddAttribute(7, "style", "stroke: black; stroke-width: 2px; stroke-miterlimit:4; font-family:tahoma; opacity: 1");
            builder.CloseElement(); //closing circle.
            builder.CloseRegion();
        }
        builder.CloseElement(); //closing g
        builder.CloseRegion();
        builder.CloseElement(); //close svg
        builder.CloseRegion(); //close svg section.
        base.BuildRenderTree(builder);
    }
}