using System.Text.Json;
using System.Text.Json.Nodes;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Writers.Endpoints;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Endpoints;

/// <summary>
/// Pins the C# BddProviderWriter emits for every supported BDD function and result shape, using
/// endpoint-bdd-model.json (one condition per function, plus the fleet's coalesce/ite forms).
/// </summary>
public class BddProviderWriterTests
{
    private const string ModelPath = "Codegen/endpoint-bdd-model.json";
    private const string ModelFileName = "smithy.json";

    private readonly string _output = new BddProviderWriter(TestModels.Context(ModelPath), ModelFileName).Write(TestContext.Current.CancellationToken);

    [Fact]
    public void ImplementsConditionEvaluatorExplicitlyOverPrivateContext()
    {
        Assert.Contains("public class AmazonExampleEndpointProvider : IEndpointProvider, IBddConditionEvaluator<AmazonExampleEndpointProvider.Context>", _output);
        Assert.Contains("private sealed class Context", _output);
        Assert.Contains("bool IBddConditionEvaluator<Context>.EvaluateCondition(int conditionIndex, Context context)", _output);
    }

    [Theory]
    [InlineData("global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Partition PartitionResult")]
    [InlineData("global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Arn BucketArn")]
    [InlineData("global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.URL Url")]
    [InlineData("object ArnResource")]
    [InlineData("string BucketPrefix")]
    [InlineData("string EncodedBucket")]
    [InlineData("IList<string> BucketParts")]
    [InlineData("string DualStackSuffix")]
    [InlineData("string AuthName")]
    public void ContextHasTypedFieldPerAssign(string field)
    {
        Assert.Contains($"public {field} {{ get; set; }}", _output);
    }

    [Theory]
    [InlineData("return IsSet(context.Parameters.Region);")]
    [InlineData("return Equals(context.Parameters.UseFIPS, true);")]
    [InlineData("""return Equals(GetAttr(context.PartitionResult, "name"), "aws");""")]
    [InlineData("return !IsSet(context.Parameters.Endpoint);")]
    [InlineData("return IsValidHostLabel((string)context.Parameters.Bucket, false);")]
    [InlineData("return IsVirtualHostableS3Bucket((string)context.Parameters.Bucket, false);")]
    public void BooleanConditionsReturnTheCall(string line)
    {
        Assert.Contains(line, _output);
    }

    [Theory]
    [InlineData("return (context.PartitionResult = Partition((string)context.Parameters.Region)) != null;")]
    [InlineData("return (context.BucketArn = ParseArn((string)context.Parameters.Bucket)) != null;")]
    [InlineData("""return (context.ArnResource = GetAttr(context.BucketArn, "resourceId[0]")) != null;""")]
    [InlineData("return (context.BucketPrefix = Substring((string)context.Parameters.Bucket, 0, 4, false)) != null;")]
    [InlineData("return (context.EncodedBucket = UriEncode((string)context.Parameters.Bucket)) != null;")]
    [InlineData("""return (context.BucketParts = Split((string)context.Parameters.Bucket, "-", 0)) != null;""")]
    [InlineData("return (context.Url = ParseURL((string)context.Parameters.Endpoint)) != null;")]
    public void AssignConditionsStoreTheResultAndCheckForNull(string line)
    {
        Assert.Contains(line, _output);
    }

    [Theory]
    [InlineData("return Equals((context.Parameters.UseDualStack ?? false), true);")]
    [InlineData("""return Equals((Substring((string)context.Parameters.Bucket, 0, 1, false) ?? ""), "a");""")]
    public void CoalesceIsParenthesized(string line)
    {
        Assert.Contains(line, _output);
    }

    [Theory]
    [InlineData("""return (context.DualStackSuffix = (context.Parameters.UseDualStack == true ? ".dualstack" : "")) != null;""")]
    [InlineData("""return (context.AuthName = ((context.Parameters.UseDualStack ?? false) == true ? "sigv4" : "sigv4a")) != null;""")]
    public void IteAssignsAParenthesizedTernary(string line)
    {
        Assert.Contains(line, _output);
    }

    [Fact]
    public void EndpointResultUnrollsUrlTemplate()
    {
        Assert.Contains("""return new Endpoint($"https://example{context.DualStackSuffix}.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")""", _output);
    }

    [Fact]
    public void EndpointResultEmitsTypedAuthSchemes()
    {
        Assert.Contains(
            """AuthSchemes = new AuthScheme[] { new AuthScheme($"{context.AuthName}", "example", $"{context.Parameters.Region}", null, true), new AuthScheme("sigv4a", "example", null, new List<string> { "*" }, null) },""",
            _output);
    }

    [Fact]
    public void EndpointResultEmitsOtherPropertiesAsPropertyBag()
    {
        Assert.Contains("""Attributes = new PropertyBag { ["backend"] = "S3Express", ["metricValues"] = new List<object> { "O" } },""", _output);
    }

    [Fact]
    public void EndpointResultEmitsHeaders()
    {
        Assert.Contains("""Headers = new Dictionary<string, IList<string>> { ["x-amz-region"] = new List<string> { $"{context.Parameters.Region}" } },""", _output);
    }

    [Fact]
    public void ReferenceUrlIsCastToString()
    {
        Assert.Contains("return new Endpoint((string)context.Parameters.Endpoint);", _output);
    }

    [Fact]
    public void PlainEndpointHasNoInitializer()
    {
        Assert.Contains("""return new Endpoint("https://example.amazonaws.com");""", _output);
    }

    [Fact]
    public void ErrorResultThrowsInterpolatedMessage()
    {
        Assert.Contains("""throw new AmazonClientException($"Invalid region: {context.Parameters.Region}");""", _output);
    }

    [Fact]
    public void TemplateEscapesQuotesAndBackslashes()
    {
        var context = ContextWith(bdd => bdd["results"]![2]!["error"] = "Bad \"region\" C:\\x {Region}");

        var output = new BddProviderWriter(context, ModelFileName).Write(TestContext.Current.CancellationToken);

        Assert.Contains("""throw new AmazonClientException($"Bad \"region\" C:\\x {context.Parameters.Region}");""", output);
    }

    [Fact]
    public void UnassignedTopLevelIteIsRejected()
    {
        var context = ContextWith(bdd => bdd["conditions"]!.AsArray().Add(JsonNode.Parse("""{ "fn": "ite", "argv": [{ "ref": "UseFIPS" }, "a", "b"] }""")));

        var ex = Assert.Throws<GeneratorException>(() => new BddProviderWriter(context, ModelFileName).Write(TestContext.Current.CancellationToken));
        Assert.Contains("top-level condition", ex.Message);
    }

    [Fact]
    public void UnknownAuthSchemeFieldIsRejected()
    {
        var context = ContextWith(bdd => bdd["results"]![0]!["endpoint"]!["properties"]!["authSchemes"]![0]!["signingFoo"] = "x");

        var ex = Assert.Throws<GeneratorException>(() => new BddProviderWriter(context, ModelFileName).Write(TestContext.Current.CancellationToken));
        Assert.Contains("signingFoo", ex.Message);
    }

    // Loads the fixture, applies mutate to its endpointBdd trait, and builds a context from the result.
    private static GenerationContext ContextWith(Action<JsonNode> mutate)
    {
        var root = JsonNode.Parse(File.ReadAllText(Path.Combine("TestData", ModelPath)))!;
        mutate(root["shapes"]!["com.example#Example"]!["traits"]!["smithy.rules#endpointBdd"]!);
        var model = JsonSerializer.Deserialize<SmithyModel>(root.ToJsonString(), TestModels.Options)
            ?? throw new InvalidOperationException("Mutated model deserialized to null.");
        return TestModels.Context(model);
    }
}
