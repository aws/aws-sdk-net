using System.Text.RegularExpressions;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Customizations;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Writers.Serialization;
using SmithyDotNet.Generator.Writers.Shapes;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Shapes;

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
        return writer.Write(context.Structures[shapeId], TestContext.Current.CancellationToken);
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

    [Fact]
    public void AuditEvent_EmitsIsSetPerMember()
    {
        Assert.Contains("internal bool IsSetEventData() => this.EventData != null;", _auditEvent);
        Assert.Contains("internal bool IsSetEventDataChecksum() => this.EventDataChecksum != null;", _auditEvent);
        Assert.Contains("internal bool IsSetId() => this.Id != null;", _auditEvent);
    }

    [Fact]
    public void DeprecatedStructure_EmitsClassLevelObsolete()
    {
        var context = TestModels.Context("Codegen/codegen-model.json");
        var shapeId = ShapeId.Parse("com.example#ConflictDetails");
        var output = new StructureWriter(context, ModelFileName)
            .Write(context.Structures[shapeId], TestContext.Current.CancellationToken);

        Assert.Contains("""[Obsolete("This type is deprecated.")]""", output);
    }

    [Fact]
    public void StructureWithoutDocumentation_StillEmitsSummary()
    {
        // Widget has no @documentation; without a class <summary> it would trip CS1591 (build error).
        var context = TestModels.Context("Codegen/nested-structure-model.json");
        var shapeId = ShapeId.Parse("com.amazonaws.testnested#Widget");
        var widget = new StructureWriter(context, ModelFileName)
            .Write(context.Structures[shapeId], TestContext.Current.CancellationToken);

        var beforeClass = widget[..widget.IndexOf("public partial class Widget", StringComparison.Ordinal)];
        Assert.Contains("/// <summary>", beforeClass);
    }

    // emitPropertyName changes only the C# name, so every protocol keeps the modeled wire name. A lowercase
    // name is upper-cased, as C2J emits iot's "marker" as Marker.
    [Fact]
    public void RenamedMember_EmitsNewPropertyAndOriginalWireName()
    {
        var context = TestModels.Context(TestModels.Load("Codegen/codegen-model.json"), TestCustomizations.Rename("DoScalarsRequest", "created", "createdAt"));

        var requestId = ShapeId.Parse("com.example#DoScalarsRequest");
        var structure = new StructureWriter(context, "scalars.json").Write(context.Structures[requestId], TestContext.Current.CancellationToken);
        Assert.Contains("public DateTime? CreatedAt", structure);

        var marshaller = new JsonRequestMarshallerWriter(context, "scalars.json").Write(context.Operations.Single(o => o.Name == "DoScalars"), TestContext.Current.CancellationToken);
        Assert.Contains("if (publicRequest.IsSetCreatedAt())", marshaller);
        Assert.Contains("""context.Writer.WritePropertyName("created");""", marshaller);
    }

    [Fact]
    public void AlternateBaseClass_IsDerivedFrom()
    {
        var customizations = new CustomizationsModel();
        customizations.InheritAlternateBaseClass["ConflictDetails"] = "IComparable<ConflictDetails>";
        var context = TestModels.Context(TestModels.Load("Codegen/codegen-model.json"), customizations);

        var output = new StructureWriter(context, ModelFileName)
            .Write(context.Structures[ShapeId.Parse("com.example#ConflictDetails")], TestContext.Current.CancellationToken);
        Assert.Contains("public partial class ConflictDetails : IComparable<ConflictDetails>", output);
    }

    // C2J keys dataTypeSwap and emitIsSetProperties by the emitted name, so both reach a renamed member by its new one.
    [Fact]
    public void RenamedMember_HooksListedByNewName_Apply()
    {
        var customizations = TestCustomizations.Rename("DoScalarsRequest", "count", "Total");
        customizations.EmitIsSetProperties["DoScalarsRequest"] = ["Total"];
        customizations.DataTypeSwaps["DoScalarsRequest"] = new Dictionary<string, DataTypeSwap> { ["Total"] = new DataTypeSwap { Type = "long?" } };
        var context = TestModels.Context(TestModels.Load("Codegen/codegen-model.json"), customizations);

        var requestId = ShapeId.Parse("com.example#DoScalarsRequest");
        var structure = new StructureWriter(context, "scalars.json").Write(context.Structures[requestId], TestContext.Current.CancellationToken);
        Assert.Contains("public long? Total", structure);
        Assert.Contains("public bool IsTotalSet", structure);
    }

    // S3's CopyObjectRequest.ModifiedSinceDate: the accessors sit in the renamed member's own entry and use the new
    // name's _camelCase field, which IsSet reads too since an injected getter can hide a null.
    [Fact]
    public void InjectedAccessors_ReplaceTheirDefaultsOverABackingField()
    {
        var customizations = new CustomizationsModel();
        var modifier = TestCustomizations.Modify("since", new PropertyModifier
        {
            EmitPropertyName = "ModifiedSinceDate",
            InjectPropertyGetter = ["get => this._modifiedSinceDate ?? DateTime.SpecifyKind(default, DateTimeKind.Utc);"],
        });
        customizations.ShapeModifiers["DoScalarsRequest"] = modifier;
        TestCustomizations.Modify("count", new PropertyModifier { InjectPropertySetter = ["set => CountCustomSetter(value);"] }, modifier);
        var context = TestModels.Context(TestModels.Load("Codegen/codegen-model.json"), customizations);

        var requestId = ShapeId.Parse("com.example#DoScalarsRequest");
        var structure = new StructureWriter(context, "scalars.json").Write(context.Structures[requestId], TestContext.Current.CancellationToken);

        Assert.Contains("private DateTime? _modifiedSinceDate;", structure);
        Assert.Contains("get => this._modifiedSinceDate ?? DateTime.SpecifyKind(default, DateTimeKind.Utc);", structure);
        Assert.Contains("set { this._modifiedSinceDate = value; }", structure);
        Assert.Contains("internal bool IsSetModifiedSinceDate() => this._modifiedSinceDate.HasValue;", structure);
        Assert.Contains("get { return this._count; }", structure);
        Assert.Contains("set => CountCustomSetter(value);", structure);
    }

    // S3's InputSerialization.CompressionType: the lines declare the _camelCase field with its default.
    [Fact]
    public void InjectPrivateMemberAssignment_ReplacesTheBackingFieldDeclaration()
    {
        var customizations = new CustomizationsModel();
        customizations.ShapeModifiers["DoScalarsRequest"] = TestCustomizations.Modify("count", new PropertyModifier { InjectPrivateMemberAssignment = ["private int? _count = 1;"] });
        var context = TestModels.Context(TestModels.Load("Codegen/codegen-model.json"), customizations);

        var requestId = ShapeId.Parse("com.example#DoScalarsRequest");
        var structure = new StructureWriter(context, "scalars.json").Write(context.Structures[requestId], TestContext.Current.CancellationToken);

        Assert.Contains("private int? _count = 1;", structure);
        Assert.Contains("internal bool IsSetCount() => this._count.HasValue;", structure);
    }

    // S3's CompleteMultipartUploadRequest.IfMatch: the lines read the _camelCase field of the emitted name.
    [Fact]
    public void InjectIsSet_ReplacesTheIsSetBodyOverABackingField()
    {
        var customizations = new CustomizationsModel();
        customizations.ShapeModifiers["DoScalarsRequest"] = TestCustomizations.Modify("count", new PropertyModifier { EmitPropertyName = "Total", InjectIsSet = ["return this._total > 0;"] });
        var context = TestModels.Context(TestModels.Load("Codegen/codegen-model.json"), customizations);

        var requestId = ShapeId.Parse("com.example#DoScalarsRequest");
        var structure = new StructureWriter(context, "scalars.json").Write(context.Structures[requestId], TestContext.Current.CancellationToken);

        Assert.Contains("private int? _total;", structure);
        Assert.Contains("public int? Total { get => this._total; set => this._total = value; }", structure);
        Assert.Contains("internal bool IsSetTotal()" + Environment.NewLine, structure);
        Assert.Contains("return this._total > 0;", structure);
    }

    // S3's S3Grantee.Type is computed: no field, no setter.
    [Fact]
    public void SkipSetterAndSkipPrivateMember_EmitAGetterOnlyProperty()
    {
        var customizations = new CustomizationsModel();
        customizations.ShapeModifiers["DoScalarsRequest"] = TestCustomizations.Modify("count", new PropertyModifier { InjectPropertyGetter = ["get { return CountGetter(); }"], SkipSetter = true, SkipPrivateMember = true });
        var context = TestModels.Context(TestModels.Load("Codegen/codegen-model.json"), customizations);

        var requestId = ShapeId.Parse("com.example#DoScalarsRequest");
        var structure = new StructureWriter(context, "scalars.json").Write(context.Structures[requestId], TestContext.Current.CancellationToken);

        Assert.DoesNotContain("_count", structure);
        Assert.Contains("get { return CountGetter(); }", structure);
        Assert.Contains("internal bool IsSetCount() => this.Count.HasValue;", structure);
        Assert.DoesNotContain("set {", structure);
    }

    // S3's GetObjectRequest.Key: a repeated entry is written once, as C2J's HashSet does; the rest are uncleaned.
    [Fact]
    public void AdditionalDocumentation_FollowsTheSummary()
    {
        var customizations = new CustomizationsModel();
        customizations.ShapeModifiers["DoScalarsRequest"] = TestCustomizations.Modify("count", new PropertyModifier { AdditionalDocumentation = ["<remarks>\n", "<para>Kept <code>as is</code>.</para>\n", "<para>Kept <code>as is</code>.</para>\n", "</remarks>"] });
        var context = TestModels.Context(TestModels.Load("Codegen/codegen-model.json"), customizations);

        var requestId = ShapeId.Parse("com.example#DoScalarsRequest");
        var structure = new StructureWriter(context, "scalars.json").Write(context.Structures[requestId], TestContext.Current.CancellationToken);

        var lines = string.Join("\n", structure.Split(Environment.NewLine).Select(line => line.Trim()));
        Assert.Contains("/// </summary>\n/// <remarks>\n/// <para>Kept <code>as is</code>.</para>\n/// </remarks>\n", lines);
    }

    [Fact]
    public void InjectPrivateMemberAssignment_DeclaringAnotherField_Throws()
    {
        var customizations = new CustomizationsModel();
        customizations.ShapeModifiers["DoScalarsRequest"] = TestCustomizations.Modify("count", new PropertyModifier { InjectPrivateMemberAssignment = ["private int? _total = 1;"] });
        var context = TestModels.Context(TestModels.Load("Codegen/codegen-model.json"), customizations);

        var requestId = ShapeId.Parse("com.example#DoScalarsRequest");
        var ex = Assert.Throws<GeneratorException>(() => new StructureWriter(context, "scalars.json").Write(context.Structures[requestId], TestContext.Current.CancellationToken));
        Assert.Equal("injectPrivateMemberAssignment on member 'Count' has to declare the field _count.", ex.Message);
    }

    // CognitoIdentity's and SecurityToken's Credentials derive from AWSCredentials, whose Expiration they override.
    [Fact]
    public void MemberOverridingABaseMember_EmitsOverride()
    {
        var customizations = new CustomizationsModel();
        customizations.ShapeModifiers["DoScalarsRequest"] = TestCustomizations.Modify("created", new PropertyModifier { OverridesBaseMember = true });
        var context = TestModels.Context(TestModels.Load("Codegen/codegen-model.json"), customizations);

        var requestId = ShapeId.Parse("com.example#DoScalarsRequest");
        var structure = new StructureWriter(context, "scalars.json").Write(context.Structures[requestId], TestContext.Current.CancellationToken);
        Assert.Contains("public override DateTime? Created ", structure);
    }

    // S3's GetBucketWebsiteOutput lists IndexDocument by its emitted name, IndexDocumentSuffix; hand-written partials declare the property.
    [Fact]
    public void ExcludedMember_ListedByEmittedName_EmitsNoPropertyOrIsSet()
    {
        var customizations = TestCustomizations.Rename("DoScalarsRequest", "count", "Total");
        customizations.ExcludeMembers["DoScalarsRequest"] = ["Total"];
        var context = TestModels.Context(TestModels.Load("Codegen/codegen-model.json"), customizations);

        var requestId = ShapeId.Parse("com.example#DoScalarsRequest");
        var structure = new StructureWriter(context, "scalars.json").Write(context.Structures[requestId], TestContext.Current.CancellationToken);
        Assert.DoesNotContain(" Total", structure);
        Assert.DoesNotContain("IsSetTotal", structure);
        Assert.Contains("public DateTime? Created ", structure);
    }

    [Fact]
    public void SkipXmlIsSet_EmitsThePropertyWithoutIsSet()
    {
        var customizations = new CustomizationsModel();
        customizations.ShapeModifiers["Tag"] = TestCustomizations.Modify("key", new PropertyModifier { SkipXmlIsSet = true });
        var context = TestModels.Context(TestModels.Load("Codegen/restxml-model.json"), customizations);

        var structure = new StructureWriter(context, "example.json").Write(context.Structures[ShapeId.Parse("com.example#Tag")], TestContext.Current.CancellationToken);
        Assert.Contains("public string Key ", structure);
        Assert.DoesNotContain("IsSetKey", structure);
        Assert.Contains("IsSetValue", structure);
    }
}
