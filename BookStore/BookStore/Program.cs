namespace BookStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();



            /* Middlewares
             app.Use(async (context,next) =>
            {
                await context.Response.WriteAsync("Hello from my first middleware ");
                await next.Invoke();

                await context.Response.WriteAsync("Hello from my first middleware response ");

            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from my second middleware ");
                await next.Invoke();

                await context.Response.WriteAsync("Hello from my second middleware response ");

            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello from my third middleware");
            });*/


            //app.MapGet("/", () => "Hello World!");

            app.MapDefaultControllerRoute();

            app.Run();


        }
    }
}