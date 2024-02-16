using BookOfRecipe.Repository;
using Domain;
using Domain.Entitys;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Logging;



namespace BookOfRecipe
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
            builder.Services.AddScoped<Context>();
            builder.Services.AddScoped<IRepository<RecipeDTO>,RecipeRepository >();
            builder.Services.AddScoped<IRepository<IngredientDTO>,IngredientRepository >();
            
#endif

            return builder.Build();
        }
    }
}
