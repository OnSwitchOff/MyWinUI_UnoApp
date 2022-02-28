using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace MyWinUI_UnoApp.Skia.Tizen
{
	class Program
{
	static void Main(string[] args)
	{
		var host = new TizenHost(() => new MyWinUI_UnoApp.App(), args);
		host.Run();
	}
}
}
