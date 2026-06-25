using System.Collections.Concurrent;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Writers;

namespace SmithyDotNet.Generator.Generation;

/// <summary>
/// Orchestrates the writers for a single service: invokes each one, maps its output to the
/// SDK-conventional relative path, and writes the files under <c>{outputPath}/Generated/</c>.
/// <para />
/// Phase 1 scope: the writers that exist today (interface, client, config, service exception,
/// metadata, operation request/response/base, structures, exceptions). The endpoint/auth
/// <c>Internal/</c> files and the marshallers are not emitted yet, so the generated tree does
/// not compile standalone.
/// </summary>
public sealed class ServiceGenerator(GenerationContext context, string modelFileName, string serviceFileVersion)
{
    /// <summary>
    /// Generates every file for the service and writes it under <paramref name="outputPath"/>.
    /// Returns the relative paths written, for logging and tests.
    /// </summary>
    public IReadOnlyList<string> Generate(string outputPath, CancellationToken cancellationToken = default)
    {
        var clientName = context.ClientName;
        // Concurrent-safe so Emit can be called from parallel writers later. TryAdd both reserves
        // the path (atomic fail-fast on duplicates) and records it as written, so there is a single
        // collection to reason about.
        var written = new ConcurrentDictionary<string, byte>();

        void Emit(string relativePath, string contents)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // Fail fast: two writers targeting the same path would silently overwrite, producing
            // wrong output while still reporting success.
            if (!written.TryAdd(relativePath, 0))
            {
                throw new GeneratorException($"Two writers produced the same output path: '{relativePath}'.");
            }

            WriteFile(outputPath, relativePath, contents);
        }

        var generated = "Generated";
        var model = Path.Combine(generated, "Model");
        var @internal = Path.Combine(generated, "Internal");

        var interfaceWriter = new ClientInterfaceWriter(context, modelFileName);
        Emit(Path.Combine(generated, $"IAmazon{context.ServiceName}.g.cs"), interfaceWriter.Write(cancellationToken));

        var clientWriter = new ClientClassWriter(context, modelFileName);
        Emit(Path.Combine(generated, $"{clientName}Client.g.cs"), clientWriter.Write(cancellationToken));

        var configWriter = new ConfigWriter(context, modelFileName, serviceFileVersion);
        Emit(Path.Combine(generated, $"{clientName}Config.g.cs"), configWriter.Write(cancellationToken));

        var metadataWriter = new MetadataWriter(context, modelFileName);
        Emit(Path.Combine(@internal, $"{clientName}Metadata.g.cs"), metadataWriter.Write(cancellationToken));

        var exceptionWriter = new ExceptionWriter(context, modelFileName);
        Emit(Path.Combine(generated, $"{clientName}Exception.g.cs"), exceptionWriter.WriteServiceException(cancellationToken));

        var operationWriter = new OperationWriter(context, modelFileName);
        Emit(Path.Combine(model, $"{clientName}Request.g.cs"), operationWriter.WriteServiceRequest(cancellationToken));

        // Operation input/output shapes are emitted as {Op}Request / {Op}Response by OperationWriter.
        // When the model omits the @input/@output traits they also land in context.Structures, so
        // collect their IDs to skip them in the structure loop and avoid emitting (and overwriting)
        // them a second time as plain classes.
        // TODO: a shape reused as BOTH an operation input/output AND a nested member elsewhere would
        // be skipped as a model class here, breaking references to it. CloudTrail Data has no such
        // shape; revisit when onboarding services that reuse input/output shapes.
        var operationShapes = new HashSet<ShapeId>();
        foreach (var operation in context.Operations)
        {
            operationShapes.Add(operation.Shape.Input);
            operationShapes.Add(operation.Shape.Output);
            Emit(Path.Combine(model, $"{operation.Name}Request.g.cs"), operationWriter.WriteRequest(operation, cancellationToken));
            Emit(Path.Combine(model, $"{operation.Name}Response.g.cs"), operationWriter.WriteResponse(operation, cancellationToken));
        }

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

    private static void WriteFile(string outputPath, string relativePath, string contents)
    {
        var fullPath = Path.Combine(outputPath, relativePath);
        Directory.CreateDirectory(Path.GetDirectoryName(fullPath) ?? outputPath);
        File.WriteAllText(fullPath, contents);
    }
}
