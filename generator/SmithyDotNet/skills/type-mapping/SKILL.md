---
name: type-mapping
description: Rules for converting Smithy shape types to .NET types, including nullability and collection defaults
---
# Skill: Smithy to .NET Type Mapping

## Purpose

Definitive mapping from Smithy shape types to .NET types, plus nullability and collection default rules.

## Type Mapping Table

| Smithy shape | .NET type | Notes |
|---|---|---|
| `blob` | `MemoryStream` | Streaming blob shapes map to `Stream`; non-streaming blobs map to `MemoryStream` |
| `boolean` | `bool?` | Nullable |
| `string` | `string` | Reference type, nullable by nature |
| `byte` | `int?` | Widened to int, nullable |
| `short` | `int?` | Widened to int, nullable |
| `integer` | `int?` | Nullable |
| `long` | `long?` | Nullable |
| `float` | `float?` | Nullable |
| `double` | `double?` | Nullable |
| `bigInteger` | `long?` | Narrowed to long, nullable |
| `bigDecimal` | `decimal?` | Nullable |
| `timestamp` | `DateTime?` | Nullable |
| `document` | `Amazon.Runtime.Documents.Document` | SDK runtime type |
| `enum` | `string` (Phase 1) / `ConstantClass` (Phase 2) | Phase 2 uses the `ConstantClass` pattern |
| `intEnum` | `int?` | Nullable |
| `list` | `List<T>` | V4 default: `null`; see Collection Defaults |
| `map` | `Dictionary<TKey, TValue>` | V4 default: `null`; see Collection Defaults |
| `structure` | Generated class | See structure rules below |
| `union` | Generated class | Generated as regular structure (matches current SDK) |

## Nullability Rules

The AWS SDK for .NET V4 convention:

1. **All value types are nullable** — `bool?`, `int?`, `DateTime?`, etc. regardless of `@required` or `@default` traits
2. **Reference types** (`string`, `MemoryStream`) — nullable by nature, no `?` suffix needed in the type declaration
3. **Collections** — V4 default: `null`; see Collection Defaults section
4. **The `@default` trait does NOT change nullability** — this matches current SDK behavior
5. **The `@required` trait does NOT change nullability** — it only affects the `[AWSProperty(Required=true)]` attribute

### Opt-in Strict Nullability (Non-AWS Use)

The generator will support an opt-in mode that respects Smithy's nullability traits (`@required`, `@default`, `@clientOptional`) for non-AWS Smithy models. When disabled (the default for AWS), all value types are nullable regardless of traits.

## Collection Defaults

Collections use `AWSConfigs.InitializeCollections` for SDK V4 backwards compatibility:

```csharp
// Field initializer
private List<AuditEvent> _auditEvents = AWSConfigs.InitializeCollections ? new List<AuditEvent>() : null;
```

When `AWSConfigs.InitializeCollections` is `false` (V4 default), collections start as `null`. When `true` (V3 compat), they start as empty.

The `IsSet` check for collections accounts for this:
```csharp
internal bool IsSetAuditEvents()
{
    return this._auditEvents != null && (this._auditEvents.Count > 0 || !AWSConfigs.InitializeCollections);
}
```

## Constrained Shapes

Smithy allows constrained shapes (e.g. a `string` shape named `Uuid` with `@length` or `@pattern`). These do NOT get wrapper classes — they map to their underlying .NET type:

| Smithy | .NET |
|---|---|
| `Uuid` (string shape with constraints) | `string` |
| `AuditEvents` (list shape) | `List<AuditEvent>` inline |
| `ChannelArn` (string shape) | `string` |

The constraints flow through to `[AWSProperty]` attributes on the **member that references the shape**. When resolving `[AWSProperty]`, check traits on **both** the member and its target shape:
- `@required` is on the member
- `@length` / `@range` are typically on the target shape (e.g. `AuditEvents` list has `@length(min:1, max:100)`, so `PutAuditEventsRequest.AuditEvents` gets `[AWSProperty(Required=true, Min=1, Max=100)]`)

## Error Shape Naming

Smithy error shapes often omit the `Exception` suffix. The naming rules (matching the existing generator's `ExceptionShape.Name` logic):
- Ends with `Exception` → keep as-is (e.g. `UnsupportedOperationException`)
- Ends with `Fault` → replace `Fault` with `Exception`
- Otherwise → append `Exception` (e.g. `ChannelNotFound` → `ChannelNotFoundException`)

## Error Shape Members

Error shapes have a `message` member in the Smithy model, but the generated exception class does **not** expose it as a property. The `message` is passed to `System.Exception` via the constructor and inherited as `Exception.Message`. The generator must filter out the `message` member when generating exception properties.

## Resolving Member Types

To get the .NET type for a structure member:

1. Get the member's `Target` shape ID
2. `GenerationContext.Resolve(target)` returns the shape. Prelude shapes (`smithy.api#String`,
   etc.) are not in the model's shape map, but `Resolve` falls back to `PreludeShapes`, so
   callers never special-case them — a prelude `String` comes back as a `StringShape` like any
   other. Map the resolved shape's `type` from the table:
   - Simple/scalar shape → map its `type` from the table
   - Structure/union → use the generated class name
   - List → `List<{resolve member.Target}>`
   - Map → `Dictionary<{resolve key.Target}, {resolve value.Target}>`
   - Enum → `string` (Phase 1), `ConstantClass` subclass (Phase 2)
   - Constrained string shapes (e.g. `Uuid`) resolve to a `StringShape` → `string` (no wrapper)

## Prelude Shape Mapping

These shapes are implicit (not in the model JSON) and map directly:

| Prelude shape ID | .NET type |
|---|---|
| `smithy.api#String` | `string` |
| `smithy.api#Boolean` | `bool?` |
| `smithy.api#Integer` | `int?` |
| `smithy.api#Long` | `long?` |
| `smithy.api#Float` | `float?` |
| `smithy.api#Double` | `double?` |
| `smithy.api#Blob` | `MemoryStream` |
| `smithy.api#Timestamp` | `DateTime?` |
| `smithy.api#Document` | `Amazon.Runtime.Documents.Document` |
| `smithy.api#Unit` | (no type — used for operations with no input/output) |
