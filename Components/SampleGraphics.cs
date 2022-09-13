﻿namespace SvgRectangleBug.Components;
public class SampleGraphics : BaseDeckGraphics
{
    [Parameter]
    public EnumShape Shape { get; set; }
    protected override SizeF DefaultSize => new(55, 72);
    protected override void DrawImage()
    {
        string color = "red";
        var shapeRect = new RectangleF(13, 5, 30, 30);
        if (Shape == EnumShape.Square)
        {
            Rect rect = new();
            rect.PopulateRectangle(shapeRect);
            //rect.AutoIncrementElement(MainGroup!);
            //this means for anything, i can go ahead and increment for cases where i need it.
            //rect.RenderUpTo = 1000; //try at 1000 here.
            rect.Fill = color;
            rect.PopulateStrokesToStyles(strokeWidth: 2);
            MainGroup!.Children.Add(rect);
            rect = new();
            shapeRect = new(45, 5, 30, 30);
            rect.PopulateRectangle(shapeRect);
            rect.Fill = color;
            rect.AutoIncrementElement(MainGroup);
            rect.PopulateStrokesToStyles(strokeWidth: 2);
            MainGroup.Children.Add(rect);

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
            throw new Exception("Triangles are no longer supported");
        }
        var textRect = new RectangleF(0, 35, 55, 25);
        var fontSize = textRect.Height;
        Text text = new();
        text.CenterText(MainGroup, textRect);
        text.Font_Size = fontSize;
        text.Fill = color;
        text.PopulateStrokesToStyles();
        text.Content = "5";
    }
}