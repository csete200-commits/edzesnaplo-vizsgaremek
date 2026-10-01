var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<EdzesnaploDb>();
var app = builder.Build();

app.MapGet("/api/tagok", async (EdzesnaploDb db) => await db.Tagok.OrderBy(t => t.Nev).ToListAsync());

app.Run();
