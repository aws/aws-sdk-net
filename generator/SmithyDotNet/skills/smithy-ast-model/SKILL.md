---
name: smithy-ast-model
description: How the SmithyDotNet generator deserializes Smithy JSON AST into typed C# records and navigates the shape graph. Use when touching Model/ (ShapeConverter, ServiceIndex, shapes, traits).
---
# Skill: Smithy AST Model

## Smithy JSON AST Structure

A Smithy model JSON file has three top-level keys (see [Smithy JSON AST spec](https://smithy.io/2.0/spec/json-ast.html)): `smithy` (the version, `"2.0"`), `shapes` (a dictionary keyed by absolute shape ID), and `metadata`.

### Shape IDs

Every shape has an absolute ID: `com.amazonaws.cloudtraildata#AuditEvent`. Members append `$member`: `com.amazonaws.cloudtraildata#AuditEvent$id`.

The `ShapeId` record (`Namespace`, `Name`, optional `Member`) parses these. The trap is the two string
forms: `AbsoluteName` **omits** `$Member` (it's the `Shapes` dictionary key), while `ToString()` and the
implicit string conversion return the full canonical ID including the member.

Parsing follows the [Smithy spec](https://smithy.io/2.0/spec/model.html#shape-id): exactly one `#`
(namespace/name), an optional `$member`, every segment non-empty — invalid forms are pinned in
`ShapeIdTests`. Prelude shapes use namespace `smithy.api` (e.g. `smithy.api#String`).

### Shape References — Two Distinct Formats

The JSON AST has two ways a shape ID appears as a value:

**1. Plain string** — inside a member object, `target` is a plain string property
(`"id": { "target": "com.amazonaws...#Uuid", "traits": {...} }`); the whole containing object is a
`MemberShape`.

**2. Wrapper object** — for operation input/output, service operation lists, etc., the entire
`{"target": "..."}` object is the value (`"input": { "target": "com.amazonaws...#PutAuditEventsRequest" }`).

Three custom `JsonConverter`s in `SmithyDotNet.Generator.Model.Converters` handle these:
- `ShapeIdConverter` — plain string → `ShapeId` (for `MemberShape.Target`)
- `ShapeTargetConverter` — `{"target": "..."}` wrapper → `ShapeId` (for `OperationShape.Input`, etc.)
- `ShapeTargetListConverter` — `[{"target": "..."}, ...]` → `List<ShapeId>` (for `ServiceShape.Operations`, etc.)

All converters are read-only (`Write` throws `NotSupportedException`). The generator never serializes models back to JSON. Use `InvalidOperationException` (not null-forgiving `!`) when a value is unexpectedly null.

## Shape Type Hierarchy

All shapes derive from the abstract `Shape` record: an abstract `Type` string plus a
`Traits` dictionary (`Dictionary<string, JsonElement>`).

**Important**: Do NOT put `[JsonConverter(typeof(ShapeConverter))]` on `Shape`. This causes infinite recursion because `ShapeConverter.Read` calls `root.Deserialize<BlobShape>(options)`, and `BlobShape` inherits `Shape`, which triggers the converter again. Instead, register `ShapeConverter` via `JsonSerializerOptions.Converters`.

Use `[JsonPropertyName]` on properties where the C# name differs in casing from the JSON key (e.g. `Traits` → `"traits"`, `Target` → `"target"`). STJ is case-sensitive by default.

### ShapeConverter Dispatch

`ShapeConverter` peeks at the `"type"` field and dispatches to the matching shape record (scalar types
share field-less records; `list` has `Member`, `map` has `Key`/`Value`, aggregate/service shapes carry
their member and binding dictionaries — see `ShapeConverter.cs`). Non-obvious:

- `union` → `UnionShape`, which derives from `StructureShape` (inherits `Members`) and is generated as a plain structure
- `enum`/`intEnum` member traits carry `@enumValue`
- An unknown `type` returns `null` with a stderr warning (forward compatibility)

### MemberShape

`MemberShape` is **not** dispatched by `ShapeConverter`. It is deserialized inline by its parent shape (e.g. when STJ processes a `StructureShape.Members` dictionary). Its `Target` is a plain string in the JSON, so the property carries `[JsonConverter(typeof(ShapeIdConverter))]`.

### Prelude Shapes

Shapes in namespace `smithy.api` (e.g. `smithy.api#String`, `smithy.api#Boolean`, `smithy.api#Integer`) are prelude shapes. They are **not** present in the model JSON — they are implicit. `ServiceIndex` skips them during shape traversal (they aren't part of a service's own shape closure), but they are still *resolvable*: `GenerationContext.Resolve` falls back to the `PreludeShapes` table, so callers map a member's target without special-casing prelude references.

## Traits

Traits are stored as `Dictionary<string, JsonElement>` on every shape. The key is the full trait ID (e.g. `smithy.api#required`, `aws.api#service`). The value is raw JSON.

Trait values are **not** deserialized at the model layer. They stay as `JsonElement` and are accessed via typed extension methods in `SmithyDotNet.Generator.Model.Traits`. Smithy trait accessors are organized by category: annotation traits (boolean presence checks), scalar traits (single value), and structured traits (typed records in `SmithyTraitRecords.cs`). AWS-specific traits (`aws.*` namespaces) live in `AWSTraits.cs` with records in `AWSTraitRecords.cs`. Use uppercase `AWS` in C# names to match .NET SDK conventions.

Structured trait records use STJ deserialization via `TraitHelpers.DeserializeTrait<T>()` and inherit from `TraitRecord`, which uses `[JsonExtensionData]` to capture unknown properties for forward compatibility. Use `[JsonPropertyName]` on record properties, matching the pattern used by shape types. `ErrorTrait` is the exception — it wraps a plain string value, not a JSON object.

[Annotation traits](https://smithy.io/2.0/spec/model.html#annotation-trait) have an empty object as their value: `"traits": { "smithy.api#required": {} }`.

## Deserialization Setup

Register `ShapeConverter` via `JsonSerializerOptions.Converters` — not via `[JsonConverter]` attribute on `Shape` (see Shape Type Hierarchy above for why) — with `PropertyNameCaseInsensitive = false` (Smithy JSON uses exact camelCase keys).

`ShapeIdConverter`, `ShapeTargetConverter`, and `ShapeTargetListConverter` are registered via `[JsonConverter]` attributes on individual properties (e.g. `MemberShape.Target`, `OperationShape.Input`) — they do NOT need to go in the options.

`SmithyModel.Shapes` is a `Dictionary<string, Shape?>` keyed by the absolute shape ID string (e.g. `"com.amazonaws.cloudtraildata#AuditEvent"`). Unknown shape types deserialize to `null` values for forward compatibility.

## Validating Models with the Smithy CLI

Install the Smithy CLI (`smithy`) to validate models and query shapes directly. See [Smithy CLI docs](https://smithy.io/2.0/guides/smithy-cli/cli_installation.html) for installation. Use it to verify shape counts, types, and structure instead of parsing JSON manually.

**Validate a model:**
```
smithy validate --allow-unknown-traits <path-to-model.json>
```

**Query shapes with selectors** ([selector spec](https://smithy.io/2.0/spec/selectors.html)):
```
smithy select --selector '<selector>' --show type --allow-unknown-traits <path-to-model.json>
```

`--allow-unknown-traits` is needed because AWS trait definitions (e.g. `aws.api#service`) are not bundled with the CLI.

**Useful selectors:**
- `service` — all service shapes
- `operation` — all operation shapes
- `structure` — all structure shapes
- `:is([id|namespace = com.amazonaws.cloudtraildata])` — shapes in a specific namespace (excludes prelude)
- `service > operation` — operations directly bound to a service
- `structure > member > string` — structure members targeting string shapes

**PowerShell caveat:** selectors containing `[` or `$` must be single-quoted to prevent PowerShell interpretation. Use `:is(...)` instead of `[...]` attribute selectors when quoting is awkward.

## Key Invariants

- A valid model has exactly one `ServiceShape` (enforced by `ModelValidator`)
- `OperationShape.Input` and `Output` default to `smithy.api#Unit` when absent
- Member names in `StructureShape.Members` are the **Smithy member names** (camelCase), not .NET names
- The `@jsonName` trait overrides the wire name; the member key is the model name
- Mixin shapes (`smithy.api#mixin` trait) are not supported — skip them during shape traversal
- Input/output shapes are identified by their reference from `OperationShape.Input`/`Output`, not solely by `@input`/`@output` traits (some models don't have these traits). Error shapes are identified by the `@error` trait.
