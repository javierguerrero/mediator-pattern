using Notifications;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registro de instancias de manejadores
builder.Services.AddTransient<INotificationHandler, NotificationHandler1>();
builder.Services.AddTransient<INotificationHandler, NotificationHandler2>();
builder.Services.AddTransient<INotificationHandler, NotificationHandler3>();

builder.Services.AddTransient<IMediator, Mediator>();

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
