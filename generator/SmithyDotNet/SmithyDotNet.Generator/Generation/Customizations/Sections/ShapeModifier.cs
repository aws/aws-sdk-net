using System.Text.Json.Serialization;

namespace SmithyDotNet.Generator.Generation.Customizations;

/// <summary>A <c>shapeModifiers</c> entry: <c>modify</c> is a list of single-key objects mapping a member name to its modifier.</summary>
public sealed record ShapeModifier
{
    [JsonPropertyName("modify")]
    public List<Dictionary<string, PropertyModifier>> Modify { get; init; } = [];

    /// <summary>Members the model lacks, added to the shape; each is a single-key object like <c>modify</c>'s.</summary>
    [JsonPropertyName("inject")]
    public List<Dictionary<string, PropertyInjector>> Inject { get; init; } = [];

    /// <summary>Members dropped from the shape, so they are neither emitted nor sent or read.</summary>
    [JsonPropertyName("exclude")]
    public List<string> Exclude { get; init; } = [];

    /// <summary>restXml-only: see <see cref="CustomizationsModel.IsExcludedFromMarshalling"/>.</summary>
    [JsonPropertyName("excludeFromMarshalling")]
    public List<string> ExcludeFromMarshalling { get; init; } = [];

    /// <summary>restXml-only: see <see cref="CustomizationsModel.IsExcludedFromUnmarshalling"/>.</summary>
    [JsonPropertyName("excludeFromUnmarshalling")]
    public List<string> ExcludeFromUnmarshalling { get; init; } = [];

    /// <summary>Lines written before the payload's root element.</summary>
    [JsonPropertyName("injectMarshallCodeInPayload")]
    public List<string>? InjectMarshallCodeInPayload { get; init; }

    /// <summary>The <c>[Obsolete]</c> message for the shape (e.g. a request/response class); applied only when the shape is already <c>@deprecated</c>.</summary>
    [JsonPropertyName("deprecatedMessage")]
    public string? DeprecatedMessage { get; init; }

    /// <summary>True when any of the three exclusion lists has an entry.</summary>
    public bool HasExclusions() => Exclude.Count > 0 || ExcludeFromMarshalling.Count > 0 || ExcludeFromUnmarshalling.Count > 0;

    /// <summary>True when the modifier sets a hook only the restXml marshallers honor.</summary>
    public bool HasRestXmlHooks()
    {
        if (ExcludeFromMarshalling.Count > 0 || ExcludeFromUnmarshalling.Count > 0 || InjectMarshallCodeInPayload is not null)
        {
            return true;
        }

        foreach (var entry in Modify)
        {
            foreach (var property in entry.Values)
            {
                if (property.SkipXmlIsSet || property.InjectMarshallCode is not null)
                {
                    return true;
                }
            }
        }

        return false;
    }

    /// <summary>The <c>modify</c> entry for <paramref name="memberName"/>, or null.</summary>
    public PropertyModifier? PropertyFor(string memberName) => Modify.SelectMany(entry => entry).FirstOrDefault(entry => entry.Key == memberName).Value;

    /// <summary>The <c>inject</c> entry for <paramref name="memberName"/>, or null.</summary>
    public PropertyInjector? InjectorFor(string memberName) => Inject.SelectMany(entry => entry).FirstOrDefault(entry => entry.Key == memberName).Value;
}

/// <summary>A single member's modifications inside a <c>modify</c> entry.</summary>
public sealed record PropertyModifier
{
    /// <summary>The .NET property name to emit instead of the modeled member name; the wire name is unaffected.</summary>
    [JsonPropertyName("emitPropertyName")]
    public string? EmitPropertyName { get; init; }

    /// <summary>The <c>[Obsolete]</c> message for the member; applied only when the member is already <c>@deprecated</c>.</summary>
    [JsonPropertyName("deprecatedMessage")]
    public string? DeprecatedMessage { get; init; }

    /// <summary>
    /// Emit the property with <c>override</c>: a hand-written partial gives the structure a base class that declares
    /// the same member (CognitoIdentity's and SecurityToken's <c>Credentials</c> derive from <c>AWSCredentials</c>,
    /// whose <c>BaseIdentity</c> declares a virtual <c>Expiration</c>).
    /// </summary>
    [JsonPropertyName("overridesBaseMember")]
    public bool OverridesBaseMember { get; init; }

    /// <summary>ec2Query-only: the request parameter name, upper-cased as C2J does; responses keep the modeled name.</summary>
    [JsonPropertyName("locationName")]
    public string? LocationName { get; init; }

    /// <summary>ec2Query-only: see <see cref="CustomizationsModel.CustomMarshall"/>.</summary>
    [JsonPropertyName("customMarshall")]
    public bool CustomMarshall { get; init; }

    /// <summary>The property's accessibility instead of <c>public</c>; only <c>internal</c> is accepted (ec2's SDK-filled PresignedUrl).</summary>
    [JsonPropertyName("accessModifier")]
    public string? AccessModifier { get; init; }

    /// <summary>restXml-only: see <see cref="CustomizationsModel.SkipsXmlIsSet"/>.</summary>
    [JsonPropertyName("skipXmlIsSet")]
    public bool SkipXmlIsSet { get; init; }

    /// <summary>See <see cref="CustomizationsModel.InjectedMarshallCode"/>.</summary>
    [JsonPropertyName("injectMarshallCode")]
    public List<string>? InjectMarshallCode { get; init; }

    /// <summary>
    /// Lines that replace the property's getter (S3's <c>get { return this._tagCount ?? 0; }</c>), reading the C2J-named
    /// backing field. Keyed by the modeled member name, like every other <c>modify</c> key (C2J uses the emitted name).
    /// </summary>
    [JsonPropertyName("injectPropertyGetter")]
    public List<string>? InjectPropertyGetter { get; init; }

    /// <summary>Lines that replace the property's setter; see <see cref="InjectPropertyGetter"/>.</summary>
    [JsonPropertyName("injectPropertySetter")]
    public List<string>? InjectPropertySetter { get; init; }
}

/// <summary>An <c>inject</c> entry: a member the model lacks, typed by the modeled shape <see cref="Shape"/>.</summary>
public sealed record PropertyInjector
{
    [JsonPropertyName("shape")]
    public required string Shape { get; init; }

    [JsonPropertyName("documentation")]
    public string? Documentation { get; init; }

    /// <summary>
    /// The wire name: with <see cref="Location"/> the header name (or a map's header prefix), otherwise the XML name
    /// (ec2Query upper-cases it in requests and lower-cases it in responses, as C2J does).
    /// </summary>
    [JsonPropertyName("locationName")]
    public string? LocationName { get; init; }

    /// <summary>
    /// Only <c>header</c>, the one value used (S3's CopyObjectRequest.SourceBucket): an <c>@httpHeader</c> named by
    /// <see cref="LocationName"/> or the member, or for a map <c>@httpPrefixHeaders</c>.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; init; }

    /// <summary>
    /// An excluded member of the same shape that the injected one replaces: it takes the original's XML name and
    /// <c>@contextParam</c>, which is all C2J reads from it (S3's
    /// CopyObjectRequest.DestinationKey keeps Key's endpoint parameter).
    /// </summary>
    [JsonPropertyName("originalMember")]
    public string? OriginalMember { get; init; }

    /// <summary>
    /// Set with <see cref="OutsideOriginalMember"/>: the injected member is a copy of another shape's member, target
    /// included, as in C2J (S3's GetBucketLifecycleConfigurationOutput.Configuration); <see cref="Shape"/> must be the copy's target as modeled.
    /// </summary>
    [JsonPropertyName("originalMemberIsOutsideContainingShape")]
    public bool OriginalMemberIsOutsideContainingShape { get; init; }

    /// <summary>The member <see cref="OriginalMemberIsOutsideContainingShape"/> copies, as <c>"ShapeName,MemberName"</c>.</summary>
    [JsonPropertyName("outsideOriginalMember")]
    public string? OutsideOriginalMember { get; init; }

    /// <summary>ec2Query-only: see <see cref="CustomizationsModel.CustomMarshall"/>.</summary>
    [JsonPropertyName("customMarshall")]
    public bool CustomMarshall { get; init; }
}
