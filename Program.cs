using Microsoft.AspNetCore.Localization;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();


var app = builder.Build();

app.MapControllers();
app.MapGet("/", () => "Hello World! Привет, мир!");


app.Run();
