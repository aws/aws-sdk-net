using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Generation;

/// <summary>
/// The wire protocol used by an AWS service.
/// </summary>
public enum AWSProtocol { RestJson1 }

/// <summary>
/// An error shape paired with its <see cref="ShapeId"/>. A <see cref="StructureShape"/> does
/// not carry its own ID, but writers need the error's name (e.g. to derive the
/// <c>{Name}Exception</c> class referenced in an operation's <c>&lt;exception&gt;</c> doc tags),
/// so the ID is resolved up front alongside the shape.
/// </summary>
public record OperationError(StructureShape Shape, ShapeId Id);

/// <summary>
/// An operation with its input, output, and error shapes pre-resolved so writers
/// don't need to perform lookups themselves.
/// </summary>
public record Operation(string Name, OperationShape Shape, StructureShape Input, StructureShape Output, IReadOnlyList<OperationError> Errors);

/// <summary>
/// Aggregates everything code writers need about a single service: derived names,
/// detected protocol, resolved operations, and partitioned reachable shapes.
/// Built from a validated <see cref="ServiceIndex"/>.
/// </summary>
public class GenerationContext
{
    /// <summary>The .NET namespace for generated code (e.g. "Amazon.CloudTrailData").</summary>
    public string Namespace { get; }

    /// <summary>The service class name (e.g. "CloudTrailData"). Used to derive all other names.</summary>
    public string ServiceName { get; }

    /// <summary>The raw, unmodified <c>sdkId</c> from the <c>aws.api#service</c> trait (e.g. "CloudTrail Data"). Unlike <see cref="ServiceName"/>, this is not normalized; it is the verbatim ServiceId the SDK metadata exposes.</summary>
    public string SdkId { get; }

    /// <summary>The client class name without "Client" suffix (e.g. "AmazonCloudTrailData").</summary>
    public string ClientName { get; }

    /// <summary>The service's API version from the service shape (e.g. "2021-08-11"). Used in generated doc links.</summary>
    public string ApiVersion { get; }

    /// <summary>The service's <c>endpointPrefix</c> from the <c>aws.api#service</c> trait (e.g. "cloudtrail-data"). Used in generated doc links.</summary>
    public string EndpointPrefix { get; }

    /// <summary>
    /// The signing name used as the service config's <c>AuthenticationServiceName</c> (e.g.
    /// "cloudtrail-data"). This is the <c>aws.auth#sigv4</c> trait's <c>name</c> when present,
    /// falling back to <see cref="EndpointPrefix"/>, matching the legacy generator's precedence
    /// (<c>SigningName ?? EndpointPrefix</c>).
    /// </summary>
    public string AuthenticationServiceName { get; }

    /// <summary>
    /// Whether the service carries a Smithy endpoint rule set (<c>smithy.rules#endpointRuleSet</c>).
    /// The service config emits its endpoint resolver field, <c>EndpointProvider</c> wiring, and
    /// <c>DetermineServiceOperationEndpoint</c> override only when this is true: the Smithy-AST
    /// equivalent of the legacy template's <c>EndpointsRuleSet != null</c> branch.
    /// </summary>
    public bool HasEndpointRuleSet { get; }

    /// <summary>
    /// The parsed endpoint rule set, or <c>null</c> when <see cref="HasEndpointRuleSet"/> is false.
    /// The endpoint writers compile this into the parameters class and the endpoint provider.
    /// </summary>
    public EndpointRuleSet? EndpointRuleSet { get; }

    /// <summary>
    /// Whether any shape carries an endpoint context-parameter trait (service <c>clientContextParams</c>,
    /// operation <c>staticContextParams</c>, or member <c>contextParam</c>).
    /// </summary>
    public bool HasEndpointContextParams { get; }

    /// <summary>
    /// Whether the service carries a Smithy endpoint test suite (<c>smithy.rules#endpointTests</c>).
    /// The endpoint provider tests file is emitted only when this is true. The constructor throws if
    /// this is true while <see cref="HasEndpointRuleSet"/> is false: the generated tests reference the
    /// endpoint parameters/provider types, which only exist when a rule set is also present.
    /// </summary>
    public bool HasEndpointTests { get; }

    /// <summary>
    /// The parsed endpoint test suite, or <c>null</c> when <see cref="HasEndpointTests"/> is false.
    /// </summary>
    public EndpointTestSuite? EndpointTests { get; }

    /// <summary>
    /// The service-level auth scheme shape IDs the resolver's <c>default</c> arm returns (e.g.
    /// <c>["aws.auth#sigv4"]</c>): the service's <c>smithy.api#auth</c> trait when present, otherwise
    /// derived from its auth traits.
    /// </summary>
    public IReadOnlyList<string> ServiceAuthSchemes { get; }

    /// <summary>
    /// Whether the service supports SigV4 (its auth scheme list contains <c>aws.auth#sigv4</c>). The
    /// auth resolver emits the <c>Region</c> parameter only when this is true.
    /// </summary>
    public bool SupportsSigV4 { get; }

    /// <summary>
    /// The operations that model their own auth (a <c>smithy.api#auth</c> override), each paired with
    /// its scheme list and ordered by name. These become the auth resolver's per-operation switch
    /// arms; operations without an override fall through to <see cref="ServiceAuthSchemes"/>.
    /// </summary>
    public IReadOnlyList<OperationAuth> OperationsWithModeledAuth { get; }

    /// <summary>The service shape's <c>@documentation</c>, or null if absent. Used for the client interface/class summary.</summary>
    public string? ServiceDocumentation { get; }

    /// <summary>The service's <c>smithy.api#title</c> (e.g. "AWS CloudTrail Data Service"). C2J equivalent: <c>service.FullName</c>. Used in the assembly description.</summary>
    public string? ServiceTitle { get; }

    /// <summary>The wire protocol detected from the service shape's protocol trait.</summary>
    public AWSProtocol Protocol { get; }

    /// <summary>All operations with their input/output/error shapes resolved.</summary>
    public IReadOnlyList<Operation> Operations { get; }

    /// <summary>Reachable structures excluding input, output, and error shapes, keyed by shape ID. Sorted by shape ID for deterministic output.</summary>
    public IReadOnlyDictionary<ShapeId, StructureShape> Structures { get; }

    /// <summary>Reachable structures that carry the <c>@error</c> trait, keyed by shape ID. Sorted by shape ID for deterministic output.</summary>
    public IReadOnlyDictionary<ShapeId, StructureShape> Errors { get; }

    /// <summary>
    /// The service's <c>metadata.json</c>, or <c>null</c> when no metadata file was supplied.
    /// Carries package/naming values (synopsis, base-name, tags, ...) and other metadata that the Smithy model can't
    /// express.
    /// </summary>
    public ServiceMetadata? Metadata { get; }

    private readonly ServiceIndex _index;

    /// <summary>
    /// The manifest for the service, read from _sdk-versions.json
    /// </summary>
    public SdkVersionManifest Manifest { get; }

    /// <summary>
    /// The name of the Assembly for the service, without the dll suffix i.e. AWSSDK.CloudTrailData.
    /// </summary>
    public string AssemblyName { get; }

    // TODO: Accept SmithyModel for shapes not reachable from operations (e.g. shared error shapes).
    // TODO: Add enum values to AWSProtocol as protocols are implemented.
    // TODO: Add customization layer hook in constructor (renames, shape modifiers).
    public GenerationContext(ServiceIndex index, SdkVersionManifest manifest, ServiceMetadata? metadata = null)
    {
        _index = index;
        Metadata = metadata;
        Manifest = manifest;
        var serviceTrait = index.Service.GetAWSService() ?? throw new GeneratorException("Service shape is missing the aws.api#service trait.");
        SdkId = serviceTrait.SdkId;
        //TODO: ServiceName should mirror ClassName in the generator, which takes into account metadata.json, customizations, and overrides
        ServiceName = SdkNaming.NormalizeSdkId(SdkId);
        Namespace = $"Amazon.{ServiceName}";
        ClientName = $"Amazon{ServiceName}";
        ApiVersion = index.Service.ApiVersion;
        AssemblyName = $"AWSSDK.{ServiceName}";
        // TODO: EndpointPrefix and ApiVersion together form the generated <seealso> doc URL
        // ("{EndpointPrefix}-{ApiVersion}"). EndpointPrefix is null-guarded below, but an empty or
        // whitespace value in either would silently produce a malformed URL. Validate both once more
        // services are onboarded.
        EndpointPrefix = serviceTrait.EndpointPrefix ?? throw new GeneratorException("aws.api#service trait is missing endpointPrefix.");

        // AuthenticationServiceName follows the legacy generator's precedence: the sigv4 signing name
        // when the trait is present, otherwise the endpoint prefix.
        AuthenticationServiceName = index.Service.GetSigV4()?.SigningName ?? EndpointPrefix;

        EndpointRuleSet = index.Service.GetEndpointRuleSet();
        HasEndpointRuleSet = EndpointRuleSet is not null;
        HasEndpointContextParams = DetectEndpointContextParams(index);

        EndpointTests = index.Service.GetEndpointTests();
        HasEndpointTests = EndpointTests is not null;
        if (HasEndpointTests && !HasEndpointRuleSet)
        {
            throw new GeneratorException("Service carries smithy.rules#endpointTests but no smithy.rules#endpointRuleSet.");
        }

        ServiceDocumentation = index.Service.GetDocumentation();
        ServiceTitle = index.Service.GetTitle();
        Protocol = DetectProtocol(index.Service);
        Operations = ResolveOperations(index);
        ServiceAuthSchemes = ModeledAuth.ServiceSchemes(index.Service);
        SupportsSigV4 = AuthSchemeMapping.ContainsSigV4(ServiceAuthSchemes);
        OperationsWithModeledAuth = ModeledAuth.OperationOverrides(Operations);

        var structures = new Dictionary<ShapeId, StructureShape>();
        var errors = new Dictionary<ShapeId, StructureShape>();

        foreach (var (shapeId, shape) in index.Shapes.OrderBy(kvp => kvp.Key.AbsoluteName, StringComparer.Ordinal))
        {
            if (shape is not StructureShape structure)
            {
                continue;
            }

            if (structure.IsError())
            {
                errors[shapeId] = structure;
            }
            else if (!structure.IsInput() && !structure.IsOutput())
            {
                structures[shapeId] = structure;
            }
        }

        Structures = structures;
        Errors = errors;
    }

    /// <summary>
    /// Looks up a shape by its <see cref="ShapeId"/>. 
    /// <para />
    /// Prelude shapes (e.g. <c>smithy.api#String</c>)
    /// are not in the index but resolve via <see cref="PreludeShapes"/>, so callers never need to
    /// special-case them. Throws if the shape is genuinely absent.
    /// </summary>
    public Shape Resolve(ShapeId shapeId)
    {
        if (_index.Shapes.TryGetValue(shapeId, out var shape))
        {
            return shape;
        }

        return PreludeShapes.Resolve(shapeId) ?? throw new GeneratorException($"Shape '{shapeId}' not found.");
    }

    /// <summary>
    /// Returns the .NET type/member name for a shape (currently just the shape name).
    /// </summary>
    /// <remarks>
    /// Future phases will layer in:
    /// 1. ServiceShape.Rename map (Smithy service-level renames to avoid conflicts)
    /// 2. Customization renames (shapeModifiers[shapeName].rename from customizations.json)
    /// 3. Member-level property name overrides (customization propertyModifier.emitName)
    /// 4. EC2 query name (aws.protocols#ec2QueryName trait for protocol-specific naming)
    /// </remarks>
    public string ToDotNetName(ShapeId shapeId) => shapeId.Name;

    // Context params live on the service, on operations, or on structure members, so all three are
    // scanned. Members are only reachable through the shapes index.
    private static bool DetectEndpointContextParams(ServiceIndex index)
    {
        if (index.Service.HasEndpointContextParams())
        {
            return true;
        }

        if (index.Operations.Any(operation => operation.HasEndpointContextParams()))
        {
            return true;
        }

        return index.Shapes.Values
            .OfType<StructureShape>()
            .SelectMany(structure => structure.Members.Values)
            .Any(member => member.HasEndpointContextParams());
    }

    private static AWSProtocol DetectProtocol(ServiceShape service)
    {
        if (service.IsRestJson1())
        {
            return AWSProtocol.RestJson1;
        }

        throw new GeneratorException("Service shape has no recognized AWS protocol trait.");
    }

    private static List<Operation> ResolveOperations(ServiceIndex index)
    {
        var operationIds = index.Service.Operations;
        var operations = index.Operations;
        var resolved = new List<Operation>(operations.Count);

        for (var i = 0; i < operations.Count; i++)
        {
            var operationId = operationIds[i];
            var operation = operations[i];

            var input = ResolveStructure(index, operation.Input, "input", operationId);
            var output = ResolveStructure(index, operation.Output, "output", operationId);

            var errors = new List<OperationError>(operation.Errors.Count);
            foreach (var errorId in operation.Errors)
            {
                errors.Add(new OperationError(ResolveStructure(index, errorId, "error", operationId), errorId));
            }

            resolved.Add(new Operation(operationId.Name, operation, input, output, errors));
        }

        return resolved;
    }

    private static StructureShape ResolveStructure(ServiceIndex index, ShapeId shapeId, string property, ShapeId operationId)
    {
        if (index.Shapes.TryGetValue(shapeId, out var shape) && shape is StructureShape structure)
        {
            return structure;
        }

        throw new GeneratorException($"Could not resolve {property} shape '{shapeId}' for operation '{operationId}'.");
    }
}
