using System.Text.Json.Serialization;
using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Generation.Customizations;

/// <summary>
/// A service's merged <c>*.customizations*.json</c> files. Model-shaped hooks are folded into the
/// Smithy model by <see cref="CustomizationTransform"/>; behavior hooks (the runtime pipeline
/// overrides, and later code injection) are read via <see cref="GenerationContext.Customizations"/>.
/// </summary>
public sealed partial record CustomizationsModel
{
    [JsonPropertyName("shapeModifiers")]
    public Dictionary<string, ShapeModifier> ShapeModifiers { get; init; } = [];

    [JsonPropertyName("operationModifiers")]
    public Dictionary<string, OperationModifier> OperationModifiers { get; init; } = [];

    /// <summary>True when <c>useWrappingResult</c> wraps <paramref name="operationName"/>'s output.</summary>
    public bool WrapsOutput(string operationName) => ModifierFor(operationName) is { UseWrappingResult: true };

    /// <summary>The C# name of modeled operation <paramref name="operationName"/>: its <c>name</c> modifier, otherwise the modeled name.</summary>
    public string OperationName(string operationName) => OperationModifiers.GetValueOrDefault(operationName)?.Name ?? operationName;

    // Writers look a hook up by Operation.Name, which a name modifier changes, so a C# name finds its modeled entry.
    private OperationModifier? ModifierFor(string operationName) =>
        OperationModifiers.Values.FirstOrDefault(modifier => modifier.Name == operationName) ?? OperationModifiers.GetValueOrDefault(operationName);

    /// <summary>Handlers the client adds to its runtime pipeline in <c>CustomizeRuntimePipeline</c>.</summary>
    [JsonPropertyName("runtimePipelineOverride")]
    public RuntimePipelineOverride? RuntimePipelineOverride { get; init; }

    [JsonPropertyName("service")]
    public ServiceCustomizations? Service { get; init; }

    [JsonPropertyName("overrideContentType")]
    public string? OverrideContentType { get; init; }

    /// <summary>
    /// restXml-only (route53): members keep the model's declaration order instead of being sorted by
    /// property name. Route 53 requires XML elements in declaration order, which the sort would break.
    /// </summary>
    [JsonPropertyName("retainOriginalMemberOrdering")]
    public bool RetainOriginalMemberOrdering { get; init; }

    /// <summary>True when <c>operationModifiers.{op}.clientMethodOnly</c> is set for modeled operation <paramref name="operationName"/>.</summary>
    public bool IsClientMethodOnly(string operationName) => OperationModifiers.GetValueOrDefault(operationName) is { ClientMethodOnly: true };

    /// <summary>True when <c>operationModifiers.{op}.allowEmptyResult</c> is set for <paramref name="operationName"/>.</summary>
    public bool AllowsEmptyResult(string operationName) => ModifierFor(operationName) is { AllowEmptyResult: true };

    /// <summary>True when <c>operationModifiers.{op}.skipChecksumDuringMarshalling</c> is set for <paramref name="operationName"/>.</summary>
    public bool SkipsChecksumDuringMarshalling(string operationName) => ModifierFor(operationName) is { SkipChecksumDuringMarshalling: true };

    /// <summary>
    /// Usage:
    /// emitIsSetProperties: {
    ///   "OwningShapeName" :["memberName", "memberName2"]
    /// }
    /// </summary>
    [JsonPropertyName("emitIsSetProperties")]
    public Dictionary<string, List<string>> EmitIsSetProperties { get; init; } = [];

    /// <summary>True when <c>emitIsSetProperties</c> lists <paramref name="memberName"/> under <paramref name="shapeName"/>.</summary>
    public bool EmitIsSet(string shapeName, string memberName) => EmitIsSetProperties.TryGetValue(shapeName, out var members) && members.Contains(memberName);

    /// <summary>Type overrides keyed by modeled shape name, then <see cref="EmittedName"/> (C2J's <c>dataTypeSwap</c>).</summary>
    [JsonPropertyName("dataTypeSwap")]
    public Dictionary<string, Dictionary<string, DataTypeSwap>> DataTypeSwaps { get; init; } = [];

    /// <summary>The <c>dataTypeSwap</c> entry for <paramref name="memberName"/> of <paramref name="shapeName"/>, or null.</summary>
    public DataTypeSwap? DataTypeSwapFor(string shapeName, string memberName) => DataTypeSwaps.TryGetValue(shapeName, out var members) && members.TryGetValue(memberName, out var swap) ? swap : null;

    /// <summary>
    /// Emitted-name overrides keyed by modeled shape name, e.g.
    /// <c>"shapeSubstitutions": { "VpcConfigResponse": { "renameShape": "VpcConfigDetail" } }</c>.
    /// A Smithy-only <c>"Structure$member"</c> key gives that member's target its own copy under the new name.
    /// </summary>
    [JsonPropertyName("shapeSubstitutions")]
    public Dictionary<string, ShapeSubstitution> ShapeSubstitutions { get; init; } = [];

    /// <summary>Per-operation <c>@paginated</c> fields the model lacks, keyed by operation name; read by <c>PaginationResolver</c>.</summary>
    [JsonPropertyName("paginators")]
    public Dictionary<string, PaginatorCustomization> Paginators { get; init; } = [];

    /// <summary>Operations given a parameterless client overload (<c>client.ListKeys()</c>), sync and async. C2J: <c>noArgOverloads</c>.</summary>
    [JsonPropertyName("noArgOverloads")]
    public List<string> NoArgOverloads { get; init; } = [];

    /// <summary>Client overloads taking listed request members as positional parameters, sync and async. C2J: <c>simpleMethods</c>.</summary>
    [JsonPropertyName("simpleMethods")]
    public SimpleMethodsCustomization? SimpleMethods { get; init; }

    /// <summary>Request/structure constructors taking listed members as parameters. C2J: <c>simpleConstructors</c>.</summary>
    [JsonPropertyName("simpleConstructors")]
    public SimpleConstructorsCustomization? SimpleConstructors { get; init; }

    /// <summary>True when <paramref name="operationName"/> is listed in <c>noArgOverloads</c> (case-insensitive, as C2J).</summary>
    public bool CreateNoArgOverload(string operationName) => NoArgOverloads.Contains(operationName, StringComparer.OrdinalIgnoreCase);

    /// <summary>The <c>simpleMethods</c> forms for <paramref name="operationName"/>, or null when the operation has none.</summary>
    public IReadOnlyList<IReadOnlyList<string>>? MethodFormsFor(string operationName) =>
        SimpleMethods is { } methods && methods.Operations.TryGetValue(operationName, out var entry) ? entry.Forms : null;

    /// <summary>The <c>simpleConstructors</c> forms for the structure/request class <paramref name="className"/>, or null when it has none.</summary>
    public IReadOnlyList<IReadOnlyList<string>>? ConstructorFormsFor(string className) =>
        SimpleConstructors is { } constructors && constructors.Constructors.TryGetValue(className, out var entry) ? entry.Forms : null;

    /// <summary>
    /// Property names of path labels that are sent empty when unset instead of failing the request; glacier's
    /// ProcessRequestHandler then fills in its "-" (current account) default.
    /// </summary>
    [JsonPropertyName("skipUriPropertyValidation")]
    public List<string> SkipUriPropertyValidation { get; init; } = [];

    /// <summary>Structures that get an unmarshaller though no response returns them.</summary>
    [JsonPropertyName("generateUnmarshaller")]
    public List<string> GenerateUnmarshaller { get; init; } = [];

    /// <summary>Operations whose output is dropped, so the response class is emitted empty.</summary>
    [JsonPropertyName("suppressResultGeneration")]
    public List<string> SuppressResultGeneration { get; init; } = [];

    /// <summary>
    /// Structures and enums, by modeled name, that hand-written code supplies: no class, enum class or (un)marshaller is
    /// emitted for them, but members still target them by name (S3's <c>NotificationConfiguration</c>).
    /// </summary>
    [JsonPropertyName("excludeShapes")]
    public List<string> ExcludeShapes { get; init; } = [];

    /// <summary>
    /// Members, by <see cref="EmittedName"/> and keyed by modeled shape name, whose properties are hand-written: the class omits the property and its
    /// <c>IsSet</c>, but the (un)marshallers still read and write it. Unlike <c>shapeModifiers.exclude</c>, the member stays in the model.
    /// </summary>
    [JsonPropertyName("excludeMembers")]
    public Dictionary<string, List<string>> ExcludeMembers { get; init; } = [];

    /// <summary>
    /// Structure <c>@httpPayload</c> members, keyed by modeled input/output shape name, whose target's members replace them
    /// on the request/response class. Applied by <see cref="Customizations.FlattenShapes"/>.
    /// </summary>
    [JsonPropertyName("flattenShapes")]
    public Dictionary<string, List<string>> FlattenShapes { get; init; } = [];

    /// <summary>
    /// The targets <c>flattenShapes</c> replaced, filled in by <see cref="CustomizationTransform"/>. No longer reachable, but
    /// C2J still ships their classes (S3's <c>Delete</c>), so they are emitted unless <c>excludeShapes</c> lists them.
    /// </summary>
    [JsonIgnore]
    public List<StructureShape> FlattenedTargets { get; } = [];

    /// <summary>
    /// Base classes, keyed by modeled structure name (an operation's input for its request), that the class derives
    /// from instead of the default (S3's <c>PutObjectRequest : PutWithACLRequest</c>). Operation outputs are rejected.
    /// </summary>
    [JsonPropertyName("inheritAlternateBaseClass")]
    public Dictionary<string, string> InheritAlternateBaseClass { get; init; } = [];

    /// <summary>The <c>inheritAlternateBaseClass</c> base for modeled structure <paramref name="shapeName"/>, or null.</summary>
    public string? AlternateBaseClassFor(string shapeName) => InheritAlternateBaseClass.GetValueOrDefault(shapeName);

    /// <summary>
    /// Enums, by modeled name, mapped to the enum their values are added to; they get no class of their own.
    /// Applied by <see cref="Customizations.MergedEnums"/>.
    /// </summary>
    [JsonPropertyName("mergedEnums")]
    public Dictionary<string, string> MergedEnums { get; init; } = [];

    /// <summary>
    /// restXml-only: lists of enums, by modeled name, whose elements keep their <c>ConstantClass</c> type when
    /// <c>false</c> (S3's <c>List&lt;ObjectAttributes&gt;</c>); by default they are <c>string</c>.
    /// </summary>
    [JsonPropertyName("overrideTreatEnumsAsString")]
    public Dictionary<string, bool> OverrideTreatEnumsAsString { get; init; } = [];

    /// <summary>False when <c>overrideTreatEnumsAsString</c> types list <paramref name="shapeName"/>'s elements as the enum.</summary>
    public bool TreatsEnumsAsString(string shapeName) => OverrideTreatEnumsAsString.GetValueOrDefault(shapeName, true);

    /// <summary>True when <c>excludeShapes</c> lists modeled shape <paramref name="shapeName"/>.</summary>
    public bool IsExcludedShape(string shapeName) => ExcludeShapes.Contains(shapeName);

    /// <summary>True when <c>excludeMembers</c> lists the member emitted as <paramref name="memberName"/> under <paramref name="shapeName"/>.</summary>
    public bool IsExcludedMember(string shapeName, string memberName) => ExcludeMembers.TryGetValue(shapeName, out var members) && members.Contains(memberName);

    /// <summary>The value member an <c>emitFromMember</c> substitution unwraps <paramref name="shapeName"/> to, or null.</summary>
    public string? EmittedValueMember(string shapeName) => ShapeSubstitutions.GetValueOrDefault(shapeName)?.EmitFromMember;

    /// <summary>
    /// True when <c>customMarshall</c> is set on modeled or injected member <paramref name="memberName"/>: the member stays
    /// on the class, but the generated marshaller skips it because hand-written code sends it.
    /// </summary>
    public bool CustomMarshall(string shapeName, string memberName) =>
        (PropertyModifierFor(shapeName, memberName)?.CustomMarshall ?? false)
        || (ShapeModifiers.TryGetValue(shapeName, out var modifier) && (modifier.InjectorFor(memberName)?.CustomMarshall ?? false));

    /// <summary>
    /// True when <c>excludeFromMarshalling</c> lists modeled member <paramref name="memberName"/> by its
    /// <see cref="EmittedName"/>: hand-written code sends it.
    /// </summary>
    public bool IsExcludedFromMarshalling(string shapeName, string memberName) =>
        ShapeModifiers.TryGetValue(shapeName, out var modifier) && modifier.ExcludeFromMarshalling.Contains(EmittedName(shapeName, memberName));

    /// <summary>
    /// True when <c>excludeFromUnmarshalling</c> lists modeled member <paramref name="memberName"/> by its
    /// <see cref="EmittedName"/>: hand-written code reads it.
    /// </summary>
    public bool IsExcludedFromUnmarshalling(string shapeName, string memberName) =>
        ShapeModifiers.TryGetValue(shapeName, out var modifier) && modifier.ExcludeFromUnmarshalling.Contains(EmittedName(shapeName, memberName));

    /// <summary>
    /// True when <c>skipXmlIsSet</c> leaves modeled member <paramref name="memberName"/> without an <c>IsSet</c>
    /// method, so the restXml request marshaller sends it even when unset.
    /// </summary>
    public bool SkipsXmlIsSet(string shapeName, string memberName) => PropertyModifierFor(shapeName, memberName)?.SkipXmlIsSet ?? false;

    /// <summary>The <c>injectMarshallCode</c> lines written in place of <paramref name="memberName"/>, or null.</summary>
    public List<string>? InjectedMarshallCode(string shapeName, string memberName) => PropertyModifierFor(shapeName, memberName)?.InjectMarshallCode;

    /// <summary>The <c>injectMarshallCodeInPayload</c> lines of <paramref name="shapeName"/>, or null.</summary>
    public List<string>? InjectedMarshallCodeInPayload(string shapeName) => ShapeModifiers.GetValueOrDefault(shapeName)?.InjectMarshallCodeInPayload;

    /// <summary>True when <c>accessModifier</c> makes modeled member <paramref name="memberName"/> <c>internal</c>, the only value supported.</summary>
    public bool IsInternal(string shapeName, string memberName) => PropertyModifierFor(shapeName, memberName)?.AccessModifier == "internal";

    /// <summary>The <c>injectPropertyGetter</c> lines that replace modeled member <paramref name="memberName"/>'s getter, or null.</summary>
    public List<string>? CustomGetter(string shapeName, string memberName) => PropertyModifierFor(shapeName, memberName)?.InjectPropertyGetter;

    /// <summary>The <c>injectPropertySetter</c> lines that replace modeled member <paramref name="memberName"/>'s setter, or null.</summary>
    public List<string>? CustomSetter(string shapeName, string memberName) => PropertyModifierFor(shapeName, memberName)?.InjectPropertySetter;

    /// <summary>
    /// The <c>marshallNameOverrides</c> wire name <paramref name="operationName"/>'s request gives property
    /// <paramref name="propertyName"/> of <paramref name="shapeName"/>, or null.
    /// </summary>
    public string? MarshallNameOverride(string operationName, string shapeName, string propertyName) =>
        OperationModifiers.TryGetValue(operationName, out var modifier)
            ? modifier.MarshallNameOverrides.SelectMany(entry => entry).Where(entry => entry.Key == shapeName)
                .Select(entry => entry.Value.GetValueOrDefault(propertyName)?.MarshallName).FirstOrDefault(name => name is not null)
            : null;

    /// <summary>
    /// The <c>emitPropertyName</c> of modeled member <paramref name="memberName"/>, or the modeled name when it isn't
    /// renamed. C2J keys <c>emitIsSetProperties</c> and <c>dataTypeSwap</c> by this name.
    /// </summary>
    public string EmittedName(string shapeName, string memberName) => PropertyModifierFor(shapeName, memberName)?.EmitPropertyName ?? memberName;

    /// <summary>Whether modeled member <paramref name="memberName"/> overrides a base-class member of the same name.</summary>
    public bool OverridesBaseMember(string shapeName, string memberName) => PropertyModifierFor(shapeName, memberName)?.OverridesBaseMember ?? false;

    private PropertyModifier? PropertyModifierFor(string shapeName, string memberName) =>
        ShapeModifiers.TryGetValue(shapeName, out var modifier)
            ? modifier.PropertyFor(memberName)
            : null;

    /// <summary>
    /// The C# property name of modeled member <paramref name="memberName"/>: its <see cref="EmittedName"/> with the
    /// first character upper-cased, as C2J emits it (iot's <c>"emitPropertyName": "marker"</c> is <c>Marker</c>).
    /// The rename never reaches the model, so the member's wire name stays the modeled one on every protocol.
    /// </summary>
    public string PropertyName(string shapeName, string memberName) => SdkNaming.ToUpperFirstCharacter(EmittedName(shapeName, memberName));
}
