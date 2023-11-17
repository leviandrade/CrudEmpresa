using CrudEmpresa.Infra.Data.Mapeamentos;
using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
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

FluentMapper.Initialize(config =>
{
    config.AddMap(new EmpresaMap());
    config.ForDommel();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
