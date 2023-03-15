namespace Planets;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		_ = builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("ChakraPetch-Bold.ttf", "BoldFont");
				fonts.AddFont("ChakraPetch-SemiBold.ttf", "SemiBoldFont");
				fonts.AddFont("ChakraPetch-Regular.ttf", "RegularFont");
			});

		return builder.Build();
	}
}
