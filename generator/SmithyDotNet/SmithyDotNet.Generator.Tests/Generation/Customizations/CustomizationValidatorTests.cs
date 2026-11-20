using SmithyDotNet.Generator.Generation.Customizations;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation.Customizations;

/// <summary>
/// Covers <see cref="CustomizationValidator"/> hook by hook against <c>Customizations/customizations-model.json</c>.
/// </summary>
public class CustomizationValidatorTests
{
    private static void ApplyAndValidate(CustomizationsModel customizations)
    {
        var model = TestModels.Load("Customizations/customizations-model.json");
        CustomizationTransform.Apply(model, customizations);
        CustomizationValidator.Validate(model, customizations);
    }

    // paginators

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

    // convenience hooks (noArgOverloads / simpleMethods / simpleConstructors)

    [Fact]
    public void NoArgOverloads_OnNonOperation_Throws()
    {
        var customizations = new CustomizationsModel { NoArgOverloads = ["Bucket"] };
        var ex = Assert.Throws<GeneratorException>(() => ApplyAndValidate(customizations));
        Assert.Contains("noArgOverloads['Bucket'] targets a shape that is not an operation", ex.Message);
    }

    // C2J keys these by the operation's C# name, so S3's simpleMethods list PutBucket, not CreateBucket.
    [Fact]
    public void ConvenienceHooks_OnRenamedOperation_KeyByCSharpName()
    {
        var simpleMethods = new SimpleMethodsCustomization();
        simpleMethods.Operations["ListAllBuckets"] = new SimpleMethodForms();
        var simpleConstructors = new SimpleConstructorsCustomization();
        simpleConstructors.Constructors["ListAllBucketsRequest"] = new SimpleConstructorForms();
        var customizations = new CustomizationsModel { NoArgOverloads = ["ListAllBuckets"], SimpleMethods = simpleMethods, SimpleConstructors = simpleConstructors };
        customizations.OperationModifiers["ListBuckets"] = new OperationModifier { Name = "ListAllBuckets" };
        ApplyAndValidate(customizations);
        simpleMethods.Operations["ListBuckets"] = new SimpleMethodForms();
        var ex = Assert.Throws<GeneratorException>(() => ApplyAndValidate(customizations));
        Assert.Contains("simpleMethods['ListBuckets'] names a renamed operation by its modeled name; use 'ListAllBuckets'", ex.Message);
    }

    [Fact]
    public void SimpleMethods_OnStaleOperation_Throws()
    {
        var customizations = new CustomizationsModel { SimpleMethods = new SimpleMethodsCustomization { Operations = { ["Ghost"] = new SimpleMethodForms() } } };
        var ex = Assert.Throws<GeneratorException>(() => ApplyAndValidate(customizations));
        Assert.Contains("simpleMethods['Ghost'] does not match any shape", ex.Message);
    }

    [Fact]
    public void SimpleConstructors_OnStaleClass_Throws()
    {
        var customizations = new CustomizationsModel { SimpleConstructors = new SimpleConstructorsCustomization { Constructors = { ["Ghost"] = new SimpleConstructorForms() } } };
        var ex = Assert.Throws<GeneratorException>(() => ApplyAndValidate(customizations));
        Assert.Contains("simpleConstructors['Ghost'] does not match any shape", ex.Message);
    }

    [Fact]
    public void SimpleConstructors_OnExistingStructure_Validates()
    {
        var customizations = new CustomizationsModel { SimpleConstructors = new SimpleConstructorsCustomization { Constructors = { ["Bucket"] = new SimpleConstructorForms() } } };
        // Existence check passes; no throw.
        ApplyAndValidate(customizations);
    }

    // A shared customizations file serves every API version; a key that is a structure in one version can be a
    // map/list here. A present-but-non-structure key is tolerated (the writers skip it), unlike a stale one.
    [Fact]
    public void SimpleConstructors_OnPresentNonStructure_Tolerated()
    {
        var customizations = new CustomizationsModel { SimpleConstructors = new SimpleConstructorsCustomization { Constructors = { ["LegacyId"] = new SimpleConstructorForms() } } };
        ApplyAndValidate(customizations);
    }

    // generateUnmarshaller

    [Theory]
    [InlineData("NoSuchShape", "generateUnmarshaller['NoSuchShape'] does not match any shape")]
    [InlineData("LegacyId", "generateUnmarshaller['LegacyId'] targets a shape that is not a structure")]
    [InlineData("Dup", "generateUnmarshaller['Dup'] matches more than one shape")]
    public void GenerateUnmarshaller_Invalid_Throws(string shape, string expectedInMessage)
    {
        var customizations = new CustomizationsModel();
        customizations.GenerateUnmarshaller.Add(shape);
        var ex = Assert.Throws<GeneratorException>(() => ApplyAndValidate(customizations));
        Assert.Contains(expectedInMessage, ex.Message);
    }
    // inheritAlternateBaseClass, overrideTreatEnumsAsString

    [Theory]
    [InlineData("LegacyId", "Base", "inheritAlternateBaseClass['LegacyId'] targets a shape that is not a structure, or is an error")]
    [InlineData("AccessDenied", "Base", "inheritAlternateBaseClass['AccessDenied'] targets a shape that is not a structure, or is an error")]
    [InlineData("Grant", " ", "inheritAlternateBaseClass['Grant'] needs a non-empty base class")]
    [InlineData("BucketPage", "Base", "inheritAlternateBaseClass['BucketPage'] targets an operation output, which is not supported")]
    public void InheritAlternateBaseClass_Invalid_Throws(string shape, string baseClass, string expectedInMessage)
    {
        var customizations = new CustomizationsModel();
        customizations.InheritAlternateBaseClass[shape] = baseClass;
        var ex = Assert.Throws<GeneratorException>(() => ApplyAndValidate(customizations));
        Assert.Contains(expectedInMessage, ex.Message);
    }

    [Theory]
    [InlineData("NameList", "overrideTreatEnumsAsString['NameList'] targets a shape that is not a list of enums")]
    [InlineData("StorageClassMap", "overrideTreatEnumsAsString['StorageClassMap'] targets a shape that is not a list of enums")]
    [InlineData("Action", "overrideTreatEnumsAsString['Action'] targets a shape that is not a list of enums")]
    public void OverrideTreatEnumsAsString_Invalid_Throws(string shape, string expectedInMessage)
    {
        var customizations = new CustomizationsModel();
        customizations.OverrideTreatEnumsAsString[shape] = false;
        var ex = Assert.Throws<GeneratorException>(() => ApplyAndValidate(customizations));
        Assert.Contains(expectedInMessage, ex.Message);
    }

    [Fact]
    public void BaseClassAndEnumListHooks_Valid_Validate()
    {
        var customizations = new CustomizationsModel();
        customizations.InheritAlternateBaseClass["Grant"] = "Base";
        customizations.OverrideTreatEnumsAsString["StorageClassList"] = false;
        ApplyAndValidate(customizations);
    }

    // excludeShapes, excludeMembers

    [Theory]
    [InlineData("NoSuchShape", "excludeShapes['NoSuchShape'] does not match any shape")]
    [InlineData("Dup", "excludeShapes['Dup'] matches more than one shape")]
    [InlineData("LegacyId", "excludeShapes['LegacyId'] targets a shape that is not a structure or enum")]
    [InlineData("AccessDenied", "excludeShapes['AccessDenied'] targets a shape that is not a structure or enum, or is an error")]
    [InlineData("BucketPage", "excludeShapes['BucketPage'] targets a shape that is not a structure or enum, or is an error or an @input/@output structure")]
    public void ExcludeShapes_Invalid_Throws(string shape, string expectedInMessage)
    {
        var customizations = new CustomizationsModel();
        customizations.ExcludeShapes.Add(shape);
        var ex = Assert.Throws<GeneratorException>(() => ApplyAndValidate(customizations));
        Assert.Contains(expectedInMessage, ex.Message);
    }

    // S3's NotificationConfiguration: GetBucketNotificationConfiguration's output without @output, and a member target.
    [Fact]
    public void ExcludeShapes_OutputWithoutTraitThatAMemberTargets_Validates()
    {
        var customizations = new CustomizationsModel();
        customizations.ExcludeShapes.Add("Chunk");
        ApplyAndValidate(customizations);
    }

    [Theory]
    [InlineData("NoSuchShape", "name", "excludeMembers['NoSuchShape'] does not match any shape")]
    [InlineData("LegacyId", "name", "excludeMembers['LegacyId'] targets a shape that is not a structure")]
    [InlineData("Bucket", "missing", "excludeMembers['Bucket'] lists member 'missing', which the shape does not have")]
    public void ExcludeMembers_Invalid_Throws(string shape, string member, string expectedInMessage)
    {
        var customizations = new CustomizationsModel();
        customizations.ExcludeMembers[shape] = [member];
        var ex = Assert.Throws<GeneratorException>(() => ApplyAndValidate(customizations));
        Assert.Contains(expectedInMessage, ex.Message);
    }

    [Theory]
    [InlineData(false, "PutBucketRequest", "missing", "shapeModifiers['PutBucketRequest'] excludes member 'missing' from (un)marshalling, which the shape does not have")]
    [InlineData(true, "Bucket", "missing", "shapeModifiers['Bucket'] excludes member 'missing' from (un)marshalling, which the shape does not have")]
    [InlineData(true, "LegacyId", "name", "shapeModifiers['LegacyId'] excludes member 'name' from (un)marshalling, which the shape does not have")]
    [InlineData(false, "Bucket", "name", "shapeModifiers['Bucket'] sets excludeFromMarshalling, but is not an operation's input.")]
    [InlineData(true, "PutBucketRequest", "trace", "shapeModifiers['PutBucketRequest'] sets excludeFromUnmarshalling, but is an operation's input.")]
    [InlineData(false, "*", "name", "shapeModifiers['*'] only supports modify.")]
    [InlineData(true, "*", "name", "shapeModifiers['*'] only supports modify.")]
    public void ExcludeFromMarshallingOrUnmarshalling_Invalid_Throws(bool unmarshalling, string shape, string member, string expectedInMessage)
    {
        var customizations = new CustomizationsModel();
        customizations.ShapeModifiers[shape] = unmarshalling ? new ShapeModifier { ExcludeFromUnmarshalling = [member] } : new ShapeModifier { ExcludeFromMarshalling = [member] };
        var ex = Assert.Throws<GeneratorException>(() => ApplyAndValidate(customizations));
        Assert.Contains(expectedInMessage, ex.Message);
    }

    [Fact]
    public void InjectMarshallCode_OnALabel_Throws()
    {
        var customizations = new CustomizationsModel();
        customizations.ShapeModifiers["PutBucketRequest"] = TestCustomizations.Modify("id", new PropertyModifier { InjectMarshallCode = ["Marshall(request, publicRequest);"] });
        var ex = Assert.Throws<GeneratorException>(() => ApplyAndValidate(customizations));
        Assert.Equal("shapeModifiers['PutBucketRequest'] sets injectMarshallCode on 'id', which is a query, label, attribute or non-structure payload member.", ex.Message);
    }

    [Theory]
    [InlineData("Bucket", "shapeModifiers['Bucket'] needs injectMarshallCodeInPayload lines and to be an operation's input.")]
    [InlineData("*", "shapeModifiers['*'] only supports modify.")]
    public void InjectMarshallCodeInPayload_Invalid_Throws(string shape, string expectedMessage)
    {
        var customizations = new CustomizationsModel();
        customizations.ShapeModifiers[shape] = new ShapeModifier { InjectMarshallCodeInPayload = ["Sort(publicRequest);"] };
        var ex = Assert.Throws<GeneratorException>(() => ApplyAndValidate(customizations));
        Assert.Equal(expectedMessage, ex.Message);
    }

    // skipUriPropertyValidation

    [Theory]
    // PermissionInput's action is an @httpLabel, so this fails on the name rather than on a model with no labels.
    [InlineData("Missing")]
    // Bucket's name is a member but not an @httpLabel.
    [InlineData("Name")]
    public void SkipUriPropertyValidation_NotALabelProperty_Throws(string propertyName)
    {
        var customizations = new CustomizationsModel();
        customizations.SkipUriPropertyValidation.Add(propertyName);
        var ex = Assert.Throws<GeneratorException>(() => ApplyAndValidate(customizations));
        Assert.Contains($"skipUriPropertyValidation['{propertyName}'] is not the property of any @httpLabel member.", ex.Message);
    }
}
