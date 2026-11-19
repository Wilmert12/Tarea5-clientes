var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// CORS: permite que Blazor (navegador) llame a la API
builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirBlazor", policy =>
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod());
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseCors("PermitirBlazor");
app.UseAuthorization();
app.MapControllers();

app.Run();