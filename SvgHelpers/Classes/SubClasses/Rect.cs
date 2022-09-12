namespace SvgRectangleBug.SvgHelpers.Classes.SubClasses;
public class Rect : BaseElement, IImageSize, IStart
{
    public bool CaptureRef { get; set; } = false;
    public string X { get; set; } = "0";
    public string Y { get; set; } = "0";
    public string RX { get; set; } = "0";
    public string RY { get; set; } = "0";
    public string Width { get; set; } = "";
    public string Height { get; set; } = "";
    public string Fill { get; set; } = "none";
    public string Fill_Opacity { get; set; } = "";
    public CustomEventClass EventData { get; set; } = new CustomEventClass();
    public string Transform { get; set; } = "";
    public string Marker_Start { get; set; } = "";
    public string Marker_Mid { get; set; } = "";
    public string Marker_End { get; set; } = "";
    public string Mask { get; set; } = "";
    bool IStart.GetCapturedRef => CaptureRef;
    List<IStart> IStart.GetChildren => new();
    string IStart.TypeUsed => "Rect";
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
            AttributeName = "RX",
            Value = RX
        };
        output.Add(item);
        item = new()
        {
            IsDouble = false,
            AttributeName = "RY",
            Value = RY
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
            AttributeName = "Fill",
            Value = Fill
        };
        output.Add(item);
        item = new()
        {
            IsDouble = false,
            AttributeName = "Fill_Opacity",
            Value = Fill_Opacity
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
            AttributeName = "Marker_Start",
            Value = Marker_Start
        };
        output.Add(item);
        item = new()
        {
            IsDouble = false,
            AttributeName = "Marker_Mid",
            Value = Marker_Mid
        };
        output.Add(item);
        item = new()
        {
            IsDouble = false,
            AttributeName = "Marker_End",
            Value = Marker_End
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
        if (name == "X")
        {
            return true;
        }
        if (name == "Y")
        {
            return true;
        }
        if (name == "RX")
        {
            return true;
        }
        if (name == "RY")
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
        if (name == "Fill")
        {
            return true;
        }
        if (name == "Fill_Opacity")
        {
            return true;
        }
        if (name == "Transform")
        {
            return true;
        }
        if (name == "Marker_Start")
        {
            return true;
        }
        if (name == "Marker_Mid")
        {
            return true;
        }
        if (name == "Marker_End")
        {
            return true;
        }
        if (name == "Mask")
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
        if (name == "X")
        {
            return X.ToString();
        }
        if (name == "Y")
        {
            return Y.ToString();
        }
        if (name == "RX")
        {
            return RX.ToString();
        }
        if (name == "RY")
        {
            return RY.ToString();
        }
        if (name == "Width")
        {
            return Width.ToString();
        }
        if (name == "Height")
        {
            return Height.ToString();
        }
        if (name == "Fill")
        {
            return Fill.ToString();
        }
        if (name == "Fill_Opacity")
        {
            return Fill_Opacity.ToString();
        }
        if (name == "Transform")
        {
            return Transform.ToString();
        }
        if (name == "Marker_Start")
        {
            return Marker_Start.ToString();
        }
        if (name == "Marker_Mid")
        {
            return Marker_Mid.ToString();
        }
        if (name == "Marker_End")
        {
            return Marker_End.ToString();
        }
        if (name == "Mask")
        {
            return Mask.ToString();
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