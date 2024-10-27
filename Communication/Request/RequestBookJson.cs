namespace LibraryManagementApi.Communication.Request;

public class RequestBookJson
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public double Price { get; set; }
    public int Quantity { get; set; }
}
