namespace Domain.Models;

public class ProcessViewModel
{
    [Nest.PropertyName("name")]
    public string? ApplicationName { get; set; }
}
