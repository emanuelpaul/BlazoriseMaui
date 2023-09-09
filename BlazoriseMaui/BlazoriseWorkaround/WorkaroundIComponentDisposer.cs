using Blazorise;

namespace BlazoriseMaui.BlazoriseWorkaround;

internal class WorkaroundIComponentDisposer : IComponentDisposer
{
	void IComponentDisposer.Dispose<TComponent>(TComponent component)
	{
		// nothing to see here
	}
}