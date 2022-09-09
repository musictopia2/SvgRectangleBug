using System.Reflection; //not common enough.
namespace SvgRectangleBug.Components;
public abstract class GraphicsCommand : KeyComponentBase
{
    protected Assembly GetAssembly => Assembly.GetAssembly(GetType())!; //needs reflection namespace for the images.  decided to not attempt to string based on problems i ran across.
    [Parameter]
    public EventCallback Click { get; set; }
    public void CreateClick(ISvg svg)
    {
        svg.EventData.ActionClicked = Clicked;
    }
    private async Task Clicked(object args1, object args2)
    {
        await Submit();
    }
    protected virtual async Task Submit()
    {
        if (Click.HasDelegate)
        {
            await Click.InvokeAsync();
        }
    }
}