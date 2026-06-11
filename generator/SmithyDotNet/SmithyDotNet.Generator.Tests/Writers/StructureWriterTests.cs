using System.Text.RegularExpressions;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers;

[Collection(nameof(CloudTrailModelCollection))]
public class StructureWriterTests
{
    private const string ModelFileName = "cloudtrail-data-2021-08-11.normal.json";
    private const string Namespace = "com.amazonaws.cloudtraildata";

    private readonly string _auditEvent;
    private readonly string _resultErrorEntry;
    private readonly string _auditEventResultEntry;

    public StructureWriterTests(CloudTrailModelFixture fixture)
    {
        var writer = new StructureWriter(fixture.Context, ModelFileName);
        _auditEvent = WriteStructure(fixture.Context, writer, "AuditEvent");
        _resultErrorEntry = WriteStructure(fixture.Context, writer, "ResultErrorEntry");
        _auditEventResultEntry = WriteStructure(fixture.Context, writer, "AuditEventResultEntry");
    }

    private static string WriteStructure(GenerationContext context, StructureWriter writer, string shapeName)
    {
        var shapeId = ShapeId.Parse($"{Namespace}#{shapeName}");
        var structure = (StructureShape)context.Resolve(shapeId);
        return writer.Write(structure, shapeId, TestContext.Current.CancellationToken);
    }

    [Fact]
    public void AuditEvent_EmitsExpectedPublicSurface()
    {
        Assert.Contains("namespace Amazon.CloudTrailData.Model", _auditEvent);
        Assert.Contains("public partial class AuditEvent", _auditEvent);
        Assert.Contains("public string EventData", _auditEvent);
        Assert.Contains("public string EventDataChecksum", _auditEvent);
        Assert.Contains("public string Id", _auditEvent);

        // EventData is @required (no length) -> Required only.
        // (Roslyn formatter normalizes attribute args to "Name = value" with spaces.)
        Assert.Contains("[AWSProperty(Required = true)]", _auditEvent);

        // Id targets Uuid (@length min 1 max 128) and is @required.
        Assert.Contains("[AWSProperty(Required = true, Min = 1, Max = 128)]", _auditEvent);
    }

    [Fact]
    public void AuditEvent_SortsMembersAlphabetically()
    {
        // Model declares id, eventData, eventDataChecksum; output must be alphabetical by property name.
        Assert.Matches(new Regex("EventData.*EventDataChecksum.*Id", RegexOptions.Singleline), _auditEvent);
    }

    [Fact]
    public void AuditEvent_EmitsAttributeOnlyForConstrainedMembers()
    {
        // EventData (Required) and Id (Required+Min+Max) carry an attribute; EventDataChecksum carries none.
        Assert.Equal(2, Regex.Count(_auditEvent, @"\[AWSProperty\("));
    }

    [Fact]
    public void AuditEvent_EmitsPropertyDocFramingAndPreservesInlineTags()
    {
        // C2J-style property doc preface.
        Assert.Contains("Gets and sets the property EventData.", _auditEvent);

        // <code> is rewritten to <c>, while <i> is left intact (denylist is exact, not over-aggressive).
        Assert.Contains("<i>$eventdata</i>", _auditEvent);
        Assert.Contains("<c>printf", _auditEvent);
    }

    [Fact]
    public void ResultErrorEntry_EmitsAwsPropertyMinMax()
    {
        Assert.Contains("public partial class ResultErrorEntry", _resultErrorEntry);
        Assert.Contains("public string ErrorCode", _resultErrorEntry);
        Assert.Contains("public string ErrorMessage", _resultErrorEntry);
        Assert.Contains("public string Id", _resultErrorEntry);

        // ErrorMessage targets ErrorMessage shape (@length min 1 max 1024).
        Assert.Contains("[AWSProperty(Required = true, Min = 1, Max = 1024)]", _resultErrorEntry);

        // ErrorCode and Id both map to min 1 max 128.
        Assert.Contains("[AWSProperty(Required = true, Min = 1, Max = 128)]", _resultErrorEntry);
    }

    [Fact]
    public void AuditEventResultEntry_PreservesEventIDAcronym()
    {
        Assert.Contains("public partial class AuditEventResultEntry", _auditEventResultEntry);
        Assert.Contains("public string EventID", _auditEventResultEntry);
        Assert.Contains("public string Id", _auditEventResultEntry);
    }
}
