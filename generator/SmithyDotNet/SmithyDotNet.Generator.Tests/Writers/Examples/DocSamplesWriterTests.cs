using System.Text.Json;
using System.Text.RegularExpressions;
using SmithyDotNet.Generator.Generation.Customizations;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;
using SmithyDotNet.Generator.Writers.Examples;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Examples;

/// <summary>
/// Covers the doc samples built from <c>smithy.api#examples</c>, which render values as C2J's <c>Example.cs</c>
/// does, with the SDK's types.
/// </summary>
public class DocSamplesWriterTests
{
    private const string ModelPath = "Codegen/examples-model.json";

    // PutItem covers every value kind: its keys are unsorted, "Enabled" differs in case from its member, "unknown"
    // (and Items' "zzz") match no member, "retries" and "verbose" are strings, "events" is a request event stream,
    // "expiresAt" is epoch milliseconds (out of range as seconds), and its title and documentation need XML
    // escaping. ListReports has no documentation.
    [Fact]
    public void Write_PinsOneOperationSampleAndMetadata()
    {
        var context = TestModels.Context(ModelPath);
        var collected = DocSamplesWriter.Collect(context);
        var samples = new DocSamplesWriter(context).Write(collected).ReplaceLineEndings("\n");
        var metadata = new DocSampleMetadataWriter(context).Write(collected).ReplaceLineEndings("\n");

        Assert.Contains("""
                    public void SamplesPutItem()
                    {
                        #region PutItem-1

                        var client = new AmazonSamplesClient();
                        var response = client.PutItem(new PutItemRequest
                        {
                            Enabled = true,
                            Attributes = new global::Amazon.Runtime.Documents.Document {
                                { "empty", new global::Amazon.Runtime.Documents.Document(new Dictionary<string, global::Amazon.Runtime.Documents.Document>()) },
                                { "emptyList", new global::Amazon.Runtime.Documents.Document(new List<global::Amazon.Runtime.Documents.Document>()) },
                                { "k", "v" },
                                { "list", new global::Amazon.Runtime.Documents.Document {
                                    1,
                                    true
                                } },
                                { "none", new global::Amazon.Runtime.Documents.Document() }
                            },
                            Body = new MemoryStream(<binary data>),
                            Count = 3,
                            CreatedAt = new DateTime(2024, 1, 2, 15, 4, 5, DateTimeKind.Utc),
                            ExpiresAt = DateTime.UtcNow,
                            Items = new List<Item> {
                                new Item {
                                    Id = "i-1",
                                    Size = 10,
                                }
                            },
                            Level = 2,
                            Name = "C:\\temp\nnext",
                            Owner = new Owner {  },
                            Ratio = 1,
                            Retries = 5,
                            Status = "ACTIVE",
                            Tags = new Dictionary<string, string> {
                                { "a", "1" },
                                { "b", "2" }
                            },
                            UpdatedAt = new DateTime(2018, 1, 9, 20, 51, 21, 123, DateTimeKind.Utc),
                            Verbose = false,
                            Weight = 2.5f
                        });

                        List<string> arnList = response.ARNList;
                        DateTime? createdAt = response.CreatedAt;
                        string @event = response.Event;
                        string itemId = response.ItemId;
                        string awsNamespace = response.Namespace;
                        Status status = response.Status;
                        int? total = response.Total;

                        #endregion
                    }
            """.ReplaceLineEndings("\n"), samples, StringComparison.Ordinal);
        Assert.DoesNotContain("Publisher", samples, StringComparison.Ordinal);

        Assert.Contains("""
              <doc>
                <members>
                  <member name="M:Amazon.Samples.IAmazonSamples.PutItem(Amazon.Samples.Model.PutItemRequest)" />
                  <member name="M:Amazon.Samples.AmazonSamplesClient.PutItem(Amazon.Samples.Model.PutItemRequest)" />
                  <member name="T:Amazon.Samples.Model.PutItemRequest" />
                  <member name="T:Amazon.Samples.Model.PutItemResponse" />
                </members>
                <value>
                  <example>
                    <para>
                      Puts an item &lt;fast&gt;. Done
                    </para>
                    <code title="Put an &quot;item&quot; &amp; more" source=".\AWSSDKDocSamples\Samples\Samples.GeneratedSamples.cs" region="PutItem-1" />
                  </example>
                </value>
              </doc>
            """.ReplaceLineEndings("\n"), metadata, StringComparison.Ordinal);
        Assert.Contains("""
                    <para>

                    </para>
                    <code title="First"
            """.ReplaceLineEndings("\n"), metadata, StringComparison.Ordinal);

        // Operations are ordered ignoring case and each one's examples are numbered. The docgenerator
        // (NDocUtilities.PreprocessCodeBlocksToPreTags) takes the first "#region {id}" in the samples file, so that
        // line must be exactly this id's.
        string[] expected = ["ListReports-1", "ListReports-2", "ListReportVersions-1", "PutItem-1"];
        Assert.Equal(expected, Regex.Matches(samples, @"#region (\S+-\d+)").Select(m => m.Groups[1].Value));
        Assert.Equal(expected, Regex.Matches(metadata, """region="([^"]+)""").Select(m => m.Groups[1].Value));
        foreach (var id in expected)
        {
            var start = samples.IndexOf($"#region {id}", StringComparison.Ordinal);
            Assert.True(start >= 0, $"#region {id} is missing.");
            Assert.Equal($"#region {id}", samples[start..samples.IndexOf('\n', start)]);
        }
    }

    // Example keys are modeled names, but C2J matches them to the renamed member: a rename that changes more
    // than case drops the value from the sample (ec2's IpPermission.IpRanges, renamed Ipv4Ranges).
    [Fact]
    public void Write_MatchesKeysToRenamedMembers_AsC2JDoes()
    {
        var context = TestModels.Context(TestModels.Load(ModelPath), new CustomizationsModel
        {
            ShapeModifiers =
            {
                ["PutItemRequest"] = new ShapeModifier
                {
                    Modify = [new() { ["name"] = new PropertyModifier { EmitPropertyName = "Label" }, ["count"] = new PropertyModifier { EmitPropertyName = "Count" } }],
                },
            },
        });
        var samples = new DocSamplesWriter(context).Write(DocSamplesWriter.Collect(context));

        Assert.DoesNotContain("Name = ", samples, StringComparison.Ordinal);
        Assert.DoesNotContain("Label = ", samples, StringComparison.Ordinal);
        Assert.Contains("Count = 3,", samples, StringComparison.Ordinal);
    }

    // C2J names the response local after the emitted name as written: "itemID" is itemid, where the modeled
    // name would give itemId and the property name itemID.
    [Fact]
    public void Write_NamesResponseLocalAfterEmittedName()
    {
        var context = TestModels.Context(TestModels.Load(ModelPath), new CustomizationsModel
        {
            ShapeModifiers = { ["PutItemResponse"] = new ShapeModifier { Modify = [new() { ["itemId"] = new PropertyModifier { EmitPropertyName = "itemID" } }] } },
        });
        var samples = new DocSamplesWriter(context).Write(DocSamplesWriter.Collect(context));

        Assert.Contains("string itemid = response.ItemID;", samples, StringComparison.Ordinal);
    }

    [Fact]
    public void Collect_OnlyForAModelWithExamples_AndNeverForS3()
    {
        Assert.NotEmpty(DocSamplesWriter.Collect(TestModels.Context(ModelPath)));
        Assert.Empty(DocSamplesWriter.Collect(TestModels.Context("Codegen/codegen-model.json")));

        var s3 = TestModels.Load(ModelPath);
        var service = Assert.IsType<ServiceShape>(s3.Shapes["com.amazonaws.samples#SamplesService"]);
        service.Traits["aws.api#service"] = JsonSerializer.SerializeToElement(new { sdkId = "S3", endpointPrefix = "s3" });
        Assert.Empty(DocSamplesWriter.Collect(TestModels.Context(s3)));
    }

    // Surfaced as a GeneratorException so the batch names the failing service.
    [Fact]
    public void GetExamples_WithoutTitle_Throws()
    {
        var operation = TestModels.DeserializeShape("""{ "type": "operation", "traits": { "smithy.api#examples": [{ "input": {} }] } }""");

        var ex = Assert.Throws<GeneratorException>(() => operation.GetExamples());
        Assert.Contains("'com.example#Shape' has an invalid smithy.api#examples trait", ex.Message, StringComparison.Ordinal);
    }
}
