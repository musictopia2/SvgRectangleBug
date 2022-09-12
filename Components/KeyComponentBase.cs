namespace SvgRectangleBug.Components;
public abstract class KeyComponentBase : ComponentBase
{
    protected static string GetKey => Guid.NewGuid().ToString();
}