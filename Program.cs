using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
builder.Services.UseExchangeApi();
var app = builder.Build();

app.MapExchangeApi();
app.UseCors("corspolicy");
app.Run();


