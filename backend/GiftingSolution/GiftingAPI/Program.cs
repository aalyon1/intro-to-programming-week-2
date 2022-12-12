using GiftingApi.Domain;
using GiftingAPI.Adapters;
using GiftingAPI.Domain;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ICatalogPeople, FakePeopleCatalog>();

builder.Services.AddDbContext<GiftingDataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("gifts"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
