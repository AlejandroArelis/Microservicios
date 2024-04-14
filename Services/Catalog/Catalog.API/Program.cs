var builder = WebApplication.CreateBuilder(args);

// Servicios
builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

var app = builder.Build();

// Peticiones http
app.MapCarter();

app.Run();
