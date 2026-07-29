using System.Text.Json;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation;

public class UnitShapeTests
{
    [Fact]
    public void OperationWithUnitInputAndOutput_ResolvesToEmptyStructures()
    {
        // smithy.api#Unit is the modeled form of "no input/output"; it is a prelude shape, so it
        // never appears in the index and must resolve to an empty structure instead of throwing.
        var modelJson = """
        {
          "smithy": "2.0",
          "shapes": {
            "com.example#MyService": {
              "type": "service",
              "version": "2023-01-01",
              "operations": [{ "target": "com.example#Ping" }],
              "traits": {
                "aws.api#service": { "sdkId": "Example", "endpointPrefix": "example" },
                "aws.protocols#restJson1": {}
              }
            },
            "com.example#Ping": {
              "type": "operation",
              "input": { "target": "smithy.api#Unit" },
              "output": { "target": "smithy.api#Unit" }
            }
          }
        }
        """;

        var model = JsonSerializer.Deserialize<SmithyModel>(modelJson, CloudTrailModelFixture.Options)!;
        var context = new GenerationContext(new ServiceIndex(model), new SdkVersionManifest
        {
            ServiceVersions = new Dictionary<string, ServiceVersion> { ["Example"] = new() { Version = "4.0.0.0" } },
        });

        var operation = Assert.Single(context.Operations);
        Assert.Empty(operation.Input.Members);
        Assert.Empty(operation.Output.Members);
    }
}
