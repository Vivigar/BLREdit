using System.Numerics;
using System.Text.Json.Serialization;

namespace BLREdit.API.REST_API.Gitlab;

public sealed class GitlabIssueStats
{
    [JsonPropertyName("total")]
    public BigInteger Total { get; set; }
    [JsonPropertyName("closed")]
    public BigInteger Closed { get; set; }
}
