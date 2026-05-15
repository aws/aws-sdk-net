---
name: smithy-ast-model
description: How to deserialize a Smithy model.json into typed C# records and navigate the shape graph
---
# Skill: Smithy AST Model

## Purpose

How to read, deserialize, and navigate Smithy JSON AST (v2.0) in the SmithyDotNet generator. This is the foundation layer — all other components depend on it.

## Smithy JSON AST Structure

A Smithy model JSON file has three top-level keys (see [Smithy JSON AST spec](https://smithy.io/2.0/spec/json-ast.html)):

```json
{
  "smithy": "2.0",
  "shapes": { "<shapeId>": { "type": "...", ... }, ... },
  "metadata": { ... }
}
```

### Shape IDs

Every shape has an absolute ID: `com.amazonaws.cloudtraildata#AuditEvent`. Members append `$member`: `com.amazonaws.cloudtraildata#AuditEvent$id`.

```csharp
public record ShapeId(string Namespace, string Name, string? Member = null)
{
    public static ShapeId Parse(string absoluteShapeId);  // splits on # and $
    public string AbsoluteName => $"{Namespace}#{Name}";  // shape-only; omits $Member — for Shapes dictionary key lookups
    public override string ToString() => Member is null ? AbsoluteName : $"{AbsoluteName}${Member}";  // full canonical ID
    public static implicit operator string(ShapeId id) => id.ToString();  // returns full ID including member
}
```

Parsing rules (matching the [Smithy spec](https://smithy.io/2.0/spec/model.html#shape-id)):
- `#` separates namespace from name — exactly one `#` required
- `$` separates name from member (optional)
- Namespace, name, and member must all be non-empty when present
- Examples of invalid IDs: `Name$member` (no `#`), `ns#` (empty name), `ns#name$` (empty member), `ns#foo#bar` (multiple `#`)
- Prelude shapes use namespace `smithy.api` (e.g. `smithy.api#String`)

### Shape References — Two Distinct Formats

The JSON AST has two ways a shape ID appears as a value:

**1. Plain string** — inside a member object, `target` is a plain string:
```json
"id": {
    "target": "com.amazonaws.cloudtraildata#Uuid",
    "traits": { ... }
}
```
The whole object is a `MemberShape`. The `target` field is just a string property on it.

**2. Wrapper object** — for operation input/output, service operations lists, etc., the value is a wrapper:
```json
"input": { "target": "com.amazonaws.cloudtraildata#PutAuditEventsRequest" }
```
Here the entire `{"target": "..."}` is the value of the `input` property on `OperationShape`.

Three custom `JsonConverter`s in `SmithyDotNet.Generator.Model.Converters` handle these:
- `ShapeIdConverter` — plain string → `ShapeId` (for `MemberShape.Target`)
- `ShapeTargetConverter` — `{"target": "..."}` wrapper → `ShapeId` (for `OperationShape.Input`, etc.)
- `ShapeTargetListConverter` — `[{"target": "..."}, ...]` → `List<ShapeId>` (for `ServiceShape.Operations`, etc.)

All converters are read-only (`Write` throws `NotSupportedException`). The generator never serializes models back to JSON. Use `InvalidOperationException` (not null-forgiving `!`) when a value is unexpectedly null.

## Shape Type Hierarchy

All shapes derive from an abstract `Shape` base:

```csharp
public abstract record Shape
{
    public abstract string Type { get; }

    [JsonPropertyName("traits")]
    public Dictionary<string, JsonElement> Traits { get; init; } = [];
}
```

**Important**: Do NOT put `[JsonConverter(typeof(ShapeConverter))]` on `Shape`. This causes infinite recursion because `ShapeConverter.Read` calls `root.Deserialize<BlobShape>(options)`, and `BlobShape` inherits `Shape`, which triggers the converter again. Instead, register `ShapeConverter` via `JsonSerializerOptions.Converters`.

Use `[JsonPropertyName]` on properties where the C# name differs in casing from the JSON key (e.g. `Traits` → `"traits"`, `Target` → `"target"`). STJ is case-sensitive by default.

### ShapeConverter Dispatch

`ShapeConverter` peeks at the `"type"` field and dispatches:

| JSON `type` value | C# record |
|---|---|
| `blob`, `boolean`, `string`, `byte`, `short`, `integer`, `long`, `float`, `double`, `bigInteger`, `bigDecimal`, `timestamp`, `document` | Scalar shape records (no extra fields) |
| `list` | `ListShape` — has `Member` (single `MemberShape`) |
| `map` | `MapShape` — has `Key` and `Value` (both `MemberShape`) |
| `structure` | `StructureShape` — has `Members` dictionary |
| `union` | `UnionShape` — has `Members` dictionary |
| `enum` | `EnumShape` — has `Members` (member traits carry `@enumValue`) |
| `intEnum` | `IntEnumShape` — has `Members` |
| `service` | `ServiceShape` — has `Operations`, `Resources`, `Errors`, `Rename`, `ApiVersion` |
| `operation` | `OperationShape` — has `Input`, `Output`, `Errors` |
| `resource` | `ResourceShape` — has lifecycle operations, `Identifiers`, `Properties` |
| Unknown | Returns `null` with a stderr warning (forward compatibility) |

### MemberShape

`MemberShape` is **not** dispatched by `ShapeConverter`. It is deserialized inline by its parent shape (e.g. when STJ processes a `StructureShape.Members` dictionary). Its `Target` is a plain string in the JSON, so it uses `ShapeIdConverter`:

```csharp
public record MemberShape : Shape
{
    public override string Type => "member";

    [JsonPropertyName("target")]
    [JsonConverter(typeof(ShapeIdConverter))]
    public required ShapeId Target { get; init; }
}
```

### Prelude Shapes

Shapes in namespace `smithy.api` (e.g. `smithy.api#String`, `smithy.api#Boolean`, `smithy.api#Integer`) are prelude shapes. They are **not** present in the model JSON — they are implicit. The generator skips them during shape traversal.

## Traits

Traits are stored as `Dictionary<string, JsonElement>` on every shape. The key is the full trait ID (e.g. `smithy.api#required`, `aws.api#service`). The value is raw JSON.

Trait values are **not** deserialized at the model layer. They stay as `JsonElement` and are accessed via typed extension methods in `SmithyDotNet.Generator.Model.Traits`. Accessors are organized by trait category: annotation traits (boolean presence checks), scalar traits (single value), and structured traits (typed records in `TraitRecords.cs`).

[Annotation traits](https://smithy.io/2.0/spec/model.html#annotation-trait) have an empty object `{}` as their value:
```json
"traits": { "smithy.api#required": {} }
```

## Deserialization Setup

Register `ShapeConverter` via options — not via `[JsonConverter]` attribute on `Shape` (see Shape Type Hierarchy above for why).

`ShapeIdConverter`, `ShapeTargetConverter`, and `ShapeTargetListConverter` are registered via `[JsonConverter]` attributes on individual properties (e.g. `MemberShape.Target`, `OperationShape.Input`) — they do NOT need to go in the options.

```csharp
var options = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = false,  // Smithy JSON uses exact camelCase keys
    Converters = { new ShapeConverter() }
};
var model = JsonSerializer.Deserialize<SmithyModel>(json, options);
```

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
