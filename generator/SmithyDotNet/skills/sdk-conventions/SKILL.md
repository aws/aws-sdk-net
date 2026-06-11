---
name: sdk-conventions
description: Exact patterns generated code must follow to match the AWS SDK for .NET public API surface
---
# Skill: .NET SDK Conventions

## Purpose

Patterns the generated code must follow so its **public API surface** matches the existing AWS SDK for .NET. The generated files do NOT need to be byte-for-byte identical — whitespace, file naming (e.g. `.g.cs` suffix), internal implementation details, and code organization can differ as long as the public types, members, signatures, and attributes are equivalent.

## What Must Match (Public API Contract)

- Public class/interface names and their base types
- Public property names, types, and nullability
- Public method signatures (name, parameters, return type)
- `[AWSProperty]` attributes on public members (Required, Min, Max)
- XML doc comments on public types and members (content, not formatting)
- `partial` modifier on all generated types
- Namespace structure (`Amazon.{ServiceName}`, `Amazon.{ServiceName}.Model`)

## What Can Differ

- Whitespace, indentation, blank lines (Roslyn formatter handles this)
- File names — prefer `{TypeName}.g.cs` to distinguish generated files
- Internal members (`IsSet` methods, backing fields, private helpers)
- `using` directive order
- `#region` blocks (purely cosmetic)
- Code comments outside XML docs

## Pragma Warnings

The SDK builds with warnings-as-errors. Generated files must include `#pragma warning disable` for warnings that would otherwise break the build. The exact set doesn't need to match the current SDK file-for-file, but the output must compile cleanly. Common ones:
- `CS0612` / `CS0618` — obsolete/deprecated member usage (generated code may reference deprecated shapes)
- `CS1570` — malformed XML doc comments (common with complex HTML from `@documentation` traits)

## License Header

Every generated file starts with the full Apache 2.0 license block followed by a generation notice:

```csharp
/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the {model-filename} service model.
 */
```

The `{model-filename}` is the Smithy model file name (e.g. `cloudtrail-data-2021-08-11.normal.json`).

## Naming Rules

### Namespace Derivation

From the `aws.api#service` trait's `sdkId` value, using `SdkNaming.NormalizeSdkId()` in `SmithyDotNet.Generator.Generation`:
1. Strip leading "AWS" or "Amazon" prefix (case-sensitive)
2. Remove all non-alphanumeric characters
3. Capitalize first character

Examples: `"CloudTrail Data"` → `"CloudTrailData"`, `"AWS IoT 1-Click Projects"` → `"IoT1ClickProjects"`, `"Amazon Pinpoint"` → `"Pinpoint"`

Then prefix with `Amazon.` for namespace → `Amazon.CloudTrailData`

Model classes go in `Amazon.{ServiceName}.Model`.

### Class and Member Names

- **Shape names** → PascalCase class names (Smithy shape names are already PascalCase)
- **Member names** → PascalCase property names. Smithy uses camelCase (`eventData`), .NET uses PascalCase (`EventData`)
- The conversion: capitalize the first letter of the Smithy member name
- **Acronyms** are preserved as-is from the Smithy model. Example: `eventID` → `EventID` (not `EventId`)

### Client Names

- Interface: `IAmazon{ServiceName}` (e.g. `IAmazonCloudTrailData`)
- Class: `Amazon{ServiceName}Client` (e.g. `AmazonCloudTrailDataClient`)
- Config: `Amazon{ServiceName}Config`
- Service exception base: `Amazon{ServiceName}Exception`
- Service request base: `Amazon{ServiceName}Request`

## File Layout

Generated files go under `Generated/`. Prefer `.g.cs` suffix:

```
Generated/
  IAmazon{ServiceName}.g.cs
  Amazon{ServiceName}Client.g.cs
  Amazon{ServiceName}Config.g.cs          # placeholder for now
  Amazon{ServiceName}Exception.g.cs
  Model/
    Amazon{ServiceName}Request.g.cs       # empty service request base
    {OperationName}Request.g.cs
    {OperationName}Response.g.cs
    {ShapeName}.g.cs
    {ExceptionName}.g.cs
```

## Base Types

| Generated class | Inherits from |
|---|---|
| Client interface | `IAmazonService, IDisposable` |
| Client class | `AmazonServiceClient, IAmazon{ServiceName}` |
| Service exception base | `AmazonServiceException` |
| Service request base | `AmazonWebServiceRequest` |
| Request classes | `Amazon{ServiceName}Request` (the service request base) |
| Response classes | `AmazonWebServiceResponse` |
| Structure classes | No base type (plain class) |
| Exception classes | `Amazon{ServiceName}Exception` (the service exception base) |
| Config class (`Amazon{ServiceName}Config`) | `ClientConfig` (overrides are placeholder for now) |

### Generated Infrastructure Files

- **`Amazon{ServiceName}Exception`** — service-level exception base. Same 6-constructor pattern as operation exceptions, plus `#if !NETSTANDARD` serialization constructor. Inherits from `AmazonServiceException`.
- **`Amazon{ServiceName}Request`** — empty class extending `AmazonWebServiceRequest`. All operation request classes inherit from this, not directly from `AmazonWebServiceRequest`.
- **`Amazon{ServiceName}Config`** — placeholder for now. Will extend `ClientConfig` with `ServiceId`, `ServiceVersion`, `AuthenticationServiceName`, etc.

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
```

The generator emits auto-properties (`{ get; set; }`); only the public signature matters. The current SDK uses explicit backing fields + `IsSet` methods internally, but that form is preferred only if a later customization requires it (e.g. collection `IsSet` semantics).

**`[AWSProperty]` attribute rules:**
- `Required=true` when member has `@required` trait
- `Min=N` when member has `@length` trait with min, or `@range` trait with min
- `Max=N` when member has `@length` trait with max, or `@range` trait with max
- Omit the attribute entirely if none of these traits are present

### Collection Properties

Collections default to `null` (SDK V4 convention):

```csharp
public List<AuditEvent> AuditEvents { get; set; }
```

The current SDK uses `AWSConfigs.InitializeCollections` for backwards compatibility. The generator should match this behavior for AWS SDK use, but the internal mechanism can differ.

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

**Service interface/class:**
```xml
/// <summary>
/// <para>Interface for accessing CloudTrailData</para>
///
/// {service @documentation}
/// </summary>
```

**Request class:**
```xml
/// <summary>
/// Container for the parameters to the {OperationName} operation.
/// {operation @documentation}
/// </summary>
```

**Response class:**
```xml
/// <summary>
/// This is the response object from the {OperationName} operation.
/// </summary>
```

**Structure class:**
```xml
/// <summary>
/// {@documentation from the shape}
/// </summary>
```

### Operation Method Docs

Include `<exception cref>` for each error and a `<seealso>` link:
```xml
/// <exception cref="Amazon.CloudTrailData.Model.ChannelNotFoundException">
/// The channel could not be found.
/// </exception>
/// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/{serviceId}-{apiVersion}/{OperationName}">REST API Reference for {OperationName} Operation</seealso>
```

## Exception Classes

Operation exceptions inherit from `Amazon{ServiceName}Exception` (not directly from `AmazonServiceException`).

Must expose these public constructors:
1. Default (no args)
2. `(string message)`
3. `(string message, Exception innerException)`
4. `(Exception innerException)`
5. `(string message, Exception innerException, ErrorType, string errorCode, string requestId, HttpStatusCode)`
6. `(string message, ErrorType, string errorCode, string requestId, HttpStatusCode)`

Operation exceptions also include a `#if !NETSTANDARD` block containing:
- `[Serializable]` attribute on the class
- `protected` serialization constructor `(SerializationInfo, StreamingContext)` — deserializes any additional exception members via `info.GetValue` for each property, then calls `base(info, context)`
- `public override void GetObjectData(SerializationInfo, StreamingContext)` with all three attributes (always emitted together as a unit from `ExceptionSerialization.t4`):
  ```csharp
  [System.Security.SecurityCritical]
  [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")]
  [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2134:MethodsMustOverrideWithConsistentTransparencyFxCopRule")]
  public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  {
      base.GetObjectData(info, context);
      // info.AddValue(...) for each additional exception member
  }
  ```
  The serialization constructor and `GetObjectData` are symmetric: both loop over the exception's members (from `ExceptionSerialization.t4`). For exceptions with additional properties, the constructor calls `info.GetValue` for each and `GetObjectData` calls `info.AddValue` for each. For exceptions with no extra members (e.g. all CloudTrail Data exceptions after filtering `message`), both bodies contain only the `base` call.

The service-level exception base (`Amazon{ServiceName}Exception`) inherits from `AmazonServiceException` and includes `[Serializable]` plus the protected serialization constructor, but does not need its own `GetObjectData` override unless it adds serialized fields.

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
