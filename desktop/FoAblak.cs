public partial class FoAblak : Form
{
    private readonly HttpClient http = new() { BaseAddress = new Uri("http://localhost:5000") };
    public FoAblak() => InitializeComponent();
    private async void FoAblak_Load(object sender, EventArgs e)
    {
        var edzesek = await http.GetFromJsonAsync<List<EdzesDto>>("/api/edzesek");
        edzesekGrid.DataSource = edzesek;
    }
}
