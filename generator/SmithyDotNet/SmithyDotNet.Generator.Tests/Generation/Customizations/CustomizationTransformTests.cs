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

    // C2J's Member name is already the emitPropertyName by the time it checks emitIsSetProperties
    // (Shape.Members), so a renamed member is listed under its new name and the modeled name is stale.
    private static CustomizationsModel RenameAndEmitIsSet(string listedName) => new()
    {
        ShapeModifiers = Rename("QueryInput", "limit", "MaxItems").ShapeModifiers,
        EmitIsSetProperties = { ["QueryInput"] = [listedName] },
    };

    private static StructureShape LimitInput() =>
        new() { Members = { ["limit"] = new MemberShape { Target = ShapeId.Parse("smithy.api#Integer") } } };

    [Fact]
    public void Validate_EmitIsSetProperties_RenamedMember_ListedByNewName_Passes()
    {
        ApplyAndValidate(ModelWith("QueryInput", LimitInput()), RenameAndEmitIsSet("MaxItems"));
    }

    [Fact]
    public void Validate_EmitIsSetProperties_RenamedMember_ListedByModeledName_Throws()
    {
        var ex = Assert.Throws<GeneratorException>(() => ApplyAndValidate(ModelWith("QueryInput", LimitInput()), RenameAndEmitIsSet("limit")));
        Assert.Contains("lists member 'limit', which the shape does not have", ex.Message);
    }

    [Theory]
    [InlineData("NoSuchShape", "Limit", "does not match any shape")]
    [InlineData("QueryInput", "limit", "which the shape does not have")]
    public void Validate_EmitIsSetProperties_StaleReference_Throws(string shape, string member, string expectedInMessage)
    {
        var structure = new StructureShape { Members = { ["Limit"] = new MemberShape { Target = ShapeId.Parse("smithy.api#Integer") } } };

        var ex = Assert.Throws<GeneratorException>(() =>
            CustomizationTransform.Validate(ModelWith("QueryInput", structure), new CustomizationsModel { EmitIsSetProperties = { [shape] = [member] } }));
        Assert.Contains($"emitIsSetProperties['{shape}']", ex.Message);
        Assert.Contains(expectedInMessage, ex.Message);
    }

    [Fact]
    public void Validate_EmitIsSetProperties_NonStructureShape_Throws()
    {
        var ex = Assert.Throws<GeneratorException>(() =>
            CustomizationTransform.Validate(ModelWith("Thing", new StringShape()), new CustomizationsModel { EmitIsSetProperties = { ["Thing"] = ["x"] } }));
        Assert.Contains("only structures and unions", ex.Message);
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

    // The entry fields (Type, Marshaller, Unmarshaller) are capitalized, unlike every other hook's; Unmarshaller may be omitted.
    [Fact]
    public void Load_DataTypeSwap_ParsesEntry()
    {
        var customizations = LoadFiles("""{ "dataTypeSwap": { "Spend": { "Amount": { "Type": "decimal?", "Marshaller": "M" } } } }""");

        Assert.Equal(new DataTypeSwap { Type = "decimal?", Marshaller = "M" }, customizations.DataTypeSwaps["Spend"]["Amount"]);
    }

    [Fact]
    public void Validate_DataTypeSwapOnMissingMember_Throws()
    {
        var model = ModelWith("Thing", new StructureShape { Members = { ["payload"] = new MemberShape { Target = ShapeId.Parse("smithy.api#String") } } });

        var ex = Assert.Throws<GeneratorException>(() => CustomizationTransform.Validate(model, Swap("Thing", "missing")));
        Assert.Contains("missing", ex.Message);
    }

    // `required` only checks the key is present, so an explicit null or blank Type reaches Validate.
    [Theory]
    [InlineData("null")]
    [InlineData("\" \"")]
    public void Validate_DataTypeSwapWithoutType_Throws(string type)
    {
        var model = ModelWith("Thing", new StructureShape { Members = { ["payload"] = new MemberShape { Target = ShapeId.Parse("smithy.api#String") } } });
        var customizations = LoadFiles($$"""{ "dataTypeSwap": { "Thing": { "payload": { "Type": {{type}} } } } }""");

        var ex = Assert.Throws<GeneratorException>(() => CustomizationTransform.Validate(model, customizations));
        Assert.Contains("Type", ex.Message);
    }

    // C2J keys a swap by the emitted property name, so a renamed member is named by its new name.
    [Fact]
    public void Validate_DataTypeSwapOnRenamedMember_UsesEmittedName()
    {
        var model = ModelWith("Thing", new StructureShape { Members = { ["payload"] = new MemberShape { Target = ShapeId.Parse("smithy.api#String") } } });
        var customizations = Swap("Thing", "PayloadV2");
        customizations.ShapeModifiers["Thing"] = new ShapeModifier { Modify = [new() { ["payload"] = new PropertyModifier { EmitPropertyName = "PayloadV2" } }] };

        ApplyAndValidate(model, customizations);
    }

    [Fact]
    public void Validate_DataTypeSwapXmlOnlyField_Throws()
    {
        var model = ModelWith("Thing", new StructureShape { Members = { ["payload"] = new MemberShape { Target = ShapeId.Parse("smithy.api#String") } } });
        var customizations = new CustomizationsModel { DataTypeSwaps = { ["Thing"] = new() { ["payload"] = new DataTypeSwap { Type = "List<string>", IsFlattened = true } } } };

        var ex = Assert.Throws<GeneratorException>(() => CustomizationTransform.Validate(model, customizations));
        Assert.Contains("isFlattened", ex.Message);
    }

    [Fact]
    public void Apply_ShapeSubstitution_RenamesViaServiceRename()
    {
        var model = SubstitutionsModel();
        CustomizationTransform.Apply(model, Substitute("Bucket", "S3Bucket"));

        var index = new ServiceIndex(model);
        Assert.Equal("S3Bucket", index.ToDotNetName(ShapeId.Parse("com.example#Bucket")));
        Assert.NotNull(model.Shapes["com.example#Bucket"]);
    }

    [Fact]
    public void Apply_ShapeSubstitution_StructureHooksUseModeledName()
    {
        var model = SubstitutionsModel();
        var customizations = Substitute("Bucket", "S3Bucket") with { ShapeModifiers = Rename("Bucket", "name", "BucketName").ShapeModifiers };

        CustomizationTransform.Apply(model, customizations);

        Assert.Contains("BucketName", Assert.IsType<StructureShape>(model.Shapes["com.example#Bucket"]).Members.Keys);
    }

    [Fact]
    public void Apply_ShapeSubstitution_StructureHookUnderRenamedName_Throws()
    {
        var customizations = Substitute("Bucket", "S3Bucket") with { ShapeModifiers = Rename("S3Bucket", "name", "BucketName").ShapeModifiers };

        var ex = Assert.Throws<GeneratorException>(() => CustomizationTransform.Apply(SubstitutionsModel(), customizations));
        Assert.Contains("does not match any shape", ex.Message);
    }

    [Fact]
    public void Apply_ShapeSubstitution_EnumHooksUseModeledName()
    {
        var model = SubstitutionsModel();
        var customizations = Substitute("StorageClass", "S3StorageClass");
        customizations.ShapeModifiers["StorageClass"] = new ShapeModifier { DeprecatedMessage = "Old." };

        CustomizationTransform.Apply(model, customizations);

        Assert.Equal("Old.", model.Shapes["com.example#StorageClass"]?.GetDeprecated()?.Message);
    }

    // Even an identical rename means the customization is stale.
    [Theory]
    [InlineData("Other")]
    [InlineData("S3Bucket")]
    public void Apply_ShapeSubstitution_ModelAlreadyRenames_Throws(string existing)
    {
        var model = SubstitutionsModel();
        Assert.IsType<ServiceShape>(model.Shapes["com.example#Service"]).Rename["com.example#Bucket"] = existing;

        var ex = Assert.Throws<GeneratorException>(() => CustomizationTransform.Apply(model, Substitute("Bucket", "S3Bucket")));
        Assert.Contains($"already renames it to '{existing}'", ex.Message);
    }

    // `required` only checks the key is present, so an explicit null or blank renameShape reaches Apply.
    [Theory]
    [InlineData("Bucket", "null")]
    [InlineData("Bucket", "\" \"")]
    [InlineData("Holder$bucket", "\" \"")]
    public void Apply_ShapeSubstitutionWithoutName_Throws(string key, string newName)
    {
        var customizations = LoadFiles($$"""{ "shapeSubstitutions": { "{{key}}": { "renameShape": {{newName}} } } }""");

        var ex = Assert.Throws<GeneratorException>(() => CustomizationTransform.Apply(SubstitutionsModel(), customizations));
        Assert.Contains($"shapeSubstitutions['{key}'] must specify a non-empty 'renameShape'", ex.Message);
    }

    // The error Throttled emits ThrottledException, so the clash check compares generated type names.
    [Theory]
    [InlineData("Grant", "S3Grant", "com.example#S3Grant")]
    [InlineData("Bucket", "ThrottledException", "com.example#Throttled")]
    public void Apply_ShapeSubstitution_ClashesWithEmittedName_Throws(string shape, string newName, string clash)
    {
        var ex = Assert.Throws<GeneratorException>(() => CustomizationTransform.Apply(SubstitutionsModel(), Substitute(shape, newName)));
        Assert.Contains($"which '{clash}' is already emitted as", ex.Message);
    }

    // The error emits GrantException, not Grant, so it doesn't clash with the Grant structure.
    [Fact]
    public void Apply_ShapeSubstitution_ErrorRenamedToStructureName_Applies()
    {
        var model = SubstitutionsModel();

        CustomizationTransform.Apply(model, Substitute("AccessDenied", "Grant"));

        Assert.Equal("Grant", new ServiceIndex(model).ToDotNetName(ShapeId.Parse("com.example#AccessDenied")));
    }

    [Fact]
    public void Apply_MemberSubstitution_SplitsSharedTargetAndDropsOriginal()
    {
        var model = SubstitutionsModel();
        var customizations = new CustomizationsModel
        {
            ShapeSubstitutions =
            {
                ["PermissionInput$action"] = new ShapeSubstitution { RenamedShapeName = "PermissionInputActionEnum" },
                ["PermissionOutput$action"] = new ShapeSubstitution { RenamedShapeName = "PermissionOutputActionEnum" },
            },
        };

        CustomizationTransform.Apply(model, customizations);

        Assert.Equal(ShapeId.Parse("com.example#PermissionInputActionEnum"), Assert.IsType<StructureShape>(model.Shapes["com.example#PermissionInput"]).Members["action"].Target);
        Assert.Equal(ShapeId.Parse("com.example#PermissionOutputActionEnum"), Assert.IsType<StructureShape>(model.Shapes["com.example#PermissionOutput"]).Members["action"].Target);
        Assert.Equal(ShapeId.Parse("com.example#PermissionInputActionEnum"), Assert.IsType<EnumShape>(model.Shapes["com.example#PermissionInputActionEnum"]).Id);
        Assert.False(model.Shapes.ContainsKey("com.example#Action"));
    }

    [Fact]
    public void Apply_MemberSubstitution_KeepsOriginalStillTargeted()
    {
        var model = SubstitutionsModel();

        CustomizationTransform.Apply(model, Substitute("PermissionInput$action", "PermissionInputActionEnum"));

        Assert.True(model.Shapes.ContainsKey("com.example#Action"));
        Assert.True(model.Shapes.ContainsKey("com.example#PermissionInputActionEnum"));
    }

    [Theory]
    [InlineData("PermissionInput$missing", "Copy", "does not name a structure member")]
    [InlineData("PermissionInput$principal", "Copy", "duplicating a structure is not supported")]
    [InlineData("PermissionInput$action", "Taken", "already emitted as")]
    public void Apply_MemberSubstitution_Invalid_Throws(string key, string newName, string expected)
    {
        var ex = Assert.Throws<GeneratorException>(() => CustomizationTransform.Apply(SubstitutionsModel(), Substitute(key, newName)));
        Assert.Contains(expected, ex.Message);
    }

    [Fact]
    public void Apply_MemberSubstitution_ExistingIdRenamedAway_Throws()
    {
        var model = SubstitutionsModel();
        Assert.IsType<ServiceShape>(model.Shapes["com.example#Service"]).Rename["com.example#Taken"] = "Other";

        var ex = Assert.Throws<GeneratorException>(() => CustomizationTransform.Apply(model, Substitute("PermissionInput$action", "Taken")));
        Assert.Contains("'com.example#Taken' is already a shape in the model", ex.Message);
    }

    private static CustomizationsModel Substitute(string shape, string newName) => new()
    {
        ShapeSubstitutions = { [shape] = new ShapeSubstitution { RenamedShapeName = newName } },
    };

    private static SmithyModel SubstitutionsModel() => TestModels.Load("Customizations/substitutions-model.json");

    private static void ApplyAndValidate(SmithyModel model, CustomizationsModel customizations)
    {
        CustomizationTransform.Apply(model, customizations);
        CustomizationTransform.Validate(model, customizations);
    }

    private static CustomizationsModel Swap(string shape, string member) => new()
    {
        DataTypeSwaps = { [shape] = new() { [member] = new DataTypeSwap { Type = "DateTime?", Marshaller = "M", Unmarshaller = "U" } } },
    };

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
        var structure = new StructureWriter(context, "scalars.json").Write(context.Structures[requestId], TestContext.Current.CancellationToken);
        Assert.Contains("public DateTime? CreatedAt", structure);

        var marshaller = new JsonRequestMarshallerWriter(context, "scalars.json").Write(context.Operations.Single(o => o.Name == "DoScalars"), TestContext.Current.CancellationToken);
        Assert.Contains("if (publicRequest.IsSetCreatedAt())", marshaller);
        Assert.Contains("""context.Writer.WritePropertyName("created");""", marshaller);
    }
}
