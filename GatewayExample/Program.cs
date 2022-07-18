using GatewayExample.Customer;
using GatewayExample.Product;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddOcelot(builder.Configuration);

builder.Configuration.AddJsonFile("ocelot.json",optional:false,reloadOnChange:true);

var app = builder.Build();
var cnfig = app.Configuration;
app.UseOcelot();



app.MapGet("/", () => "Hello World!");

app.Run();
