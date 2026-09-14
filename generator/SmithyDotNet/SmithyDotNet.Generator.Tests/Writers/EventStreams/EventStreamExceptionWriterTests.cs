using System.Text.RegularExpressions;
using SmithyDotNet.Generator.Writers.EventStreams;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.EventStreams;

public class EventStreamExceptionWriterTests
{
    private const string ModelFileName = "example-2023-01-01.normal.json";

    private readonly string _source;

    public EventStreamExceptionWriterTests()
    {
        var context = TestModels.Context("Codegen/event-stream-model.json");
        _source = new EventStreamExceptionWriter(context, ModelFileName).Write(TestContext.Current.CancellationToken);
    }

    [Fact]
    public void EmitsPartialClassInBaseNamespace()
    {
        Assert.Contains("namespace Amazon.Example", _source);
        Assert.DoesNotContain("namespace Amazon.Example.Model", _source);
        Assert.Contains("public partial class ExampleEventStreamException : EventStreamException", _source);
    }

    [Fact]
    public void EmitsLicenseHeaderAndSerializableAttribute()
    {
        Assert.Contains("Licensed under the Apache License", _source);
        Assert.Contains("#if !NETSTANDARD", _source);
        Assert.Contains("[Serializable]", _source);
    }

    [Fact]
    public void EmitsThreeForwardingConstructors()
    {
        Assert.Equal(3, Regex.Count(_source, @"public ExampleEventStreamException\("));
        Assert.Contains("public ExampleEventStreamException() : base()", _source);
        Assert.Contains("public ExampleEventStreamException(string message) : base(message)", _source);
        Assert.Contains("public ExampleEventStreamException(string message, Exception innerException) : base(message, innerException)", _source);
    }

    [Fact]
    public void EmitsSerializationConstructorWithoutGetObjectData()
    {
        Assert.Contains("protected ExampleEventStreamException(System.Runtime.Serialization.SerializationInfo info", _source);
        Assert.DoesNotContain("GetObjectData", _source);
    }

    [Fact]
    public void DocContentMatchesC2J()
    {
        Assert.Contains("/// Modeled Exception that either comes over the stream from the service model, or wraps other exceptions for the purpose of raising events. If it is", _source);
        Assert.Contains("/// modelled, it will be a subclass.", _source);
        Assert.Contains("/// Creates a new ExampleEventStreamException", _source);
    }
}
