var builder = WebApplication.CreateBuilder(args);

// Bật hỗ trợ cho Controllers
builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();

// Chuyển hướng các request tới đúng Controller
app.MapControllers();

app.Run();