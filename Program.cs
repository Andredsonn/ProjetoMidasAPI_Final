using Microsoft.EntityFrameworkCore;
using ProjetoMidasAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Escolha a conexão: ConexaoCasa ou ConexaoLocal
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoCasa")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
