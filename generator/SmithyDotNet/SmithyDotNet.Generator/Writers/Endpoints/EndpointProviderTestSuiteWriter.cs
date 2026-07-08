using System.Text.RegularExpressions;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers.Endpoints;

/// <summary>
/// Emits the endpoint provider unit tests (e.g. <c>CloudTrailDataEndpointProviderTests.g.cs</c>):
/// one <c>[TestMethod]</c> per <c>smithy.rules#endpointTests</c> case, each constructing
/// <c>{ServiceName}EndpointParameters</c>, calling <c>Amazon{ServiceName}EndpointProvider.ResolveEndpoint</c>,
/// and asserting either the resolved URL or the thrown <see cref="Amazon.Runtime.AmazonClientException"/>
/// message. Matches the legacy generator's behavior of asserting only <c>endpoint.URL</c> — no pinned
/// test file anywhere in the SDK asserts resolved endpoint properties or headers, so those aren't
/// emitted here either.
/// </summary>
public sealed partial class EndpointProviderTestSuiteWriter(GenerationContext context, string modelFileName)
{
    /// <summary>
    /// Emits the endpoint provider tests source. The endpoint test suite is required; callers gate on
    /// <see cref="GenerationContext.HasEndpointTests"/>.
    /// </summary>
    public string Write(CancellationToken cancellationToken = default)
    {
        var suite = context.EndpointTests ?? throw new GeneratorException("EndpointProviderTestSuiteWriter requires an endpoint test suite.");
        var className = $"{context.ServiceName}EndpointsTests";

        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, [.. FileHeader.EndpointProviderTestsUsings, $"{context.Namespace}.Endpoints", $"{context.Namespace}.Internal"]);
        writer.OpenNamespace("AWSSDK_DotNet.UnitTests.Endpoints", () =>
        {
            writer.WriteLine("[TestClass]");
            writer.WriteLine("[TestCategory(\"UnitTest\")]");
            writer.WriteLine("[TestCategory(\"Endpoints\")]");
            writer.WriteLine($"[TestCategory({CodeWriter.Literal(context.ServiceName)})]");
            writer.OpenBlock($"public partial class {className}", () =>
            {
                // Test cases can sanitize to the same method name (e.g. differently-worded
                // documentation that both strip down to the same identifier); dedupe across the
                // whole file the way the legacy generator does, with a numeric suffix.
                var usedNames = new Dictionary<string, int>();
                for (var i = 0; i < suite.TestCases.Count; i++)
                {
                    WriteTestMethod(writer, suite.TestCases[i], usedNames);
                    if (i < suite.TestCases.Count - 1)
                    {
                        writer.WriteLine();
                    }
                }
            });
        });

        return writer.ToFormattedString(cancellationToken);
    }

    private void WriteTestMethod(CodeWriter writer, EndpointTestCase testCase, Dictionary<string, int> usedNames)
    {
        var testName = ToTestName(testCase.Documentation, usedNames);
        var parametersName = $"{context.ServiceName}EndpointParameters";
        var providerName = $"{context.ClientName}EndpointProvider";

        writer.WriteLine("[TestMethod]");
        writer.WriteLine($"[Description({CodeWriter.Literal(testCase.Documentation)})]");
        writer.OpenBlock($"public void {testName}_Test()", () =>
        {
            writer.WriteLine($"var parameters = new {parametersName}();");
            foreach (var (name, value) in testCase.Params)
            {
                writer.WriteLine($"parameters[\"{name}\"] = {CodeWriter.NativeValue(value)};");
            }

            var error = testCase.Expect.Error;
            var endpoint = testCase.Expect.Endpoint;
            if (error is not null && endpoint is not null)
            {
                throw new GeneratorException($"Endpoint test case '{testCase.Documentation}' has both 'endpoint' and 'error' in its expectation.");
            }

            if (error is not null)
            {
                writer.OpenBlock($"var exception = Assert.ThrowsExactly<AmazonClientException>(() =>", "});", () =>
                {
                    writer.WriteLine($"new {providerName}().ResolveEndpoint(parameters);");
                });
                writer.WriteLine($"Assert.AreEqual(@\"{SanitizeQuotes(error)}\", exception.Message);");
            }
            else if (endpoint is not null)
            {
                writer.WriteLine($"var endpoint = new {providerName}().ResolveEndpoint(parameters);");
                writer.WriteLine($"Assert.AreEqual({CodeWriter.Literal(endpoint.Url)}, endpoint.URL);");
            }
            else
            {
                throw new GeneratorException($"Endpoint test case '{testCase.Documentation}' has neither 'endpoint' nor 'error' in its expectation.");
            }
        });
    }

    // Mirrors the legacy generator's ToTestName: sanitize the case documentation into a valid,
    // unique C# identifier. usedNames tracks collisions across the whole file (some documentation
    // strings sanitize to the same identifier), appending a numeric suffix on repeats.
    private static string ToTestName(string documentation, Dictionary<string, int> usedNames)
    {
        var name = documentation.Trim().Replace(" ", "_");
        if (name.Length > 0 && char.IsDigit(name[0]))
        {
            name = "_" + name;
        }

        name = NonAlphanumericOrUnderscoreRegex().Replace(name, string.Empty).Replace("__", "_");
        name = SdkNaming.ToUpperFirstCharacter(name);

        if (!usedNames.TryGetValue(name, out var count))
        {
            usedNames[name] = 0;
            return name;
        }

        count++;
        usedNames[name] = count;
        return $"{name}_{count}";
    }

    private static string SanitizeQuotes(string value) => value.Replace("\"", "\"\"");

    [GeneratedRegex("[^a-zA-Z0-9_]")]
    private static partial Regex NonAlphanumericOrUnderscoreRegex();
}
