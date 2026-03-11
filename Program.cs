var builder = WebApplication.CreateBuilder(args);

// Контроллеры
builder.Services.AddControllers();

// Swagger (Только Swashbuckle!)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger UI (только в Development)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
