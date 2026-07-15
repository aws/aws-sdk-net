using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Writers;
using SmithyDotNet.Generator.Writers.CodeAnalysis;
using SmithyDotNet.Generator.Writers.Endpoints;
using SmithyDotNet.Generator.Writers.NuGet;
using System.Collections.Concurrent;

namespace SmithyDotNet.Generator.Generation;

/// <summary>
/// Orchestrates the writers for a single service: invokes each one, maps its output to the
/// SDK-conventional relative path, and writes the files under <c>{outputPath}/Generated/</c>.
/// <para />
/// Phase 1 scope: the writers that exist today (interface, client, config, service exception,
/// metadata, endpoint parameters/provider/resolver, operation request/response/base, structures,
/// exceptions, the restJson1 request marshaller + structure (un)marshallers, and the auth resolver).
/// The operation-response / exception unmarshallers have no writers yet, so the generated tree does
/// not compile standalone.
/// </summary>
public sealed class ServiceGenerator(GenerationContext context, string modelFileName, string serviceFileVersion, IReadOnlyList<ResolvedDefaultConfigurationMode> defaultConfigurationModes)
{
    /// <summary>
    /// Generates every file for the service and writes it under <paramref name="outputPath"/>.
    /// Returns the relative paths written under <paramref name="outputPath"/>, for logging and tests.
    /// <para />
    /// When <paramref name="testsOutputPath"/> is supplied and the service carries endpoint tests
    /// (<see cref="GenerationContext.HasEndpointTests"/>), the endpoint provider tests file is also
    /// written under <c>{testsOutputPath}/UnitTests/Generated/Endpoints/</c> — a separate root because
    /// the SDK lays out its test tree (<c>sdk/test/Services/{Service}/</c>) as a sibling of the source
    /// tree (<c>sdk/src/Services/{Service}/</c>), not nested under it. That file gets its own
    /// duplicate-path guard (via <c>EmitUnder</c>) but isn't tracked in the returned list, which stays
    /// scoped to <paramref name="outputPath"/>.
    /// </summary>
    public IReadOnlyList<string> Generate(string outputPath, string? testsOutputPath = null, CancellationToken cancellationToken = default)
    {
        var clientName = context.ClientName;
        // Concurrent-safe so Emit can be called from parallel writers later. TryAdd both reserves
        // the path (atomic fail-fast on duplicates) and records it as written, so there is a single
        // collection to reason about.
        var written = new ConcurrentDictionary<string, byte>();
        var writtenTests = new ConcurrentDictionary<string, byte>();

        void EmitUnder(string root, ConcurrentDictionary<string, byte> tracker, string relativePath, string contents)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // Fail fast: two writers targeting the same path would silently overwrite, producing
            // wrong output while still reporting success.
            if (!tracker.TryAdd(relativePath, 0))
            {
                throw new GeneratorException($"Two writers produced the same output path: '{relativePath}'.");
            }

            WriteFile(root, relativePath, contents);
        }

        void Emit(string relativePath, string contents) => EmitUnder(outputPath, written, relativePath, contents);
        
        var generated = "Generated";
        var model = Path.Combine(generated, "Model");
        var @internal = Path.Combine(generated, "Internal");
        var marshalling = Path.Combine(model, "Internal", "MarshallTransformations");
        // the real codeAnalysis folder is up two levels from "generatedOutput" but for now let's just put it at the 
        // same level as the "Generated" folder.
        var codeAnalysis = "code-analysis";
        var ServiceAnalysis = "ServiceAnalysis";
        var serviceSpecificCodeAnalysis = Path.Combine(codeAnalysis, ServiceAnalysis);
        var serviceSpecificCodeAnalysisGenerated = Path.Combine(serviceSpecificCodeAnalysis, generated);

        var interfaceWriter = new ClientInterfaceWriter(context, modelFileName);
        Emit(Path.Combine(generated, $"IAmazon{context.ServiceName}.g.cs"), interfaceWriter.Write(cancellationToken));

        var clientWriter = new ClientClassWriter(context, modelFileName);
        Emit(Path.Combine(generated, $"{clientName}Client.g.cs"), clientWriter.Write(cancellationToken));

        var configWriter = new ConfigWriter(context, modelFileName, serviceFileVersion);
        Emit(Path.Combine(generated, $"{clientName}Config.g.cs"), configWriter.Write(cancellationToken));

        var defaultConfigurationWriter = new DefaultConfigurationWriter(context, modelFileName, defaultConfigurationModes);
        Emit(Path.Combine(generated, $"{clientName}DefaultConfiguration.g.cs"), defaultConfigurationWriter.Write(cancellationToken));

        var serviceEnumerationsWriter = new ServiceEnumerationsWriter(context, modelFileName);
        Emit(Path.Combine(generated, "ServiceEnumerations.g.cs"), serviceEnumerationsWriter.Write(cancellationToken));

        var metadataWriter = new MetadataWriter(context, modelFileName);
        Emit(Path.Combine(@internal, $"{clientName}Metadata.g.cs"), metadataWriter.Write(cancellationToken));

        var nullCollectionInitializerAnalyzer = new NullCollectionInitializerAnalyzerWriter(context, modelFileName);
        Emit(Path.Combine(serviceSpecificCodeAnalysisGenerated, "NullCollectionInitializerAnalyzer.g.cs"), nullCollectionInitializerAnalyzer.Write(cancellationToken));

        var propertyValueAssignmentAnalyzerWriter = new PropertyValueAssignmentAnalyzerWriter(context, modelFileName);
        Emit(Path.Combine(serviceSpecificCodeAnalysisGenerated, "PropertyValueAssignmentAnalyzer.g.cs"), propertyValueAssignmentAnalyzerWriter.Write(cancellationToken));

        var propertyValueRulesWriter = new PropertyValueRulesWriter(context);
        Emit(Path.Combine(serviceSpecificCodeAnalysisGenerated, "PropertyValueRules.xml"), propertyValueRulesWriter.Write(cancellationToken));

        var codeAnalysisProjectFileWriter = new CodeAnalysisProjectFileWriter(context);
        var codeAnalysisProjectFilePath = Path.Combine(serviceSpecificCodeAnalysis, $"{context.AssemblyName}.CodeAnalysis.csproj");

        var codeAnalysisAssemblyInfoWriter = new CodeAnalysisAssemblyInfoWriter(context);
        Emit(Path.Combine(serviceSpecificCodeAnalysis, "Properties","AssemblyInfo.cs"), codeAnalysisAssemblyInfoWriter.Write());

        //file path needed here for existing GUID check
        Emit(codeAnalysisProjectFilePath, codeAnalysisProjectFileWriter.Write(codeAnalysisProjectFilePath));

        // Endpoint files are emitted only when the service carries an endpoint rule set. The
        // parameters class lives in the *.Endpoints namespace (emitted under Generated/), the
        // provider and resolver under Internal/.
        if (context.HasEndpointRuleSet)
        {
            var endpointParametersWriter = new EndpointParametersWriter(context, modelFileName);
            Emit(Path.Combine(generated, $"{clientName}EndpointParameters.g.cs"), endpointParametersWriter.Write(cancellationToken));

            var endpointProviderWriter = new EndpointProviderWriter(context, modelFileName);
            Emit(Path.Combine(@internal, $"{clientName}EndpointProvider.g.cs"), endpointProviderWriter.Write(cancellationToken));

            var endpointResolverWriter = new EndpointResolverWriter(context, modelFileName);
            Emit(Path.Combine(@internal, $"{clientName}EndpointResolver.g.cs"), endpointResolverWriter.Write(cancellationToken));
        }

        // The endpoint provider tests file lives under the test project's tree, a sibling of the
        // source tree rather than a descendant of outputPath, so it's tracked in its own dictionary
        // under testsOutputPath rather than outputPath's — but it still goes through the same
        // collision-guarded, cancellation-checked EmitUnder as everything else.
        if (context.HasEndpointTests && testsOutputPath is not null)
        {
            var endpointProviderTestSuiteWriter = new EndpointProviderTestSuiteWriter(context, modelFileName);
            var testsRelativePath = Path.Combine("UnitTests", "Generated", "Endpoints", $"{context.ServiceName}EndpointProviderTests.g.cs");
            EmitUnder(testsOutputPath, writtenTests, testsRelativePath, endpointProviderTestSuiteWriter.Write(cancellationToken));
        }

        var exceptionWriter = new ExceptionWriter(context, modelFileName);
        Emit(Path.Combine(generated, $"{clientName}Exception.g.cs"), exceptionWriter.WriteServiceException(cancellationToken));

        var operationWriter = new OperationWriter(context, modelFileName);
        var requestMarshaller = new JsonRequestMarshallerWriter(context, modelFileName);
        var responseUnmarshaller = new JsonResponseUnmarshallerWriter(context, modelFileName);
        var structureMarshaller = new JsonStructureMarshallerWriter(context, modelFileName);
        var structureUnmarshaller = new JsonStructureUnmarshallerWriter(context, modelFileName);
        var exceptionUnmarshallerWriter = new JsonExceptionUnmarshallerWriter(context, modelFileName);
        var nuspecWriter = new NuspecWriter(context);

        Emit(Path.Combine(model, $"{clientName}Request.g.cs"), operationWriter.WriteServiceRequest(cancellationToken));
        Emit(Path.Combine($"{context.AssemblyName}.nuspec"), nuspecWriter.Write());

        // Per-operation walk, mirroring the existing generator: emit the request/response classes
        // and request marshaller, then the (un)marshaller for each structure the operation references
        // — input-side structures get a marshaller, output-side an unmarshaller. The seen-sets skip
        // structures shared across operations. The operation input/output shapes are tracked so they
        // aren't re-emitted as plain model classes below.
        var operationShapes = new HashSet<ShapeId>();
        var marshalledStructures = new HashSet<ShapeId>();
        var unmarshalledStructures = new HashSet<ShapeId>();
        var errorStructures = new HashSet<ShapeId>();

        foreach (var operation in context.Operations)
        {
            operationShapes.Add(operation.Shape.Input);
            operationShapes.Add(operation.Shape.Output);

            Emit(Path.Combine(model, $"{operation.Name}Request.g.cs"), operationWriter.WriteRequest(operation, cancellationToken));
            Emit(Path.Combine(model, $"{operation.Name}Response.g.cs"), operationWriter.WriteResponse(operation, cancellationToken));
            Emit(Path.Combine(marshalling, $"{operation.Name}RequestMarshaller.g.cs"), requestMarshaller.Write(operation, cancellationToken));
            Emit(Path.Combine(marshalling, $"{operation.Name}ResponseUnmarshaller.g.cs"), responseUnmarshaller.Write(operation, cancellationToken));

            foreach (var (shapeId, structure) in ReferencedStructures(operation.Input))
            {
                if (marshalledStructures.Add(shapeId))
                {
                    Emit(Path.Combine(marshalling, $"{context.ToDotNetName(shapeId)}Marshaller.g.cs"), structureMarshaller.Write(structure, shapeId, cancellationToken));
                }
            }

            foreach (var (shapeId, structure) in ReferencedStructures(operation.Output))
            {
                if (unmarshalledStructures.Add(shapeId))
                {
                    Emit(Path.Combine(marshalling, $"{context.ToDotNetName(shapeId)}Unmarshaller.g.cs"), structureUnmarshaller.Write(structure, shapeId, cancellationToken));
                }
            }

            foreach (var error in operation.Errors)
            {
                if (errorStructures.Add(error.Id))
                {
                    var name = ExceptionWriter.ToExceptionName(error.Id.Name);
                    Emit(Path.Combine(marshalling, $"{name}Unmarshaller.g.cs"), exceptionUnmarshallerWriter.Write(error.Shape, error.Id, cancellationToken));
                }
            }
        }

        // Every service gets an auth resolver: a service that models no auth falls back to noAuth, so
        // this is emitted unconditionally (unlike the endpoint files, which are gated on a rule set).
        var authResolverWriter = new AuthResolverWriter(context, modelFileName);
        Emit(Path.Combine(@internal, $"{clientName}AuthResolver.g.cs"), authResolverWriter.Write(cancellationToken));

        var structureWriter = new StructureWriter(context, modelFileName);
        foreach (var (shapeId, structure) in context.Structures)
        {
            if (operationShapes.Contains(shapeId))
            {
                continue;
            }

            Emit(Path.Combine(model, $"{context.ToDotNetName(shapeId)}.g.cs"), structureWriter.Write(structure, shapeId, cancellationToken));
        }

        foreach (var (shapeId, errorShape) in context.Errors)
        {
            var exceptionName = ExceptionWriter.ToExceptionName(shapeId.Name);
            Emit(Path.Combine(model, $"{exceptionName}.g.cs"), exceptionWriter.WriteException(errorShape, shapeId, cancellationToken));
        }

        return written.Keys.ToList();
    }

    // Finds the nested structures inside a request or response so each gets its own (un)marshaller.
    // A member is either a structure itself or a list/map of structures.
    // TODO: only scans one level deep; make this recursive once the writers need (un)marshallers for deeper nesting.
    private IEnumerable<(ShapeId Id, StructureShape Shape)> ReferencedStructures(StructureShape parent)
    {
        foreach (var member in parent.Members.Values)
        {
            // If the member is a list/map, the structure is its element/value; otherwise the member
            // targets the structure directly.
            var structureId = context.Resolve(member.Target) switch
            {
                ListShape list => list.Member.Target,
                MapShape map => map.Value.Target,
                _ => member.Target,
            };

            if (context.Resolve(structureId) is StructureShape structure)
            {
                yield return (structureId, structure);
            }
        }
    }

    private static void WriteFile(string outputPath, string relativePath, string contents)
    {
        var fullPath = Path.Combine(outputPath, relativePath);
        Directory.CreateDirectory(Path.GetDirectoryName(fullPath) ?? outputPath);
        File.WriteAllText(fullPath, contents);
    }
}
