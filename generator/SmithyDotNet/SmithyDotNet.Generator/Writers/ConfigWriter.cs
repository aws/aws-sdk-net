using Microsoft.CodeAnalysis.CSharp;
using SmithyDotNet.Generator.Generation;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Emits the C# source for the service configuration class (e.g. <c>AmazonCloudTrailDataConfig</c>),
/// which derives from <see cref="Amazon.Runtime.ClientConfig"/> and supplies the service's identity:
/// its <c>ServiceId</c>, <c>ServiceVersion</c>, <c>AuthenticationServiceName</c>, and
/// <c>RegionEndpointServiceName</c>, plus the user-agent string and (for services with an endpoint
/// rule set) the endpoint resolver/provider wiring.
/// <para />
/// Most of the class is a projection of the Smithy AST. The lone exception is the package build
/// version baked into the user-agent string (<c>BuildUserAgentString(serviceId, version)</c>): that
/// version is not in the model (it comes from the C2J <c>_sdk-versions.json</c>), so it is supplied
/// to the writer as a constructor argument rather than derived, the same way the model file name is.
/// </summary>
public sealed class ConfigWriter(GenerationContext context, string modelFileName, string serviceFileVersion)
{
    // The config references the service's .Internal types (EndpointResolver/Provider,
    // DefaultConfiguration) alongside the runtime/auth/endpoint namespaces. Mirrors the using set of
    // the existing C2J-generated config.
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
            // The class doc uses the normalized service name (ClassName), not the raw sdkId, matching
            // the legacy ServiceConfig.tt: "Configuration for accessing Amazon {ClassName} service".
            writer.WriteLine($"/// Configuration for accessing Amazon {context.ServiceName} service");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public partial class {configName} : ClientConfig", () =>
            {
                // Blank-line spacing between members matches the oracle.
                WriteStaticFields(writer);
                WriteServiceIdProperty(writer);
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
        // The user-agent string pairs the raw sdkId with the external package build version (the one
        // input not present in the Smithy model; see the class remarks).
        writer.WriteLine("private static readonly string UserAgentString =");
        writer.WriteLine($"    InternalSDKUtils.BuildUserAgentString({Literal(context.SdkId)}, {Literal(serviceFileVersion)});");
        writer.WriteLine();

        // The static endpoint resolver field exists only for services with an endpoint rule set
        // (the legacy template's "EndpointsRuleSet != null" branch).
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
        // The static ServiceId returns the verbatim sdkId ("CloudTrail Data"), NOT the normalized
        // class-name component. The doc uses the C2J ServiceConfig.tt's tight "///<summary>" form.
        writer.WriteLine("///<summary>");
        writer.WriteLine("/// The ServiceId, which is the unique identifier for a service.");
        writer.WriteLine("///</summary>");
        writer.WriteLine($"public static new string ServiceId => {Literal(context.SdkId)};");
    }

    private void WriteConstructor(CodeWriter writer, string configName)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Default constructor");
        writer.WriteLine("/// </summary>");
        // CodeWriter has no constructor-initializer helper, so the ": base(...)" line is written as
        // the OpenBlock header, matching the ClientClassWriter pattern.
        writer.WriteLine($"public {configName}()");
        writer.OpenBlock($"    : base(new Amazon.Runtime.Internal.DefaultConfigurationProvider({context.ClientName}DefaultConfiguration.GetAllConfigurations()))", () =>
        {
            writer.WriteLine($"base.ServiceId = {Literal(context.SdkId)};");
            // AuthenticationServiceName is always present (EndpointPrefix is required, and it is the
            // fallback), so it is emitted unconditionally, matching every shipping config.
            writer.WriteLine($"this.AuthenticationServiceName = {Literal(context.AuthenticationServiceName)};");
            // The legacy template also emits MaxErrorRetry (from customizations.json
            // overrideMaxRetries) and a RegionEndpoint fallback (from defaultRegion) here for the few
            // services that customize them. Those values live in the C2J customization layer (the same
            // layer that carries operation renames), not the Smithy model, so they are deferred to the
            // customization-source hook (CloudTrailData has neither).
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
        writer.WriteLine($"public override string RegionEndpointServiceName => {Literal(context.EndpointPrefix)};");
    }

    private void WriteServiceVersion(CodeWriter writer)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Gets the ServiceVersion property.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"public override string ServiceVersion => {Literal(context.ApiVersion)};");
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

    // Renders a runtime string value as a quoted, fully-escaped C# string literal, so a value
    // containing a quote or backslash still produces compilable source.
    private static string Literal(string value) => SymbolDisplay.FormatLiteral(value, quote: true);
}
