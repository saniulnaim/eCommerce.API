var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Add Swagger
builder.Services.AddEndpointsApiExplorer(); // For API exploere services
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    // Swagger (must come after UseRouting)
    app.UseSwagger(); // Add endpoint that can serve the swagger.json
    app.UseSwaggerUI(); // Adds swagger UI
}

app.MapControllers();

app.Run();
