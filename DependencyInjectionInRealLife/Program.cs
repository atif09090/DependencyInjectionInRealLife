using DependencyInjectionInRealLife.Application;
using DependencyInjectionInRealLife.Interfaces;
using DependencyInjectionInRealLife.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Register services
builder.Services.AddScoped<INotificationService, EmailNotificationService>(); // Or SmsNotificationService
builder.Services.AddScoped<INotificationService, SmsNotificationService>(); // Or SmsNotificationService

builder.Services.AddScoped<EfficientJobApplicationService>();
builder.Services.AddScoped<JobApplicationService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
