using System.Text.Json.Serialization;

namespace SmithyDotNet.Generator.Generation.Customizations;

/// <summary>The <c>simpleMethods</c> hook: convenience client overloads keyed by operation name.</summary>
public sealed record SimpleMethodsCustomization
{
    [JsonPropertyName("operations")]
    public Dictionary<string, SimpleMethodForms> Operations { get; init; } = [];
}

/// <summary>One operation's <c>simpleMethods</c> entry: each form lists the request members an overload takes.</summary>
public sealed record SimpleMethodForms
{
    [JsonPropertyName("methodForms")]
    public List<List<string>> Forms { get; init; } = [];
}

/// <summary>The <c>simpleConstructors</c> hook: convenience constructors keyed by request/structure class name.</summary>
public sealed record SimpleConstructorsCustomization
{
    [JsonPropertyName("constructors")]
    public Dictionary<string, SimpleConstructorForms> Constructors { get; init; } = [];
}

/// <summary>One class's <c>simpleConstructors</c> entry: each form lists the members a constructor takes.</summary>
public sealed record SimpleConstructorForms
{
    [JsonPropertyName("constructorForms")]
    public List<List<string>> Forms { get; init; } = [];
}
