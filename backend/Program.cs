var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<EdzesnaploDb>();
var app = builder.Build();

app.MapGet("/api/tagok", async (EdzesnaploDb db) => await db.Tagok.OrderBy(t => t.Nev).ToListAsync());

app.MapGet("/api/edzesek", async (string? szakosztaly, EdzesnaploDb db) =>
    await db.Edzesek.Where(e => szakosztaly == null || e.Szakosztaly == szakosztaly).OrderBy(e => e.Datum).ToListAsync());

app.MapPost("/api/edzesek", async (UjEdzes uj, EdzesnaploDb db) =>
{
    if (string.IsNullOrWhiteSpace(uj.Edzo) || uj.IdotartamPerc <= 0) return Results.BadRequest("Hiányzó vagy hibás adat.");
    var e = new Edzes { Datum = uj.Datum, Szakosztaly = uj.Szakosztaly, Edzo = uj.Edzo, IdotartamPerc = uj.IdotartamPerc };
    db.Edzesek.Add(e); await db.SaveChangesAsync();
    return Results.Created($"/api/edzesek/{e.Id}", e);
});

app.Run();
