namespace SvgRectangleBug.SvgHelpers.Classes.Interfaces;
public interface IParentGraphic
{
    List<IStart> Children { get; set; }
}