namespace SvgRectangleBug.SvgHelpers.Classes.SubClasses;
public partial class SVG : BaseElement, IImageSize, IParentGraphic, ISvg
{
    public bool CaptureRef { get; set; } = false;
    public string Width { get; set; } = "";
    public string Height { get; set; } = "";
    public CustomEventClass EventData { get; set; } = new();
    public string Transform { get; set; } = "";
    public string Xmlns { get; set; } = "http://www.w3.org/2000/svg";
    public string ViewBox { get; set; } = "";
    public string PreserveAspectRatio { get; set; } = "";
    public string Mask { get; set; } = "";
    public string X { get; set; } = "0";
    public string Y { get; set; } = "0";
    public List<IStart> Children { get; set; } = new();
    bool IStart.GetCapturedRef => CaptureRef;
    List<IStart> IStart.GetChildren => Children;
    string IStart.TypeUsed => "SVG";

    int IParentGraphic.ManuelUpTo { get; set; } = 1000;

    List<CustomProperty> IStart.Properties()
    {
        List<CustomProperty> output = new();
        CustomProperty item;
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
            AttributeName = "EventData",
            Value = EventData
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
            AttributeName = "Xmlns",
            Value = Xmlns
        };
        output.Add(item);
        item = new()
        {
            IsDouble = false,
            AttributeName = "ViewBox",
            Value = ViewBox
        };
        output.Add(item);
        item = new()
        {
            IsDouble = false,
            AttributeName = "PreserveAspectRatio",
            Value = PreserveAspectRatio
        };
        output.Add(item);
        item = new()
        {
            IsDouble = false,
            AttributeName = "Mask",
            Value = Mask
        };
        output.Add(item);
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
        return output;
    }
    bool IStart.HasSpecificProperty(string name)
    {
        if (name == "CaptureRef")
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
        if (name == "Xmlns")
        {
            return true;
        }
        if (name == "ViewBox")
        {
            return true;
        }
        if (name == "PreserveAspectRatio")
        {
            return true;
        }
        if (name == "Mask")
        {
            return true;
        }
        if (name == "X")
        {
            return true;
        }
        if (name == "Y")
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
        return false;
    }
    string IStart.GetSpecificProperty(string name)
    {
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
        if (name == "Xmlns")
        {
            return Xmlns.ToString();
        }
        if (name == "ViewBox")
        {
            return ViewBox.ToString();
        }
        if (name == "PreserveAspectRatio")
        {
            return PreserveAspectRatio.ToString();
        }
        if (name == "Mask")
        {
            return Mask.ToString();
        }
        if (name == "X")
        {
            return X.ToString();
        }
        if (name == "Y")
        {
            return Y.ToString();
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
        throw new Exception($"Nothing found with property name {name}");
    }
}