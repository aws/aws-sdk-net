using SmithyDotNet.Generator.Generation;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Emits the C# source for the service configuration class (e.g. <c>AmazonCloudTrailDataConfig</c>),
/// which derives from <see cref="Amazon.Runtime.ClientConfig"/> and supplies the service's identity:
/// its <c>ServiceId</c>, <c>ServiceVersion</c>, <c>AuthenticationServiceName</c>, and
/// <c>RegionEndpointServiceName</c>, plus the user-agent string and (for services with an endpoint
/// rule set) the endpoint resolver/provider wiring.
/// <para />
/// The package build version is not in the Smithy model (it comes from C2J <c>_sdk-versions.json</c>),
/// so it is supplied as a constructor argument.
/// </summary>
public sealed class ConfigWriter(GenerationContext context, string modelFileName, string serviceFileVersion)
{
    // The runtime/auth/endpoint namespaces and the service's .Internal types
    // (EndpointResolver/Provider, DefaultConfiguration) the config references.
    private readonly IReadOnlyList<string> _usings =
    [
        "System",
        "Amazon.Runtime",
        "Amazon.Runtime.Internal",
        "Amazon.Util.Internal",
        "Amazon.Runtime.Internal.Auth",
        "Amazon.Runtime.Endpoints",
        $"{context.Namespace}.Internal",
    ];

    /// <summary>
    /// Emits the complete formatted config source for the service.
    /// </summary>
    public string Write(CancellationToken cancellationToken = default)
    {
        var configName = $"{context.ClientName}Config";

        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, _usings);
        writer.OpenNamespace(context.Namespace, () =>
        {
            writer.WriteLine("/// <summary>");
            // Class doc uses the normalized ServiceName (e.g. CloudTrailData), not the sdkId.
            writer.WriteLine($"/// Configuration for accessing Amazon {context.ServiceName} service");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public partial class {configName} : ClientConfig", () =>
            {
                WriteStaticFields(writer);
                writer.WriteLine();
                WriteServiceIdProperty(writer);
                writer.WriteLine();
                WriteConstructor(writer, configName);
                writer.WriteLine();
                WriteRegionEndpointServiceName(writer);
                writer.WriteLine();
                WriteServiceVersion(writer);
                writer.WriteLine();
                WriteUserAgent(writer);
                if (context.HasEndpointRuleSet)
                {
                    writer.WriteLine();
                    WriteDetermineServiceOperationEndpoint(writer);
                }
            });
        });

        return writer.ToFormattedString(cancellationToken);
    }

    private void WriteStaticFields(CodeWriter writer)
    {
        // User-agent pairs the sdkId with the build version (see class remarks).
        writer.WriteLine("private static readonly string UserAgentString =");
        writer.WriteLine($"    InternalSDKUtils.BuildUserAgentString({CodeWriter.Literal(context.SdkId)}, {CodeWriter.Literal(serviceFileVersion)});");
        writer.WriteLine();

        // The static endpoint resolver field exists only for services with an endpoint rule set.
        if (context.HasEndpointRuleSet)
        {
            writer.WriteLine($"private static readonly {context.ClientName}EndpointResolver EndpointResolver =");
            writer.WriteLine($"    new {context.ClientName}EndpointResolver();");
            writer.WriteLine();
        }

        writer.WriteLine("private string _userAgent = UserAgentString;");
    }

    private void WriteServiceIdProperty(CodeWriter writer)
    {
        // Static ServiceId is the sdkId ("CloudTrail Data"), not the normalized class name.
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// The ServiceId, which is the unique identifier for a service.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"public static new string ServiceId => {CodeWriter.Literal(context.SdkId)};");
    }

    private void WriteConstructor(CodeWriter writer, string configName)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Default constructor");
        writer.WriteLine("/// </summary>");
        // CodeWriter has no constructor-initializer helper, so the ": base(...)" line is written as
        // the OpenBlock header.
        writer.WriteLine($"public {configName}()");
        writer.OpenBlock($"    : base(new Amazon.Runtime.Internal.DefaultConfigurationProvider({context.ClientName}DefaultConfiguration.GetAllConfigurations()))", () =>
        {
            writer.WriteLine($"base.ServiceId = {CodeWriter.Literal(context.SdkId)};");
            // AuthenticationServiceName is always present (EndpointPrefix is required and is the
            // fallback), so it is emitted unconditionally.
            writer.WriteLine($"this.AuthenticationServiceName = {CodeWriter.Literal(context.AuthenticationServiceName)};");
            if (context.HasEndpointRuleSet)
            {
                writer.WriteLine($"this.EndpointProvider = new {context.ClientName}EndpointProvider();");
            }
        });
    }

    private void WriteRegionEndpointServiceName(CodeWriter writer)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// The constant used to lookup in the region hash the endpoint.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"public override string RegionEndpointServiceName => {CodeWriter.Literal(context.EndpointPrefix)};");
    }

    private void WriteServiceVersion(CodeWriter writer)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Gets the ServiceVersion property.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"public override string ServiceVersion => {CodeWriter.Literal(context.ApiVersion)};");
    }

    private static void WriteUserAgent(CodeWriter writer)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Gets the value of UserAgent property.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine("public override string UserAgent => _userAgent;");
    }

    private static void WriteDetermineServiceOperationEndpoint(CodeWriter writer)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Returns the endpoint that will be used for a particular request.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine("/// <param name=\"parameters\">A Container class for parameters used for endpoint resolution.</param>");
        writer.WriteLine("/// <returns>The resolved endpoint for the given request.</returns>");
        writer.OpenBlock("public override Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(ServiceOperationEndpointParameters parameters)", () =>
        {
            writer.OpenBlock("var requestContext = new RequestContext(false)", "};", () =>
            {
                writer.WriteLine("ClientConfig = this,");
                writer.WriteLine("OriginalRequest = parameters.Request,");
                writer.OpenBlock("Request = new DefaultRequest(parameters.Request, ServiceId)", "}", () =>
                {
                    writer.WriteLine("AlternateEndpoint = parameters.AlternateEndpoint");
                });
            });
            writer.WriteLine();
            writer.WriteLine("var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);");
            writer.WriteLine("return EndpointResolver.GetEndpoint(executionContext);");
        });
    }
}
