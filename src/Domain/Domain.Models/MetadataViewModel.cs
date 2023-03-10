namespace Domain.Models;

public class MetadataViewModel
{
    [Nest.PropertyName("message_template")]
    public string? MessageTemplate { get; set; }
    [Nest.PropertyName("correlation_id")]
    public string? CorrelationId { get; set; }
}