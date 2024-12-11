using Microsoft.Extensions.Options;
using Services.Core.ServiceDiscovery.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddConsul(builder.Configuration.GetServiceConfig());
builder.Services.AddHealthChecks();
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();
app.UseHealthChecks("/healthz");
app.MapControllers();

app.Run();
