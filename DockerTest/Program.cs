namespace DockerTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args); 


            var app = builder.Build();
             

            app.MapGet("/test", (HttpContext httpContext) =>
            { 
                return $"test from {Environment.MachineName}";
            });

            app.MapGet("/hello", (HttpContext httpContext) =>
            {
                return $"hello from {Environment.MachineName}";
            });

            app.MapGet("/hi", (HttpContext httpContext) =>
            {
                return $"hi from {Environment.MachineName}";
            });

            app.MapGet("/", (HttpContext httpContext) =>
            {
                return $"welcome page from {Environment.MachineName}";
            });

            app.Run();
        }
    }
}
