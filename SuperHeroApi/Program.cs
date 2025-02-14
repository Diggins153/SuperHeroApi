using Microsoft.EntityFrameworkCore;
using SuperHeroApi.Data;

var builder = WebApplication.CreateBuilder(args);

var connectionString = "server=bvsoihq2zoccp2fsqs1h-mysql.services.clever-cloud.com;database=bvsoihq2zoccp2fsqs1h;user=ubqit6veicdjliuo;password=ih7eaOAH3O54Sl53p1Wu";
var serverVersion = new MySqlServerVersion(new Version(8,0,30));
// Add services to the container.
builder.Services.AddControllers();

//old
//builder.Services.AddDbContext<DataContext>(opt => opt.UseInMemoryDatabase("DataContext"));

//new
builder.Services.AddDbContext<DataContext>(opt =>
    opt.UseMySql(connectionString, serverVersion));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
