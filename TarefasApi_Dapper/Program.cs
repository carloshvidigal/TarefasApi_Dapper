using TarefasApi.Extensions;
using TarefasApi_Dapper.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.AddPersistence();

var app = builder.Build();

app.MapTarefasEndpoints();

app.Run();
