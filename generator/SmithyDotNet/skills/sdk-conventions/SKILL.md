---
name: sdk-conventions
description: The public-API contract SmithyDotNet-generated code must match against the shipping AWS SDK for .NET - what must match vs. what can differ. Use before writing or changing any SmithyDotNet writer.
---
# Skill: .NET SDK Conventions

## Reviewing Generated Output

When reviewing a service migration's generated output, open and diff **every single generated file** — every operation's request marshaller and response unmarshaller, every model, exception, and client file. No sampling. Reviewing one operation and generalizing "clean" to its neighbors is how regressions ship. Thousands of files is not a reason to skip any.

The public API surface can be identical while the wire behavior changes. AssemblyComparer and "the public surface is unchanged" only check the public contract; they **cannot** see marshaller/unmarshaller bodies — `ResourcePath`, query parameters, headers, serialization. A clean AssemblyComparer is necessary, not sufficient; it is not a substitute for reading the diff.

A **removed** line in generated output is a red flag — investigate it, do not wave it through. Real example: the generator dropping `request.AddSubResource("aws_iam", "t")` and folding the query literal into `request.ResourcePath = "/token?aws_iam=t"` left the public API identical while silently changing the request sent to the wire (`?` gets percent-encoded, dropping the flag).

## What Must Match (Public API Contract)

- Public class/interface names and their base types
- Public property names, types, and nullability
- Public method signatures (name, parameters, return type)
- `[AWSProperty]` attributes on public members (Required, Min, Max)
- XML doc comments on public types and members (content, not formatting)
- `partial` modifier on all generated types
- Namespace structure (`{Namespace}`, `{Namespace}.Model`)
- `internal bool IsSet{Property}()` per member — the public `AWSSDKUtils.IsPropertySet`
  reflection API and existing marshallers invoke these by name

## What Can Differ

- Whitespace, indentation, blank lines (Roslyn formatter handles this)
- File names — prefer `{TypeName}.g.cs` to distinguish generated files
- Backing fields and other private helpers (the generator omits them — see Property Pattern below)
- `using` directive order
- `#region` blocks (purely cosmetic)
- Code comments outside XML docs

## Pragma Warnings

The SDK builds with warnings-as-errors. Generated files must include `#pragma warning disable` for warnings that would otherwise break the build. The exact set doesn't need to match the current SDK file-for-file, but the output must compile cleanly. Common ones:
- `CS0612` / `CS0618` — obsolete/deprecated member usage (generated code may reference deprecated shapes)
- `CS1570` — malformed XML doc comments (common with complex HTML from `@documentation` traits)

## License Header

Every generated file starts with the full Apache 2.0 license block followed by the
"Do not modify this file. This file is generated from the {model-filename} service model." notice,
where `{model-filename}` is the Smithy model file name (e.g. `cloudtrail-data-2021-08-11.normal.json`).
The exact text lives in `Writers/FileHeader.cs`.

## Naming Rules

### Which Name Goes Where

A service has two derived names (see `GenerationContext`), equal for most services:

- `BaseName` (C2J `ClassName`, metadata.json's `base-name`) → the generated type names: client,
  config, exception/request bases, endpoint types. Model classes go in `{Namespace}.Model`.
- `ServiceName` (C2J `ServiceFolderName`, the namespace minus `Amazon.`) → everything else:
  `AWSSDK.{X}` package names, `sdk/src|test/Services/{X}` trees, `_sdk-versions.json` keys,
  `{X}.slnx`, the endpoint tests `[TestCategory]`, **and the paginator factory types**
  (`I{X}PaginatorFactory` — C2J's templates use `ServiceNameRoot` there).

They diverge when metadata.json overrides the namespace: sesv2 has class
`AmazonSimpleEmailServiceV2Client` but package/folder/paginators `SimpleEmailV2`. When adding a
name to a writer, check the shipping SDK for which of the two it follows.

### Class and Member Names

- **Shape names** → PascalCase class names (Smithy shape names are already PascalCase)
- **Member names** → PascalCase property names. Smithy uses camelCase (`eventData`), .NET uses PascalCase (`EventData`)
- The conversion: capitalize the first letter of the Smithy member name
- **Acronyms** are preserved as-is from the Smithy model. Example: `eventID` → `EventID` (not `EventId`)
- A response member named `ContentLength` is **omitted** from the response class —
  `AmazonWebServiceResponse` already declares it — but the response unmarshaller still assigns the
  inherited property. Matches `StructureGenerator.tt`'s response-only skip (the MediaStoreData case);
  lives in `OperationWriter.WriteResponse`.

### Client Names

- Interface: `IAmazon{BaseName}` (e.g. `IAmazonCloudTrailData`)
- Class: `Amazon{BaseName}Client` (e.g. `AmazonCloudTrailDataClient`)
- Config: `Amazon{BaseName}Config`
- Service exception base: `Amazon{BaseName}Exception`
- Service request base: `Amazon{BaseName}Request`

## File Layout

Generated files go under `Generated/`. Prefer `.g.cs` suffix:

```
Generated/
  IAmazon{BaseName}.g.cs
  Amazon{BaseName}Client.g.cs
  Amazon{BaseName}Config.cs            # plain .cs so CI's Amazon*Config.cs glob stages it
  Amazon{BaseName}Exception.g.cs
  Model/
    Amazon{BaseName}Request.g.cs       # empty service request base
    {OperationName}Request.g.cs
    {OperationName}Response.g.cs
    {ShapeName}.g.cs
    {ExceptionName}.g.cs
```

A structure that doubles as an operation input/output normally gets only its
`{Op}Request`/`{Op}Response` wrappers — no `{ShapeName}.g.cs`. Exception: when other generated
code references the shape through a member (directly or as a list/map element), the standalone
class is emitted too, because member properties are typed with the plain class name (C2J parity:
drs `SourceServer` has one, kinesis `EnhancedMonitoringOutput` does not). Lives in
`ServiceGenerator`'s model-class loop.

## Base Types

| Generated class | Inherits from |
|---|---|
| Client interface | `IAmazonService, IDisposable` |
| Client class | `AmazonServiceClient, IAmazon{BaseName}` |
| Service exception base | `AmazonServiceException` |
| Service request base | `AmazonWebServiceRequest` |
| Request classes | `Amazon{BaseName}Request` (the service request base) |
| Response classes | `AmazonWebServiceResponse`, plus `, IDisposable` when an output member is `@streaming` (emits a `#region Dispose Pattern` that disposes each streaming member's stream) |
| Structure classes | No base type (plain class) |
| Exception classes | `Amazon{BaseName}Exception` (the service exception base) |
| Config class (`Amazon{BaseName}Config`) | `ClientConfig` (overrides are placeholder for now) |

## All Types Are `partial`

Every generated class and interface uses the `partial` modifier.

## Property Pattern

The public surface must match. Internal implementation can vary.

**Required public surface:**
```csharp
/// <summary>
/// Gets and sets the property EventData. 
/// <para>
/// The content of an audit event...
/// </para>
/// </summary>
[AWSProperty(Required=true)]
public string EventData { get; set; }

/// <summary>
/// Checks to see if the EventData property is set.
/// </summary>
internal bool IsSetEventData() => this.EventData != null;
```

The generator emits auto-properties (`{ get; set; }`) plus an internal `IsSet{Property}()`
method per member. The current SDK uses explicit backing fields, but the public surface (and
the reflection API) only needs the property and the IsSet method — a backing field is not
required.

**`[AWSProperty]` attribute rules:**
- `Required=true` when member has `@required` trait
- `Min=N` when member has `@length` trait with min, or `@range` trait with min
- `Max=N` when member has `@length` trait with max, or `@range` trait with max
- Omit the attribute entirely if none of these traits are present

### Collection Properties

Collections use the `AWSConfigs.InitializeCollections` initializer to support both V4 (null
default) and V3-compat (empty list default) modes. The matching `IsSet` encodes the V3/V4
"empty counts as set?" rule so callers see consistent behavior in both modes:

```csharp
[AWSProperty(Required=true, Min=1, Max=100)]
public List<AuditEvent> AuditEvents { get; set; } = AWSConfigs.InitializeCollections ? new List<AuditEvent>() : null;

internal bool IsSetAuditEvents() => this.AuditEvents != null && (this.AuditEvents.Count > 0 || !AWSConfigs.InitializeCollections);
```

## Reference: Existing Generator

When implementing transformation logic (HTML sanitization, naming rules, type mapping, etc.), consult the existing C2J generator at `generator/ServiceClientGeneratorLib/` to understand the correct behavior. Key files:
- `GeneratorHelpers.cs` / `Utils.cs` — HTML processing, naming transforms
- `Member.cs` — property naming, type resolution
- `Shape.cs` / `ExceptionShape.cs` — shape naming conventions
- `Generators/Marshallers/*.tt` — T4 templates showing exact output patterns

The new generator is a clean reimplementation, not a port — but the existing generator defines what "correct" looks like.

## XML Documentation Comments

### HTML Sanitization

The `@documentation` trait contains HTML. `DocumentationFormatter.Cleanup` ports the existing
generator's `CleanupDocumentation` (`ServiceClientGeneratorLib/Generators/BaseGenerator.cs`).
The transform, in order:
- Collapse runs of whitespace (the source doc's newlines + indentation) to single spaces. The
  meaningful `<para>` line breaks are inserted afterward.
- `<code>...</code>` → `<c>...</c>`
- `<p>...</p>` → `<para>...</para>` (including `<p>` tags carrying attributes)
- Strip `<br>`, `<fullname>`, `<function>`, `<p/>` (bare and attribute-carrying forms)
- `<i>...</i>` → keep as-is
- Remove `<examples>...</examples>` and `<!-- ... -->` snippets
- Drop the leading `<para>...</para>` wrapper (the summary's first paragraph is unwrapped)
- Soft-wrap at ~80 columns (break at the next space after a line exceeds 80 chars)

Note: HTML entities are NOT decoded (`&amp;` stays `&amp;`) — the existing generator does not
decode them, so neither do we.

### Type-Specific Summaries

- **Service interface/class**: `<para>Interface for accessing {BaseName}</para>`, a blank `///` line, then the service `@documentation`
- **Request class**: `Container for the parameters to the {OperationName} operation.` then the operation `@documentation`
- **Response class**: `This is the response object from the {OperationName} operation.`
- **Structure class**: the shape's `@documentation`

### Operation Method Docs

Each operation method includes an `<exception cref="{full exception type}">` (body = the error shape's
`@documentation`) per error, plus
`<seealso href="http://docs.aws.amazon.com/goto/WebAPI/{serviceId}-{apiVersion}/{OperationName}">REST API Reference for {OperationName} Operation</seealso>`.

## Exception Classes

Operation exceptions inherit from `Amazon{BaseName}Exception` (not directly from `AmazonServiceException`).

Must expose these public constructors:
1. Default (no args)
2. `(string message)`
3. `(string message, Exception innerException)`
4. `(Exception innerException)`
5. `(string message, Exception innerException, ErrorType, string errorCode, string requestId, HttpStatusCode)`
6. `(string message, ErrorType, string errorCode, string requestId, HttpStatusCode)`

Operation exceptions also include a `#if !NETSTANDARD` block containing:
- `[Serializable]` attribute on the class
- `protected` serialization constructor `(SerializationInfo, StreamingContext)` — deserializes each serialized exception member (every modeled member except `message`) via `info.GetValue`, then calls `base(info, context)`
- `public override void GetObjectData(SerializationInfo, StreamingContext)` carrying all three attributes as a unit (from `ExceptionSerialization.t4`): `[System.Security.SecurityCritical]` plus the CA2123 and CA2134 `SuppressMessage` attributes; body is `base.GetObjectData(info, context)` then `info.AddValue(...)` per additional member.
  The serialization constructor and `GetObjectData` are symmetric: both loop over the same member set — every modeled member except `message` (from `ExceptionSerialization.t4`), so base-owned `RequestId`/`ErrorCode` are serialized here even though they get no property (see "Exception Member Property Names"). The constructor calls `info.GetValue` for each and `GetObjectData` calls `info.AddValue` for each, both keyed on the .NET property name. For exceptions whose only member is `message` (e.g. all CloudTrail Data exceptions), both bodies contain only the `base` call.

The service-level exception base (`Amazon{BaseName}Exception`) inherits from `AmazonServiceException`, exposes the same six public constructors as operation exceptions, and includes `[Serializable]` plus the protected serialization constructor, but does not need its own `GetObjectData` override unless it adds serialized fields.

### Exception Member Property Names

Canonical treatment lives in type-mapping's "Error Shape Members". Summary: `errorType` → property
`RequestErrorType` (wire name unchanged); `Retryable` emitted with `new`; `Equals` gets `new` on any
structure (not exception-specific); `RequestId`/`ErrorCode` get no property but stay in serialization
and unmarshalling; every other member is emitted as-is even when it shadows an inherited property.

### Retryable Errors

An error shape carrying the `@retryable` trait emits a public override that marks it retryable:
```csharp
public override RetryableDetails Retryable { get; } = new RetryableDetails(<throttling>);
```
`<throttling>` is the trait's `throttling` value (`true`/`false`); an empty `@retryable` (`{}`) is retryable but not throttling (`false`). The base `AmazonServiceException.Retryable` returns `null`, so emitting a non-null `RetryableDetails` is what marks the exception retryable — errors without the trait emit no override. `RetryableDetails` resolves via `Amazon.Runtime` (already in the model file's usings).

## Client Interface

Must expose:
- **Sync method** (.NET Framework): `{Op}Response {Op}({Op}Request request)` per operation
- **Async method** (all targets): `Task<{Op}Response> {Op}Async({Op}Request request, CancellationToken cancellationToken = default)`
- `Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)`
- **Static factory methods** (`#if NET8_0_OR_GREATER`): `CreateDefaultClientConfig()` and `CreateDefaultServiceClient(AWSCredentials, ClientConfig)`

Use `#if` directives to include sync methods only for .NET Framework targets (`#if NETFRAMEWORK`).

## Client Class

Must expose:
- All constructors matching the current SDK pattern (default, region, config, credentials variants — 10 constructors total)
- **Sync method** (.NET Framework): `public virtual {Op}Response {Op}({Op}Request request)` per operation
- **Async method** (all targets): `public virtual Task<{Op}Response> {Op}Async(...)` per operation
- `DetermineServiceOperationEndpoint` implementation
- `CustomizeRuntimePipeline` override
- `ServiceMetadata` property override

Use `#if NETFRAMEWORK` directives to include sync methods only for .NET Framework targets. Both sync and async methods are `public virtual` on the client class.
