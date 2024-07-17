using WorkerService1;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

//var builder = Host.CreateApplicationBuilder(args);
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddHostedService<Worker>();

builder.Services.AddWindowsService();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var host = builder.Build();

// Configure the HTTP request pipeline.
if (host.Environment.IsDevelopment())
{
    host.UseSwagger();
    host.UseSwaggerUI();
}

host.MapControllers();
host.Run();