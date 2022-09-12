namespace SvgRectangleBug.SvgHelpers.Classes.Interfaces;
public interface IStart
{
    bool HasSpecificProperty(string name);
    bool GetCapturedRef { get; }
    string GetSpecificProperty(string name);
    string TypeUsed { get; }
    List<CustomProperty> Properties();
    List<IStart> GetChildren { get; }
}