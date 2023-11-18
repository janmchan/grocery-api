namespace grocery_backend;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddAuthorization();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapGet("/products", (HttpContext httpContext) =>
        {
            var forecast = new[]
            {
                new Product(1, "Egg", "Chicken Eggs"),
                new Product(1, "Milk", "Cow's Milk")
            };
            return forecast;
        })
        .WithName("GetProducts");

        app.Run();
    }
}
