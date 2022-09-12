namespace SvgRectangleBug.SvgHelpers.Classes.SubClasses;
public partial class G : IParentGraphic, IStart
{
    public string ID { get; set; } = "";
    public string Transform { get; set; } = "";
    public string Font_Family { get; set; } = "";
    public string Text_Anchor { get; set; } = "";
    public string Fill { get; set; } = "";
    public string Mask { get; set; } = "";
    public CustomEventClass EventData { get; set; } = new CustomEventClass();
    public List<IStart> Children { get; set; } = new();
    public string ClipPath { get; set; } = "";
    bool IStart.GetCapturedRef => throw new Exception($"There was no property for GetCapturedRef.  Try running GetSpecificProperty");
    List<IStart> IStart.GetChildren => Children;
    string IStart.TypeUsed => "G";
    List<CustomProperty> IStart.Properties()
    {
        List<CustomProperty> output = new();
        CustomProperty item;
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
            AttributeName = "Transform",
            Value = Transform
        };
        output.Add(item);
        item = new()
        {
            IsDouble = false,
            AttributeName = "Font_Family",
            Value = Font_Family
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
            AttributeName = "Fill",
            Value = Fill
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
            AttributeName = "EventData",
            Value = EventData
        };
        output.Add(item);
        item = new()
        {
            IsDouble = false,
            AttributeName = "ClipPath",
            Value = ClipPath
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
        if (name == "ID")
        {
            return true;
        }
        if (name == "Transform")
        {
            return true;
        }
        if (name == "Font_Family")
        {
            return true;
        }
        if (name == "Text_Anchor")
        {
            return true;
        }
        if (name == "Fill")
        {
            return true;
        }
        if (name == "Mask")
        {
            return true;
        }
        if (name == "ClipPath")
        {
            return true;
        }
        return false;
    }
    string IStart.GetSpecificProperty(string name)
    {
        if (name == "ID")
        {
            return ID.ToString();
        }
        if (name == "Transform")
        {
            return Transform.ToString();
        }
        if (name == "Font_Family")
        {
            return Font_Family.ToString();
        }
        if (name == "Text_Anchor")
        {
            return Text_Anchor.ToString();
        }
        if (name == "Fill")
        {
            return Fill.ToString();
        }
        if (name == "Mask")
        {
            return Mask.ToString();
        }
        if (name == "ClipPath")
        {
            return ClipPath.ToString();
        }
        throw new Exception($"Nothing found with property name {name}");
    }
}