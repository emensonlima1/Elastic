namespace Domain.Models;

public class LogViewModel
{
    [Nest.PropertyName("@timestamp")]
    public DateTimeOffset Timestamp { get; set; }
    [Nest.PropertyName("message")]
    public string? Message { get; set; }
    [Nest.PropertyName("log.level")]
    public string? Level { get; set; }
    [Nest.PropertyName("metadata")]
    public MetadataViewModel? Metadata { get; set; }
    [Nest.PropertyName("process")]
    public ProcessViewModel? Process { get; set; }
}