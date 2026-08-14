using System.Text.Json;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation;

/// <summary>
/// Guards that <see cref="ServiceGenerator"/> emits unmarshallers for structures reachable *only*
/// through an exception's rich members (a nested structure and a list-of-structure). The generated
/// exception unmarshaller references those <c>*Unmarshaller</c> types, so a missing file is a latent
/// compile break — one the writer-level string assertions in <c>RichExceptionCodegenTests</c> can't
/// catch because they never run the orchestration that decides which files to emit.
/// </summary>
[Collection(nameof(CloudTrailModelCollection))]
public class RichExceptionServiceGeneratorTests : IDisposable
{
    private const string ModelFileName = "example-2023-01-01.normal.json";

    // One operation whose only error, ResourceConflict, reaches two structures the rest of the model
    // does not: ConflictDetails (nested) and RelatedResource (list element). Both must get unmarshallers.
    private const string ModelJson = """
    {
      "smithy": "2.0",
      "shapes": {
        "com.example#Example": {
          "type": "service",
          "version": "2023-01-01",
          "operations": [{ "target": "com.example#DoThing" }],
          "traits": {
            "aws.api#service": { "sdkId": "Example", "endpointPrefix": "example" },
            "aws.protocols#restJson1": {},
            "smithy.api#title": "Example Service"
          }
        },
        "com.example#DoThing": {
          "type": "operation",
          "input": { "target": "smithy.api#Unit" },
          "output": { "target": "smithy.api#Unit" },
          "errors": [{ "target": "com.example#ResourceConflict" }],
          "traits": { "smithy.api#http": { "uri": "/things", "method": "POST" } }
        },
        "com.example#ResourceConflict": {
          "type": "structure",
          "members": {
            "message": { "target": "smithy.api#String" },
            "details": { "target": "com.example#ConflictDetails" },
            "related": { "target": "com.example#ResourceList" }
          },
          "traits": { "smithy.api#error": "client" }
        },
        "com.example#ConflictDetails": {
          "type": "structure",
          "members": { "reason": { "target": "smithy.api#String" } }
        },
        "com.example#ResourceList": {
          "type": "list",
          "member": { "target": "com.example#RelatedResource" }
        },
        "com.example#RelatedResource": {
          "type": "structure",
          "members": { "arn": { "target": "smithy.api#String" } }
        }
      }
    }
    """;

    private readonly string _outputDir;
    private readonly string _codeAnalysisDir;
    private readonly IReadOnlyList<string> _written;

    public RichExceptionServiceGeneratorTests(CloudTrailModelFixture fixture)
    {
        // Depend on the collection fixture only so its constructor runs TargetPlatforms.Initialize
        // (the csproj writers read it); this test drives its own inline model, and borrows the
        // fixture's default-configuration modes to satisfy the default-configuration writer.
        var model = JsonSerializer.Deserialize<SmithyModel>(ModelJson, CloudTrailModelFixture.Options)
            ?? throw new InvalidOperationException("Model deserialized to null.");
        var context = new GenerationContext(new ServiceIndex(model), new SdkVersionManifest
        {
            CoreVersion = "4.0.0.0",
            ServiceVersions = new Dictionary<string, ServiceVersion> { ["Example"] = new() { Version = "4.0.0.0" } },
        });

        _outputDir = Path.Combine(Path.GetTempPath(), $"smithy-gen-test-{Guid.NewGuid():N}");
        _codeAnalysisDir = Path.Combine(Path.GetTempPath(), $"smithy-gen-test-{Guid.NewGuid():N}");

        var generator = new ServiceGenerator(context, ModelFileName, "4.0.0.0", fixture.DefaultConfigurationModes);
        _written = generator.Generate(_outputDir, _codeAnalysisDir, testsOutputPath: null, TestContext.Current.CancellationToken);
    }

    public void Dispose()
    {
        foreach (var dir in new[] { _outputDir, _codeAnalysisDir })
        {
            if (Directory.Exists(dir))
            {
                Directory.Delete(dir, recursive: true);
            }
        }
    }

    [Fact]
    public void EmitsUnmarshallersForStructuresReachableOnlyThroughException()
    {
        var marshalling = Path.Combine("Generated", "Model", "Internal", "MarshallTransformations");
        AssertWritten(Path.Combine(marshalling, "ResourceConflictExceptionUnmarshaller.g.cs"));
        AssertWritten(Path.Combine(marshalling, "ConflictDetailsUnmarshaller.g.cs"));
        AssertWritten(Path.Combine(marshalling, "RelatedResourceUnmarshaller.g.cs"));
    }

    private void AssertWritten(string relativePath)
    {
        Assert.True(File.Exists(Path.Combine(_outputDir, relativePath)), $"Expected file: {relativePath}");
        Assert.Contains(relativePath, _written);
    }
}
