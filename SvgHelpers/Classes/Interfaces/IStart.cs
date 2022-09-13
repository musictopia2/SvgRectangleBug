namespace SvgRectangleBug.SvgHelpers.Classes.Interfaces;
public interface IStart
{
    int RenderUpTo { get; set; }
    bool HasSpecificProperty(string name);
    bool GetCapturedRef { get; }
    string GetSpecificProperty(string name);
    string TypeUsed { get; }
    List<CustomProperty> Properties();
    List<IStart> GetChildren { get; }
}