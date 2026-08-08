var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#if (IncludeSwagger)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#endif

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
#if (IncludeSwagger)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
#endif

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();