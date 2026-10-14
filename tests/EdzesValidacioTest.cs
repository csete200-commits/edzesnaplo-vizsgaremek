public class EdzesValidacioTest
{
    [Fact]
    public void Nulla_perces_edzes_hibas() => Assert.False(Edzes.Ervenyes(new UjEdzes("2026-10-01", "úszás", "Nagy edző", 0)));
}
