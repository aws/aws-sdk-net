using SmithyDotNet.Generator.Generation.Customizations;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation.Customizations;

/// <summary>
/// Covers <see cref="CustomizationTransform"/> hook by hook against <c>Customizations/customizations-model.json</c>:
/// hooks move into the model as traits, renames keep the wire name, stale entries throw.
/// </summary>
public class CustomizationTransformTests
{
    private static SmithyModel Model() => TestModels.Load("Customizations/customizations-model.json");

    private static SmithyModel Apply(CustomizationsModel customizations)
    {
        var model = Model();
        CustomizationTransform.Apply(model, customizations);
        return model;
    }

    private static void ApplyAndValidate(CustomizationsModel customizations)
    {
        var model = Model();
        CustomizationTransform.Apply(model, customizations);
        CustomizationTransform.Validate(model, customizations);
    }

    private static StructureShape Structure(SmithyModel model, string name) =>
        Assert.IsType<StructureShape>(model.Shapes[$"com.example#{name}"]);

    private static CustomizationsModel Substitute(string key, string newName)
    {
        var customizations = new CustomizationsModel();
        customizations.ShapeSubstitutions[key] = new ShapeSubstitution { RenamedShapeName = newName };
        return customizations;
    }

    private static CustomizationsModel Deprecate(string shape, string member, string message)
    {
        var customizations = new CustomizationsModel();
        customizations.ShapeModifiers[shape] = TestCustomizations.Modify(member, new PropertyModifier { DeprecatedMessage = message });
        return customizations;
    }

    // shapeSubstitutions

    // The error AccessDenied emits AccessDeniedException, so renaming it to Grant doesn't clash with the Grant structure.
    [Theory]
    [InlineData("Bucket", "S3Bucket")]
    [InlineData("AccessDenied", "Grant")]
    public void ShapeSubstitution_RenamesViaServiceRename(string shape, string newName)
    {
        var model = Apply(Substitute(shape, newName));

        Assert.Equal(newName, new ServiceIndex(model).ToDotNetName(ShapeId.Parse($"com.example#{shape}")));
        Assert.True(model.Shapes.ContainsKey($"com.example#{shape}"));
    }

    // Every hook keys a shape by its modeled name, unlike C2J, which rekeys a renamed structure.
    [Fact]
    public void ShapeSubstitution_OtherHooksUseModeledName()
    {
        var customizations = Substitute("Bucket", "S3Bucket");
        customizations.ShapeSubstitutions["StorageClass"] = new ShapeSubstitution { RenamedShapeName = "S3StorageClass" };
        customizations.ShapeModifiers["Bucket"] = TestCustomizations.RenameMember("name", "BucketName");
        customizations.ShapeModifiers["StorageClass"] = new ShapeModifier { DeprecatedMessage = "Old." };

        var model = Apply(customizations);

        Assert.Contains("name", Structure(model, "Bucket").Members.Keys);
        Assert.Equal("BucketName", customizations.PropertyName("Bucket", "name"));
        Assert.Equal("Old.", model.Shapes["com.example#StorageClass"]?.GetDeprecated()?.Message);
    }

    [Fact]
    public void MemberSubstitution_SplitsSharedTargetAndDropsOriginal()
    {
        var customizations = Substitute("PermissionInput$action", "PermissionInputActionEnum");
        customizations.ShapeSubstitutions["PermissionOutput$action"] = new ShapeSubstitution { RenamedShapeName = "PermissionOutputActionEnum" };

        var model = Apply(customizations);

        Assert.Equal(ShapeId.Parse("com.example#PermissionInputActionEnum"), Structure(model, "PermissionInput").Members["action"].Target);
        Assert.Equal(ShapeId.Parse("com.example#PermissionOutputActionEnum"), Structure(model, "PermissionOutput").Members["action"].Target);
        Assert.Equal(ShapeId.Parse("com.example#PermissionInputActionEnum"), Assert.IsType<EnumShape>(model.Shapes["com.example#PermissionInputActionEnum"]).Id);
        Assert.False(model.Shapes.ContainsKey("com.example#Action"));
    }

    [Fact]
    public void MemberSubstitution_KeepsOriginalStillTargeted()
    {
        var model = Apply(Substitute("PermissionInput$action", "PermissionInputActionEnum"));

        Assert.True(model.Shapes.ContainsKey("com.example#Action"));
        Assert.True(model.Shapes.ContainsKey("com.example#PermissionInputActionEnum"));
    }

    [Theory]
    // `required` only checks the JSON key is present, so a blank renameShape reaches Apply.
    [InlineData("Bucket", " ", "shapeSubstitutions['Bucket'] must specify a non-empty 'renameShape'")]
    [InlineData("Holder$bucket", " ", "shapeSubstitutions['Holder$bucket'] must specify a non-empty 'renameShape'")]
    // The model renames Moved itself; even an identical rename means the customization is stale.
    [InlineData("Moved", "Other", "already renames it to 'MovedAway'")]
    [InlineData("Moved", "MovedAway", "already renames it to 'MovedAway'")]
    // The error Throttled emits ThrottledException, so the clash check compares generated type names.
    [InlineData("Grant", "S3Grant", "which 'com.example#S3Grant' is already emitted as")]
    [InlineData("Bucket", "ThrottledException", "which 'com.example#Throttled' is already emitted as")]
    [InlineData("PermissionInput$missing", "Copy", "does not name a structure member")]
    [InlineData("PermissionInput$principal", "Copy", "duplicating a structure is not supported")]
    [InlineData("PermissionInput$action", "Taken", "already emitted as")]
    [InlineData("PermissionInput$action", "Moved", "'com.example#Moved' is already a shape in the model")]
    public void ShapeSubstitution_Invalid_Throws(string key, string newName, string expectedInMessage)
    {
        var ex = Assert.Throws<GeneratorException>(() => ApplyAndValidate(Substitute(key, newName)));
        Assert.Contains(expectedInMessage, ex.Message);
    }

    // shapeModifiers

    // deprecatedMessage only supplies the [Obsolete] text; C2J gates the attribute on the model's
    // deprecated flag, so a message on a not-already-deprecated target must not create a deprecation.
    [Fact]
    public void ShapeModifiers_DeprecatedMessage_OnDeprecatedShape_SetsMessage()
    {
        var customizations = new CustomizationsModel();
        customizations.ShapeModifiers["LegacyId"] = new ShapeModifier { DeprecatedMessage = "Use LegacyIdV2." };

        var model = Apply(customizations);

        Assert.Equal("Use LegacyIdV2.", model.Shapes["com.example#LegacyId"]?.GetDeprecated()?.Message);
    }

    [Fact]
    public void ShapeModifiers_DeprecatedMessage_OnDeprecatedMember_SetsMessageAndKeepsSince()
    {
        var model = Apply(Deprecate("Bucket", "created", "Use CreatedAt."));

        var deprecated = Structure(model, "Bucket").Members["created"].GetDeprecated();
        Assert.Equal("Use CreatedAt.", deprecated?.Message);
        Assert.Equal("2020-01-01", deprecated?.Since);
    }

    [Fact]
    public void ShapeModifiers_DeprecatedMessage_OnNonDeprecatedMember_DoesNotCreateDeprecation()
    {
        var model = Apply(Deprecate("Bucket", "name", "Ignored."));

        Assert.Null(Structure(model, "Bucket").Members["name"].GetDeprecated());
    }

    [Theory]
    [InlineData("NoSuchShape", "name", "X", "shapeModifiers['NoSuchShape'] does not match any shape")]
    // Hooks are keyed by the modeled name; the service's rename of Moved doesn't make MovedAway a key.
    [InlineData("MovedAway", "x", "X", "does not match any shape")]
    [InlineData("Dup", "name", "X", "com.example#Dup, com.other#Dup")]
    [InlineData("LegacyId", "x", "X", "only structures and enums")]
    [InlineData("Bucket", "noSuchMember", "X", "which the shape does not have")]
    // Compared by emitted name: 'arn' and a rename to 'Arn' both emit 'Arn'.
    [InlineData("Bucket", "name", "Arn", "which the shape already has")]
    [InlineData("Bucket", "name", "arn", "which the shape already has")]
    // C2J sends a renamed event under its new name, which the service wouldn't recognize; no service renames one.
    [InlineData("InputStream", "chunk", "Piece", "renames event 'chunk' of an event stream")]
    public void ShapeModifiers_InvalidRename_Throws(string shape, string member, string newName, string expectedInMessage)
    {
        var ex = Assert.Throws<GeneratorException>(() => ApplyAndValidate(TestCustomizations.Rename(shape, member, newName)));
        Assert.Contains(expectedInMessage, ex.Message);
    }

    [Fact]
    public void ShapeModifiers_TwoMembersRenamedToOneName_Throws()
    {
        var customizations = TestCustomizations.Rename("Bucket", "name", "Same");
        customizations.ShapeModifiers["Bucket"].Modify.Add(new Dictionary<string, PropertyModifier> { ["arn"] = new PropertyModifier { EmitPropertyName = "Same" } });

        var ex = Assert.Throws<GeneratorException>(() => ApplyAndValidate(customizations));
        Assert.Contains("which the shape already has", ex.Message);
    }

    // operationModifiers and paginators

    [Fact]
    public void OperationModifiers_OnNonOperation_Throws()
    {
        var customizations = new CustomizationsModel();
        customizations.OperationModifiers["Bucket"] = new OperationModifier { DeprecatedMessage = "x" };

        var ex = Assert.Throws<GeneratorException>(() => ApplyAndValidate(customizations));
        Assert.Contains("not an operation", ex.Message);
    }

    [Fact]
    public void Paginators_OnNonOperation_Throws()
    {
        var customizations = new CustomizationsModel();
        customizations.Paginators["Bucket"] = new PaginatorCustomization();

        var ex = Assert.Throws<GeneratorException>(() => ApplyAndValidate(customizations));
        Assert.Contains("not an operation", ex.Message);
    }

    // emitIsSetProperties

    [Theory]
    [InlineData("NoSuchShape", "name", "emitIsSetProperties['NoSuchShape'] does not match any shape")]
    [InlineData("LegacyId", "x", "only structures and unions")]
    [InlineData("Bucket", "noSuchMember", "emitIsSetProperties['Bucket'] lists member 'noSuchMember', which the shape does not have")]
    // Members match by exact emitted name, so the modeled 'name' is not found as 'Name'.
    [InlineData("Bucket", "Name", "lists member 'Name', which the shape does not have")]
    public void EmitIsSetProperties_Invalid_Throws(string shape, string member, string expectedInMessage)
    {
        var customizations = new CustomizationsModel();
        customizations.EmitIsSetProperties[shape] = [member];

        var ex = Assert.Throws<GeneratorException>(() => ApplyAndValidate(customizations));
        Assert.Contains(expectedInMessage, ex.Message);
    }

    // C2J checks emitIsSetProperties against Shape.Members, whose names are already the emitted ones, so a
    // renamed member is listed under its new name and the modeled one is stale.
    [Fact]
    public void EmitIsSetProperties_RenamedMemberListedByModeledName_Throws()
    {
        var customizations = TestCustomizations.Rename("Bucket", "name", "BucketName");
        customizations.EmitIsSetProperties["Bucket"] = ["name"];

        var ex = Assert.Throws<GeneratorException>(() => ApplyAndValidate(customizations));
        Assert.Contains("lists member 'name', which the shape does not have", ex.Message);
    }

    // dataTypeSwap

    [Theory]
    [InlineData("missing", "int?", null, "swaps member 'missing', which the shape does not have")]
    // `required` only checks the JSON key is present, so a blank Type reaches Validate.
    [InlineData("name", " ", null, "without a 'Type'")]
    [InlineData("name", "List<string>", true, "isFlattened")]
    public void DataTypeSwap_Invalid_Throws(string member, string type, bool? isFlattened, string expectedInMessage)
    {
        var customizations = new CustomizationsModel();
        customizations.DataTypeSwaps["Bucket"] = new Dictionary<string, DataTypeSwap> { [member] = new DataTypeSwap { Type = type, IsFlattened = isFlattened } };

        var ex = Assert.Throws<GeneratorException>(() => ApplyAndValidate(customizations));
        Assert.Contains(expectedInMessage, ex.Message);
    }
}
