using SmithyDotNet.Generator.Generation.Customizations;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation.Customizations;

/// <summary>Covers <see cref="CustomizationsModel.Load"/>: hooks are read as JSON, unknown ones fail loudly, and files merge without overlap.</summary>
public class CustomizationsModelTests
{
    private static CustomizationsModel LoadFiles(params string[] contents)
    {
        var directory = Directory.CreateTempSubdirectory("customizations-");
        try
        {
            var paths = contents.Select((json, i) =>
            {
                var path = Path.Combine(directory.FullName, $"svc.customizations.{i}.json");
                File.WriteAllText(path, json);
                return path;
            }).ToList();

            return CustomizationsModel.Load(paths);
        }
        finally
        {
            directory.Delete(recursive: true);
        }
    }

    [Fact]
    public void Load_UnsupportedHook_Throws()
    {
        var ex = Assert.Throws<GeneratorException>(() => LoadFiles("""{ "unsupportedHook": {} }"""));
        Assert.Contains("unsupportedHook", ex.Message);
    }

    [Fact]
    public void Load_RuntimePipelineOverride_ReadsOverridesInOrder()
    {
        var model = LoadFiles("""
            { "runtimePipelineOverride": { "overrides": [
                { "operation": "addBefore", "targetType": "T", "newType": "First" },
                { "operation": "addAfter", "targetType": "T", "newType": "Second" },
                { "operation": "replace", "targetType": "T", "newType": "Third", "constructorInput": "this.Config", "condition": "true" }
            ] } }
            """);

        Assert.Equal(
        [
            new PipelineOverride { Operation = PipelineOverride.AddBefore, TargetType = "T", NewType = "First" },
            new PipelineOverride { Operation = PipelineOverride.AddAfter, TargetType = "T", NewType = "Second" },
            new PipelineOverride { Operation = PipelineOverride.Replace, TargetType = "T", NewType = "Third", ConstructorInput = "this.Config", Condition = "true" },
        ], model.RuntimePipelineOverride?.Overrides ?? []);
    }

    [Theory]
    [InlineData("""[{ "operation": "remove", "targetType": "T", "newType": "N" }]""", "overrides[0] needs")]
    [InlineData("""[{ "operation": "addbefore", "targetType": "T", "newType": "N" }]""", "overrides[0] needs")]
    [InlineData("""[{ "operation": "addBefore", "targetType": "", "newType": "N" }]""", "overrides[0] needs")]
    [InlineData("""[{ "operation": "addBefore", "targetType": "T", "newType": null }]""", "overrides[0] needs")]
    [InlineData("""[null]""", "overrides[0] needs")]
    [InlineData("""null""", "needs an 'overrides' list")]
    [InlineData("""[{ "operation": "addBefore", "targetType": "T" }]""", "newType")]
    public void Load_RuntimePipelineOverride_MalformedOrUnsupported_Throws(string overrides, string expectedInMessage)
    {
        var ex = Assert.Throws<GeneratorException>(() => LoadFiles($$"""{ "runtimePipelineOverride": { "overrides": {{overrides}} } }"""));
        Assert.Contains(expectedInMessage, ex.Message);
    }

    [Fact]
    public void Load_RuntimePipelineOverride_InTwoFiles_Throws()
    {
        var ex = Assert.Throws<GeneratorException>(() => LoadFiles(
            """{ "runtimePipelineOverride": { "overrides": [] } }""",
            """{ "runtimePipelineOverride": { "overrides": [] } }"""));
        Assert.Contains("runtimePipelineOverride appears in more than one customizations file", ex.Message);
    }

    [Fact]
    public void Load_UnsupportedNestedHook_Throws()
    {
        var ex = Assert.Throws<GeneratorException>(() => LoadFiles("""{ "shapeModifiers": { "Thing": { "modify": [{ "m": { "unsupportedHook": "x" } }] } } }"""));
        Assert.Contains("unsupportedHook", ex.Message);
    }

    [Fact]
    public void Load_ShapeSubstitutions_ReadsRenameShape()
    {
        var model = LoadFiles("""{ "shapeSubstitutions": { "VpcConfigResponse": { "renameShape": "VpcConfigDetail" } } }""");
        Assert.Equal("VpcConfigDetail", model.ShapeSubstitutions["VpcConfigResponse"].RenamedShapeName);
    }

    [Fact]
    public void Load_ShapeSubstitutions_EmitAsShape_Throws()
    {
        var ex = Assert.Throws<GeneratorException>(() => LoadFiles("""{ "shapeSubstitutions": { "Thing": { "emitAsShape": "String" } } }"""));
        Assert.Contains("emitAsShape", ex.Message);
    }

    [Fact]
    public void Load_EmitIsSetProperties_MergesAcrossFiles()
    {
        var model = LoadFiles(
            """{ "emitIsSetProperties": { "AttributeValue": ["BOOL", "M"] } }""",
            """{ "emitIsSetProperties": { "QueryInput": ["Limit"] } }""");

        Assert.Equal(["BOOL", "M"], model.EmitIsSetProperties["AttributeValue"]);
        Assert.Equal(["Limit"], model.EmitIsSetProperties["QueryInput"]);
        Assert.Equal(2, model.EmitIsSetProperties.Count);
    }

    [Fact]
    public void Load_EmitIsSetProperties_SameShapeInTwoFiles_Throws()
    {
        var ex = Assert.Throws<GeneratorException>(() => LoadFiles(
            """{ "emitIsSetProperties": { "QueryInput": ["Limit"] } }""",
            """{ "emitIsSetProperties": { "QueryInput": ["Select"] } }"""));
        Assert.Contains("emitIsSetProperties['QueryInput']", ex.Message);
    }

    [Fact]
    public void Load_CombinesShapeModifiersAcrossFiles()
    {
        var merged = LoadFiles(
            """{ "shapeModifiers": { "Thing": { "modify": [] } } }""",
            """{ "shapeModifiers": { "Other": { "modify": [] } } }""");

        Assert.Equal(["Other", "Thing"], merged.ShapeModifiers.Keys.Order());
    }

    // A later entry's rename would otherwise be lost: EmittedName reads only the first.
    [Fact]
    public void Load_MemberModifiedTwice_Throws()
    {
        var ex = Assert.Throws<GeneratorException>(() => LoadFiles(
            """{ "shapeModifiers": { "Thing": { "modify": [{ "m": { "deprecatedMessage": "x" } }, { "m": { "emitPropertyName": "M2" } }] } } }"""));
        Assert.Contains("shapeModifiers['Thing'] modifies 'm' more than once", ex.Message);
    }

    [Fact]
    public void Load_SameShapeInTwoFiles_Throws()
    {
        var ex = Assert.Throws<GeneratorException>(() => LoadFiles(
            """{ "shapeModifiers": { "Thing": { "modify": [] } } }""",
            """{ "shapeModifiers": { "Thing": { "modify": [] } } }"""));
        Assert.Contains("more than one customizations file", ex.Message);
    }

    [Fact]
    public void Load_OverrideContentType_ReadsValue()
    {
        var model = LoadFiles(
            """{ "shapeModifiers": { } }""",
            """{ "overrideContentType": "application/x-amz-json-1.1" }""");
        Assert.Equal("application/x-amz-json-1.1", model.OverrideContentType);
    }

    [Fact]
    public void Load_OverrideContentType_InTwoFiles_Throws()
    {
        var ex = Assert.Throws<GeneratorException>(() => LoadFiles(
            """{ "overrideContentType": "application/x-amz-json-1.1" }""",
            """{ "overrideContentType": "application/json" }"""));
        Assert.Contains("overrideContentType appears in more than one customizations file", ex.Message);
    }

    // The entry fields (Type, Marshaller, Unmarshaller) are capitalized, unlike every other hook's; Unmarshaller may be omitted.
    [Fact]
    public void Load_DataTypeSwap_ParsesEntry()
    {
        var customizations = LoadFiles("""{ "dataTypeSwap": { "Spend": { "Amount": { "Type": "decimal?", "Marshaller": "M" } } } }""");

        Assert.Equal(new DataTypeSwap { Type = "decimal?", Marshaller = "M" }, customizations.DataTypeSwaps["Spend"]["Amount"]);
    }
}
