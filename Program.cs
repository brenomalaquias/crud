using crud.Data;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("CRUD");
builder.Services.AddSqlite<AppDbContext>(connString);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
