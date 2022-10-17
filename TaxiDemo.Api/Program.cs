using System.Reflection;
using TaxiDemo.Core.Contracts;
using TaxiDemo.Core.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo()
    {
        Title = "My Taxi tool Demo",
        Description = "This is Web for Available vehicles for Taxi orders -  direct",
        License = new Microsoft.OpenApi.Models.OpenApiLicense()
        {           
            Name = "VHP1 v 1.1"
        }
    });

    c.IncludeXmlComments("WebTaxiDocumentation.xml");

 });


builder.Services.AddScoped<ITaxiService, TaxiService>();

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
