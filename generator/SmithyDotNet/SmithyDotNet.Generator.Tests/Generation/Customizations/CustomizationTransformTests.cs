using System.Text.Json;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Customizations;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;
using SmithyDotNet.Generator.Writers.Serialization;
using SmithyDotNet.Generator.Writers.Service;
using SmithyDotNet.Generator.Writers.Shapes;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation.Customizations;

/// <summary>
/// Covers the customizations loader (unknown hooks fail loudly) and <see cref="CustomizationTransform"/> (renames pin the wire name, stale entries throw).
/// </summary>
public class CustomizationTransformTests
{
    private static CustomizationsModel Rename(string shape, string member, string newName) => new()
    {
        ShapeModifiers =
        {
            [shape] = new ShapeModifier { Modify = [new() { [member] = new PropertyModifier { EmitPropertyName = newName } }] },
        },
    };

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
        var ex = Assert.Throws<GeneratorException>(() => LoadFiles("""{ "runtimePipelineOverride": {} }"""));
        Assert.Contains("runtimePipelineOverride", ex.Message);
    }

    [Fact]
    public void Load_UnsupportedNestedHook_Throws()
    {
        var ex = Assert.Throws<GeneratorException>(() => LoadFiles("""{ "shapeModifiers": { "Thing": { "modify": [{ "m": { "unsupportedHook": "x" } }] } } }"""));
        Assert.Contains("unsupportedHook", ex.Message);
    }

    [Fact]
    public void Load_CombinesShapeModifiersAcrossFiles()
    {
        var merged = LoadFiles(
            """{ "shapeModifiers": { "Thing": { "modify": [] } } }""",
            """{ "shapeModifiers": { "Other": { "modify": [] } } }""");

        Assert.Equal(["Other", "Thing"], merged.ShapeModifiers.Keys.Order());
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
    public void Apply_UnsupportedShapeType_Throws()
    {
        var model = new SmithyModel
        {
            Version = "2.0",
            Shapes = new() { ["com.example#Thing"] = new StringShape() },
        };

        var ex = Assert.Throws<GeneratorException>(() => CustomizationTransform.Apply(model, Rename("Thing", "payload", "Payload")));
        Assert.Contains("only structures and enums", ex.Message);
    }

    [Theory]
    [InlineData("NoSuchShape", "created", "CreatedAt", "NoSuchShape")]
    [InlineData("DoScalarsRequest", "noSuchMember", "X", "noSuchMember")]
    [InlineData("DoScalarsRequest", "created", "Expiry", "already has")]
    [InlineData("DoScalarsRequest", "created", "createdAt", "verbatim")]
    public void Apply_StaleReference_Throws(string shape, string member, string newName, string expectedInMessage)
    {
        var ex = Assert.Throws<GeneratorException>(() => CustomizationTransform.Apply(TestModels.Load("Codegen/codegen-model.json"), Rename(shape, member, newName)));
        Assert.Contains(expectedInMessage, ex.Message);
    }

    [Fact]
    public void Apply_AmbiguousShapeName_Throws()
    {
        var model = new SmithyModel
        {
            Version = "2.0",
            Shapes = new()
            {
                ["com.a#Thing"] = new StructureShape(),
                ["com.b#Thing"] = new StructureShape(),
            },
        };

        var ex = Assert.Throws<GeneratorException>(() => CustomizationTransform.Apply(model, Rename("Thing", "payload", "Payload")));
        Assert.Contains("com.a#Thing, com.b#Thing", ex.Message);
    }

    [Fact]
    public void Apply_KeepsExistingJsonName()
    {
        var member = new MemberShape { Target = ShapeId.Parse("smithy.api#String") };
        member.SetJsonName("wireName");

        var model = new SmithyModel
        {
            Version = "2.0",
            Shapes = new() { ["com.example#Thing"] = new StructureShape { Members = { ["payload"] = member } } },
        };

        CustomizationTransform.Apply(model, Rename("Thing", "payload", "PayloadStream"));
        var thing = Assert.IsType<StructureShape>(model.Shapes["com.example#Thing"]);
        Assert.Equal("wireName", thing.Members["PayloadStream"].GetJsonName());
    }

    // Mirrors the restjson protocol-test customization: "0"/"1" wire values derive constant names
    // that are not valid identifiers, so the customization names them (entries keyed by wire value).
    [Fact]
    public void Codegen_RenamedEnumValues_EmitCustomizedConstantNames()
    {
        var customizations = new CustomizationsModel
        {
            ShapeModifiers =
            {
                ["InstanceType"] = new ShapeModifier
                {
                    Modify =
                    [
                        new() { ["0"] = new PropertyModifier { EmitPropertyName = "Num_0" } },
                        new() { ["1"] = new PropertyModifier { EmitPropertyName = "Num_1" } },
                    ],
                },
            },
        };
        var model = TestModels.Load("Codegen/codegen-model.json");
        CustomizationTransform.Apply(model, customizations);
        var context = new GenerationContext(new ServiceIndex(model), TestManifests.Example(), customizations: customizations);

        var enums = new ServiceEnumerationsWriter(context, "scalars.json").Write(TestContext.Current.CancellationToken);
        Assert.Contains("""public static readonly InstanceType Num_0 = new InstanceType("0");""", enums);
        Assert.Contains("""public static readonly InstanceType Num_1 = new InstanceType("1");""", enums);
    }

    // deprecatedMessage only supplies the [Obsolete] text; C2J gates the attribute on the model's
    // deprecated flag, so a message on a not-already-deprecated target must not create a deprecation.
    [Fact]
    public void Apply_DeprecatedMessage_OnAlreadyDeprecatedMember_SetsMessageAndKeepsSince()
    {
        var member = DeprecatedMember(since: "2020-01-01");
        var model = ModelWith("Thing", new StructureShape { Members = { ["payload"] = member } });

        CustomizationTransform.Apply(model, MemberDeprecation("Thing", "payload", "Use PayloadV2."));

        Assert.Equal("Use PayloadV2.", member.GetDeprecated()?.Message);
        Assert.Equal("2020-01-01", member.GetDeprecated()?.Since);
    }

    [Fact]
    public void Apply_DeprecatedMessage_OnNonDeprecatedMember_DoesNotCreateDeprecation()
    {
        var member = new MemberShape { Target = ShapeId.Parse("smithy.api#String") };
        var model = ModelWith("Thing", new StructureShape { Members = { ["payload"] = member } });

        CustomizationTransform.Apply(model, MemberDeprecation("Thing", "payload", "Ignored."));

        Assert.Null(member.GetDeprecated());
    }

    [Fact]
    public void Apply_ShapeDeprecatedMessage_OnDeprecatedStringShape_SetsMessageWithoutThrowing()
    {
        var stringShape = Deprecated(new StringShape());
        var model = ModelWith("LegacyId", stringShape);

        CustomizationTransform.Apply(model, new CustomizationsModel
        {
            ShapeModifiers = { ["LegacyId"] = new ShapeModifier { DeprecatedMessage = "Use LegacyIdV2." } },
        });

        Assert.Equal("Use LegacyIdV2.", stringShape.GetDeprecated()?.Message);
    }

    [Fact]
    public void Apply_MemberModificationsOnNonStructure_Throws()
    {
        var model = ModelWith("LegacyId", new StringShape());
        var customizations = new CustomizationsModel
        {
            ShapeModifiers = { ["LegacyId"] = new ShapeModifier { Modify = [new() { ["x"] = new PropertyModifier { EmitPropertyName = "X" } }] } },
        };

        var ex = Assert.Throws<GeneratorException>(() => CustomizationTransform.Apply(model, customizations));
        Assert.Contains("only structures and enums", ex.Message);
    }

    [Fact]
    public void Apply_OperationModifier_OnNonOperation_Throws()
    {
        var model = ModelWith("Thing", new StructureShape());
        var customizations = new CustomizationsModel
        {
            OperationModifiers = { ["Thing"] = new OperationModifier { DeprecatedMessage = "x" } },
        };

        var ex = Assert.Throws<GeneratorException>(() => CustomizationTransform.Apply(model, customizations));
        Assert.Contains("not an operation", ex.Message);
    }

    // End-to-end: the customized message replaces the model's in the emitted [Obsolete]. The
    // @deprecated -> [Obsolete] wire is the same BuildObsolete call at every level, so one proves it.
    [Fact]
    public void Codegen_OperationDeprecatedMessage_ReplacesMessageOnClientMethods()
    {
        var model = TestModels.Load("Codegen/codegen-model.json");
        CustomizationTransform.Apply(model, new CustomizationsModel
        {
            OperationModifiers = { ["DoHeaderOnly"] = new OperationModifier { DeprecatedMessage = "Use DoHeaderOnlyV2." } },
        });
        var context = TestModels.Context(model);

        var output = new ClientClassWriter(context, "example-2023-01-01.normal.json").Write(TestContext.Current.CancellationToken);
        Assert.Contains("""[Obsolete("Use DoHeaderOnlyV2.")]""", output);
        Assert.DoesNotContain("This operation is deprecated.", output);
    }

    private static SmithyModel ModelWith(string bareName, Shape shape) => new()
    {
        Version = "2.0",
        Shapes = new() { [$"com.example#{bareName}"] = shape },
    };

    private static T Deprecated<T>(T shape) where T : Shape
    {
        shape.Traits["smithy.api#deprecated"] = JsonSerializer.SerializeToElement(new { });
        return shape;
    }

    private static MemberShape DeprecatedMember(string? since = null)
    {
        var member = new MemberShape { Target = ShapeId.Parse("smithy.api#String") };
        member.Traits["smithy.api#deprecated"] = since is null
            ? JsonSerializer.SerializeToElement(new { })
            : JsonSerializer.SerializeToElement(new { since });
        return member;
    }

    private static CustomizationsModel MemberDeprecation(string shape, string member, string message) => new()
    {
        ShapeModifiers = { [shape] = new ShapeModifier { Modify = [new() { [member] = new PropertyModifier { DeprecatedMessage = message } }] } },
    };

    [Fact]
    public void Codegen_RenamedMember_EmitsNewPropertyAndOriginalWireName()
    {
        var model = TestModels.Load("Codegen/codegen-model.json");
        CustomizationTransform.Apply(model, Rename("DoScalarsRequest", "created", "CreatedAt"));
        var context = TestModels.Context(model);

        var requestId = ShapeId.Parse("com.example#DoScalarsRequest");
        var structure = new StructureWriter(context, "scalars.json").Write(context.Structures[requestId], requestId, TestContext.Current.CancellationToken);
        Assert.Contains("public DateTime? CreatedAt", structure);

        var marshaller = new JsonRequestMarshallerWriter(context, "scalars.json").Write(context.Operations.Single(o => o.Name == "DoScalars"), TestContext.Current.CancellationToken);
        Assert.Contains("if (publicRequest.IsSetCreatedAt())", marshaller);
        Assert.Contains("""context.Writer.WritePropertyName("created");""", marshaller);
    }
}
