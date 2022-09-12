namespace SvgRectangleBug.SvgHelpers.Classes.SubClasses;
public class Text : BaseElement, IStart
{
    public string X { get; set; } = "0";
    public string Y { get; set; } = "0";
    public string Width { get; set; } = "0";
    public string Height { get; set; } = "0";
    public string Transform { get; set; } = "";
    public string Fill { get; set; } = "black"; 
    public double Font_Size { get; set; } = double.NaN;
    public double Opacity { get; set; } = double.NaN;
    public string Font_Weight { get; set; } = "";
    public string Text_Anchor { get; set; } = "";
    public string Dominant_Baseline { get; set; } = "";
    public string Transform_Origin { get; set; } = "";
    public List<IStart> Children { get; set; } = new();
    public string Content { get; set; } = "";
    bool IStart.GetCapturedRef => throw new Exception($"There was no property for GetCapturedRef.  Try running GetSpecificProperty");
    List<IStart> IStart.GetChildren => Children;
    string IStart.TypeUsed => "Text";
    List<CustomProperty> IStart.Properties()
    {
        List<CustomProperty> output = new();
        CustomProperty item;
        item = new()
        {
            IsDouble = false,
            AttributeName = "X",
            Value = X
        };
        output.Add(item);
        item = new()
        {
            IsDouble = false,
            AttributeName = "Y",
            Value = Y
        };
        output.Add(item);
        item = new()
        {
            IsDouble = false,
            AttributeName = "Width",
            Value = Width
        };
        output.Add(item);
        item = new()
        {
            IsDouble = false,
            AttributeName = "Height",
            Value = Height
        };
        output.Add(item);
        item = new()
        {
            IsDouble = false,
            AttributeName = "Transform",
            Value = Transform
        };
        output.Add(item);
        item = new()
        {
            IsDouble = false,
            AttributeName = "Fill",
            Value = Fill
        };
        output.Add(item);
        item = new()
        {
            IsDouble = true,
            AttributeName = "Font_Size",
            Value = Font_Size
        };
        output.Add(item);
        item = new()
        {
            IsDouble = true,
            AttributeName = "Opacity",
            Value = Opacity
        };
        output.Add(item);
        item = new()
        {
            IsDouble = false,
            AttributeName = "Font_Weight",
            Value = Font_Weight
        };
        output.Add(item);
        item = new()
        {
            IsDouble = false,
            AttributeName = "Text_Anchor",
            Value = Text_Anchor
        };
        output.Add(item);
        item = new()
        {
            IsDouble = false,
            AttributeName = "Dominant_Baseline",
            Value = Dominant_Baseline
        };
        output.Add(item);
        item = new()
        {
            IsDouble = false,
            AttributeName = "Transform_Origin",
            Value = Transform_Origin
        };
        output.Add(item);
        item = new()
        {
            IsDouble = false,
            AttributeName = "ClassName",
            Value = ClassName
        };
        output.Add(item);
        item = new()
        {
            IsDouble = false,
            AttributeName = "ID",
            Value = ID
        };
        output.Add(item);
        item = new()
        {
            IsDouble = false,
            AttributeName = "Style",
            Value = Style
        };
        output.Add(item);
        item = new()
        {
            IsDouble = false,
            AttributeName = "Content",
            Value = Content
        };
        output.Add(item);
        return output;
    }
    bool IStart.HasSpecificProperty(string name)
    {
        if (name == "CaptureRef")
        {
            return false;
        }
        if (name == "X")
        {
            return true;
        }
        if (name == "Y")
        {
            return true;
        }
        if (name == "Width")
        {
            return true;
        }
        if (name == "Height")
        {
            return true;
        }
        if (name == "Transform")
        {
            return true;
        }
        if (name == "Fill")
        {
            return true;
        }
        if (name == "Font_Size")
        {
            return true;
        }
        if (name == "Opacity")
        {
            return true;
        }
        if (name == "Font_Weight")
        {
            return true;
        }
        if (name == "Text_Anchor")
        {
            return true;
        }
        if (name == "Dominant_Baseline")
        {
            return true;
        }
        if (name == "Transform_Origin")
        {
            return true;
        }
        if (name == "ClassName")
        {
            return true;
        }
        if (name == "ID")
        {
            return true;
        }
        if (name == "Style")
        {
            return true;
        }
        if (name == "Content")
        {
            return true;
        }
        return false;
    }
    string IStart.GetSpecificProperty(string name)
    {
        if (name == "X")
        {
            return X.ToString();
        }
        if (name == "Y")
        {
            return Y.ToString();
        }
        if (name == "Width")
        {
            return Width.ToString();
        }
        if (name == "Height")
        {
            return Height.ToString();
        }
        if (name == "Transform")
        {
            return Transform.ToString();
        }
        if (name == "Fill")
        {
            return Fill.ToString();
        }
        if (name == "Font_Size")
        {
            return Font_Size.ToString();
        }
        if (name == "Opacity")
        {
            return Opacity.ToString();
        }
        if (name == "Font_Weight")
        {
            return Font_Weight.ToString();
        }
        if (name == "Text_Anchor")
        {
            return Text_Anchor.ToString();
        }
        if (name == "Dominant_Baseline")
        {
            return Dominant_Baseline.ToString();
        }
        if (name == "Transform_Origin")
        {
            return Transform_Origin.ToString();
        }
        if (name == "ClassName")
        {
            return ClassName.ToString();
        }
        if (name == "ID")
        {
            return ID.ToString();
        }
        if (name == "Style")
        {
            return Style.ToString();
        }
        if (name == "Content")
        {
            return Content.ToString();
        }
        throw new Exception($"Nothing found with property name {name}");
    }
}