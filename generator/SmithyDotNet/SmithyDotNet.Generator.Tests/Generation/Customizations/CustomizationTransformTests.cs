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
    // Operation and resource shapes emit no type, so their names are free as well.
    [Theory]
    [InlineData("Bucket", "S3Bucket")]
    [InlineData("AccessDenied", "Grant")]
    [InlineData("StorageClass", "ListBuckets")]
    [InlineData("Grant", "BucketResource")]
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

    // S3's C2J layout (CopySourceIfModifiedSince renamed, its getter keyed by ModifiedSinceDate) must be rekeyed.
    [Fact]
    public void ShapeModifiers_InjectedAccessorKeyedByTheNewName_Throws()
    {
        var customizations = TestCustomizations.Rename("Bucket", "name", "Title");
        TestCustomizations.Modify("Title", new PropertyModifier { InjectPropertyGetter = ["get { return this._title; }"] }, customizations.ShapeModifiers["Bucket"]);

        var ex = Assert.Throws<GeneratorException>(() => ApplyAndValidate(customizations));
        Assert.Contains("shapeModifiers['Bucket'] modifies member 'Title', which the shape does not have", ex.Message);
    }

    [Fact]
    public void ShapeModifiers_TwoMembersRenamedToOneName_Throws()
    {
        var customizations = TestCustomizations.Rename("Bucket", "name", "Same");
        customizations.ShapeModifiers["Bucket"].Modify.Add(new Dictionary<string, PropertyModifier> { ["arn"] = new PropertyModifier { EmitPropertyName = "Same" } });

        var ex = Assert.Throws<GeneratorException>(() => ApplyAndValidate(customizations));
        Assert.Contains("which the shape already has", ex.Message);
    }

    // The clash with Bucket's own arn rename shows "*" reached Bucket.name.
    [Fact]
    public void ShapeModifiers_GlobalRenameClashingInAStructure_Throws()
    {
        var customizations = TestCustomizations.Rename("*", "name", "Same");
        customizations.ShapeModifiers["Bucket"] = TestCustomizations.RenameMember("arn", "Same");

        var ex = Assert.Throws<GeneratorException>(() => ApplyAndValidate(customizations));
        Assert.Contains("shapeModifiers['Bucket'] renames", ex.Message);
    }

    [Fact]
    public void ShapeModifiers_GlobalRename_YieldsToTheStructuresOwnEntry()
    {
        var customizations = TestCustomizations.Rename("*", "action", "Verb");
        customizations.ShapeModifiers["PermissionOutput"] = TestCustomizations.RenameMember("action", "Act");

        ApplyAndValidate(customizations);

        Assert.Equal("Verb", customizations.EmittedName("PermissionInput", "action"));
        Assert.Equal("Act", customizations.EmittedName("PermissionOutput", "action"));
    }

    [Theory]
    [InlineData("name", true, "shapeModifiers['*'] only supports modify.")]
    [InlineData("missing", false, "shapeModifiers['*'] modifies member 'missing', which no structure has.")]
    public void ShapeModifiers_GlobalKey_Throws(string memberName, bool exclude, string expectedMessage)
    {
        var customizations = TestCustomizations.Rename("*", memberName, "Renamed");
        if (exclude)
        {
            customizations.ShapeModifiers["*"].Exclude.Add(memberName);
        }

        var ex = Assert.Throws<GeneratorException>(() => ApplyAndValidate(customizations));
        Assert.Contains(expectedMessage, ex.Message);
    }

    [Fact]
    public void ShapeModifiers_Exclude_RemovesMember()
    {
        var customizations = new CustomizationsModel();
        customizations.ShapeModifiers["Bucket"] = new ShapeModifier { Exclude = ["arn"] };

        Assert.Equal(["name", "created"], Structure(Apply(customizations), "Bucket").Members.Keys);
    }

    [Fact]
    public void ShapeModifiers_ExcludeUnknownMember_Throws()
    {
        var customizations = new CustomizationsModel();
        customizations.ShapeModifiers["Bucket"] = new ShapeModifier { Exclude = ["missing"] };

        var ex = Assert.Throws<GeneratorException>(() => Apply(customizations));
        Assert.Contains("excludes member 'missing', which the shape does not have", ex.Message);
    }

    // inject

    // S3's CopyObjectRequest.DestinationKey and GetBucketCorsOutput.Configuration: the original is excluded first, and its
    // binding stays behind, as C2J reads only the original's XML name and endpoint parameter.
    [Fact]
    public void Inject_OriginalMember_TakesItsXmlNameAndContextParam()
    {
        var customizations = new CustomizationsModel();
        var modifier = TestCustomizations.Inject("BucketId", new PropertyInjector { Shape = "Text", OriginalMember = "id" });
        TestCustomizations.Inject("Configuration", new PropertyInjector { Shape = "BucketConfig", OriginalMember = "config" }, modifier);
        modifier.Exclude.AddRange(["id", "config"]);
        customizations.ShapeModifiers["PutBucketRequest"] = modifier;

        var request = Structure(Apply(customizations), "PutBucketRequest");

        Assert.Equal("Id", request.Members["BucketId"].GetContextParam()?.Name);
        Assert.False(request.Members["BucketId"].IsHttpLabel());
        Assert.Equal("CreateBucketConfiguration", request.Members["Configuration"].GetXmlName());
    }

    // S3's CopyObjectRequest.SourceBucket and Headers.
    [Fact]
    public void Inject_HeaderLocation_BindsAHeader()
    {
        var customizations = new CustomizationsModel();
        var modifier = TestCustomizations.Inject("Source", new PropertyInjector { Shape = "Text", Location = "header" });
        TestCustomizations.Inject("Named", new PropertyInjector { Shape = "Text", Location = "header", LocationName = "x-named" }, modifier);
        TestCustomizations.Inject("Headers", new PropertyInjector { Shape = "NameValueMap", Location = "header" }, modifier);
        customizations.ShapeModifiers["PutBucketRequest"] = modifier;

        var request = Structure(Apply(customizations), "PutBucketRequest");

        Assert.Equal("Source", request.Members["Source"].GetHttpHeader());
        Assert.Equal("x-named", request.Members["Named"].GetHttpHeader());
        Assert.Null(request.Members["Named"].GetXmlName());
        Assert.Equal("", request.Members["Headers"].GetHttpPrefixHeaders());
    }

    // S3's entry: the copy is a body member of the output, not its payload.
    [Fact]
    public void Inject_OutsideOriginalMember_CopiesThatMemberWithoutItsPayload()
    {
        var customizations = new CustomizationsModel();
        var modifier = TestCustomizations.Inject("Configuration", new PropertyInjector
        {
            Shape = "BucketLifecycleConfiguration",
            OriginalMemberIsOutsideContainingShape = true,
            OutsideOriginalMember = "PutBucketLifecycleConfigurationRequest,LifecycleConfiguration",
        });
        modifier.Exclude.Add("Rules");
        customizations.ShapeModifiers["GetBucketLifecycleConfigurationOutput"] = modifier;

        var output = Structure(Apply(customizations), "GetBucketLifecycleConfigurationOutput");

        var configuration = Assert.Single(output.Members).Value;
        Assert.Equal("com.example#BucketLifecycleConfiguration", configuration.Target.AbsoluteName);
        Assert.Equal("LifecycleConfiguration", configuration.GetXmlName());
        Assert.False(configuration.IsHttpPayload());
    }

    [Theory]
    [InlineData("uri", null, false, null, "with location 'uri'; only 'header' is supported")]
    [InlineData(null, "missing", false, null, "with originalMember 'missing', which the shape does not exclude")]
    [InlineData(null, null, true, null, "sets only one of originalMemberIsOutsideContainingShape and outsideOriginalMember")]
    [InlineData(null, "id", true, "PutBucketRequest,config", "sets both originalMember and outsideOriginalMember")]
    [InlineData(null, null, true, "PutBucketRequest,missing", "copies outsideOriginalMember 'PutBucketRequest,missing', which is not a 'ShapeName,MemberName' of a structure")]
    [InlineData(null, null, true, "PutBucketRequest,config", "names shape 'Text', but outsideOriginalMember 'PutBucketRequest,config' targets 'BucketConfig'")]
    public void Inject_Invalid_Throws(string? location, string? originalMember, bool outside, string? outsideMember, string expectedInMessage)
    {
        var customizations = new CustomizationsModel();
        customizations.ShapeModifiers["PutBucketRequest"] = TestCustomizations.Inject("Injected", new PropertyInjector
        {
            Shape = "Text",
            Location = location,
            OriginalMember = originalMember,
            OriginalMemberIsOutsideContainingShape = outside,
            OutsideOriginalMember = outsideMember,
        });

        var ex = Assert.Throws<GeneratorException>(() => Apply(customizations));
        Assert.Contains($"shapeModifiers['PutBucketRequest'] injects 'Injected' {expectedInMessage}", ex.Message);
    }

    // operationModifiers and paginators

    // ListBuckets is bound to the service; TagBucket and DeleteBucket are a resource's instance and collection operations.
    [Theory]
    [InlineData("ListBuckets")]
    [InlineData("TagBucket")]
    [InlineData("DeleteBucket")]
    public void OperationModifiers_Exclude_UnbindsOperation(string operation)
    {
        var customizations = new CustomizationsModel();
        customizations.OperationModifiers[operation] = new OperationModifier { Exclude = true };

        var model = Apply(customizations);

        var id = ShapeId.Parse($"com.example#{operation}");
        Assert.DoesNotContain(model.Shapes.Values, shape => (shape as ServiceShape)?.Operations.Contains(id) == true || (shape as ResourceShape)?.AllOperations().Contains(id) == true);
    }

    [Fact]
    public void OperationModifiers_UseWrappingResult_MovesOutputUnderOneMember()
    {
        var customizations = new CustomizationsModel();
        customizations.OperationModifiers["ListBuckets"] = new OperationModifier { UseWrappingResult = true, WrappedResultShape = "BucketPage", WrappedResultMember = "Page" };

        var model = Apply(customizations);

        var operation = Assert.IsType<OperationShape>(model.Shapes["com.example#ListBuckets"]);
        var member = Assert.Single(Structure(model, operation.Output.Name).Members);
        Assert.Equal(("Page", "BucketPage"), (member.Key, member.Value.Target.Name));
        Assert.False(Structure(model, "BucketPage").IsOutput());
    }

    [Theory]
    [InlineData("Bucket", false, false, false, null, "not an operation")]
    [InlineData("Orphan", true, false, false, null, "excludes an operation that no service or resource lists")]
    [InlineData("ListBuckets", true, true, false, null, "both excludes the operation and keeps its client methods")]
    [InlineData("ListBuckets", false, false, true, "Bucket", "wrappedResultShape must name the output, 'BucketPage'")]
    [InlineData("TagBucket", false, false, true, "Unit", "wrappedResultShape must name the output, 'Unit'")]
    [InlineData("ListBuckets", false, false, false, "BucketPage", "needs both useWrappingResult and a wrappedResultMember")]
    [InlineData("Orphan", false, false, true, "Chunk", "'com.example#OrphanWrappedOutput', which is already a shape in the model")]
    public void OperationModifiers_Invalid_Throws(string operation, bool exclude, bool clientMethodOnly, bool useWrappingResult, string? wrappedResultShape, string expectedInMessage)
    {
        var customizations = new CustomizationsModel();
        customizations.OperationModifiers[operation] = new OperationModifier
        {
            Exclude = exclude,
            ClientMethodOnly = clientMethodOnly,
            UseWrappingResult = useWrappingResult,
            WrappedResultShape = wrappedResultShape,
            WrappedResultMember = wrappedResultShape is null ? null : "Page",
        };

        var ex = Assert.Throws<GeneratorException>(() => Apply(customizations));
        Assert.Contains(expectedInMessage, ex.Message);
    }

    [Theory]
    [InlineData("ListBuckets", " ", "name must be a new, non-empty name")]
    [InlineData("ListBuckets", "ListBuckets", "name must be a new, non-empty name")]
    [InlineData("TagBucket", "ListBuckets", "renames the operation to 'ListBuckets', which is also the name of 'com.example#ListBuckets'")]
    public void OperationModifiers_InvalidName_Throws(string operation, string name, string expectedInMessage)
    {
        var customizations = new CustomizationsModel();
        customizations.OperationModifiers[operation] = new OperationModifier { Name = name };

        var ex = Assert.Throws<GeneratorException>(() => Apply(customizations));
        Assert.Contains(expectedInMessage, ex.Message);
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

    // flattenShapes

    private static CustomizationsModel Flatten(string shape, string member)
    {
        var customizations = new CustomizationsModel();
        customizations.FlattenShapes[shape] = [member];
        return customizations;
    }

    [Fact]
    public void FlattenShapes_ReplacesPayloadWithItsMembers()
    {
        var model = Apply(Flatten("PutBucketRequest", "config"));

        var request = Structure(model, "PutBucketRequest");
        Assert.Equal(["id", "name", "region", "trace"], request.Members.Keys);
        // C2J checks @required against the parent, which never lists a flattened member.
        Assert.False(request.Members["name"].IsRequired());
        Assert.True(Structure(model, "BucketConfig").Members["name"].IsRequired());
        // The body's root element stays the payload's.
        Assert.Equal("CreateBucketConfiguration", request.GetXmlName());
    }

    // shapeModifiers address a flattened member on its new parent (S3's RestoreObjectRequest.Tier).
    [Fact]
    public void FlattenShapes_RunsBeforeShapeModifiers()
    {
        var customizations = Flatten("PutBucketRequest", "config");
        customizations.ShapeModifiers["PutBucketRequest"] = new ShapeModifier { Exclude = ["region"] };

        Assert.DoesNotContain("region", Structure(Apply(customizations), "PutBucketRequest").Members.Keys);
    }

    [Theory]
    [InlineData("LegacyId", "config", "flattenShapes['LegacyId'] targets a shape that is not a structure")]
    [InlineData("PutBucketRequest", "missing", "flattenShapes['PutBucketRequest'] flattens 'missing', which the shape does not have")]
    [InlineData("Holder", "bucket", "flattenShapes['Holder'] flattens 'bucket', which is not a structure @httpPayload")]
    [InlineData("ClashRequest", "config", "flattenShapes['ClashRequest'] flattens 'config', whose member 'name' the shape already has")]
    [InlineData("NamespacedRequest", "config", "flattenShapes['NamespacedRequest'] flattens 'config', whose @xmlNamespace or target @xmlName is not supported yet")]
    public void FlattenShapes_Invalid_Throws(string shape, string member, string expectedInMessage)
    {
        var ex = Assert.Throws<GeneratorException>(() => Apply(Flatten(shape, member)));
        Assert.Contains(expectedInMessage, ex.Message);
    }

    // mergedEnums

    private static CustomizationsModel Merge(string source, string target)
    {
        var customizations = new CustomizationsModel();
        customizations.MergedEnums[source] = target;
        return customizations;
    }

    [Fact]
    public void MergedEnums_AddsValuesTheTargetLacks()
    {
        var model = Apply(Merge("ObjectStorageClass", "StorageClass"));

        var target = Assert.IsType<EnumShape>(model.Shapes["com.example#StorageClass"]);
        Assert.Equal(["STANDARD", "GLACIER"], target.Members.Values.Select(member => member.GetEnumValue()));
    }

    [Theory]
    [InlineData("Grant", "StorageClass", "mergedEnums['Grant'] merges a shape that is not an enum, or into one")]
    [InlineData("ObjectStorageClass", "Grant", "mergedEnums['ObjectStorageClass'] merges a shape that is not an enum, or into one")]
    [InlineData("ObjectStorageClass", "NoSuchShape", "mergedEnums['ObjectStorageClass'] mergeInto 'NoSuchShape' does not match any shape")]
    [InlineData("Taken", "Taken", "mergedEnums['Taken'] merges into 'Taken', which is itself merged")]
    [InlineData("ActionAlias", "Action", "mergedEnums['ActionAlias'] adds member 'READ', which 'Action' has with a different value")]
    public void MergedEnums_Invalid_Throws(string source, string target, string expectedInMessage)
    {
        var ex = Assert.Throws<GeneratorException>(() => Apply(Merge(source, target)));
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

    // EC2-only hooks; the fixture's PutValue, AttributeValue, SpotSpec and Spec copy EC2's shapes.

    [Fact]
    public void SuppressResultGeneration_DropsTheOutput()
    {
        var customizations = new CustomizationsModel();
        customizations.SuppressResultGeneration.Add("ListBuckets");

        var model = Apply(customizations);

        Assert.Equal(ShapeId.Unit, Assert.IsType<OperationShape>(model.Shapes["com.example#ListBuckets"]).Output);
    }

    // ec2's BlobAttributeValue.Value targets Blob, which is itself substituted, so the value's type resolves through it.
    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void UnwrappedValue_WhoseTypeIsSubstituted_AppliesInEitherOrder(bool valueTypeFirst)
    {
        var customizations = new CustomizationsModel();
        var valueType = new ShapeSubstitution { EmitAsShape = "Text" };
        if (valueTypeFirst)
        {
            customizations.ShapeSubstitutions["LegacyId"] = valueType;
        }
        customizations.ShapeSubstitutions["IdValue"] = new ShapeSubstitution { EmitAsShape = "Text", EmitFromMember = "Value" };
        if (!valueTypeFirst)
        {
            customizations.ShapeSubstitutions["LegacyId"] = valueType;
        }

        var model = Apply(customizations);

        var wrapper = Assert.IsType<StructureShape>(model.Shapes["com.example#IdValue"]);
        Assert.Equal("com.example#Text", wrapper.Members["Value"].Target.AbsoluteName);
    }

    // The old name sets the new shape's request-only keys with the same values, so they merge.
    [Fact]
    public void SubstitutedShape_OldNameMirroringTheNewShape_Merges()
    {
        var customizations = new CustomizationsModel();
        var spec = TestCustomizations.Inject("Names", new PropertyInjector { Shape = "NameList", LocationName = "group" });
        TestCustomizations.Modify("Kind", new PropertyModifier { LocationName = "type" }, spec);
        customizations.ShapeModifiers["Spec"] = spec;
        var spotSpec = TestCustomizations.Inject("Names", new PropertyInjector { Shape = "NameList", LocationName = "group", CustomMarshall = true });
        TestCustomizations.Modify("Kind", new PropertyModifier { LocationName = "type" }, spotSpec);
        customizations.ShapeModifiers["SpotSpec"] = spotSpec;
        customizations.ShapeSubstitutions["SpotSpec"] = new ShapeSubstitution { EmitAsShape = "Spec" };

        Apply(customizations);

        Assert.True(customizations.CustomMarshall("Spec", "Names"));
    }

    [Theory]
    [InlineData("mixed", "mixes renameShape with emitAsShape")]
    [InlineData("memberWithoutEmitAsShape", "sets emitFromMember or listMemberSuffixExclusions, which need emitAsShape")]
    [InlineData("exclusionsWithoutMember", "lists listMemberSuffixExclusions without an emitFromMember")]
    [InlineData("staleExclusion", "listMemberSuffixExclusions['Bucket'] targets a 'structure' shape, not an operation")]
    [InlineData("missingValueMember", "emits from member 'Missing', which the shape does not have")]
    [InlineData("wrongValueType", "emits 'Boolean', but member 'Value' targets 'smithy.api#String'")]
    [InlineData("operationInput", "substitutes the input or output of 'com.example#PutValue'")]
    [InlineData("unwrappedOperationInput", "substitutes the input or output of 'com.example#PutValue'")]
    [InlineData("unwrappedMapValue", "substitutes a key or value of map 'com.example#NameValueMap'")]
    [InlineData("sentByRequest", "which a request already sends")]
    [InlineData("oldNameRename", "changes the emitted 'Spec' class")]
    [InlineData("oldNameExclusion", "modifies a substituted shape, which only supports modify and inject")]
    [InlineData("oldNameSkipXmlIsSet", "changes the emitted 'Spec' class")]
    [InlineData("oldNameInject", "does not inject as 'IdList'")]
    [InlineData("newNameOnly", "sets an inject, locationName or customMarshall on 'Groups' that shapeModifiers['SpotSpec'] does not mirror")]
    [InlineData("differentLocationName", "sets an inject, locationName or customMarshall on 'Groups' that shapeModifiers['SpotSpec'] does not mirror")]
    [InlineData("injectNotSkipped", "sets an inject, locationName or customMarshall on 'Groups' that shapeModifiers['SpotSpec'] does not mirror")]
    [InlineData("substitutedAwayOverride", "marshallNameOverrides does not match any shape")]
    [InlineData("injectTaken", "injects 'Kind', which the shape already has")]
    [InlineData("accessModifier", "only 'internal' is supported")]
    [InlineData("marshallNameOverride", "'PutValueRequest.Missing', which is not a property of the shape")]
    [InlineData("suppressWrapped", "suppresses an output that operationModifiers wraps")]
    public void Ec2Hooks_Invalid_Throws(string invalid, string expectedInMessage)
    {
        var customizations = new CustomizationsModel();
        var overrides = new Dictionary<string, Dictionary<string, MarshallNameOverride>>();
        var names = new Dictionary<string, MarshallNameOverride>();
        switch (invalid)
        {
            case "mixed":
                customizations.ShapeSubstitutions["Bucket"] = new ShapeSubstitution { RenamedShapeName = "Bin", EmitAsShape = "String" };
                break;
            case "memberWithoutEmitAsShape":
                customizations.ShapeSubstitutions["AttributeValue"] = new ShapeSubstitution { EmitFromMember = "Value" };
                break;
            case "exclusionsWithoutMember":
                customizations.ShapeSubstitutions["SpotSpec"] = new ShapeSubstitution { EmitAsShape = "Spec", ListMemberSuffixExclusions = ["PutValue"] };
                break;
            case "staleExclusion":
                customizations.ShapeSubstitutions["AttributeValue"] = new ShapeSubstitution { EmitAsShape = "String", EmitFromMember = "Value", ListMemberSuffixExclusions = ["Bucket"] };
                break;
            case "missingValueMember":
                customizations.ShapeSubstitutions["AttributeValue"] = new ShapeSubstitution { EmitAsShape = "String", EmitFromMember = "Missing" };
                break;
            case "wrongValueType":
                customizations.ShapeSubstitutions["AttributeValue"] = new ShapeSubstitution { EmitAsShape = "Boolean", EmitFromMember = "Value" };
                break;
            case "operationInput":
                customizations.ShapeSubstitutions["PutValueRequest"] = new ShapeSubstitution { EmitAsShape = "Spec" };
                break;
            case "unwrappedOperationInput":
                customizations.ShapeSubstitutions["PutValueRequest"] = new ShapeSubstitution { EmitAsShape = "AttributeValue", EmitFromMember = "value" };
                break;
            case "unwrappedMapValue":
                customizations.ShapeSubstitutions["NameValue"] = new ShapeSubstitution { EmitAsShape = "Text", EmitFromMember = "Value" };
                break;
            case "sentByRequest":
                customizations.ShapeSubstitutions["SpotSpec"] = new ShapeSubstitution { EmitAsShape = "AttributeValue" };
                customizations.ShapeModifiers["SpotSpec"] = TestCustomizations.Modify("Value", new PropertyModifier { CustomMarshall = true });
                break;
            case "oldNameRename":
                customizations.ShapeSubstitutions["SpotSpec"] = new ShapeSubstitution { EmitAsShape = "Spec" };
                customizations.ShapeModifiers["SpotSpec"] = TestCustomizations.RenameMember("Kind", "Type");
                break;
            case "oldNameExclusion":
                customizations.ShapeSubstitutions["SpotSpec"] = new ShapeSubstitution { EmitAsShape = "Spec" };
                customizations.ShapeModifiers["SpotSpec"] = new ShapeModifier { ExcludeFromUnmarshalling = ["Kind"] };
                break;
            case "oldNameSkipXmlIsSet":
                customizations.ShapeSubstitutions["SpotSpec"] = new ShapeSubstitution { EmitAsShape = "Spec" };
                customizations.ShapeModifiers["SpotSpec"] = TestCustomizations.Modify("Kind", new PropertyModifier { SkipXmlIsSet = true });
                break;
            case "oldNameInject":
                customizations.ShapeSubstitutions["SpotSpec"] = new ShapeSubstitution { EmitAsShape = "Spec" };
                customizations.ShapeModifiers["SpotSpec"] = TestCustomizations.Inject("Groups", new PropertyInjector { Shape = "IdList", CustomMarshall = true });
                break;
            case "newNameOnly":
                customizations.ShapeSubstitutions["SpotSpec"] = new ShapeSubstitution { EmitAsShape = "Spec" };
                customizations.ShapeModifiers["Spec"] = TestCustomizations.Modify("Groups", new PropertyModifier { CustomMarshall = true });
                break;
            case "differentLocationName":
                customizations.ShapeModifiers["Spec"] = TestCustomizations.Modify("Groups", new PropertyModifier { LocationName = "type" });
                customizations.ShapeSubstitutions["SpotSpec"] = new ShapeSubstitution { EmitAsShape = "Spec" };
                customizations.ShapeModifiers["SpotSpec"] = TestCustomizations.Modify("Groups", new PropertyModifier { LocationName = "G" });
                break;
            case "injectNotSkipped":
                customizations.ShapeModifiers["Spec"] = TestCustomizations.Inject("Groups", new PropertyInjector { Shape = "NameList", LocationName = "group" });
                customizations.ShapeSubstitutions["SpotSpec"] = new ShapeSubstitution { EmitAsShape = "Spec" };
                customizations.ShapeModifiers["SpotSpec"] = TestCustomizations.Inject("Groups", new PropertyInjector { Shape = "NameList" });
                break;
            case "substitutedAwayOverride":
                names["Kind"] = new MarshallNameOverride { MarshallName = "Type" };
                overrides["SpotSpec"] = names;
                customizations.ShapeSubstitutions["SpotSpec"] = new ShapeSubstitution { EmitAsShape = "Spec" };
                customizations.OperationModifiers["PutValue"] = new OperationModifier { MarshallNameOverrides = [overrides] };
                break;
            case "injectTaken":
                customizations.ShapeModifiers["Spec"] = TestCustomizations.Inject("Kind", new PropertyInjector { Shape = "NameList" });
                break;
            case "accessModifier":
                customizations.ShapeModifiers["Spec"] = TestCustomizations.Modify("Kind", new PropertyModifier { AccessModifier = "private" });
                break;
            case "marshallNameOverride":
                names["Missing"] = new MarshallNameOverride { MarshallName = "Value" };
                overrides["PutValueRequest"] = names;
                customizations.OperationModifiers["PutValue"] = new OperationModifier { MarshallNameOverrides = [overrides] };
                break;
            case "suppressWrapped":
                customizations.OperationModifiers["ListBuckets"] = new OperationModifier { UseWrappingResult = true, WrappedResultShape = "BucketPage", WrappedResultMember = "Page" };
                customizations.SuppressResultGeneration.Add("ListBuckets");
                break;
        }

        var ex = Assert.Throws<GeneratorException>(() => Apply(customizations));
        Assert.Contains(expectedInMessage, ex.Message);
    }
}
