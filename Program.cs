
using universidades;
using universidades.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//BD Conexion
builder.Services.AddSqlServer<context>("Data Source=localhost,1433; Initial Catalog=universidadesDB;user id=sa;password=r00t.R00t;Encrypt=False");
builder.Services.AddScoped <ICountryService, CountryService> ();
builder.Services.AddScoped <IrankingSystemService, rankingSystemService> ();
builder.Services.AddScoped <universityService, universityService> ();
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