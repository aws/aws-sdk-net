using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Writers;
using SmithyDotNet.Generator.Writers.CodeAnalysis;
using SmithyDotNet.Generator.Writers.Endpoints;
using SmithyDotNet.Generator.Writers.NuGet;
using SmithyDotNet.Generator.Writers.ProjectFiles;
using System.Collections.Concurrent;

namespace SmithyDotNet.Generator.Generation;

/// <summary>
/// Orchestrates the writers for a single service: invokes each one, maps its output to the
/// SDK-conventional relative path, and writes the files under the <c>outputPath</c> passed to
/// <see cref="Generate"/>.
/// Most generated source lands under <c>Generated/</c>; <c>Properties/AssemblyInfo.cs</c> and
/// the <c>code-analysis/</c> tree sit alongside it at the service root.
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
    /// The code-analysis files are written under <paramref name="codeAnalysisPath"/> — the caller
    /// supplies the real per-service root (<c>sdk/code-analysis/ServiceAnalysis/{Service}/</c>),
    /// which the SDK lays out outside the source tree.
    /// <para />
    /// When <paramref name="testsOutputPath"/> is supplied, the unit-test project file is written
    /// under <c>{testsOutputPath}/UnitTests/</c>, plus the endpoint provider tests file under
    /// <c>UnitTests/Generated/Endpoints/</c> when the service carries endpoint tests
    /// (<see cref="GenerationContext.HasEndpointTests"/>) — a separate root because the SDK lays out
    /// its test tree (<c>sdk/test/Services/{Service}/</c>) as a sibling of the source tree
    /// (<c>sdk/src/Services/{Service}/</c>), not nested under it. Code-analysis and test files get
    /// the same duplicate-path guard (via <c>EmitUnder</c>) but aren't tracked in the returned list,
    /// which stays scoped to <paramref name="outputPath"/>.
    /// </summary>
    public IReadOnlyList<string> Generate(string outputPath, string codeAnalysisPath, string? testsOutputPath = null, CancellationToken cancellationToken = default)
    {
        var clientName = context.ClientName;

        // Concurrent-safe so Emit can be called from parallel writers later. TryAdd both reserves
        // the path (atomic fail-fast on duplicates) and records it as written, so there is a single
        // collection to reason about.
        var written = new ConcurrentDictionary<string, byte>();
        var writtenCodeAnalysis = new ConcurrentDictionary<string, byte>();
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
        void EmitCodeAnalysis(string relativePath, string contents) => EmitUnder(codeAnalysisPath, writtenCodeAnalysis, relativePath, contents);

        var generated = "Generated";
        var model = Path.Combine(generated, "Model");
        var @internal = Path.Combine(generated, "Internal");
        var marshalling = Path.Combine(model, "Internal", "MarshallTransformations");

        var assemblyInfoWriter = new AssemblyInfoWriter(context, serviceFileVersion);
        Emit(Path.Combine("Properties", "AssemblyInfo.cs"), assemblyInfoWriter.Write(cancellationToken));

        var interfaceWriter = new ClientInterfaceWriter(context, modelFileName);
        Emit(Path.Combine(generated, $"IAmazon{context.ServiceName}.g.cs"), interfaceWriter.Write(cancellationToken));

        var clientWriter = new ClientClassWriter(context, modelFileName);
        Emit(Path.Combine(generated, $"{clientName}Client.g.cs"), clientWriter.Write(cancellationToken));

        var configWriter = new ConfigWriter(context, modelFileName, serviceFileVersion);
        // Plain .cs (not .g.cs): the SDK release automation stages Amazon*Config.cs after the
        // post-version generator run rewrites the embedded file version; the same name keeps the
        // Smithy config on the existing staging path.
        Emit(Path.Combine(generated, $"{clientName}Config.cs"), configWriter.Write(cancellationToken));

        var defaultConfigurationWriter = new DefaultConfigurationWriter(context, modelFileName, defaultConfigurationModes);
        Emit(Path.Combine(generated, $"{clientName}DefaultConfiguration.g.cs"), defaultConfigurationWriter.Write(cancellationToken));

        var serviceEnumerationsWriter = new ServiceEnumerationsWriter(context, modelFileName);
        Emit(Path.Combine(generated, "ServiceEnumerations.g.cs"), serviceEnumerationsWriter.Write(cancellationToken));

        var metadataWriter = new MetadataWriter(context, modelFileName);
        Emit(Path.Combine(@internal, $"{clientName}Metadata.g.cs"), metadataWriter.Write(cancellationToken));

        var nullCollectionInitializerAnalyzer = new NullCollectionInitializerAnalyzerWriter(context, modelFileName);
        EmitCodeAnalysis(Path.Combine(generated, "NullCollectionInitializerAnalyzer.g.cs"), nullCollectionInitializerAnalyzer.Write(cancellationToken));

        var propertyValueAssignmentAnalyzerWriter = new PropertyValueAssignmentAnalyzerWriter(context, modelFileName);
        EmitCodeAnalysis(Path.Combine(generated, "PropertyValueAssignmentAnalyzer.g.cs"), propertyValueAssignmentAnalyzerWriter.Write(cancellationToken));

        var propertyValueRulesWriter = new PropertyValueRulesWriter(context);
        EmitCodeAnalysis(Path.Combine(generated, "PropertyValueRules.xml"), propertyValueRulesWriter.Write(cancellationToken));

        var codeAnalysisAssemblyInfoWriter = new CodeAnalysisAssemblyInfoWriter(context);
        EmitCodeAnalysis(Path.Combine("Properties", "AssemblyInfo.cs"), codeAnalysisAssemblyInfoWriter.Write());

        // The writer probes the existing csproj to preserve its ProjectGuid, so it needs the full
        // on-disk path, not the root-relative one used for emission.
        var codeAnalysisProjectFileWriter = new CodeAnalysisProjectFileWriter(context);
        var codeAnalysisProjectFileName = $"{context.AssemblyName}.CodeAnalysis.csproj";
        EmitCodeAnalysis(codeAnalysisProjectFileName, codeAnalysisProjectFileWriter.Write(Path.Combine(codeAnalysisPath, codeAnalysisProjectFileName)));

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

        // Every service gets a unit-test project so the files under UnitTests/ (generated endpoint
        // tests today, hand-written tests as they are added) have a project to compile under. Not
        // gated on endpoint tests — the legacy generator emits it for every service.
        if (testsOutputPath is not null)
        {
            var unitTestProjectFileWriter = new UnitTestProjectFileWriter(context);
            EmitUnder(testsOutputPath, writtenTests, Path.Combine("UnitTests", $"AWSSDK.UnitTests.{context.ServiceName}.csproj"), unitTestProjectFileWriter.Write());
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
        var serviceProjectFileWriter = new ServiceProjectFileWriter(context);

        Emit(Path.Combine(model, $"{clientName}Request.g.cs"), operationWriter.WriteServiceRequest(cancellationToken));
        Emit(Path.Combine($"{context.AssemblyName}.nuspec"), nuspecWriter.Write());
        // The NuGet README is the service documentation converted to Markdown, falling back to the
        // synopsis when the model carries no @documentation (see aws/aws-sdk-net#3186). Named
        // nuget-readme.md (not README.md) so it can be gitignored as a generated artifact without
        // catching hand-written READMEs.
        var readme = DocumentationFormatter.ToMarkdown(context.ServiceDocumentation);
        Emit("nuget-readme.md", readme.Length > 0 ? readme : context.Metadata?.Synopsis ?? string.Empty);

        Emit($"{context.AssemblyName}.NetFramework.csproj", serviceProjectFileWriter.WriteNetFramework());
        if (context.Metadata?.NetStandardSupport ?? true)
        {
            Emit($"{context.AssemblyName}.NetStandard.csproj", serviceProjectFileWriter.WriteNetStandard());
        }

        // The unified csproj (ServiceProjectFileWriter.WriteUnified) is deliberately not emitted:
        // nothing consumes it yet, and the build system still assumes the NetFramework/NetStandard pair.

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

            foreach (var (shapeId, structure) in ReferencedStructures(operation.Shape.Input, operation.Input))
            {
                if (marshalledStructures.Add(shapeId))
                {
                    Emit(Path.Combine(marshalling, $"{context.ToDotNetName(shapeId)}Marshaller.g.cs"), structureMarshaller.Write(structure, shapeId, cancellationToken));
                }
            }

            foreach (var (shapeId, structure) in ReferencedStructures(operation.Shape.Output, operation.Output))
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

                    // An exception's rich members can target structures (directly, or as list/map
                    // elements); the exception unmarshaller deserializes them, so those nested
                    // structures need unmarshallers too. Exceptions are response-only, so only the
                    // unmarshaller side is walked (never a marshaller), deduped against the shared set
                    // so a structure also reachable from an output isn't emitted twice.
                    foreach (var (shapeId, structure) in ReferencedStructures(error.Id, error.Shape))
                    {
                        if (unmarshalledStructures.Add(shapeId))
                        {
                            Emit(Path.Combine(marshalling, $"{context.ToDotNetName(shapeId)}Unmarshaller.g.cs"), structureUnmarshaller.Write(structure, shapeId, cancellationToken));
                        }
                    }
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

        // Last on purpose: the solution writer scans outputPath for the service csprojs to build
        // the /Services/ dependency folder, so it must run after every csproj has been emitted —
        // otherwise a clean first run produces a .slnx missing the service dependencies that a
        // re-run would then pick up.
        var serviceSpecificSolutionWriter = new ServiceSpecificSolutionFileWriter(context);
        Emit($"{context.ServiceName}.slnx", serviceSpecificSolutionWriter.Write(outputPath));

        return written.Keys.ToList();
    }

    // Finds all structures transitively referenced from a request or response so each gets its own
    // (un)marshaller. A member targets a structure directly, or indirectly via a list/map element.
    // The visited set prevents infinite recursion on circular references.
    private IEnumerable<(ShapeId Id, StructureShape Shape)> ReferencedStructures(ShapeId parentId, StructureShape parent)
    {
        var visited = new HashSet<ShapeId> { parentId };
        return ReferencedStructuresRecursive(parent, visited);
    }

    private IEnumerable<(ShapeId Id, StructureShape Shape)> ReferencedStructuresRecursive(StructureShape parent, HashSet<ShapeId> visited)
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

            if (!visited.Add(structureId))
            {
                continue;
            }

            if (context.Resolve(structureId) is StructureShape structure)
            {
                yield return (structureId, structure);
                foreach (var nested in ReferencedStructuresRecursive(structure, visited))
                {
                    yield return nested;
                }
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
