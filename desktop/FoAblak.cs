public partial class FoAblak : Form
{
    private readonly HttpClient http = new() { BaseAddress = new Uri("http://localhost:5000") };
    public FoAblak() => InitializeComponent();
    private async void FoAblak_Load(object sender, EventArgs e)
    {
        try
        {
            edzesekGrid.DataSource = await http.GetFromJsonAsync<List<EdzesDto>>("/api/edzesek");
        }
        catch (HttpRequestException)
        {
            MessageBox.Show("A szerver nem érhető el.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
