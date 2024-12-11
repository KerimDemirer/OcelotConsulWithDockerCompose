using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Provider.Consul;
using Ocelot.Provider.Polly;
using WebApiGateway.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Configuration.AddJsonFile($"Configurations/ocelot.{builder.Environment.EnvironmentName}.json", false, true).AddEnvironmentVariables();

builder.Services.AddControllers();
builder.Services.AddOcelot().AddConsul<MyConsulServiceBuilder>().AddPolly();
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();
app.UseOcelot().Wait();

app.Run();
